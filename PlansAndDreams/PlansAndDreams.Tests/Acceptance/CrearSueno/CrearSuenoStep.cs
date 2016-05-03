using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.CrearSueno
{
    [Binding]
    public class CrearSuenoStep
    {
        [Given(@"El sonador ingresa en una pantalla sueño: ""(.*)""")]
        public void GivenElSonadorIngresaEnUnaPantallaSueno(string p0)
        {
            Console.Write("Ingresa pantalla");
        }

        [Given(@"fecha: ""(.*)"" categoria: ""(.*)""")]
        public void GivenFechaCategoria(string p0, string p1)
        {
            Console.Write("Ingresa pantalla");
        }

        [When(@"Cuando presione el boton grabar")]
        public void WhenCuandoPresioneElBotonGrabar()
        {
            Console.Write("Ingresa pantalla");
        }

        [Then(@"El sistema debe decir que el sueño fue grabado exitosamente\.")]
        public void ThenElSistemaDebeDecirQueElSuenoFueGrabadoExitosamente_()
        {
            Console.Write("Ingresa pantalla");
        }
    }
}
