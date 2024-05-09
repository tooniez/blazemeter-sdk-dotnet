
using System;
using System.Threading.Tasks;
using BlazeMeter.SDK.Helpers;
using BlazeMeter.SDK.Models;

namespace BlazeMeter.SDK.Endpoints.MockServices
{
    public class BlazeMeterMockService
    {
        private readonly Uri _baseUri = new Uri("https://api.blazemeter.com/api/v4/");

        public async Task<BlazeMeterMockServiceModel> GetMockServiceAsync(string mockServiceId)
        {
            var response = await HttpClientHelper.GetAsync(new Uri(_baseUri, $"mock-services/{mockServiceId}"));
            // Parse response JSON into BlazeMeterMockServiceModel object
            return new BlazeMeterMockServiceModel(); // Placeholder
        }
    }
}
