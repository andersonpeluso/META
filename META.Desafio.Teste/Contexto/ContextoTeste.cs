using META.Desafio.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace META.Desafio.Teste.Contexto
{
    public class ContextoTeste
    {
        public HttpClient httpClient { get; set; }
        private TestServer testServer;

        public ContextoTeste()
        {
            SetupClient();
        }

        private void SetupClient()
        {
            testServer = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            httpClient = testServer.CreateClient();
        }
    }
}