using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public class Sonador
    {

        public Sonador()
        {
            this.Suenos = new List<Sueno>();
            this.Amigos = new List<Sonador>();
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public List<Sonador> Amigos { get; set; }

        public List<Sueno> Suenos { get; set; }

        public void agregarSueno(Sueno sueno) {
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
            List<CategoriaSueno> categoriasDelSueno = null;//Categorias de los sueños que tiene Jose

            foreach (var categoria in categoriasDelSueno)
            {
                Producto _PlanEspecial = new Producto();
               
                //consultar la lista de productos correspondientes a la categoria

                catalogoProductos.Productos.Add(_PlanEspecial);
            }
            return catalogoProductos;
        }
        public List<Sueno> obtenerSuenosAmigo(Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos;
            return suenos;
        }
    }
}
