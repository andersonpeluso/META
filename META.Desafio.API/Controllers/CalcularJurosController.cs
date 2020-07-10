using META.Desafio.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace META.Desafio.API.Controllers
{
    [Route("api/")]
    public class CalcularJurosController : DefaultController
    {
        private readonly ICalculoDeJuros _calculoDeJuros;

        public CalcularJurosController(ICalculoDeJuros calculoDeJuros)
        {
            _calculoDeJuros = calculoDeJuros;
        }

        [HttpGet("calculajuros")]
        public ActionResult<double> CalculaJuros(double valorInicial, int tempo)
        {
            return _calculoDeJuros.CalcularJuros(valorInicial, tempo);
        }
    }
}