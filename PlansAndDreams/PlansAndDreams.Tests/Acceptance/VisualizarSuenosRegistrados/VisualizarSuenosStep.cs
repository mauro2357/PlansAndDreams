using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenosRegistrados
{
    [Binding]
    public  class VisualizarSuenosStep
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
        public void ThenNoDeberianMostrarseLosSuenosMayoresAMeses(int p0)
        {
            Console.WriteLine("test");
        }

        ///Tercer escenario
        ///
       


    }

}

