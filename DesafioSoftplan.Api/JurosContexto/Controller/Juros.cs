using DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Api.JurosContexto.Controller
{
    [ApiController]
    [Route("/")]
    public class Juros : ControllerBase
    {
        private IServicoAplicacaoCalculoJuros _servicoAplicacaoCalculoJuros;
        
        public Juros(IServicoAplicacaoCalculoJuros servicoAplicacaoCalculoJuros)
        {
            _servicoAplicacaoCalculoJuros = servicoAplicacaoCalculoJuros;
            
        }

        [HttpGet("calculajuros")]        
        [AllowAnonymous]
        [ProducesResponseType(typeof(double), 200)]
        public IActionResult CalculaJuros(double valorInicial, int meses)
        {
            return new JsonResult(_servicoAplicacaoCalculoJuros.CalculaJuros(valorInicial, meses));
        }
    }
}
