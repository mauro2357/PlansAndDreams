using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.domain
{
    public interface ISonadorRepository
    {
        bool CrearSonador(Sonador sonador);
        List<Sueno> ObtenerSuenosFecha(DateTime fecha, Sonador sonador);
        List<Sueno> obtenerSuenosAmigo(Sonador sonador);
        List<Sueno> obtenerSuenosAmigos(Sonador sonador);
    }
}
