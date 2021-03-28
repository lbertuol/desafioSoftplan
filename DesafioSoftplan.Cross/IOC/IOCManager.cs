using DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos;
using DesafioSoftplan.Api2.Aplicacao.JurosContexto.Servicos.Interfaces;
using DesafioSoftplan.Api2.Aplicacao.ShowMeTheCodeContexto.Servicos;
using DesafioSoftplan.Api2.Aplicacao.ShowMeTheCodeContexto.Servicos.Interfaces;
using DesafioSoftplan.Api2.Core.IntegracoesContexto.Interfaces;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos.Interfaces;
using DesafioSoftplan.Api2.Infra.IntegracoesContexto.TaxaJurosContexto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Cross.IOC
{
    public static class IOCManager
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IServicoCalculoJuros, ServicoCalculoJuros>();
            services.AddScoped<IServicoAplicacaoCalculoJuros, ServicoAplicacaoCalculoJuros>();
            services.AddScoped<IServicoAplicacaoShowMeTheCode, ServicoAplicacaoShowMeTheCode>();
            services.AddScoped<IRepositorioTaxaJuros, RepositorioTaxaJuros>();
        }
    }
}
