using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim
{
    public partial class V_Funcionario : Form
    {
        public V_Funcionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            V_funcionario1 v_Funcionario1 = new V_funcionario1();
            v_Funcionario1.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            V_funcionario2 v_Funcionario2 = new V_funcionario2();

            v_Funcionario2.ShowDialog();


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            V_funcionario3 v_Funcionario3 = new V_funcionario3();

            v_Funcionario3.ShowDialog();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            V_funcionario4 v_Funcionario4 = new V_funcionario4();

            v_Funcionario4.ShowDialog();
        }
    }
}
