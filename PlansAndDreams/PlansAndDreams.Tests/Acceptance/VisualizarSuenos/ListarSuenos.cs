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
    public class ListarSuenos
    {
        
        IWebDriver driver = new ChromeDriver(@"C:\exc"); /*andres el mejor*/
    }
}
