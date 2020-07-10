using META.Desafio.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace META.Desafio.API.Controllers
{
    [Route("api/")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaDeJuros _taxaDeJuros;

        public TaxaJurosController(ITaxaDeJuros taxaDeJuros)
        {
            _taxaDeJuros = taxaDeJuros;
        }

        [Route("taxajuros")]
        [HttpGet]
        public ActionResult<double> ObterTaxaDeJuros()
        {
            //if (_taxaDeJuros.ObterTaxaDeJuros() == )
            //{
            //    AdicionarErroProcessamento("Não conseguir carregar todos os usuários.");
            //    return CustomResponse();
            //}

            return _taxaDeJuros.ObterTaxaDeJuros();
        }
    }
}