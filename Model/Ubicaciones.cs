using SimpleEchoBot.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Model
{
    [Serializable]
    public class Ubicaciones
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }

        public Ubicaciones() { }

        public Ubicaciones(string nombre, string descripcion,string foto)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Foto = foto.Image2Base64();
        }
    }
}