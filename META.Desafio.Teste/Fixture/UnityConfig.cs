using META.Desafio.Servico.Classes;
using META.Desafio.Servico.Interfaces;
using Unity;

namespace META.Desafio.Teste.Fixture
{
    public class UnityConfig
    {
        public static void RegisterDependencies(IUnityContainer container)
        {
            container.RegisterFactory<ICalculoDeJuros>((c, type, name) => c.Resolve<ServicoDeCalculoDeJuros>());
            container.RegisterFactory<IShowMeTheCode>((c, type, name) => c.Resolve<ServicoDoShowMeTheCode>());
            container.RegisterFactory<ITaxaDeJuros>((c, type, name) => c.Resolve<ServicoDeTaxaDeJuros>());
        }
    }
}