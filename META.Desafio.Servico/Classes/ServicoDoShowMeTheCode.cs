using META.Desafio.Dominio.Classes;
using META.Desafio.Servico.Interfaces;

namespace META.Desafio.Servico.Classes
{
    public class ServicoDoShowMeTheCode : IShowMeTheCode
    {
        public ServicoDoShowMeTheCode()
        {
        }

        public string ObterEnderecoDoGithub()
        {
            ShowMeTheCode showMeTheCode = new ShowMeTheCode();
            return showMeTheCode.ObterEnderecoGithub();
        }
    }
}