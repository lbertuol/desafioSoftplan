using DesafioSoftplan.Api2.Aplicacao.ShowMeTheCodeContexto.Servicos.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Api.ShowMeTheCodeContexto.Controller
{
    [ApiController]
    [Route("/")]    
    public class ShowMeTheCode : ControllerBase
    {
        private IServicoAplicacaoShowMeTheCode _servicoAplicacaoShowMeTheCode;

        public ShowMeTheCode(IServicoAplicacaoShowMeTheCode servicoAplicacaoShowMeTheCode)
        {
            _servicoAplicacaoShowMeTheCode = servicoAplicacaoShowMeTheCode;
        }

        [HttpGet("showmethecode")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult ShowTheCode()
        {
            return new JsonResult(_servicoAplicacaoShowMeTheCode.ShowMeTheCode());
        }
    }
}
