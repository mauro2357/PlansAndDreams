﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class CategoriaSueno
    {
        private string _NombreCategoria;

        public string NombreCategoria
        {
            get { return _NombreCategoria; }
            set { _NombreCategoria = value; }
        }

        private int _IdCategoria;

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }


    }
}
