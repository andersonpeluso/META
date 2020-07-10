using FluentAssertions;
using META.Desafio.Servico.Interfaces;
using META.Desafio.Teste.Fixture;
using Xunit;

namespace META.Desafio.Teste.Testes
{
    public class TestaServicoDeCalculoDeJuros : IClassFixture<ContainerFixture>
    {
        private readonly ICalculoDeJuros _calculoDeJuros;

        public TestaServicoDeCalculoDeJuros(ContainerFixture container)
        {
            _calculoDeJuros = container.CalculoDeJuros;
        }

        [Fact]
        public void CalcularJurosTesteOk()
        {
            var response = _calculoDeJuros.CalcularJuros(100, 5);
            response.Should().Be(105.1);
        }

        [Fact]
        public void CalcularJurosTesteErro()
        {
            var response = _calculoDeJuros.CalcularJuros(100, 5);
            response.Should().NotBe(100);
        }
    }
}