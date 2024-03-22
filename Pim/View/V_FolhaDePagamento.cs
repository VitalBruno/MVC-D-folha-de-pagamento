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
    public partial class V_FolhaDePagamento : Form
    {
        public V_FolhaDePagamento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_calcular v_calcular = new V_calcular();

            v_calcular.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_buscar v_buscar = new V_buscar();

            v_buscar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            V_enviar v_enviar = new V_enviar();

            v_enviar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            V_realizar v_realizar = new V_realizar();

            v_realizar.ShowDialog();
        }
    }
}
