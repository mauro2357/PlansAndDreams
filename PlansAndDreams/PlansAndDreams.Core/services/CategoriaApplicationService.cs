using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.services
{
    public class CategoriaApplicationService
    {

        async public Task<bool> grabarCategoria(String nombreCategoria)
        {
            CategoriaSueno categoria = new CategoriaSueno()
            {
                NombreCategoria = nombreCategoria
            };
            categoria.categoriaSuenoRepository = new CategoriaSuenoRepository();
            return await categoria.AgregarCategoria();
        }


    }
}
