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
        public void agregar()
        {
            Console.Out.WriteLine("Sueño Agregado Exitosamente");
            
        }
        public CategoriaSueno Categoria { get; set; }

    }
}
