using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class CategoriaSuenoMockRepository : ICategoriaSuenoRepository
    {
        public bool AgregarCategoria(string nombreCategoria)
        {
            return true; 
        }

        public bool ValidarCategoriaExiste(string nombreCategoria)
        {
            if (nombreCategoria == "Juguetes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
