using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using Pim.Model;

namespace Pim.DAO
{
    internal class DAO_Funcionario
    {
        public void RegistrarBD(Pessoa pessoa, Endereço endereço, Funcionario funcionario, Cargo cargo)
        {
            string c = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";
            using (var workbook = new XLWorkbook(c))
            {
                //SALVAR DADOS EM PESSOA
                var worksheet = workbook.Worksheet("Pessoa");
                worksheet.Cell("A2").Value = pessoa.nome;
                worksheet.Cell("B2").Value = pessoa.cpf;
                worksheet.Cell("C2").Value = pessoa.email;
                worksheet.Cell("D2").Value = pessoa.telefone;
                workbook.Save();
                //SALVAR DADOS EM ENDEREÇO
                var worksheet1 = workbook.Worksheet("Endereço");
                worksheet1.Cell("A2").Value = endereço.CEP;
                worksheet1.Cell("B2").Value = endereço.Rua;
                worksheet1.Cell("C2").Value = endereço.Bairro;
                worksheet1.Cell("D2").Value = endereço.Cidade;
                worksheet1.Cell("E2").Value = endereço.Estado;
                worksheet1.Cell("F2").Value = endereço.Numero;
                workbook.Save();
                //SALVAR DADOS EM Funcionario
                var worksheet2 = workbook.Worksheet("Funcionario");
                worksheet2.Cell("A2").Value = funcionario.DataDeAdmissao;
                worksheet2.Cell("B2").Value = funcionario.DadosBancarios;
                worksheet2.Cell("C2").Value = funcionario.Matricula;
                worksheet2.Cell("D2").Value = funcionario.Status;

                var worksheet3 = workbook.Worksheet("Cargo");
                worksheet3.Cell("A2").Value = cargo.Funcao;
                worksheet3.Cell("B2").Value = cargo.SalarioBruto;
                worksheet3.Cell("C2").Value = cargo.HorasJornada;
                workbook.Save();

            }


        }
        public Funcionario buscar(Funcionario funcionario)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {
                var worksheet = workbook.Worksheet("Funcionario");

                // Acessa as células que contêm os valores de usuário e senha na planilha
                var ad = worksheet.Cell("A2");
                var banc = worksheet.Cell("B2");
                var matricula = worksheet.Cell("C2");
                var status = worksheet.Cell("D2");

                // Lê os valores das células
                funcionario.DataDeAdmissao = Convert.ToDouble(ad.Value.ToString());
                funcionario.DadosBancarios = banc.Value.ToString();
                funcionario.Matricula = Convert.ToInt32(matricula.Value.ToString());
                funcionario.Status = status.Value.ToString();
                return funcionario;

            }
        }
    }
}
