using DesafioSoftplan.Api2.Core.IntegracoesContexto.Dto;
using Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Core.IntegracoesContexto.Interfaces
{
    public interface IRepositorioTaxaJuros
    {
        Task<Option<OutTaxaJuros>> RetornarTaxaJurosApi1();
    }
}
