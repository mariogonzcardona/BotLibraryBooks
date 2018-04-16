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
    public class Libros:BaseModel
    {
        //public String Titulo { get; set; }
        //public String Autor { get; set; }
        public String Serie { get; set; }
        public String Etiqueta { get; set; }
        public String Formato { get; set; }
        //public String Intro { get; set; }
        //public String Foto { get; set; }

        public Libros() { }

        public Libros(string titulo, string autor, string serie, string etiqueta, string formato, string intro, string foto)
        {
            Titulo = titulo;
            Autor = autor;
            Serie = serie;
            Etiqueta = etiqueta;
            Formato = formato;
            Intro = intro;
            Foto = foto.Image2Base64();
        }

        public override Attachment ToAttachment(IDialogContext context)
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

       
    }
}