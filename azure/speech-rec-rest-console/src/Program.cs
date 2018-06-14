using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            string subscriptionKey = String.Empty;
            string fetchUri = "https://northeurope.tts.speech.microsoft.com/cognitiveservices/v1";

            Console.WriteLine("Donna welcomes you!");

            try
            {
                var auth = new Authentication(subscriptionKey,fetchUri);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Exception!");
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.Source);
            }
        }
    }

    public class Authentication
    {
        private string subscriptionKey;
        private string fetchUri;
        private string token;

        public Authentication(string subscriptionKey, string fetchUri)
        {
            this.subscriptionKey = subscriptionKey;
            this.fetchUri = fetchUri;
            this.token = FetchTokenAsync(fetchUri, subscriptionKey).Result;
        }

        public string GetAccessToken()
        {
            return this.token;
        }

        private async Task<string> FetchTokenAsync(string fetchUri, string subscriptionKey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                UriBuilder uriBuilder = new UriBuilder(fetchUri);
                uriBuilder.Path += "/issueToken";

                var result = await client.PostAsync(uriBuilder.Uri.AbsoluteUri, null);
                Console.WriteLine("Token Uri: {0}", uriBuilder.Uri.AbsoluteUri);
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
