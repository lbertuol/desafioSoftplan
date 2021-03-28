using DesafioSoftplan.Api2.Core.JurosContexto.Dto;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Core.JurosContexto.Servicos
{
    public class ServicoCalculoJuros : IServicoCalculoJuros
    {
        public double CalculaJuros(InJurosParam jurosParam)
        {
            var resultadoCalculoJuros = jurosParam.ValorInicial * Math.Pow((1 + jurosParam.Juros), jurosParam.Meses);
            var resultadoTruncadoDuasCasasSemArredondamento = Math.Truncate(resultadoCalculoJuros * 100) / 100;
            return resultadoTruncadoDuasCasasSemArredondamento;
        }
    }
}
