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
    public partial class V_funcionario1 : Form
    {
        Pessoa pessoa = new Pessoa();
        Endereço endereço = new Endereço();
        Funcionario funcionario = new Funcionario();
        Cargo cargo = new Cargo();
        Erro erro = new Erro();

        public V_funcionario1()
        {
            InitializeComponent();

        }





        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" || tb_cpf.Text == "" || tb_email.Text == "" || tb_telefone.Text == "" || tb_cep.Text == "" || tb_rua.Text == "" || tb_bairro.Text == "" || tb_cidade.Text == "" || tb_estado.Text == "" || tb_numero.Text == "" || tb_ad.Text == "" || tb_pix.Text == "" || tb_matricula.Text == "" || tb_status.Text == "")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pessoa.nome = tb_nome.Text;
                pessoa.cpf = Convert.ToDouble(tb_cpf.Text);
                pessoa.email = tb_email.Text;
                pessoa.telefone = Convert.ToDouble(tb_telefone.Text);

                endereço.CEP = Convert.ToDouble(tb_cep.Text);
                endereço.Rua = tb_rua.Text;
                endereço.Bairro = tb_bairro.Text;
                endereço.Cidade = tb_cidade.Text;
                endereço.Estado = tb_estado.Text;
                endereço.Numero = Convert.ToInt32(tb_numero.Text);

                funcionario.DataDeAdmissao = Convert.ToDouble(tb_ad.Text);
                funcionario.DadosBancarios = tb_pix.Text;
                funcionario.Matricula = Convert.ToInt32(tb_matricula.Text);
                funcionario.Status = tb_status.Text;

                cargo.Funcao = tb_cargo.Text;
                CTR_Funcionario c = new CTR_Funcionario();
                c.addFuncionario(pessoa, endereço, funcionario, cargo);

                MessageBox.Show("Cadastrado com sucesso", "CADASTRO CONCLUIDO", MessageBoxButtons.OK);


            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
