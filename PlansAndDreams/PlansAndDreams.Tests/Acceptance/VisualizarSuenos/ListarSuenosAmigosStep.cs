using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.VisualizarSuenos
{
    [Binding]
    public sealed class ListarSuenosAmigosStep
    {
        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres el mejor*/
        IWebElement categoriaElement;

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"Ingresar a la pantalla de visualizar sueños de amigos")]
        public void GivenIngresarALaPantallaDeVisualizarSuenosDeAmigos()
        {
            driver.Navigate().GoToUrl("http://localhost/PlansAndDreams.WebUI/Forms/VisualizarSuenosAmigos.aspx");
        }

        [When(@"Cargue la pantalla de visualizar sueños de amigos")]
        public void WhenCargueLaPantallaDeVisualizarSuenosDeAmigos()
        {
            categoriaElement = driver.FindElement(By.Id("GrdListaSuenosAmigos"));
        }

        [Then(@"Carga en una tabla la lista de sueños de mis amigos")]
        public void ThenCargaEnUnaTablaLaListaDeSuenosDeMisAmigos()
        {
            Assert.IsNotNull(categoriaElement);
            driver.Close();
        }
    }
}
