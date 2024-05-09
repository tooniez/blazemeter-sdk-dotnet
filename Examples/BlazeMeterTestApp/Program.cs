using System;
using System.Threading.Tasks;
using BlazeMeter.SDK;

namespace BlazeMeterTestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Replace "your-api-key" with your BlazeMeter API key
            var apiKey = "your-api-key";
            var client = new BlazeMeterClient(apiKey);

            Console.WriteLine("Testing BlazeMeter SDK...");

            // Test the BlazeMeterMockService endpoint
            await TestBlazeMeterMockService(client);

            Console.WriteLine("Testing complete. Press any key to exit...");
            Console.ReadKey();
        }

        static async Task TestBlazeMeterMockService(BlazeMeterClient client)
        {
            // Replace "mock-service-id" with a valid BlazeMeter mock service ID
            var mockServiceId = "mock-service-id";

            Console.WriteLine($"Getting BlazeMeter mock service with ID: {mockServiceId}...");

            var mockService = await client.MockServices.GetMockServiceAsync(mockServiceId);

            if (mockService != null)
            {
                Console.WriteLine($"Mock Service Name: {mockService.Name}");
                // Output additional properties as needed
            }
            else
            {
                Console.WriteLine("Failed to retrieve BlazeMeter mock service.");
            }
        }
    }
}

