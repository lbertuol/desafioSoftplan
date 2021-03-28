using DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Servicos;
using DesafioSoftplan.Api1.Aplicacao.TaxaJurosContexto.Servicos.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api1.Cross.IOC
{
    public static class IOCManager
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IServicoAplicacaoTaxaJuros, ServicoAplicacaoTaxaJuros>();            
        }
    }
}
