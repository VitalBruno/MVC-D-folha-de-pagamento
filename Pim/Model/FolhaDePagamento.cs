using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class FolhaDePagamento
    {
        public DateTime DataDeEmissao { get; set; }
        public double mes { get; set; }
        public double ano { get; set; }
        public double gastototal { get; set; }

        public double INSS { get; set; }
        public double FGTS { get; set; }
        public double VA { get; set; }
        public double VR { get; set; }
        public double VT { get; set; }
        public double Ferias { get; set; }

        public double SalarioLiquido { get; set; }
        public Taxas taxas { get; set; }
        public Pagamento pagamento { get; set; }
        public ControleDePonto controleDePonto { get; set; }
        public FolhaDePagamento()
        {
            controleDePonto = new ControleDePonto();
            pagamento = new Pagamento();
            taxas = new Taxas();

        }
    }

}
