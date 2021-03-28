using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api2.Core.JurosContexto.Dto
{
    public class InJurosParam
    {
        public double ValorInicial { get; set; }
        public int Meses { get; set; }
        public double Juros { get; set; }
    }
}
