using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories;

namespace PlansAndDreams.Core.services
{
    public class SuenoApplicationService
    {

        public bool grabarSueno(String nombreSueno)
        {
            Sueno Sueno = new Sueno();
            Sueno.suenoRepository = new SuenosRepository();
            return Sueno.agregar();
        }




    }
}
