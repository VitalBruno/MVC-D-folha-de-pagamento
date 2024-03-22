namespace Pim
{
    partial class V_calcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tb_cpf = new TextBox();
            tb_horas = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lb_nome = new Label();
            lb_inss = new Label();
            label5 = new Label();
            lb_fgts = new Label();
            label7 = new Label();
            lb_va = new Label();
            label9 = new Label();
            lb_vr = new Label();
            label11 = new Label();
            lb_vt = new Label();
            label13 = new Label();
            lb_bruto = new Label();
            label6 = new Label();
            lb_liquido = new Label();
            label10 = new Label();
            btn_gerar = new Button();
            lb_horas = new Label();
            label8 = new Label();
            tb_justificativa = new TextBox();
            label12 = new Label();
            lb_data = new Label();
            label15 = new Label();
            btn_salvar = new Button();
            button3 = new Button();
            label16 = new Label();
            tb_mes = new ComboBox();
            tb_ano = new TextBox();
            label17 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF DO FUCIONARIO:";
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(150, 27);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(145, 23);
            tb_cpf.TabIndex = 1;
            // 
            // tb_horas
            // 
            tb_horas.Location = new Point(150, 63);
            tb_horas.Name = "tb_horas";
            tb_horas.Size = new Size(145, 23);
            tb_horas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "HORAS TRABALHADAS:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 134);
            label3.Margin = new Padding(30);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(121, 134);
            lb_nome.Margin = new Padding(30);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(48, 15);
            lb_nome.TabIndex = 5;
            lb_nome.Text = "\"nome\"";
            lb_nome.Visible = false;
            // 
            // lb_inss
            // 
            lb_inss.AutoSize = true;
            lb_inss.Location = new Point(123, 183);
            lb_inss.Margin = new Padding(30);
            lb_inss.Name = "lb_inss";
            lb_inss.Size = new Size(41, 15);
            lb_inss.TabIndex = 7;
            lb_inss.Text = "\"INSS\"";
            lb_inss.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 183);
            label5.Margin = new Padding(30);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "INSS:";
            // 
            // lb_fgts
            // 
            lb_fgts.AutoSize = true;
            lb_fgts.Location = new Point(123, 208);
            lb_fgts.Margin = new Padding(30);
            lb_fgts.Name = "lb_fgts";
            lb_fgts.Size = new Size(43, 15);
            lb_fgts.TabIndex = 9;
            lb_fgts.Text = "\"FGTS\"";
            lb_fgts.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 208);
            label7.Margin = new Padding(30);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 8;
            label7.Text = "FGTS:";
            // 
            // lb_va
            // 
            lb_va.AutoSize = true;
            lb_va.Location = new Point(123, 233);
            lb_va.Margin = new Padding(30);
            lb_va.Name = "lb_va";
            lb_va.Size = new Size(31, 15);
            lb_va.TabIndex = 11;
            lb_va.Text = "\"VA\"";
            lb_va.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 233);
            label9.Margin = new Padding(30);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 10;
            label9.Text = "Vale alimentação:";
            // 
            // lb_vr
            // 
            lb_vr.AutoSize = true;
            lb_vr.Location = new Point(122, 256);
            lb_vr.Margin = new Padding(30);
            lb_vr.Name = "lb_vr";
            lb_vr.Size = new Size(31, 15);
            lb_vr.TabIndex = 13;
            lb_vr.Text = "\"VR\"";
            lb_vr.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 256);
            label11.Margin = new Padding(30);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 12;
            label11.Text = "Vale refeição:";
            // 
            // lb_vt
            // 
            lb_vt.AutoSize = true;
            lb_vt.Location = new Point(122, 281);
            lb_vt.Margin = new Padding(30);
            lb_vt.Name = "lb_vt";
            lb_vt.Size = new Size(30, 15);
            lb_vt.TabIndex = 15;
            lb_vt.Text = "\"VT\"";
            lb_vt.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 281);
            label13.Margin = new Padding(30);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 14;
            label13.Text = "Vale transporte:";
            // 
            // lb_bruto
            // 
            lb_bruto.AutoSize = true;
            lb_bruto.Location = new Point(123, 305);
            lb_bruto.Margin = new Padding(30);
            lb_bruto.Name = "lb_bruto";
            lb_bruto.Size = new Size(83, 15);
            lb_bruto.TabIndex = 17;
            lb_bruto.Text = "\"salario bruto\"";
            lb_bruto.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 305);
            label6.Margin = new Padding(30);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 16;
            label6.Text = "Salario bruto:";
            // 
            // lb_liquido
            // 
            lb_liquido.AutoSize = true;
            lb_liquido.Location = new Point(123, 331);
            lb_liquido.Margin = new Padding(30);
            lb_liquido.Name = "lb_liquido";
            lb_liquido.Size = new Size(91, 15);
            lb_liquido.TabIndex = 19;
            lb_liquido.Text = "\"salario liquido\"";
            lb_liquido.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 331);
            label10.Margin = new Padding(30);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 18;
            label10.Text = "Salario liquido:";
            // 
            // btn_gerar
            // 
            btn_gerar.Location = new Point(482, 27);
            btn_gerar.Name = "btn_gerar";
            btn_gerar.Size = new Size(75, 23);
            btn_gerar.TabIndex = 20;
            btn_gerar.Text = "GERAR";
            btn_gerar.UseVisualStyleBackColor = true;
            btn_gerar.Click += btn_gerar_Click;
            // 
            // lb_horas
            // 
            lb_horas.AutoSize = true;
            lb_horas.Location = new Point(125, 158);
            lb_horas.Margin = new Padding(30);
            lb_horas.Name = "lb_horas";
            lb_horas.Size = new Size(46, 15);
            lb_horas.TabIndex = 22;
            lb_horas.Text = "\"horas\"";
            lb_horas.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 158);
            label8.Margin = new Padding(30);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 21;
            label8.Text = "Horas trabalhadas:";
            // 
            // tb_justificativa
            // 
            tb_justificativa.Location = new Point(150, 95);
            tb_justificativa.Name = "tb_justificativa";
            tb_justificativa.Size = new Size(310, 23);
            tb_justificativa.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 103);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 23;
            label12.Text = "JUSTIFICATIVA:";
            // 
            // lb_data
            // 
            lb_data.AutoSize = true;
            lb_data.Location = new Point(123, 352);
            lb_data.Margin = new Padding(30);
            lb_data.Name = "lb_data";
            lb_data.Size = new Size(40, 15);
            lb_data.TabIndex = 26;
            lb_data.Text = "\"data\"";
            lb_data.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(80, 352);
            label15.Margin = new Padding(30);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 25;
            label15.Text = "Data:";
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(482, 63);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 27;
            btn_salvar.Text = "SALVAR";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(482, 134);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "SAIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(301, 35);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 30;
            label16.Text = "DATA:";
            // 
            // tb_mes
            // 
            tb_mes.FormattingEnabled = true;
            tb_mes.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            tb_mes.Location = new Point(345, 28);
            tb_mes.Name = "tb_mes";
            tb_mes.Size = new Size(36, 23);
            tb_mes.TabIndex = 31;
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(387, 27);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(52, 23);
            tb_ano.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(349, 10);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 33;
            label17.Text = "Mês";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(399, 10);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 34;
            label18.Text = "Ano";
            // 
            // V_calcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 409);
            ControlBox = false;
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tb_ano);
            Controls.Add(tb_mes);
            Controls.Add(label16);
            Controls.Add(button3);
            Controls.Add(btn_salvar);
            Controls.Add(lb_data);
            Controls.Add(label15);
            Controls.Add(tb_justificativa);
            Controls.Add(label12);
            Controls.Add(lb_horas);
            Controls.Add(label8);
            Controls.Add(btn_gerar);
            Controls.Add(lb_liquido);
            Controls.Add(label10);
            Controls.Add(lb_bruto);
            Controls.Add(label6);
            Controls.Add(lb_vt);
            Controls.Add(label13);
            Controls.Add(lb_vr);
            Controls.Add(label11);
            Controls.Add(lb_va);
            Controls.Add(label9);
            Controls.Add(lb_fgts);
            Controls.Add(label7);
            Controls.Add(lb_inss);
            Controls.Add(label5);
            Controls.Add(lb_nome);
            Controls.Add(label3);
            Controls.Add(tb_horas);
            Controls.Add(label2);
            Controls.Add(tb_cpf);
            Controls.Add(label1);
            Name = "V_calcular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_cpf;
        private TextBox tb_horas;
        private Label label2;
        private Label label3;
        private Label lb_nome;
        private Label lb_inss;
        private Label label5;
        private Label lb_fgts;
        private Label label7;
        private Label lb_va;
        private Label label9;
        private Label lb_vr;
        private Label label11;
        private Label lb_vt;
        private Label label13;
        private Label lb_bruto;
        private Label label6;
        private Label lb_liquido;
        private Label label10;
        private Button btn_gerar;
        private Label lb_horas;
        private Label label8;
        private TextBox tb_justificativa;
        private Label label12;
        private Label lb_data;
        private Label label15;
        private Button btn_salvar;
        private Button button3;
        private Label label16;
        private ComboBox tb_mes;
        private TextBox tb_ano;
        private Label label17;
        private Label label18;
    }
}