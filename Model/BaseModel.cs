using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Model
{

    public abstract class BaseModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Intro { get; set; }
        public string Foto { get; set; }

        public IMessageActivity ToMessage(IDialogContext contect)
        {
            var replay = contect.MakeMessage();
            replay.Attachments = new List<Attachment> {
                ToAttachment(contect)
            };
            return replay;
        }

        public static IMessageActivity ToMessage(IEnumerable<BaseModel> model,IDialogContext context)
        {
            var replay = context.MakeMessage();
            replay.AttachmentLayout = "carousel";
            replay.Attachments = model.Select(c => c.ToAttachment(context)).ToList();
            return replay;
        }

        public abstract Attachment ToAttachment(IDialogContext context);

    }
}