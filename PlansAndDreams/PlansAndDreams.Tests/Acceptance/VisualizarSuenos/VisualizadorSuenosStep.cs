using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenos
{
    [Binding]
    public class VisualizadorSuenosStep
    {



        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres error*/

        [Given(@"Yo ingreso a la pantalla de sueños")]
        public void GivenYoIngresoALaPantallaDeSuenos()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Abre el navegador");
        }

        [When(@"Yo selecciono como sueño una casa en rionegro")]
        public void WhenYoSeleccionoComoSuenoUnaCasaEnRionegro()
        {
            IWebElement myField = driver.FindElement(By.Id("lst-ib"));
            myField.SendKeys("Quiero una casa en rionegro");
            Console.WriteLine("Ingresa que quiere buscar.");
        }

        [Then(@"Deberia aparecer en pantalla (.*)")]
        public void ThenDeberiaAparecerEnPantalla(int p0)
        {
            driver.Close();
            Console.WriteLine("Cierra el browser");
        }
    }
}
