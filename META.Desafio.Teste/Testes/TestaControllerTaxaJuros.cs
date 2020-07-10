using FluentAssertions;
using META.Desafio.Teste.Contexto;
using META.Desafio.Teste.Fixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace META.Desafio.Teste.Testes
{
    public class TestaControllerTaxaJuros : IClassFixture<ContainerFixture>
    {
        private readonly ContextoTeste _contextoTeste;

        public TestaControllerTaxaJuros()
        {
            _contextoTeste = new ContextoTeste();
        }

        [Fact]
        public async Task ObterTaxaDeJurosTesteOk()
        {
            var response = await _contextoTeste.httpClient.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ObterTaxaDeJurosTesteContentType()
        {
            var response = await _contextoTeste.httpClient.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }
    }
}