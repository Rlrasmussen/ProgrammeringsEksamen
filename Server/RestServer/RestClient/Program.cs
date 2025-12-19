using SharedLibrary;
using System.Threading.Tasks;

namespace RestClient
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseURL = "https://localhost:32777/WeatherForecast/", clientPrivateKey, clientPublicKey;



        static async Task Main(string[] args)
        {
            
            Console.ReadKey();
            bool ping = await Heartbeat();

            if (ping)
            {
                Console.WriteLine("Ping ping");
            }

        }

        private static async Task<bool> Heartbeat()
        {
            var request = new HttpRequestMessage(HttpMethod.Head, baseURL + "Heartbeat"); //It's a task
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}
