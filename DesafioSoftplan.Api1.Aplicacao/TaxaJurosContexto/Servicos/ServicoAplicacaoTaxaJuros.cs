using DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Dto;
using DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Servicos
{
    public class ServicoAplicacaoTaxaJuros : IServicoAplicacaoTaxaJuros
    {
        public TaxaJuros RetornarTaxaJuros()
        {
            return new TaxaJuros {ValorTaxa = 0.01 };
        }
    }
}
