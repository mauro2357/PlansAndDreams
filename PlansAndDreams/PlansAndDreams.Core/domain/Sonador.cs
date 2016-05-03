using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sonador
    {
        private ISonadorRepository _iSonadorRepository;
        public Sonador(ISonadorRepository _iSonadorRepository)
        {
            this._iSonadorRepository = _iSonadorRepository;
            this.Suenos = new List<Sueno>();
            this.Amigos = new List<Sonador>();
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public List<Sonador> Amigos { get; set; }

        internal bool CrearSonador(Sonador sonador)
        {
            return _iSonadorRepository.CrearSonador(sonador);
        }

        public List<Sueno> Suenos { get; set; }

        public void agregarSueno(Sueno sueno)
        {
            Suenos.Add(sueno);
        }
        public void agregarAmigos(Sonador amigo)
        {
            Amigos.Add(amigo);
        }

        public CatalogoProductos verProductos()
        {
            CatalogoProductos catalogoProductos = new CatalogoProductos();
            catalogoProductos.Productos = new List<Producto>();
            List<Producto> lstProductosEncontrados = new List<Producto>();
          
            //Se simula el origen de datos
            var dataProductos = new List<Producto>();
            dataProductos.Add(new Producto { Nombre= "Viaje especial", Categoria = new CategoriaSueno { NombreCategoria = "Viajes" } });
            dataProductos.Add(new Producto { Nombre = "Viaje Quince", Categoria = new CategoriaSueno { NombreCategoria = "Viajes" } });
            dataProductos.Add(new Producto { Categoria = new CategoriaSueno { NombreCategoria = "Viajes" } });
            dataProductos.Add(new Producto { Categoria = new CategoriaSueno { NombreCategoria = "Pensión" } });
            dataProductos.Add(new Producto { Categoria = new CategoriaSueno { NombreCategoria = "Vivienda" } });
            ////////////


            List<CategoriaSueno> categoriasDelSueno = new List<CategoriaSueno>();//Categorias de los sueños que tiene Jose
            //Se agrupan las categorias de los sueños para que no esten repetidas
            foreach (var sueno in this.Suenos)
            {
                if (categoriasDelSueno.Where(x=> x.NombreCategoria==sueno.Categoria.NombreCategoria).Count()==0)
                {
                    categoriasDelSueno.Add(sueno.Categoria);
                } 
            }

           
            //se recorren las categorias y se buscan que productos tienen esa categoria
            foreach (var categoria in categoriasDelSueno)
            {
                foreach (var productoEncontrado in dataProductos.Where(x=> x.Categoria.NombreCategoria== categoria.NombreCategoria))
                {
                    lstProductosEncontrados.Add(productoEncontrado);
                }
            }


            catalogoProductos.Productos = lstProductosEncontrados;
            return catalogoProductos;
        }
        public List<Sueno> obtenerSuenosAmigo(Sonador sonador)
        {
            return _iSonadorRepository.obtenerSuenosAmigo(sonador);
        }

        public List<Sueno> ObtenerSuenosFecha(DateTime fecha, Sonador sonador)
        {
            return _iSonadorRepository.ObtenerSuenosFecha(fecha, sonador);
        }

        public List<Sueno> obtenerSuenosAmigos()
        {
            
            return _iSonadorRepository.obtenerSuenosAmigos(this);
        }
    }
}
