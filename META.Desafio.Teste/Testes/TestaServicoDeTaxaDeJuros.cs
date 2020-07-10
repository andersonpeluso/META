using FluentAssertions;
using META.Desafio.Servico.Interfaces;
using META.Desafio.Teste.Fixture;
using Xunit;

namespace META.Desafio.Teste.Testes
{
    public class TestaServicoDeTaxaDeJuros : IClassFixture<ContainerFixture>
    {
        private readonly ITaxaDeJuros _taxaDeJuros;

        public TestaServicoDeTaxaDeJuros(ContainerFixture container)
        {
            _taxaDeJuros = container.TaxaDeJuros;
        }

        [Fact]
        public void TaxaDeJurosTesteOk()
        {
            var response = _taxaDeJuros.ObterTaxaDeJuros();
            response.Should().Be(.01);
        }

        [Fact]
        public void TaxaDeJurosTesteErro()
        {
            var response = _taxaDeJuros.ObterTaxaDeJuros();
            response.Should().NotBe(0);
            response.Should().NotBe(.02);
        }
    }
}