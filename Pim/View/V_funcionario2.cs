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
    public partial class V_funcionario2 : Form
    {
        Pessoa pessoa = new Pessoa();
        Endereço endereço = new Endereço();
        Funcionario funcionario = new Funcionario();
        Cargo cargo = new Cargo();
        Erro erro = new Erro();
        public V_funcionario2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                CTR_p.Buscar(pessoa, endereço, funcionario, cargo);
                preencher();




            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void preencher()
        {
            tb_nome.Text = pessoa.nome;
            tb_cpf.Text = Convert.ToString(pessoa.cpf);
            tb_email.Text = pessoa.email;
            tb_telefone.Text = Convert.ToString(pessoa.telefone);

            tb_cep.Text = Convert.ToString(endereço.CEP);
            tb_rua.Text = endereço.Rua;
            tb_bairro.Text = endereço.Bairro;
            tb_cidade.Text = endereço.Cidade;
            tb_estado.Text = endereço.Estado;
            tb_numero.Text = Convert.ToString(endereço.Numero);

            tb_ad.Text = Convert.ToString(funcionario.DataDeAdmissao);
            tb_pix.Text = funcionario.DadosBancarios;
            tb_matricula.Text = Convert.ToString(funcionario.Matricula);
            tb_status.Text = funcionario.Status;

            tb_cargo.Text = cargo.Funcao;
        }
    }
}
