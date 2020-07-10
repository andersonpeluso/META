using META.Desafio.Servico.Interfaces;

namespace META.Desafio.Servico.Classes
{
    public class ServicoDeTaxaDeJuros : ITaxaDeJuros
    {
        public double ObterTaxaDeJuros()
        {
            return .01;
        }
    }
}