using META.Desafio.CrossCutting;
using META.Desafio.Dominio.Classes;
using META.Desafio.Servico.Interfaces;

namespace META.Desafio.Servico.Classes
{
    public class ServicoDeCalculoDeJuros : ICalculoDeJuros
    {
        private readonly ITaxaDeJuros _taxaJuros;

        public ServicoDeCalculoDeJuros(ITaxaDeJuros taxaDeJuros)
        {
            _taxaJuros = taxaDeJuros;
        }

        public double CalcularJuros(double valorInicial, int tempo)
        {
            var taxaJuros = _taxaJuros.ObterTaxaDeJuros();

            var calculoDeJuros = new CalculoDeJuros();

            var totalJuros = calculoDeJuros.CalcularJuros(valorInicial, taxaJuros, tempo);

            return totalJuros.ObterTruncado();
        }
    }
}