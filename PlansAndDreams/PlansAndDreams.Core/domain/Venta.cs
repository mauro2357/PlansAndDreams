using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Venta
    {
        private Sonador _Sonador;

        public Sonador Sonador
        {
            get { return _Sonador; }
            set { _Sonador = value; }
        }

        private List<Producto> _Productos;

        public List<Producto> Productos
        {
            get { return _Productos; }
            set { _Productos = value; }
        }

        private Decimal _ValorComision;
        public Decimal ValorComision
        {
            get { return _ValorComision; }
            set { _ValorComision = value; }
        }

        public Decimal ObtenerComision()
        {
            return Decimal.MaxValue;
        }
    }
}
