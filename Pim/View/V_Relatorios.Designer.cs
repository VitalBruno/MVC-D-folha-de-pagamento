namespace Pim
{
    partial class V_Relatorios
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
            btn_sair = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(74, 228);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(164, 65);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // button2
            // 
            button2.Location = new Point(74, 131);
            button2.Name = "button2";
            button2.Size = new Size(164, 65);
            button2.TabIndex = 4;
            button2.Text = "GASTO TOTAL FOLHA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(74, 38);
            button1.Name = "button1";
            button1.Size = new Size(164, 65);
            button1.TabIndex = 3;
            button1.Text = "HISTORICO DE FOLHA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // V_Relatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 362);
            ControlBox = false;
            Controls.Add(btn_sair);
            Controls.Add(button2);
            Controls.Add(button1);
            Cursor = Cursors.Arrow;
            Name = "V_Relatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorios";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_sair;
        private Button button2;
        private Button button1;
    }
}