using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim.DAO;
using Pim.Model;

namespace Pim.CTR
{
    internal class CTR_Cargo
    {


        public void definir(Cargo cargo)
        {
            switch (cargo.Funcao)
            {
                case "Auxiliar":
                    cargo.SalarioBruto = 1600;
                    cargo.HorasJornada = 120;
                    break;
                case "Tecnico":
                    cargo.SalarioBruto = 2500;
                    cargo.HorasJornada = 176;
                    break;
                case "Coordenador":
                    cargo.SalarioBruto = 4500;
                    cargo.HorasJornada = 176;
                    break;
                case "Lider":
                    cargo.SalarioBruto = 6000;
                    cargo.HorasJornada = 160;
                    break;

            }

        }
        public Cargo buscar(Cargo cargo)
        {
            DAO_Cargo dAO_Cargo = new DAO_Cargo();
            dAO_Cargo.BuscarCargo(cargo);
            return cargo;
        }
    }
}
