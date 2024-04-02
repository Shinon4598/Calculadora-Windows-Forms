namespace Calculadora
{
    partial class FrmInico
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnContinuar = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 190);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora hecha por:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 205);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 1;
            label2.Text = "No segui ningun tutorial así que el código ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 220);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 2;
            label3.Text = "no esta muy bien estructurado.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 253);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 3;
            label4.Text = " Pero funciona ╰(*°▽°*)╯ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 60);
            label5.Name = "label5";
            label5.Size = new Size(266, 42);
            label5.TabIndex = 4;
            label5.Text = "CALCULADORA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 102);
            label6.Name = "label6";
            label6.Size = new Size(275, 42);
            label6.TabIndex = 5;
            label6.Text = "BIEN ARGENTO";
            label6.Click += label6_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(50, 293);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(266, 29);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continuar...";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(202, 191);
            label7.Name = "label7";
            label7.Size = new Size(82, 14);
            label7.TabIndex = 7;
            label7.Text = "Shinon4598";
            // 
            // FrmInico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 359);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(btnContinuar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInico";
            Text = "Calculadora";
            Load += FrmInico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnContinuar;
        private Label label7;
    }
}