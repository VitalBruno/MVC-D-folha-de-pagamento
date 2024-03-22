﻿using System;
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
    public partial class V_realizar : Form
    {
        Pessoa pessoa = new Pessoa();
        public V_realizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {
            CTR_Pessoa CTR_p = new CTR_Pessoa();
            CTR_p.verificar(pessoa);
            if (pessoa.cpf == Convert.ToDouble(tb_cpf.Text))
                if (tb_cpf.Text != "" && tb_mes.Text != "" && tb_ano.Text != "" && tb_mes1.Text != "" && tb_ano1.Text != "" && tb__dia.Text != "")
                {

                    Pessoa p = CTR_p.Buscar(pessoa);
                    MessageBox.Show("Pagamento será realizado dia " + tb__dia.Text + "/" + tb_mes1.Text + "/" + tb_ano1.Text, "OK", MessageBoxButtons.OK);
                }
                else { MessageBox.Show("DIGITE O MES E O ANO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { MessageBox.Show("FUNCIONARIO NAO ENCONTRADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}


