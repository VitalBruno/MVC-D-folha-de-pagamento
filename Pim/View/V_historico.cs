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
    public partial class V_historico : Form
    {
        FolhaDePagamento folhaDePagamento = new FolhaDePagamento();
        Pessoa pessoa = new Pessoa();

        public V_historico()
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
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                CTR_FolhaDePagamento cTR_FolhaDePagamento = new CTR_FolhaDePagamento();
                cTR_FolhaDePagamento.buscar(folhaDePagamento);

                if (tb_ano.Text == Convert.ToString(folhaDePagamento.ano) && tb_mes.Text == Convert.ToString(folhaDePagamento.mes))
                {


                    CTR_Pessoa cTR_Pessoa = new CTR_Pessoa();
                    Pessoa p = CTR_p.Buscar(pessoa);
                    lb_nome.Text = p.nome;
                    lb_inss.Text = Convert.ToString(folhaDePagamento.INSS);
                    lb_fgts.Text = Convert.ToString(folhaDePagamento.FGTS);
                    lb_va.Text = Convert.ToString(folhaDePagamento.VA);
                    lb_vr.Text = Convert.ToString(folhaDePagamento.VR);
                    lb_vt.Text = Convert.ToString(folhaDePagamento.VT);
                    lb_liquido.Text = Convert.ToString(folhaDePagamento.SalarioLiquido);
                    lb_data.Text = Convert.ToString(folhaDePagamento.DataDeEmissao);


                    lb_nome.Visible = true;
                    lb_data.Visible = true;
                    lb_inss.Visible = true;
                    lb_fgts.Visible = true;
                    lb_vr.Visible = true;
                    lb_va.Visible = true;
                    lb_vt.Visible = true;

                    lb_liquido.Visible = true;

                }
                else { MessageBox.Show("SEM REGISTRO NESTA DATA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
