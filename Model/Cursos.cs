using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using SimpleEchoBot.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Model
{
    [Serializable]
    public class Cursos
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Intro { get; set; }
        public string Clases { get; set; }
        public string Horas { get; set; }
        public string Foto { get; set; }

        public Cursos() { }

        public Cursos(string titulo, string autor, string intro, string clases, string horas, string foto)
        {
            Titulo = titulo;
            Autor = autor;
            Intro = intro;
            Clases = clases;
            Horas = horas;
            Foto = foto.Image2Base64();
        }

        public IMessageActivity ToMessage(IDialogContext context)
        {
            var replay = context.MakeMessage();
            replay.Attachments = new List<Attachment> {ToAttachment(context) };
            return replay;
        }

        private Attachment ToAttachment(IDialogContext context)
        {
            HeroCard hc = new HeroCard()
            {
                Title = Titulo,
                Subtitle = Autor,
                Text = Intro,
                Images = new List<CardImage>()
                {
                    new CardImage()
                    {
                        Url=Foto
                    }
                }
            };
            return hc.ToAttachment();
        }
    }
}