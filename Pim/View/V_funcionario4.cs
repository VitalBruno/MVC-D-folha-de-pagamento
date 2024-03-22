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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pim
{
    public partial class V_funcionario4 : Form
    {
        public V_funcionario4()
        {
            InitializeComponent();
        }
        Pessoa pessoa = new Pessoa();
        Endereço endereço = new Endereço();
        Funcionario funcionario = new Funcionario();
        Cargo cargo = new Cargo();
        Erro erro = new Erro();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                CTR_p.Buscar(pessoa, endereço, funcionario, cargo);


                MessageBox.Show("Funcionario exlcuido", "Excluido", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

