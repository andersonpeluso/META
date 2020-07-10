using FluentAssertions;
using META.Desafio.Servico.Interfaces;
using META.Desafio.Teste.Fixture;
using Xunit;

namespace META.Desafio.Teste.Testes
{
    public class TestaServicoDoShowMeTheCode : IClassFixture<ContainerFixture>
    {
        private readonly IShowMeTheCode _showMeTheCode;

        public TestaServicoDoShowMeTheCode(ContainerFixture container)
        {
            _showMeTheCode = container.ShowMeTheCode;
        }

        [Fact]
        public void ShowMeTheCodeTesteOk()
        {
            var response = _showMeTheCode.ObterEnderecoDoGithub();
            response.Should().Be("https://github.com/andersonpeluso/META");
        }

        [Fact]
        public void ShowMeTheCodeTesteErro()
        {
            var response = _showMeTheCode.ObterEnderecoDoGithub();
            response.Should().NotBe("https://github.com");
            response.Should().NotBe("");
        }
    }
}