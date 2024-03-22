using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Pim.DAO;
using Pim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.CTR
{
    internal class CTR_Login
    {
        Login login = new Login();
        Erro erro = new Erro();
        public CTR_Login()
        {

        }
        public void RegistrarUS(Login login)
        {
            DAO_Login d = new DAO_Login();
            d.RegistrarBD(login);


        }
        public Erro Validar(Login login)
        {
            DAO_Login d = new DAO_Login();
            d.validar(login);

            if (login.usuario == login.usuario1 && login.senha == login.senha1)
            {
                erro.erro = false;
                return erro;// Usuário e senha correspondem
            }
            else
            {
                erro.erro = true;
                return erro;// Usuário e senha não correspondem
            }

        }

    }

}





