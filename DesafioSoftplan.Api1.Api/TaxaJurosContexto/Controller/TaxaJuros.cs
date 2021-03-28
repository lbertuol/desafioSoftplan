using DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Servicos.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api1.Api.TaxaJurosContexto.Controller
{
    [ApiController]
    [Route("/")]
    public class TaxaJuros : ControllerBase
    {
        private IServicoAplicacaoTaxaJuros _servicoAplicacaoTaxaJuros;

        public TaxaJuros(IServicoAplicacaoTaxaJuros servicoAplicacaoTaxaJuros)
        {
            _servicoAplicacaoTaxaJuros = servicoAplicacaoTaxaJuros;

        }

        [HttpGet("taxaJuros")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(double), 200)]
        public IActionResult CalculaJuros(double valorInicial, int meses)
        {
            return new JsonResult(_servicoAplicacaoTaxaJuros.RetornarTaxaJuros());
        }
    }
}
