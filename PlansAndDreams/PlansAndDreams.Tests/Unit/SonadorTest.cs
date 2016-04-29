using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Tests.MockRepositories;

namespace PlansAndDreams.Tests.Unit
{
    [TestClass]
    public class SonadorTest
    {
        [TestMethod]
        public void CrearSonadorTest()
        {
            Sonador sonador = new Sonador(new SonadorMockRepository());
            sonador.Documento = "34001733";
            sonador.Nombre = "Mario";
            sonador.Apellido = "Nieto";
            Assert.IsTrue(sonador.CrearSonador(sonador));
        }
    }
}
