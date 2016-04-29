using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.Unit
{
    [TestClass()]
    public class VentaTests
    {
        [TestMethod()]
        public void ObtenerComisionTest()
        {
            //Arrange
            Venta target = new Venta();
            var expected = Decimal.MaxValue;

            List<Producto> productos = new List<Producto>();
            Producto producto1 = new Producto();
            producto1.Categoria = new CategoriaSueno { NombreCategoria = "Viaje", IdCategoria = 1, Porcentaje = 10 };
            producto1.Nombre = "Nombre Producto";
            productos.Add(producto1);
            target.Productos = productos;
                        
            //Action
            Decimal actual = target.ObtenerComision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}