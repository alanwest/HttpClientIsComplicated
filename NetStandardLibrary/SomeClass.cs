using System.Net.Http;
using System.Threading.Tasks;

namespace NetStandardLibrary
{
    public class SomeClass
    {
        private static HttpClient HttpClient = new HttpClient();

        public static async Task MakeAnHttpCall()
        {
            await HttpClient.GetStringAsync("https://opentelemetry.io");
        }
    }
}
