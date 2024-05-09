
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazeMeter.SDK.Helpers
{
    public static class HttpClientHelper
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<string> GetAsync(Uri requestUri)
        {
            var response = await HttpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
