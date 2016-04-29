using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.Unit
{
    public class CatalogoTest
    {
        [TestMethod]

        public void ObtenerCatalogoquecumplconelsueño() {

            //Arrande
            Sonador _jose = new Sonador();
            var _lstSuenos = new List<Sueno>();
            _jose.Nombre = "Jose";
            Sueno _viajeAEuropa = new Sueno();
            _viajeAEuropa.nombre="Viajar a europa";
            CategoriaSueno _viajes = new CategoriaSueno();
            _viajes.NombreCategoria="Viajes";
            _viajeAEuropa.Categoria = _viajes;
            _lstSuenos.Add(_viajeAEuropa);
            _jose.Suenos = _lstSuenos;

            //Act
            CatalogoProductos catalogoProductos=_jose.verProductos();


            //Assert
            //Assert.AreEqual

        }
        

    }
}
