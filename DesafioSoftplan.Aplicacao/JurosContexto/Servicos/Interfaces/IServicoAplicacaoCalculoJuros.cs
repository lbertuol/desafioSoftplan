using DesafioSoftplan.Api2.Core.JurosContexto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos.Interfaces
{
    public interface IServicoAplicacaoCalculoJuros
    {
        double CalculaJuros(double valorInicial, int meses);
    }
}
