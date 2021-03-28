using DesafioSoftplan.Api2.Core.IntegracoesContexto.Dto;
using DesafioSoftplan.Api2.Core.IntegracoesContexto.Interfaces;
using Newtonsoft.Json;
using Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Infra.IntegracoesContexto.TaxaJurosContexto
{
    public class RepositorioTaxaJuros : IRepositorioTaxaJuros
    {
        public async Task<Option<OutTaxaJuros>> RetornarTaxaJurosApi1()
        {
            string json = await Get("http://localhost:23066/taxaJuros");
            var retorno = JsonConvert.DeserializeObject<OutTaxaJuros>(json);
            return retorno == null ? Option.None<OutTaxaJuros>() : Option.Some<OutTaxaJuros>(retorno);
        }

        private async Task<string> Get(string caminho)
        {
            try
            {
                HttpClient requisicao = new HttpClient();
                HttpResponseMessage resposta = requisicao.GetAsync(caminho).GetAwaiter().GetResult();
                if (resposta.StatusCode == HttpStatusCode.OK)
                {
                    var conteudo = await resposta.Content.ReadAsStringAsync();
                    return conteudo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
