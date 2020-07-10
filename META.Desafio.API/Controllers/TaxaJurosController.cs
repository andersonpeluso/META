using META.Desafio.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace META.Desafio.API.Controllers
{
    [Route("api/")]
    public class TaxaJurosController : DefaultController
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
            return CustomResponse(_taxaDeJuros.ObterTaxaDeJuros());
        }
    }
}