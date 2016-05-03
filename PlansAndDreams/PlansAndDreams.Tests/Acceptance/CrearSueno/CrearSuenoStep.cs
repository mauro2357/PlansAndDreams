using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres el mejor*/

        [Given(@"El sonador ingresa a la pantalla ""(.*)""")]
        public void GivenElSonadorIngresaALaPantalla(string p0)
        {
            driver.Navigate().GoToUrl("http://localhost/PlansAndDreams.WebUI/Forms/CrearSueno.aspx");
        }

        [Given(@"crea el sueno: ""(.*)"" fecha: ""(.*)"" categoria: ""(.*)""")]
        public void GivenCreaElSuenoFechaCategoria(string sueno, string fecha, string categoria)
        {
            IWebElement suenoElement = driver.FindElement(By.Id("sueno"));
            suenoElement.SendKeys(sueno);

            IWebElement FechaElement = driver.FindElement(By.Id("fecha"));
            FechaElement.SendKeys(fecha);

            IWebElement categoriaElement = driver.FindElement(By.Id("categoria"));
            categoriaElement.SendKeys(categoria);

        }

        [When(@"Cuando presione el boton grabar")]
        public void WhenCuandoPresioneElBotonGrabar()
        {
            IWebElement grabarElement = driver.FindElement(By.Id("grabar"));
            grabarElement.Click();
        }

        [Then(@"Deberia aparecer el siguiente mensaje ""(.*)""")]
        public void ThenDeberiaAparecerElSiguienteMensaje(string mensaje)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement mensajeEnPantallaElement = wait.Until<IWebElement>(d => d.FindElement(By.Id("mensajeEnPantalla")));
            String mensajeEnPantalla = mensajeEnPantallaElement.Text;
            Assert.AreEqual(mensaje, mensajeEnPantalla);
            driver.Close();
        }


    }
}
