using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sonador
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public List<Sonador> Amigos { get; set; }

        public List<Sueno> Suenos { get; set; }

        public void agregarSueno(Sueno sueno) {
            Suenos.Add(sueno);
        }
        public void agregarAmigos(Sonador amigo)
        {
            Amigos.Add(amigo);
        }
    }
}
