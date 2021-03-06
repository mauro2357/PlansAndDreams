﻿using PlansAndDreams.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Tests.MockRepositories
{
    public class SonadorMockRepository : ISonadorRepository
    {
        public bool CrearSonador(Sonador sonador)
        {
            Console.WriteLine("Estamos utilizando un Mock para crear soñador.");
            return true;
        }

        public List<Sueno> obtenerSuenosAmigo(Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos;
            return suenos;
        }

        public List<Sueno> ObtenerSuenosFecha(DateTime fecha, Sonador sonador)
        {
            List<Sueno> suenos = sonador.Suenos.Where(x => x.fechaDeseada == fecha).ToList();
            return suenos;
        }

        public List<Sueno> obtenerSuenosAmigos(Sonador sonador)
        {
            List<Sueno> suenos = new List<Sueno>();
            sonador.Amigos.ForEach(x =>
            {
                suenos.AddRange(x.Suenos);
            });
            return suenos;
        }

        public List<Sueno> ObtenerSuenosMayoresa(Sonador sonador)
        {
            var fechaIni = DateTime.Now.AddMonths(-3);
            List<Sueno> lstSuenos = ObtenerSuenosMayoresa(sonador);
            lstSuenos = lstSuenos.Where(x => x.fechaDeseada > fechaIni).ToList();
            return lstSuenos;
        }
    }
}
