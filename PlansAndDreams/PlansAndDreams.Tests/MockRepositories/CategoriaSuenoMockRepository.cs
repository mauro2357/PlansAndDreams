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
        public Task<bool> AgregarCategoria(string nombreCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
