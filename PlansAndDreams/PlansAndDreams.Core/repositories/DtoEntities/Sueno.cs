using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.repositories.DtoEntities
{
    public class Sueno
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nombre { get; set; }
        public string IdSueno { get; set; }
    }
}
