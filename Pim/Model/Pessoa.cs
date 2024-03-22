using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Model
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public double cpf { get; set; }
        public string email { get; set; }
        public double telefone { get; set; }
        public Endereço endereço;
        public Pessoa()
        {
            endereço = new Endereço();
        }
    }

}
