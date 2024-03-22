namespace Pim
{
    partial class V_enviar
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
            btn_enviar = new Button();
            tb_cpf = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(395, 7);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 78;
            label18.Text = "Ano";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(345, 7);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 77;
            label17.Text = "Mês";
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(383, 24);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(52, 23);
            tb_ano.TabIndex = 76;
            // 
            // tb_mes
            // 
            tb_mes.FormattingEnabled = true;
            tb_mes.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            tb_mes.Location = new Point(341, 25);
            tb_mes.Name = "tb_mes";
            tb_mes.Size = new Size(36, 23);
            tb_mes.TabIndex = 75;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(297, 32);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 74;
            label16.Text = "DATA:";
            // 
            // button1
            // 
            button1.Location = new Point(478, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 73;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(478, 24);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 72;
            btn_enviar.Text = "ENVIAR";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(146, 24);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(145, 23);
            tb_cpf.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 70;
            label1.Text = "CPF DO FUCIONARIO:";
            // 
            // V_enviar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 109);
            ControlBox = false;
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tb_ano);
            Controls.Add(tb_mes);
            Controls.Add(label16);
            Controls.Add(button1);
            Controls.Add(btn_enviar);
            Controls.Add(tb_cpf);
            Controls.Add(label1);
            Name = "V_enviar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enviar";
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
        private Button btn_enviar;
        private TextBox tb_cpf;
        private Label label1;
    }
}