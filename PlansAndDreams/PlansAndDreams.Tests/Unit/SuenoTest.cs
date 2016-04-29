using PlansAndDreams.Core.domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PlansAndDreams.Tests.MockRepositories;

namespace PlansAndDreams.Tests
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para SuenoTest y se pretende que
    ///contenga todas las pruebas unitarias SuenoTest.
    ///</summary>
    [TestClass()]
    public class SuenoTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        
         
        [TestMethod()]
        public void crearSuenoTest()
        {
            Sueno sueno = new Sueno("bicileta", new DateTime(2016, 12, 25, 0, 0, 0));

            Assert.IsTrue(sueno.guardarSueno());
             
        }


        /// <summary>
        ///Una prueba de listar sueños
        ///</summary>
        [TestMethod()]
        public void ListarSuenos()
        {

            Sonador _jose = new Sonador();
            _jose.Nombre = "Jose";
            _jose.Apellido = "Galarga";
            _jose.Documento = "545636";

            Sonador _erika = new Sonador();
            _erika.Nombre = "Erike";
            _erika.Apellido = "Correa";
            _erika.Documento = "454655";

            CategoriaSueno _categoriaS = new CategoriaSueno();
            _categoriaS.IdCategoria = 12;
            _categoriaS.NombreCategoria = "Viajes";

            Sueno _sueno = new Sueno("Viaje a Europa", new DateTime(2016,12,1));
            _sueno.Categoria = _categoriaS;

            _jose.agregarSueno(_sueno);
            _erika.agregarAmigos(_jose);


            List<Sueno> lstSuenos = _erika.obtenerSuenosAmigo(_jose);

            Assert.IsNotNull(lstSuenos);



        }

        /// <summary>
        ///Una prueba de listar sueños
        ///</summary>
        [TestMethod()]
        public void ListarSuenosFecha()
        {

            Sonador _jose = new Sonador();
            _jose.Nombre = "Jose";
            _jose.Apellido = "Galarga";
            _jose.Documento = "545636";

            Sonador _erika = new Sonador();
            _erika.Nombre = "Erike";
            _erika.Apellido = "Correa";
            _erika.Documento = "454655";

            CategoriaSueno _categoriaS = new CategoriaSueno();
            _categoriaS.IdCategoria = 12;
            _categoriaS.NombreCategoria = "Viajes";

            Sueno _sueno = new Sueno("Viaje a Europa", new DateTime(2016, 12, 1));
            _sueno.Categoria = _categoriaS;

            _jose.agregarSueno(_sueno);
            _erika.agregarAmigos(_jose);
            List<Sueno> lstSuenosFecha = _erika.ObtenerSuenosFecha(new DateTime(2016, 12, 1), _jose);

            Assert.IsNotNull(lstSuenosFecha);
        }

        /// <summary>
        ///Una prueba de agregar
        ///</summary>
        [TestMethod()]
        public void agregarTest()
        {
            Sueno target = new Sueno(); // TODO: Inicializar en un valor adecuado
            target.suenoRepository = new SuenosConsolaMockRepository();
            bool resultado = target.agregar();
            Assert.IsTrue(resultado);
            //Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }
    }
}
