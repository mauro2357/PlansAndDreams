using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class CatalogoProductos
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }


    }
}
