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
    public partial class V_total : Form
    {
        Pessoa pessoa = new Pessoa();
        FolhaDePagamento folhaDePagamento = new FolhaDePagamento();
        public V_total()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);


            CTR_FolhaDePagamento cTR_FolhaDePagamento = new CTR_FolhaDePagamento();
            cTR_FolhaDePagamento.buscar(folhaDePagamento);

            if (tb_ano.Text == Convert.ToString(folhaDePagamento.ano) && tb_mes.Text == Convert.ToString(folhaDePagamento.mes))
            { 
             
                FolhaDePagamento g = cTR_FolhaDePagamento.gasto(folhaDePagamento);
                lb_inss.Text = Convert.ToString(folhaDePagamento.INSS);
                lb_fgts.Text = Convert.ToString(folhaDePagamento.FGTS);
                lb_va.Text = Convert.ToString(folhaDePagamento.VA);
                lb_vr.Text = Convert.ToString(folhaDePagamento.VR);
                lb_vt.Text = Convert.ToString(folhaDePagamento.VT);
                lb_total.Text = Convert.ToString(g.gastototal);




                lb_inss.Visible = true;
                lb_fgts.Visible = true;
                lb_vr.Visible = true;
                lb_va.Visible = true;
                lb_vt.Visible = true;
                lb_total.Visible = true;


            }
            else { MessageBox.Show("DATA NAO ENCONTRADA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



    }
}

