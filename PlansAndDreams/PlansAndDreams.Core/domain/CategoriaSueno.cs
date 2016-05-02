using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.domain
{
    public class CategoriaSueno
    {
        public ICategoriaSuenoRepository categoriaSuenoRepository;

        //constructur 

        public CategoriaSueno(string nombreCategoria,decimal porcentaje)
        {
            this.NombreCategoria = nombreCategoria;
            this.Porcentaje = porcentaje;
        }

        public CategoriaSueno()
        {
        }


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

        private decimal _Porcentaje;

        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set { _Porcentaje = value; }
        }


        public Task<bool> AgregarCategoria()
        {
            return categoriaSuenoRepository.AgregarCategoria(this.NombreCategoria);
        }
    }
}
