using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Pim.Model;

namespace Pim.DAO
{
    internal class DAO_Cargo
    {
        public Cargo BuscarCargo(Cargo cargo)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {


                var worksheet = workbook.Worksheet("Cargo");
                // Acessa as células que contêm os valores de usuário e senha na planilha
                var funcao = worksheet.Cell("A2");
                var salario = worksheet.Cell("B2");
                var horas = worksheet.Cell("C2");



                // Lê os valores das células
                cargo.SalarioBruto = Convert.ToDouble(salario.Value.ToString());
                cargo.Funcao = funcao.Value.ToString();
                cargo.HorasJornada = Convert.ToDouble(horas.Value.ToString());
                return cargo;
            }
        }
    }
}