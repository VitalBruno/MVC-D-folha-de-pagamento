namespace Pim
{
    partial class V_buscar
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
            label18 = new Label();
            label17 = new Label();
            tb_ano = new TextBox();
            tb_mes = new ComboBox();
            label16 = new Label();
            button1 = new Button();
            lb_data = new Label();
            label15 = new Label();
            btn_gerar = new Button();
            lb_liquido = new Label();
            label10 = new Label();
            lb_vt = new Label();
            label13 = new Label();
            lb_vr = new Label();
            label11 = new Label();
            lb_va = new Label();
            label9 = new Label();
            lb_fgts = new Label();
            label7 = new Label();
            lb_inss = new Label();
            label5 = new Label();
            lb_nome = new Label();
            label3 = new Label();
            tb_cpf = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(415, 26);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 69;
            label18.Text = "Ano";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(365, 26);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 68;
            label17.Text = "Mês";
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(403, 43);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(52, 23);
            tb_ano.TabIndex = 67;
            // 
            // tb_mes
            // 
            tb_mes.FormattingEnabled = true;
            tb_mes.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            tb_mes.Location = new Point(361, 44);
            tb_mes.Name = "tb_mes";
            tb_mes.Size = new Size(36, 23);
            tb_mes.TabIndex = 66;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(317, 51);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 65;
            label16.Text = "DATA:";
            // 
            // button1
            // 
            button1.Location = new Point(498, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 62;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_data
            // 
            lb_data.AutoSize = true;
            lb_data.Location = new Point(294, 317);
            lb_data.Margin = new Padding(30);
            lb_data.Name = "lb_data";
            lb_data.Size = new Size(40, 15);
            lb_data.TabIndex = 61;
            lb_data.Text = "\"data\"";
            lb_data.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(251, 317);
            label15.Margin = new Padding(30);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 60;
            label15.Text = "Data:";
            // 
            // btn_gerar
            // 
            btn_gerar.Location = new Point(498, 43);
            btn_gerar.Name = "btn_gerar";
            btn_gerar.Size = new Size(75, 23);
            btn_gerar.TabIndex = 55;
            btn_gerar.Text = "BUSCAR";
            btn_gerar.UseVisualStyleBackColor = true;
            btn_gerar.Click += btn_gerar_Click;
            // 
            // lb_liquido
            // 
            lb_liquido.AutoSize = true;
            lb_liquido.Location = new Point(294, 296);
            lb_liquido.Margin = new Padding(30);
            lb_liquido.Name = "lb_liquido";
            lb_liquido.Size = new Size(91, 15);
            lb_liquido.TabIndex = 54;
            lb_liquido.Text = "\"salario liquido\"";
            lb_liquido.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(203, 296);
            label10.Margin = new Padding(30);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 53;
            label10.Text = "Salario liquido:";
            // 
            // lb_vt
            // 
            lb_vt.AutoSize = true;
            lb_vt.Location = new Point(294, 269);
            lb_vt.Margin = new Padding(30);
            lb_vt.Name = "lb_vt";
            lb_vt.Size = new Size(30, 15);
            lb_vt.TabIndex = 50;
            lb_vt.Text = "\"VT\"";
            lb_vt.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(200, 269);
            label13.Margin = new Padding(30);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 49;
            label13.Text = "Vale transporte:";
            // 
            // lb_vr
            // 
            lb_vr.AutoSize = true;
            lb_vr.Location = new Point(294, 244);
            lb_vr.Margin = new Padding(30);
            lb_vr.Name = "lb_vr";
            lb_vr.Size = new Size(31, 15);
            lb_vr.TabIndex = 48;
            lb_vr.Text = "\"VR\"";
            lb_vr.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 244);
            label11.Margin = new Padding(30);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 47;
            label11.Text = "Vale refeição:";
            // 
            // lb_va
            // 
            lb_va.AutoSize = true;
            lb_va.Location = new Point(295, 221);
            lb_va.Margin = new Padding(30);
            lb_va.Name = "lb_va";
            lb_va.Size = new Size(31, 15);
            lb_va.TabIndex = 46;
            lb_va.Text = "\"VA\"";
            lb_va.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 221);
            label9.Margin = new Padding(30);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 45;
            label9.Text = "Vale alimentação:";
            // 
            // lb_fgts
            // 
            lb_fgts.AutoSize = true;
            lb_fgts.Location = new Point(295, 196);
            lb_fgts.Margin = new Padding(30);
            lb_fgts.Name = "lb_fgts";
            lb_fgts.Size = new Size(43, 15);
            lb_fgts.TabIndex = 44;
            lb_fgts.Text = "\"FGTS\"";
            lb_fgts.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 196);
            label7.Margin = new Padding(30);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 43;
            label7.Text = "FGTS:";
            // 
            // lb_inss
            // 
            lb_inss.AutoSize = true;
            lb_inss.Location = new Point(295, 171);
            lb_inss.Margin = new Padding(30);
            lb_inss.Name = "lb_inss";
            lb_inss.Size = new Size(41, 15);
            lb_inss.TabIndex = 42;
            lb_inss.Text = "\"INSS\"";
            lb_inss.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 171);
            label5.Margin = new Padding(30);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 41;
            label5.Text = "INSS:";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(290, 146);
            lb_nome.Margin = new Padding(30);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(48, 15);
            lb_nome.TabIndex = 40;
            lb_nome.Text = "\"nome\"";
            lb_nome.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 146);
            label3.Margin = new Padding(30);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 39;
            label3.Text = "Nome:";
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(166, 43);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(145, 23);
            tb_cpf.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 35;
            label1.Text = "CPF DO FUCIONARIO:";
            // 
            // V_buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 418);
            ControlBox = false;
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tb_ano);
            Controls.Add(tb_mes);
            Controls.Add(label16);
            Controls.Add(button1);
            Controls.Add(lb_data);
            Controls.Add(label15);
            Controls.Add(btn_gerar);
            Controls.Add(lb_liquido);
            Controls.Add(label10);
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
            Controls.Add(tb_cpf);
            Controls.Add(label1);
            Name = "V_buscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            Load += V_buscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Label label17;
        private TextBox tb_ano;
        private ComboBox tb_mes;
        private Label label16;
        private Button button1;
        private Label lb_data;
        private Label label15;
        private Button btn_gerar;
        private Label lb_liquido;
        private Label label10;
        private Label lb_vt;
        private Label label13;
        private Label lb_vr;
        private Label label11;
        private Label lb_va;
        private Label label9;
        private Label lb_fgts;
        private Label label7;
        private Label lb_inss;
        private Label label5;
        private Label lb_nome;
        private Label label3;
        private TextBox tb_cpf;
        private Label label1;
    }
}