using Newtonsoft.Json;
using PlansAndDreams.Core.domain;
using PlansAndDreams.Core.repositories.DtoEntities;
using PlansAndDreams.Core.Utilities;
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
        public bool AgregarCategoria(string nombreCategoria)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    Nombre = nombreCategoria
                };

                var client = new HttpService();
                var result = client.PostAsync("categoria", categoria);
                if (result.IsSuccessStatusCode)
                {
                    //string response = await result.Content.ReadAsStringAsync();
                    //Categoria serializedResponse = JsonConvert.DeserializeObject<Categoria>(response);
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

        public bool ValidarCategoriaExiste(string nombreCategoria)
        {
            try
            {
                var client = new HttpService();
                var result = client.GetAsync<String>("categoria");
                if (result.IsSuccessStatusCode)
                {

                    string response = client.ReadString(result);
                    List<Categoria> serializedResponse = JsonConvert.DeserializeObject<List<Categoria>>(response);
                    Console.WriteLine("Ya grabé en la base de datos y funcionó");
                    return true;
                }
                else
                {
                    Console.WriteLine("Error guardando...");
                    return false;
                }

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
