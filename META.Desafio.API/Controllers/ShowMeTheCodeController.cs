using META.Desafio.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace META.Desafio.API.Controllers
{
    [Route("api/")]
    public class ShowMeTheCodeController : DefaultController
    {
        private readonly IShowMeTheCode _showMeTheCode;

        public ShowMeTheCodeController(IShowMeTheCode showMeTheCode)
        {
            _showMeTheCode = showMeTheCode;
        }

        [Route("showmethecode")]
        [HttpGet]
        public ActionResult<string> ObterEnderecoDoGithub()
        {
            return _showMeTheCode.ObterEnderecoDoGithub();
        }
    }
}