using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sueno
    {
        public ISuenoRepository suenoRepository;

        public string nombre { get; set; }
        public string IdSueno { get; set; }

        public DateTime fechaDeseada { get; set; }

        public Sueno(string nombre, DateTime fechaDeseada)
        {
            this.nombre = nombre;
            this.fechaDeseada = fechaDeseada;
        }

        public Sueno()
        {
        }

        public bool agregar()
        {          
            return suenoRepository.agregarSueno(this);
        }
        public CategoriaSueno Categoria { get; set; }

        public bool guardarSueno()
        {
            return true;
        }
    }
}
