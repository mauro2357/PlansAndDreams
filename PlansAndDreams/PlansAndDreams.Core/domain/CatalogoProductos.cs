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

        private List<Producto> producto;

        public List<Producto>  Productos
        {
            get { return producto; }
            set { producto = value; }
        }

        private Sonador sonador;

        public Sonador Sonador
        {
            get { return sonador; }
            set { sonador = value; }
        }




    }
}
