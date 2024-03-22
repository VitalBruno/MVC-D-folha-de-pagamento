using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class Pagamento
    {
        public double PIX { get; set; }
        public double DataDePagamento { get; set; }
        public double HorarioDePagamento { get; set; }
        public double SalarioLiquido { get; set; }
    }
}
