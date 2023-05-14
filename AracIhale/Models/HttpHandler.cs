using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhale.UI.Models
{
    public class HttpHandler
    {
        private readonly HttpClient _client;

        public HttpHandler(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Veriler API ye gönderilemedi");
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<T> PostAsync<T>(string url, T dto)
        {
            var serializedDto = JsonConvert.SerializeObject(dto);

            var stringContent = new StringContent(serializedDto);
            stringContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(url, stringContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Veriler API ye gönderilemedi");
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    
}
}
