using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.services;

namespace PlansAndDreams.Tests.Integration
{
    [TestClass]
    public class SuenoApplicationServiceIntegrationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SuenoApplicationService suenoApplicationService = new SuenoApplicationService();
            suenoApplicationService.grabarSueno("Viajar a europa");
        }
    }
}
