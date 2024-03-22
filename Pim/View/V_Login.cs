using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pim.CTR;
using Pim.Model;

namespace Pim
{
    public partial class V_Login : Form
    {
        Login login = new Login();
        Erro Erro = new Erro();
        public V_Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            login.usuario = tb_usuario.Text;
            login.senha = tb_senha.Text;
            CTR_Login ctr_login = new CTR_Login();
            Erro erro=ctr_login.Validar(login);
            if (erro.erro == false)
            {
                this.Close();
                MessageBox.Show("Bom trabalho " + login.usuario, "BEM-VINDO");
            }
            else
            {

                MessageBox.Show("USUARIO/SENHA ERRADA", "Credencial invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ;
            }

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            if (tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                login.usuario = tb_usuario.Text;
                login.senha = tb_senha.Text;
                CTR_Login ctr_login = new CTR_Login();

                ctr_login.RegistrarUS(login);
                MessageBox.Show("Cadastrado com sucesso", "OK", MessageBoxButtons.OK);
            }

        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
