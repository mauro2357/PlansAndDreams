using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlansAndDreams.Core.domain;

namespace PlansAndDreams.Core.repositories
{
    public class SuenosRepository: ISuenoRepository 
    {

        public bool agregarSueno(Sueno sueno)
        {
            Console.WriteLine("Ya grabé en la base de datos y funcionó");
            //throw new Exception("Opps!!");
            return true;
        }
    }
}
