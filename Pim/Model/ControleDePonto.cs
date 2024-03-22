using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class ControleDePonto
    {
        public double HorasTrabalhadas { get; set; }
        public double HorasExtras { get; set; }
        public string justificativa { get; set; }
        public double SalarioLiquido { get; set; }
    }
}