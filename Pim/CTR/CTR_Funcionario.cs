using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.DAO;
using Pim.Model;

namespace Pim.CTR
{
    internal class CTR_Funcionario
    {
        public void addFuncionario(Pessoa pessoa, Endereço endereço, Funcionario funcionario, Cargo cargo)
        {
            CTR_Cargo CTR_c = new CTR_Cargo();
            CTR_c.definir(cargo);

            DAO_Funcionario d = new DAO_Funcionario();
            d.RegistrarBD(pessoa, endereço, funcionario, cargo);
        }

        public Funcionario buscarFuncionario(Funcionario funcionario)
        {
            DAO_Funcionario d = new DAO_Funcionario();
            d.buscar(funcionario);
            return funcionario;

        }
    }
}
