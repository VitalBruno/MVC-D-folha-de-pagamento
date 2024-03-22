using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.DAO;
using Pim.Model;

namespace Pim.CTR
{
    internal class CTR_FolhaDePagamento
    {
        public FolhaDePagamento calcular(FolhaDePagamento folhaDePagamento, Taxas taxas, ControleDePonto controleDePonto)
        {
            folhaDePagamento.SalarioLiquido = controleDePonto.SalarioLiquido - taxas.INSS;

            return folhaDePagamento;
        }
        public void salvar(FolhaDePagamento folhaDePagamento)
        {
            DAO_FolhaDePagamento dAO_FolhaDePagamento = new DAO_FolhaDePagamento();
            dAO_FolhaDePagamento.salvar(folhaDePagamento);
        }
        public void buscar(FolhaDePagamento folhaDePagamento)
        {
            DAO_FolhaDePagamento dAO_FolhaDePagamento = new DAO_FolhaDePagamento();
            dAO_FolhaDePagamento.Buscar(folhaDePagamento);
        }
        public FolhaDePagamento gasto(FolhaDePagamento folhaDePagamento)
        {
            folhaDePagamento.gastototal = folhaDePagamento.SalarioLiquido + folhaDePagamento.FGTS + folhaDePagamento.VA + folhaDePagamento.VR + folhaDePagamento.VT;

            return folhaDePagamento;
        }

    }
}
