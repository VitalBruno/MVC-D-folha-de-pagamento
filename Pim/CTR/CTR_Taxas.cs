using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pim.CTR
{
    internal class CTR_Taxas
    {
        Taxas taxas = new Taxas();
        Cargo cargo = new Cargo();
        public void CalculoINSS(Funcionario funcionario)
        {
            CTR_Cargo cTR_Cargo = new CTR_Cargo();
            Cargo c = cTR_Cargo.buscar(cargo);

            double s;
            s = c.SalarioBruto;
            double aux;

            if (s <= 1.320)
            {
                aux = s * 0.075;
                taxas.INSS = aux;
            }
            else if (s <= 2571.29)
            {
                aux = s * 0.09;
                taxas.INSS = aux;
            }
            else if (s <= 3856.94)
            {
                aux = s * 0.12;
                taxas.INSS = aux;
            }
            else
            {
                aux = s * 0.14;
                taxas.INSS = aux;
            }




        }
        public void CalculoFGTS(Funcionario funcionario)
        {
            CTR_Cargo cTR_Cargo = new CTR_Cargo();
            Cargo c = cTR_Cargo.buscar(cargo);

            double s;
            s = c.SalarioBruto;
            taxas.FGTS = s * 0.08;

        }
        public void CalculoVR(Funcionario funcionario)
        {
            CTR_Cargo cTR_Cargo = new CTR_Cargo();
            Cargo c = cTR_Cargo.buscar(cargo);

            double s;
            s = c.SalarioBruto;
            taxas.VR = s * 0.06;

        }
        public void CalculoVA(Funcionario funcionario)
        {
            CTR_Cargo cTR_Cargo = new CTR_Cargo();
            Cargo c = cTR_Cargo.buscar(cargo);

            double s;
            s = c.SalarioBruto;
            taxas.VA = s * 0.06;

        }
        public void CalculoVT()
        {
            taxas.VT = 200;

        }
        public Taxas fazercalculo(Funcionario funcionario)
        {

            CalculoINSS(funcionario);
            CalculoFGTS(funcionario);
            CalculoVR(funcionario);
            CalculoVA(funcionario);
            CalculoVT();
            return taxas;
        }
    }
}
