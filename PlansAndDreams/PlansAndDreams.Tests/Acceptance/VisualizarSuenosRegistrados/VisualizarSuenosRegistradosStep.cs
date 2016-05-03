using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenosRegistrados
{
    [Binding]
    public  class VisualizarSuenosRegistradosStep
    {
       

        [Given(@"Acceder a la pantalla de visualización de sueños")]
        public void GivenAccederALaPantallaDeVisualizacionDeSuenos()
        {
            Console.WriteLine("test");
        }

        [When(@"cargue la página")]
        public void WhenCargueLaPagina()
        {
            Console.WriteLine("test");

        }

        [Then(@"no deberían mostrarse los sueños mayores a (.*) meses")]
        public void ThenNoDeberianMostrarseLosSuenosMayoresAMeses(string mensaje)
        {
            Console.WriteLine("test");
            Assert.AreEqual(mensaje,"Prueba");

        }

        ///Tercer escenario
        ///
       


    }

}

