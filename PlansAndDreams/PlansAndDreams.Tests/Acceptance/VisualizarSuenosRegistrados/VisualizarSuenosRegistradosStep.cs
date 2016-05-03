using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres el mejor*/
        [Given(@"Acceder a la pantalla de visualizacion de sueños")]
        public void GivenAccederALaPantallaDeVisualizacionDeSuenos()
        {
            
            driver.Navigate().GoToUrl("http://localhost/PlansAndDreams.WebUI/Forms/VisualizarSuenosSonador.aspx");
        }

        //[When(@"cargue la pagina")]
        //public void WhenCargueLaPagina()
        //{
        //    Console.WriteLine("Paso");
        //}

        [Then(@"no deberian mostrarse los sueños mayores a (.*) meses")]
        public void ThenNoDeberianMostrarseLosSuenosMayoresAMeses(int parametro)
        {
            IWebElement categoriaElement = driver.FindElement(By.Id("gridSuenos"));
            Assert.IsNotNull(categoriaElement);
        }

    }
}







