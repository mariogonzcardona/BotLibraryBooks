﻿using Microsoft.Bot.Builder.Dialogs;
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
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Intro { get; set; }
        public String Clases { get; set; }
        public String Horas { get; set; }
        public String Foto { get; set; }

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

        private Attachment ToAttachment(IDialogContext contect)
        {
            HeroCard hc = new HeroCard()
            {
                Title = Titulo,
                Subtitle = Autor,
                Text = Intro,
                Images = new List<CardImage>
                {
                    new CardImage()
                    {
                        Url=Foto
                    }
                }
            };
            return hc.ToAttachment();

        }

        public IMessageActivity ToMessage(IDialogContext contect)
        {
            var replay = contect.MakeMessage();
            replay.Attachments = new List<Attachment> {
                ToAttachment(contect)
            };
            return replay;
        }
    }
}