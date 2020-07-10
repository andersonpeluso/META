using FluentAssertions;
using META.Desafio.Teste.Contexto;
using META.Desafio.Teste.Fixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace META.Desafio.Teste.Testes
{
    public class TestaControllerShowMeTheCode : IClassFixture<ContainerFixture>
    {
        private readonly ContextoTeste _contextoTeste;

        public TestaControllerShowMeTheCode()
        {
            _contextoTeste = new ContextoTeste();
        }

        [Fact]
        public async Task ObterEnderecoDoGithubOK()
        {
            var response = await _contextoTeste.httpClient.GetAsync("/api/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ObterEnderecoDoGithubContentType()
        {
            var response = await _contextoTeste.httpClient.GetAsync("/api/showmethecode");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}