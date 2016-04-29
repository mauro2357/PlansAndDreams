using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlansAndDreams.Core.domain;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class SuenosMockRepository: ISuenoRepository
    {
        public bool agregarSueno(Sueno sueno)
        {
            Console.WriteLine("Aca estoy usando el repositorio basico");
            return true;
        }
    }
}
