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
    public partial class V_Relatorios : Form
    {
        public V_Relatorios()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_historico V_historico = new V_historico();
            V_historico.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_total V_total = new V_total();
            V_total.ShowDialog();
        }
    }
}
