using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Pim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.DAO
{
    internal class DAO_Pessoa
    {
        public Pessoa verificar(Pessoa pessoa)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {
                var worksheet = workbook.Worksheet("Pessoa");

                // Acessa as células que contêm os valores de usuário e senha na planilha
                var cpf = worksheet.Cell("B2");


                // Lê os valores das células
                pessoa.cpf = Convert.ToDouble(cpf.Value.ToString());

                return pessoa;

            }
        }
        public void Buscar(Pessoa pessoa, Endereço endereço, Funcionario funcionario, Cargo cargo)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {


                var worksheet = workbook.Worksheet("Pessoa");
                // Acessa as células que contêm os valores de usuário e senha na planilha
                var cpf = worksheet.Cell("B2");
                var nome = worksheet.Cell("A2");
                var email = worksheet.Cell("C2");
                var telefone = worksheet.Cell("D2");


                // Lê os valores das células
                pessoa.cpf = Convert.ToDouble(cpf.Value.ToString());
                pessoa.nome = nome.Value.ToString();
                pessoa.email = email.Value.ToString();
                pessoa.telefone = Convert.ToDouble(telefone.Value.ToString());

                var worksheet1 = workbook.Worksheet("Endereço");

                // Acessa as células que contêm os valores de usuário e senha na planilha
                var CEP = worksheet1.Cell("A2");
                var rua = worksheet1.Cell("B2");
                var bairro = worksheet1.Cell("C2");
                var cidade = worksheet1.Cell("D2");
                var estado = worksheet1.Cell("E2");
                var numero = worksheet1.Cell("F2");


                // Lê os valores das células
                endereço.CEP = Convert.ToDouble(CEP.Value.ToString());
                endereço.Rua = rua.Value.ToString();
                endereço.Bairro = bairro.Value.ToString();
                endereço.Cidade = cidade.Value.ToString();
                endereço.Estado = estado.Value.ToString();
                endereço.Numero = Convert.ToInt32(numero.Value.ToString());

                var worksheet2 = workbook.Worksheet("Funcionario");

                // Acessa as células que contêm os valores de usuário e senha na planilha
                var data = worksheet2.Cell("A2");
                var dados = worksheet2.Cell("B2");
                var matricula = worksheet2.Cell("C2");
                var status = worksheet2.Cell("D2");


                // Lê os valores das células
                funcionario.DataDeAdmissao = Convert.ToDouble(data.Value.ToString());
                funcionario.DadosBancarios = dados.Value.ToString();
                funcionario.Matricula = Convert.ToInt32(matricula.Value.ToString());
                funcionario.Status = status.Value.ToString();

                var worksheet3 = workbook.Worksheet("Cargo");
                var funcao = worksheet3.Cell("A2");
                var salario = worksheet3.Cell("B2");


                // Lê os valores das células
                cargo.Funcao = funcao.Value.ToString();
                cargo.SalarioBruto = Convert.ToDouble(salario.Value.ToString());



            }

        }
        public void excluir()
        {
            string c = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";
            using (var workbook = new XLWorkbook(c))
            {
                //SALVAR DADOS EM PESSOA
                var worksheet = workbook.Worksheet("Pessoa");
                worksheet.Cell("A2").Value = "";
                worksheet.Cell("B2").Value = "";
                worksheet.Cell("C2").Value = "";
                worksheet.Cell("D2").Value = "";
                workbook.Save();
                //SALVAR DADOS EM ENDEREÇO
                var worksheet1 = workbook.Worksheet("Endereço");
                worksheet1.Cell("A2").Value = "";
                worksheet1.Cell("B2").Value = "";
                worksheet1.Cell("C2").Value = "";
                worksheet1.Cell("D2").Value = "";
                worksheet1.Cell("E2").Value = "";
                worksheet1.Cell("F2").Value = "";
                workbook.Save();
                //SALVAR DADOS EM Funcionario
                var worksheet2 = workbook.Worksheet("Funcionario");
                worksheet2.Cell("A2").Value = "";
                worksheet2.Cell("B2").Value = "";
                worksheet2.Cell("C2").Value = "";
                worksheet2.Cell("D2").Value = "";

                var worksheet3 = workbook.Worksheet("Cargo");
                worksheet3.Cell("A2").Value = "";
                worksheet3.Cell("B2").Value = "";
                worksheet3.Cell("C2").Value = "";
                workbook.Save();
            }
        }
        public void BuscarP(Pessoa pessoa)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {


                var worksheet = workbook.Worksheet("Pessoa");
                // Acessa as células que contêm os valores de usuário e senha na planilha
                var cpf = worksheet.Cell("B2");
                var nome = worksheet.Cell("A2");
                var email = worksheet.Cell("C2");
                var telefone = worksheet.Cell("D2");
                // Lê os valores das células
                pessoa.cpf = Convert.ToDouble(cpf.Value.ToString());
                pessoa.nome = nome.Value.ToString();
                pessoa.email = email.Value.ToString();
                pessoa.telefone = Convert.ToDouble(telefone.Value.ToString());
            }
        }
    }
}