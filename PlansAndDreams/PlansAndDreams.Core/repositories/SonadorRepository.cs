using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.repositories
{
    public class SonadorRepository : ISonadorRepository
    {
        public bool CrearSonador(Sonador sonador)
        {
            Console.WriteLine("Repositorio Base de datos");
            return true;
        }

        public List<Sueno> obtenerSuenosAmigo(Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos;
            return suenos;
        }

        public List<Sueno> obtenerSuenosAmigos(Sonador sonador)
        {
            List<Sueno> suenos = new List<Sueno>();
            sonador.Amigos.ForEach(x => {
                suenos.AddRange(x.Suenos);
            });
            return suenos;
        }

        public List<Sueno> ObtenerSuenosFecha(DateTime fecha, Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos.Where(x => x.fechaDeseada == fecha).ToList();
            return suenos;
        }

        public List<Sueno> ObtenerSuenosMayoresa(Sonador sonador)
        {
            throw new NotImplementedException();
        }

        //public List<Sueno> ObtenerSuenosMayoresa(int meses, Sonador sonador)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
