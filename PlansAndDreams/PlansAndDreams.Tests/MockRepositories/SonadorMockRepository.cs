using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class SonadorMockRepository : ISonadorRepository
    {
        public bool CrearSonador(Sonador sonador)
        {
            Console.WriteLine("Estamos utilizando un Mock para crear soñador.");
            return true;
        }
    }
}
