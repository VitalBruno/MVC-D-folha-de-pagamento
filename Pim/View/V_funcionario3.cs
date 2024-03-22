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
    public partial class V_funcionario3 : Form
    {
        Pessoa pessoa = new Pessoa();
        Endereço endereço = new Endereço();
        Funcionario funcionario = new Funcionario();
        Cargo cargo = new Cargo();
        Erro erro = new Erro();
        public V_funcionario3()
        {
            InitializeComponent();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                CTR_p.Buscar(pessoa, endereço, funcionario, cargo);
                preencher();
                tb_ad.Enabled = true;
                tb_bairro.Enabled = true;
                tb_cargo.Enabled = true;
                tb_cep.Enabled = true;
                tb_cidade.Enabled = true;
                tb_cpf.Enabled = true;
                tb_email.Enabled = true;
                tb_estado.Enabled = true;
                tb_matricula.Enabled = true;
                tb_nome.Enabled = true;
                tb_numero.Enabled = true;
                tb_pix.Enabled = true;
                tb_rua.Enabled = true;
                tb_status.Enabled = true;
                tb_telefone.Enabled = true;

            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btn_alterar_Click(object sender, EventArgs e)
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

                MessageBox.Show("Alterado com sucesso", "CADASTRO CONCLUIDO", MessageBoxButtons.OK);
                tb_ad.Enabled = false;
                tb_bairro.Enabled = false;
                tb_cargo.Enabled = false;
                tb_cep.Enabled = false;
                tb_cidade.Enabled = false;
                tb_cpf.Enabled = false;
                tb_email.Enabled = false;
                tb_estado.Enabled = false;
                tb_matricula.Enabled = false;
                tb_nome.Enabled = false;
                tb_numero.Enabled = false;
                tb_pix.Enabled = false;
                tb_rua.Enabled = false;
                tb_status.Enabled = false;
                tb_telefone.Enabled = false;


            }
        }
    }
}
