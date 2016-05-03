using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlansAndDreams.Core.Utilities
{
    public class HttpService
    {
        public string Api = "https://plananddreams.azurewebsites.net/tables/";

        public HttpResponseMessage PostAsync<TRequest>(string table, TRequest request, string mediaType = "application/json")
        {
            HttpResponseMessage result = new HttpResponseMessage();

            Task.WaitAny(
                 Task.Run(async () =>
                 {
                     using (var client = new HttpClient())
                     {
                         string bodyRequest;
                         bodyRequest = JsonConvert.SerializeObject(request);
                         client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                         result = await client.PostAsync(Api + table, new StringContent(bodyRequest, System.Text.Encoding.UTF8, mediaType));
                     }
                 })

                );
            return result;
        }

        public HttpResponseMessage GetAsync<TRequest>(string table)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            Task.WaitAny(
                 Task.Run(async () =>
                 {
                     using (var client = new HttpClient())
                     {
                         client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                         result = await client.GetAsync(Api + table);
                     }
                 })
                );
            return result;
        }

        public HttpResponseMessage PutAsync<TRequest>(string table, TRequest request, string Id, string mediaType = "application/json")
        {
            HttpResponseMessage result = new HttpResponseMessage();
            Task.WaitAny(
                 Task.Run(async () =>
                 {
                     using (var client = new HttpClient())
                     {
                         string serviceUrlFinal = String.Format("{0}/{1}", Api + table, Id);
                         string bodyRequest;
                         bodyRequest = JsonConvert.SerializeObject(request);
                         client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                         result = await client.PutAsync(serviceUrlFinal, new StringContent(bodyRequest, System.Text.Encoding.UTF8, mediaType));
                     }
                 })
                );
            return result;
        }
        public HttpResponseMessage DeleteAsync<TRequest>(string table, string Id)
        {
            HttpResponseMessage result = new HttpResponseMessage();
            Task.WaitAny(
                 Task.Run(async () =>
                 {
                     using (var client = new HttpClient())
                     {
                         string serviceUrlFinal = String.Format("{0}/{1}", Api + table, Id);
                         client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                         result = await client.DeleteAsync(serviceUrlFinal);
                     }
                 })
                );
            return result;
        }
    }
}
