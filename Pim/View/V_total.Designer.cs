namespace Pim
{
    partial class V_total
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
            lb_total = new Label();
            label8 = new Label();
            lb_fgts = new Label();
            label7 = new Label();
            lb_inss = new Label();
            label5 = new Label();
            lb_vt = new Label();
            label13 = new Label();
            lb_vr = new Label();
            label11 = new Label();
            lb_va = new Label();
            label9 = new Label();
            button1 = new Button();
            btn_buscar = new Button();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(145, 17);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 46;
            label18.Text = "Ano";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(95, 17);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 45;
            label17.Text = "Mês";
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(133, 34);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(52, 23);
            tb_ano.TabIndex = 44;
            // 
            // tb_mes
            // 
            tb_mes.FormattingEnabled = true;
            tb_mes.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            tb_mes.Location = new Point(91, 35);
            tb_mes.Name = "tb_mes";
            tb_mes.Size = new Size(36, 23);
            tb_mes.TabIndex = 43;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(47, 42);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 42;
            label16.Text = "DATA:";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(123, 77);
            lb_total.Margin = new Padding(30);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(73, 15);
            lb_total.TabIndex = 52;
            lb_total.Text = "\"gasto total\"";
            lb_total.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 77);
            label8.Margin = new Padding(30);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 51;
            label8.Text = "Gasto total:";
            // 
            // lb_fgts
            // 
            lb_fgts.AutoSize = true;
            lb_fgts.Location = new Point(121, 127);
            lb_fgts.Margin = new Padding(30);
            lb_fgts.Name = "lb_fgts";
            lb_fgts.Size = new Size(43, 15);
            lb_fgts.TabIndex = 50;
            lb_fgts.Text = "\"FGTS\"";
            lb_fgts.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 127);
            label7.Margin = new Padding(30);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 49;
            label7.Text = "FGTS:";
            // 
            // lb_inss
            // 
            lb_inss.AutoSize = true;
            lb_inss.Location = new Point(121, 102);
            lb_inss.Margin = new Padding(30);
            lb_inss.Name = "lb_inss";
            lb_inss.Size = new Size(41, 15);
            lb_inss.TabIndex = 48;
            lb_inss.Text = "\"INSS\"";
            lb_inss.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 102);
            label5.Margin = new Padding(30);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 47;
            label5.Text = "INSS:";
            // 
            // lb_vt
            // 
            lb_vt.AutoSize = true;
            lb_vt.Location = new Point(119, 200);
            lb_vt.Margin = new Padding(30);
            lb_vt.Name = "lb_vt";
            lb_vt.Size = new Size(30, 15);
            lb_vt.TabIndex = 58;
            lb_vt.Text = "\"VT\"";
            lb_vt.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 200);
            label13.Margin = new Padding(30);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 57;
            label13.Text = "Vale transporte:";
            // 
            // lb_vr
            // 
            lb_vr.AutoSize = true;
            lb_vr.Location = new Point(119, 175);
            lb_vr.Margin = new Padding(30);
            lb_vr.Name = "lb_vr";
            lb_vr.Size = new Size(31, 15);
            lb_vr.TabIndex = 56;
            lb_vr.Text = "\"VR\"";
            lb_vr.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 175);
            label11.Margin = new Padding(30);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 55;
            label11.Text = "Vale refeição:";
            // 
            // lb_va
            // 
            lb_va.AutoSize = true;
            lb_va.Location = new Point(120, 152);
            lb_va.Margin = new Padding(30);
            lb_va.Name = "lb_va";
            lb_va.Size = new Size(31, 15);
            lb_va.TabIndex = 54;
            lb_va.Text = "\"VA\"";
            lb_va.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 152);
            label9.Margin = new Padding(30);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 53;
            label9.Text = "Vale alimentação:";
            // 
            // button1
            // 
            button1.Location = new Point(225, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 98;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(225, 35);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 97;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // V_total
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 237);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btn_buscar);
            Controls.Add(lb_vt);
            Controls.Add(label13);
            Controls.Add(lb_vr);
            Controls.Add(label11);
            Controls.Add(lb_va);
            Controls.Add(label9);
            Controls.Add(lb_total);
            Controls.Add(label8);
            Controls.Add(lb_fgts);
            Controls.Add(label7);
            Controls.Add(lb_inss);
            Controls.Add(label5);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tb_ano);
            Controls.Add(tb_mes);
            Controls.Add(label16);
            Name = "V_total";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Label label17;
        private TextBox tb_ano;
        private ComboBox tb_mes;
        private Label label16;
        private Label lb_total;
        private Label label8;
        private Label lb_fgts;
        private Label label7;
        private Label lb_inss;
        private Label label5;
        private Label lb_vt;
        private Label label13;
        private Label lb_vr;
        private Label label11;
        private Label lb_va;
        private Label label9;
        private Button button1;
        private Button btn_buscar;
    }
}