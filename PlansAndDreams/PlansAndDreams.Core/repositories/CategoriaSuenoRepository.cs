using Newtonsoft.Json;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories.DtoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.repositories
{
    public class CategoriaSuenoRepository : ICategoriaSuenoRepository
    {
        async public Task<bool> AgregarCategoria(string nombreCategoria)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    Nombre = nombreCategoria
                };
                var result = await PostAsync("https://plananddreams.azurewebsites.net/tables/categoria", categoria);
                if (result.IsSuccessStatusCode)
                {
                    string response = await result.Content.ReadAsStringAsync();
                    Categoria serializedResponse = JsonConvert.DeserializeObject<Categoria>(response);
                    //serializedResponse contiene el registro almacenado
                    Console.WriteLine("Ya grabé en la base de datos y funcionó");
                }
                else
                {
                    Console.WriteLine("Error guardando...");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error guardando...");
                return false;
            }


            return true;
        }



        public async Task<HttpResponseMessage> PostAsync<TRequest>(string serviceUrl, TRequest request, string mediaType = "application/json")
        {
            using (var client = new HttpClient())
            {
                string bodyRequest;
                bodyRequest = JsonConvert.SerializeObject(request);
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                return await client.PostAsync(serviceUrl, new StringContent(bodyRequest, System.Text.Encoding.UTF8, mediaType));
            }
        }

    }



}
