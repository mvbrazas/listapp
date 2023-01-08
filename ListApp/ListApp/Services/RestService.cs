using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListApp.Services
{
    public class RestService
    {
        private HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromMinutes(3);
        }

        public async Task<T> GetResponse<T>(string weburl) where T : class
        {
            try
            {
                var response = await _client.GetAsync(weburl, HttpCompletionOption.ResponseContentRead);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResult = await response.Content.ReadAsStreamAsync();
                    using (var sr = new StreamReader(jsonResult))
                    using (var jtr = new JsonTextReader(sr))
                    {
                        var js = new JsonSerializer();
                        var searchResult = js.Deserialize<T>(jtr);
                        return searchResult;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Log(ex.ToString());
            }
            return null;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}