namespace Pim
{
    partial class V_FolhaDePagamento
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 21);
            button1.Name = "button1";
            button1.Size = new Size(164, 65);
            button1.TabIndex = 0;
            button1.Text = "CALCULAR ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 114);
            button2.Name = "button2";
            button2.Size = new Size(164, 65);
            button2.TabIndex = 1;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(71, 211);
            button3.Name = "button3";
            button3.Size = new Size(164, 65);
            button3.TabIndex = 2;
            button3.Text = "ENVIAR ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(71, 311);
            button4.Name = "button4";
            button4.Size = new Size(164, 65);
            button4.TabIndex = 3;
            button4.Text = "REALIZAR PAGAMENTO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(71, 407);
            button5.Name = "button5";
            button5.Size = new Size(164, 65);
            button5.TabIndex = 4;
            button5.Text = "SAIR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // V_FolhaDePagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 494);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "V_FolhaDePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha de pagamento";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}