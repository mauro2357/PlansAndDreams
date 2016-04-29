using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain.Tests
{
    [TestClass()]
    public class CategoriaSuenoTests
    {
        [TestMethod()]
        public void AgregarCategoriaTest()
        {
            //Arrange
            CategoriaSueno target = new CategoriaSueno();
            var expected = true;
            target.NombreCategoria = "Viaje";

            //Action
            Boolean actual = target.AgregarCategoria();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}