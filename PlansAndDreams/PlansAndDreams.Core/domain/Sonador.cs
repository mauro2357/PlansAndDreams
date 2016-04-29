using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sonador
    {

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string documento { get; set; }

        public List<Sonador> amigos { get; set; }
    }
}
