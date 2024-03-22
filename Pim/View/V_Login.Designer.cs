namespace Pim
{
    partial class V_Login
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
            label2 = new Label();
            tb_usuario = new TextBox();
            tb_senha = new TextBox();
            btn_logar = new Button();
            btn_registrar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 78);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "SENHA";
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(15, 43);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(269, 23);
            tb_usuario.TabIndex = 2;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(18, 96);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(266, 23);
            tb_senha.TabIndex = 3;
            // 
            // btn_logar
            // 
            btn_logar.Location = new Point(18, 141);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(269, 35);
            btn_logar.TabIndex = 4;
            btn_logar.Text = "LOGIN";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(18, 182);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(269, 37);
            btn_registrar.TabIndex = 5;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(18, 225);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(269, 37);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 284);
            ControlBox = false;
            Controls.Add(btn_cancelar);
            Controls.Add(btn_registrar);
            Controls.Add(btn_logar);
            Controls.Add(tb_senha);
            Controls.Add(tb_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += V_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_usuario;
        private TextBox tb_senha;
        private Button btn_logar;
        private Button btn_registrar;
        private Button btn_cancelar;
    }
}