using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.DAO;
using Pim.Model;

namespace Pim.CTR
{
    internal class CTR_Pessoa
    {
        public Pessoa verificar(Pessoa pessoa)
        {
            DAO_Pessoa p = new DAO_Pessoa();
            p.verificar(pessoa);
            return pessoa;
        }
        public void Buscar(Pessoa pessoa, Endereço endereço, Funcionario funcionario, Cargo cargo)
        {
            DAO_Pessoa p = new DAO_Pessoa();
            p.Buscar(pessoa, endereço, funcionario, cargo);

        }
        public void Excluir()
        {
            DAO_Pessoa p = new DAO_Pessoa();
            p.excluir();

        }
        public Pessoa Buscar(Pessoa pessoa)
        {
            DAO_Pessoa p = new DAO_Pessoa();
            p.BuscarP(pessoa);
            return pessoa;

        }

    }
}
