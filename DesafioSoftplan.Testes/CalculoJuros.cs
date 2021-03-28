using DesafioSoftplan.Api2.Core.JurosContexto.Dto;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos;
using DesafioSoftplan.Api2.Core.JurosContexto.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioSoftplan.Api2.Testes
{
    public class CalculoJuros
    {
        private IServicoCalculoJuros calculoJuros;        

        [Theory]
        [InlineData(100, 5, 0.01)]
        public void CalculaJuros(double valorInicial, int meses, double juros)
        {
            //arranje
            IServicoCalculoJuros calculoJuros = new ServicoCalculoJuros();

            //act
            var valorFinal = calculoJuros.CalculaJuros(new InJurosParam
            {
                ValorInicial = valorInicial,
                Meses = meses,
                Juros = juros
            });

            //assert
            var valorEsperado = 105.10;
            Assert.Equal(valorEsperado, valorFinal);
        }
    }
}
