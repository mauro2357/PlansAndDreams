using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.domain
{
    public interface ICategoriaSuenoRepository
    {
        Task<bool> AgregarCategoria(string nombreCategoria);
    }
}
