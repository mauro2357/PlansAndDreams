using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Producto
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private CategoriaSueno categoria;

        public CategoriaSueno Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }


    }
}
