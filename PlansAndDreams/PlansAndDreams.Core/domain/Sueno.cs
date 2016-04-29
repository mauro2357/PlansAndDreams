using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sueno
    {
        public string nombre { get; set; }

        public DateTime fechaDeseada { get; set; }

        public Sueno(string nombre, DateTime fechaDeseada)
        {
            this.nombre = nombre;
            this.fechaDeseada = fechaDeseada;
        }
        public void agregar()
        {
            Console.Out.WriteLine("Sueño Agregado Exitosamente");
            
        }
        public CategoriaSueno Categoria { get; set; }

        public bool guardarSueno()
        {
            return true;
        }
    }
}
