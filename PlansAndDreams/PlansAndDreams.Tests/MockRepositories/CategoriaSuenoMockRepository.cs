using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class CategoriaSuenoMockRepository : ICategoriaSuenoRepository
    {
        public bool AgregarCategoria()
        {
            Console.WriteLine("Aca estoy usando el repositorio basico");
            return true;
        }
    }
}
