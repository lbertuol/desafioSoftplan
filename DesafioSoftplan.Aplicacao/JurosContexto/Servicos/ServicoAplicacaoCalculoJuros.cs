using DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos.Interfaces;
using DesafioSoftplan.Api2.Core.IntegracoesContexto.Interfaces;
using DesafioSoftplan.Api2.Core.JurosContexto.Dto;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos
{
    public class ServicoAplicacaoCalculoJuros : IServicoAplicacaoCalculoJuros
    {
        private IServicoCalculoJuros _servicoCalculoJuros;
        private IRepositorioTaxaJuros _repositorioTaxaJuros;

        public ServicoAplicacaoCalculoJuros(IServicoCalculoJuros servicoCalculoJuros, IRepositorioTaxaJuros repositorioTaxaJuros)
        {
            _servicoCalculoJuros = servicoCalculoJuros;
            _repositorioTaxaJuros = repositorioTaxaJuros;
        }
        public double CalculaJuros(double valorInicial, int meses)
        {
            var retorno = Task.Run(() => _repositorioTaxaJuros.RetornarTaxaJurosApi1()).Result;
            var resultado = retorno.Match
                (
                some: x => x,
                none: () => {
                    return default;
                });

            return _servicoCalculoJuros.CalculaJuros(new InJurosParam
            {
                ValorInicial = valorInicial,
                Meses = meses,
                Juros = resultado.ValorTaxa                
            });
        }        
    }
}
