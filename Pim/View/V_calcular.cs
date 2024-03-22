using Pim.CTR;
using Pim.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pim
{
    public partial class V_calcular : Form
    {
        FolhaDePagamento folhaDePagamento = new FolhaDePagamento();
        ControleDePonto controledeponto = new ControleDePonto();
        Funcionario funcionario = new Funcionario();
        Pessoa pessoa = new Pessoa();
        Endereço endereço = new Endereço();
        Cargo cargo = new Cargo();


        public V_calcular()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                if (tb_horas.Text != "" && tb_ano.Text != "" && tb_mes.Text != "")
                {
                    controledeponto.HorasTrabalhadas = Convert.ToDouble(tb_horas.Text);
                    controledeponto.justificativa = tb_justificativa.Text;

                    CTR_p.Buscar(pessoa, endereço, funcionario, cargo);
                    CTR_Taxas CTR_t = new CTR_Taxas();
                    CTR_ControleDePonto CTR_c = new CTR_ControleDePonto();
                    Taxas t = CTR_t.fazercalculo(funcionario);
                    ControleDePonto p = CTR_c.CalcularSalario(cargo, controledeponto);
                    CTR_Cargo cTR_Cargo = new CTR_Cargo();
                    Cargo c = cTR_Cargo.buscar(cargo);
                    CTR_FolhaDePagamento ctR_FolhaDePagamento = new CTR_FolhaDePagamento();
                    FolhaDePagamento f = ctR_FolhaDePagamento.calcular(folhaDePagamento, t, p);
                    lb_nome.Text = pessoa.nome;
                    lb_horas.Text = Convert.ToString(controledeponto.HorasTrabalhadas);
                    lb_inss.Text = Convert.ToString(t.INSS);
                    lb_fgts.Text = Convert.ToString(t.FGTS);
                    lb_vr.Text = Convert.ToString(t.VR);
                    lb_va.Text = Convert.ToString(t.VA);
                    lb_vt.Text = Convert.ToString(t.VT);
                    lb_bruto.Text = Convert.ToString(c.SalarioBruto);
                    lb_liquido.Text = Convert.ToString(Math.Round(f.SalarioLiquido, 2));

                    lb_data.Text = Convert.ToString(System.DateTime.Today);

                    lb_nome.Visible = true;
                    lb_horas.Visible = true;
                    lb_inss.Visible = true;
                    lb_fgts.Visible = true;
                    lb_vr.Visible = true;
                    lb_va.Visible = true;
                    lb_vt.Visible = true;
                    lb_bruto.Visible = true;
                    lb_liquido.Visible = true;
                    lb_data.Visible = true;
                }
                else { MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
            {
                if (tb_horas.Text != "" && tb_ano.Text != "" && tb_mes.Text != "")
                {
                    folhaDePagamento.INSS = Convert.ToDouble(lb_inss.Text);
                    folhaDePagamento.FGTS = Convert.ToDouble(lb_fgts.Text);
                    folhaDePagamento.VA = Convert.ToDouble(lb_va.Text);
                    folhaDePagamento.VR = Convert.ToDouble(lb_vr.Text);
                    folhaDePagamento.VT = Convert.ToDouble(lb_vt.Text);
                    folhaDePagamento.SalarioLiquido = Convert.ToDouble(lb_liquido.Text);
                    folhaDePagamento.DataDeEmissao = System.DateTime.Today;
                    folhaDePagamento.mes = Convert.ToDouble(tb_mes.Text);
                    folhaDePagamento.ano = Convert.ToDouble(tb_ano.Text);



                    CTR_FolhaDePagamento cTR_FolhaDePagamento = new CTR_FolhaDePagamento();
                    cTR_FolhaDePagamento.salvar(folhaDePagamento);
                    MessageBox.Show("SALVO COM SUCESSO", "SALVO", MessageBoxButtons.OK);
                    lb_nome.Visible = false;
                    lb_horas.Visible = false;
                    lb_inss.Visible = false;
                    lb_fgts.Visible = false;
                    lb_vr.Visible = false;
                    lb_va.Visible = false;
                    lb_vt.Visible = false;
                    lb_bruto.Visible = false;
                    lb_liquido.Visible = false;
                    lb_data.Visible = false;
                }
                else { MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

