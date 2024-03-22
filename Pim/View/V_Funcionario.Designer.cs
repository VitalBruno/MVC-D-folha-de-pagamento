namespace Pim
{
    partial class V_Funcionario
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
            btn_cadastrar = new Button();
            btn_buscar = new Button();
            btn_alterar = new Button();
            btn_excluir = new Button();
            btn_sair = new Button();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(52, 60);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(101, 41);
            btn_cadastrar.TabIndex = 0;
            btn_cadastrar.Text = "CRIAR";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(52, 185);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(101, 41);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(52, 297);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(101, 41);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "ALTERAR";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(52, 426);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(101, 41);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "EXCLUIR";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(134, 505);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 4;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += button1_Click;
            // 
            // V_Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 540);
            ControlBox = false;
            Controls.Add(btn_sair);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_cadastrar);
            Name = "V_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionario";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cadastrar;
        private Button btn_buscar;
        private Button btn_alterar;
        private Button btn_excluir;
        private Button btn_sair;
    }
}