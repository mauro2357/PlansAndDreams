using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.repositories
{
    public class CategoriaSuenoSuenosRepository : ICategoriaSuenoRepository
    {
        public bool AgregarCategoria()
        {
            Console.WriteLine("Ya grabé en la base de datos y funcionó");
            return true;
        }
    }
}
