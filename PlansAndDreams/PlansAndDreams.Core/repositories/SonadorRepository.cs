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
            throw new NotImplementedException();
        }

        public List<Sueno> ObtenerSuenosFecha(DateTime fecha, Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos.Where(x => x.fechaDeseada == fecha).ToList();
            return suenos;
        }
    }
}
