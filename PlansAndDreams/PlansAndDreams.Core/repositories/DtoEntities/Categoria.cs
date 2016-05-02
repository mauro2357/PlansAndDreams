using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlansAndDreams.Core.repositories.DtoEntities
{
    public class Categoria
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Porcentaje { get; set; }
    }
}
