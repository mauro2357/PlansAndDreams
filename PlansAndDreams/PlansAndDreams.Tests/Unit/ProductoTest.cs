using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.Unit
{
       
    class ProductoTest
    {
        [TestMethod()]
        public void ComprarProducto()
        {
            Producto productocomprar = new Producto();
            productocomprar.Nombre = "Viaje San Andres";
            productocomprar.Categoria = new CategoriaSueno{
                NombreCategoria = "Viajes",
                Porcentaje = 0
            };

           Assert.IsTrue(productocomprar.ComprarProducto());

        }

    }
}
