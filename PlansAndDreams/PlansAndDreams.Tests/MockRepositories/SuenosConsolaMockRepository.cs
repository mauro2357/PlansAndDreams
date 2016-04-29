using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlansAndDreams.Core.domain;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class SuenosConsolaMockRepository: ISuenoRepository
    {
        public bool agregarSueno(Sueno sueno)
        {
            Console.WriteLine("Maldito visual Studio!!!");
            return true;
        }
    }
}
