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
    internal class DAO_FolhaDePagamento
    {
        public void salvar(FolhaDePagamento folhaDePagamento)
        {
            string c = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";
            using (var workbook = new XLWorkbook(c))
            {
                //SALVAR DADOS EM PESSOA
                var worksheet = workbook.Worksheet("Folha");
                worksheet.Cell("A2").Value = folhaDePagamento.INSS;
                worksheet.Cell("B2").Value = folhaDePagamento.FGTS;
                worksheet.Cell("C2").Value = folhaDePagamento.VA;
                worksheet.Cell("D2").Value = folhaDePagamento.VR;
                worksheet.Cell("E2").Value = folhaDePagamento.VT;
                worksheet.Cell("F2").Value = folhaDePagamento.Ferias;
                worksheet.Cell("G2").Value = folhaDePagamento.SalarioLiquido;
                worksheet.Cell("H2").Value = folhaDePagamento.DataDeEmissao;
                worksheet.Cell("I2").Value = folhaDePagamento.mes;
                worksheet.Cell("J2").Value = folhaDePagamento.ano;
                workbook.Save();
            }

        }
        public void Buscar(FolhaDePagamento folhaDePagamento)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {


                var worksheet = workbook.Worksheet("Folha");
                // Acessa as células que contêm os valores de usuário e senha na planilha
                var inss = worksheet.Cell("A2");
                var fgts = worksheet.Cell("B2");
                var va = worksheet.Cell("C2");
                var vr = worksheet.Cell("D2");
                var vt = worksheet.Cell("E2");
                var ferias = worksheet.Cell("F2");
                var salarioliquido = worksheet.Cell("G2");
                var data = worksheet.Cell("H2");
                var mes = worksheet.Cell("I2");
                var ano = worksheet.Cell("J2");

                // Lê os valores das células
                folhaDePagamento.INSS = Convert.ToDouble(inss.Value.ToString());
                folhaDePagamento.FGTS = Convert.ToDouble(fgts.Value.ToString());
                folhaDePagamento.VA = Convert.ToDouble(va.Value.ToString());
                folhaDePagamento.VR = Convert.ToDouble(vr.Value.ToString());
                folhaDePagamento.VT = Convert.ToDouble(vt.Value.ToString());
                folhaDePagamento.Ferias = Convert.ToDouble(ferias.Value.ToString());
                folhaDePagamento.SalarioLiquido = Convert.ToDouble(salarioliquido.Value.ToString());
                folhaDePagamento.DataDeEmissao = Convert.ToDateTime(data.Value.ToString());
                folhaDePagamento.mes = Convert.ToDouble(mes.Value.ToString());
                folhaDePagamento.ano = Convert.ToDouble(ano.Value.ToString());
            }
        }


    }
}