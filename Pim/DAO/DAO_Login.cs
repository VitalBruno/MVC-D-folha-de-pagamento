using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.Logging;
using Pim.Model;

namespace Pim.DAO
{
    internal class DAO_Login
    {
        Login login = new Login();
        public DAO_Login()
        {


        }


        public void RegistrarBD(Login login)
        {
            string c = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";
            using (var workbook = new XLWorkbook(c))
            {

                var worksheet = workbook.Worksheet("Planilha1");
                worksheet.Cell("A2").Value = login.usuario;
                worksheet.Cell("B2").Value = login.senha;
                workbook.Save();

            }

        }

        public void validar(Login login)
        {
            string caminhoArquivo = @"C:\Users\Bruno\Documents\Certificados\TESTE.xlsx";

            using (var workbook = new XLWorkbook(caminhoArquivo))
            {
                var worksheet = workbook.Worksheet("Planilha1");

                // Acessa as células que contêm os valores de usuário e senha na planilha
                var cellUsuario = worksheet.Cell("A2");
                var cellSenha = worksheet.Cell("B2");

                // Lê os valores das células
                login.usuario1 = cellUsuario.Value.ToString();
                login.senha1 = cellSenha.Value.ToString();



            }




        }

    }
}

