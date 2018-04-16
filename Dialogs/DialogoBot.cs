using Microsoft.Bot.Builder.Dialogs;
using SimpleEchoBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleEchoBot.Dialogs
{
    [Serializable]
    public class DialogoBot : IDialog
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Hola que tal Bienvenido mi nombre es Library Books Bot, ¿Que te gustaria saber?");
            context.Wait(MessageReciveAsync);

        }

        private async Task MessageReciveAsync(IDialogContext context, IAwaitable<object> result)
        {
            ShowOption(context);
        }

        private void ShowOption(IDialogContext context)
        {
            var opciones = new[] { "Libros", "Cursos" };
            PromptDialog.Choice(context, OptionSelectAsync, opciones, "", "Elige una opcion correcta");

        }

        private async Task OptionSelectAsync(IDialogContext context, IAwaitable<string> result)
        {
            var opcion = await result;
            switch (opcion)
            {
                case "Libros":
                    var choicesLibros = FakeData.Libros.Keys.ToArray();
                    PromptDialog.Choice(context, BooksSelectedAsync, choicesLibros, "Elige un Libro", "Eliga una opcion correcta");

                    break;
                case "Cursos":
                    var choicesCursos = FakeData.Cursos.Keys.ToArray();
                    PromptDialog.Choice(context, CurseSelectedAsync, choicesCursos, "Elige un Libro", "Eliga una opcion correcta");
                    break;
                default:
                    ShowOption(context);
                    break;
            }
        }

        private async Task BooksSelectedAsync(IDialogContext context, IAwaitable<string> result)
        {
            var opcion = await result;
            var libos = FakeData.Libros.ContainsKey(opcion) ? FakeData.Libros[opcion] : null;
            if(libos!=null)
            {
                await context.PostAsync(libos.ToMessage(context));
            }
            else
            {
                await context.PostAsync($"La opcion, {opcion} no es valida");
            }
            ShowOption(context);
        }

        private async Task CurseSelectedAsync(IDialogContext context, IAwaitable<string> result)
        {
            var opcion = await result;
            var cursos = FakeData.Cursos.ContainsKey(opcion) ? FakeData.Cursos[opcion] : null;
            if (cursos != null)
            {
                await context.PostAsync(cursos.ToMessage(context));
            }
            else
            {
                await context.PostAsync($"La opcion, {opcion} no es valida");
            }
            ShowOption(context);
        }
    }
}