using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenosRegistrados
{
    [Binding]
    public class VisualizarSuenosRegistradosStep
    {
        [Given(@"Acceder a la pantalla de visualizacion de sueños")]
        public void GivenAccederALaPantallaDeVisualizacionDeSuenos()
        {
            Console.WriteLine("Paso");
        }

        [When(@"cargue la pagina")]
        public void WhenCargueLaPagina()
        {
            Console.WriteLine("Paso");
        }

        [Then(@"no deberian mostrarse los sueños mayores a (.*) meses")]
        public void ThenNoDeberianMostrarseLosSuenosMayoresAMeses(int p0)
        {
            Console.WriteLine("Paso");
        }

    }
}







