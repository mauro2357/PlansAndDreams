using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories;
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
            target.categoriaSuenoRepository = new CategoriaSuenoSuenosRepository();
            var expected = true;
            target.NombreCategoria = "Viaje";
            target.Porcentaje = 10;

            //Action
            Boolean actual = target.AgregarCategoria();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}