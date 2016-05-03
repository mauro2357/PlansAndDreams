using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories;
using PlansAndDreams.Tests.MockRepositories;
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
            target.categoriaSuenoRepository = new CategoriaSuenoMockRepository();
            var expected = 1;
            target.NombreCategoria = "Viaje";
            target.Porcentaje = 10;

            //Action
            int actual = target.AgregarCategoria();

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void ValidarCategoriaRepetidaTest()
        {
            //Arrange 
            CategoriaSueno target = new CategoriaSueno();
            target.categoriaSuenoRepository = new CategoriaSuenoMockRepository();
            var expected = true;
            target.NombreCategoria = "Juguetes";

            //Action
            bool actual = target.ValidarCategoriaExiste();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}