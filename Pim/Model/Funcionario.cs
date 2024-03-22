using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class Funcionario : Pessoa
    {
        public double DataDeAdmissao { get; set; }
        public string DadosBancarios { get; set; }
        public int Matricula { get; set; }
        public string Status { get; set; }
        public Cargo cargo;
        public FolhaDePagamento folhaDePagamento;
        public Funcionario()
        {
            cargo = new Cargo();
            folhaDePagamento = new FolhaDePagamento();
        }
    }

}
