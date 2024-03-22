using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.Model;

namespace Pim.CTR
{
    internal class CTR_ControleDePonto
    {

        public ControleDePonto CalcularSalario(Cargo cargo, ControleDePonto controledeponto)
        {
            CTR_Cargo cTR_cargo = new CTR_Cargo();
            cTR_cargo.buscar(cargo);
            double h;
            double s;
            h = cargo.HorasJornada;
            s = cargo.SalarioBruto;
            if (h >= controledeponto.HorasTrabalhadas)
            {
                double aux = s / h;

                controledeponto.SalarioLiquido = controledeponto.HorasTrabalhadas * aux;
                return controledeponto;
            }
            else
            {
                double h1 = controledeponto.HorasTrabalhadas - h;
                double aux = s / h * 1.5;
                double aux1 = s / h;

                controledeponto.SalarioLiquido = h1 * aux + aux1 * controledeponto.HorasTrabalhadas;
                return controledeponto;
            }

        }
    }
}
