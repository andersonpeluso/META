using META.Desafio.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace META.Desafio.API.Controllers
{
    [Route("api/[controller]")]
    public class ShowMeTheCodeController : DefaultController
    {
        private readonly IShowMeTheCode _showMeTheCode;

        public ShowMeTheCodeController(IShowMeTheCode showMeTheCode)
        {
            _showMeTheCode = showMeTheCode;
        }

        //[Route("showmethecode")]
        [HttpGet]
        public ActionResult<string> ObterEnderecoDoGithub()
        {
            return CustomResponse(_showMeTheCode.ObterEnderecoDoGithub());
        }
    }
}