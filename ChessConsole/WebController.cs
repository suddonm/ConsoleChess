using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleChess
{
    class WebController
    {
        private string REST_URI;        

        public WebController(string URI)
        {
            REST_URI = URI;
        }

        private bool CreateGame()
        {
            return true;
        }

        public async Task RetrieveGames()
        {
            using (var webRequest = new WebRequestHandler())
            {
                webRequest.ServerCertificateValidationCallback +=
                delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
                {
                    return true; // **** Always accept
                };

                using (var httpClient = new HttpClient(webRequest))
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();

                    var stringTask = httpClient.GetStringAsync(REST_URI + "/api/chess");

                    var msg = await stringTask;
                    Console.WriteLine(msg);
                }
            }
        }
    }
}
