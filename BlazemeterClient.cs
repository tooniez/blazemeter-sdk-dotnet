
using System;

namespace BlazeMeter.SDK
{
    public class BlazeMeterClient
    {
        public BlazeMeterClient(string apiKey)
        {
            // Initialize client with API key
        }

        public Endpoints.MockServices.BlazeMeterMockService MockServices { get; } = new Endpoints.MockServices.BlazeMeterMockService();
    }
}
