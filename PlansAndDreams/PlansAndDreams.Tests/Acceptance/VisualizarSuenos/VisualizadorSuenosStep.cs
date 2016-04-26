using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenos
{
    [Binding]
    public class VisualizadorSuenosStep
    {
        [Given(@"Yo ingreso a la pantalla de sueños")]
        public void GivenYoIngresoALaPantallaDeSuenos()
        {
            Console.WriteLine("GivenYoIngresoALaPantallaDeSuenos");
        }

        [When(@"Yo selecciono como sueño una casa en rionegro")]
        public void WhenYoSeleccionoComoSuenoUnaCasaEnRionegro()
        {
            Console.WriteLine("WhenYoSeleccionoComoSuenoUnaCasaEnRionegro");
        }

        [Then(@"Deberia aparecer en pantalla (.*)")]
        public void ThenDeberiaAparecerEnPantalla(int p0)
        {
            Console.WriteLine("ThenDeberiaAparecerEnPantalla");
        }
    }
}
