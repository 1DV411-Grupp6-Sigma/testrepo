using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Linq;


namespace testSigma.Models
{
    public abstract class HTTPFetcher
    {
        internal static readonly string BaseUrl = "http://api.kolada.se/v2/";

        public JObject JsonFetcher(string apiRequest)
        {
            using (var client = new HttpClient())
            {
                //Set http header
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                //Request
                var response = client.GetAsync(apiRequest).Result;

                //Ensures the response is 200, otherwise an exception is thrown
                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsAsync<JObject>().Result;

                return content;
            }
        }
    }
}