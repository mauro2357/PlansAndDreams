using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PlansAndDreams.Tests.Acceptance.CrearCategoriasSueno
{
    [Binding]
    public class CrearCategoriaSuenosStep
    {

        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres el mejor*/

        [Given(@"Acceso a la pantalla de registro de categoria")]
        public void GivenAccesoALaPantallaDeRegistroDeCategoria()
        {
            driver.Navigate().GoToUrl("http://localhost:9030/PlansAndDreams/CrearCategoriaSueno.aspx");
        }

        [Given(@"ingreso la categoria ""(.*)""")]
        public void GivenIngresoLaCategoria(string categoria)
        {
            IWebElement categoriaElement = driver.FindElement(By.Id("categoria"));
            categoriaElement.SendKeys(categoria);
        }

        [When(@"Presiono grabar")]
        public void WhenPresionoGrabar()
        {
            IWebElement categoriaElement = driver.FindElement(By.Id("grabar"));
            categoriaElement.Click();
        }

        [Then(@"Deberia aparecer el mensaje ""(.*)""")]
        public void ThenDeberiaAparecerElMensaje(string mensaje)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement mensajeEnPantallaElement = wait.Until<IWebElement>(d => d.FindElement(By.Id("mensajeEnPantalla")));
            String mensajeEnPantalla = mensajeEnPantallaElement.Text;
            Assert.AreEqual(mensaje, mensajeEnPantalla);
        }

    }
}
