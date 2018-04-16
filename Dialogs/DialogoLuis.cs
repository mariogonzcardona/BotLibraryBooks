using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using SimpleEchoBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleEchoBot.Dialogs
{
    [Serializable]
    public class DialogoLuis:LuisDialog<object>
    {
        public DialogoLuis(LuisService service):base(service)
        {

        }

        [LuisIntent("")]
        public async Task NoneAsync(IDialogContext context,LuisResult result)
        {
            await context.PostAsync($"Lo siento, no te he entendido'{result.Query}'");
            await context.PostAsync("¿Que deseas saber?");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Bienvenida")]
        public async Task WelcomeAsync(IDialogContext context, LuisResult result)
        {
            
            await context.PostAsync("Mi funcion es brindarte una pequeña guia sobre libros y cursos, que deseas saber?");
            context.Wait(MessageReceived);
        }

        private async Task ManagerDefaultResponse(IEnumerable<BaseModel> data, IDialogContext context, string msg)
        {
            await context.PostAsync(msg);
            await context.PostAsync("Tenemos estos");
            var mensaje = BaseModel.ToMessage(data, context);
            await context.PostAsync(mensaje);

        }

        [LuisIntent("Libros")]
        public async Task LibrosAsync(IDialogContext context, LuisResult result)
        {
            EntityRecommendation nombreEntRec;
            if(result.TryFindEntity("Lib",out nombreEntRec))
            {
                var libro = FakeData.Libros.ContainsKey(nombreEntRec.Entity.ToLower()) ? FakeData.Libros[nombreEntRec.Entity.ToLower()] : null;
                if(libro!=null)
                {
                    await context.PostAsync(libro.ToMessage(context)); 
                }
                else
                {
                    await ManagerDefaultResponse(FakeData.Libros.Values.ToList(), context, $"Libro no encontrado {result.Query}");
                }
            }
            else
            {
                await ManagerDefaultResponse(FakeData.Libros.Values.ToList(),context, $"Libro no encontrado {result.Query}");
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("Cursos")]
        public async Task CursosAsync(IDialogContext context, LuisResult result)
        {
            EntityRecommendation nombreEntRec;
            if (result.TryFindEntity("Cur", out nombreEntRec))
            {
                var curso = FakeData.Cursos.ContainsKey(nombreEntRec.Entity.ToLower()) ? FakeData.Cursos[nombreEntRec.Entity.ToLower()] : null;
                if (curso != null)
                {
                    await context.PostAsync(curso.ToMessage(context));
                }
                else
                {
                    await ManagerDefaultResponse(FakeData.Cursos.Values.ToList(), context, $"Curso no encontrado {result.Query}");
                }
            }
            else
            {
                await ManagerDefaultResponse(FakeData.Cursos.Values.ToList(), context, $"Curso no encontrado {result.Query}");
            }
            context.Wait(MessageReceived);
        }
    }
}