namespace Av2_Trabalho
{
    partial class Tela_Escolha
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnProceguir = new System.Windows.Forms.Button();
            this.rdop1 = new System.Windows.Forms.RadioButton();
            this.rdop2 = new System.Windows.Forms.RadioButton();
            this.rdop3 = new System.Windows.Forms.RadioButton();
            this.rdop4 = new System.Windows.Forms.RadioButton();
            this.rdop5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(25, 267);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnProceguir
            // 
            this.btnProceguir.Location = new System.Drawing.Point(549, 267);
            this.btnProceguir.Name = "btnProceguir";
            this.btnProceguir.Size = new System.Drawing.Size(75, 23);
            this.btnProceguir.TabIndex = 1;
            this.btnProceguir.Text = "A diante";
            this.btnProceguir.UseVisualStyleBackColor = true;
            this.btnProceguir.Click += new System.EventHandler(this.btnProceguir_Click);
            // 
            // rdop1
            // 
            this.rdop1.AutoSize = true;
            this.rdop1.Location = new System.Drawing.Point(34, 13);
            this.rdop1.Name = "rdop1";
            this.rdop1.Size = new System.Drawing.Size(60, 17);
            this.rdop1.TabIndex = 2;
            this.rdop1.TabStop = true;
            this.rdop1.Text = "Nível 1";
            this.rdop1.UseVisualStyleBackColor = true;
            this.rdop1.CheckedChanged += new System.EventHandler(this.rdop1_CheckedChanged);
            // 
            // rdop2
            // 
            this.rdop2.AutoSize = true;
            this.rdop2.Location = new System.Drawing.Point(34, 55);
            this.rdop2.Name = "rdop2";
            this.rdop2.Size = new System.Drawing.Size(60, 17);
            this.rdop2.TabIndex = 3;
            this.rdop2.TabStop = true;
            this.rdop2.Text = "Nível 2";
            this.rdop2.UseVisualStyleBackColor = true;
            this.rdop2.CheckedChanged += new System.EventHandler(this.rdop2_CheckedChanged);
            // 
            // rdop3
            // 
            this.rdop3.AutoSize = true;
            this.rdop3.Location = new System.Drawing.Point(34, 105);
            this.rdop3.Name = "rdop3";
            this.rdop3.Size = new System.Drawing.Size(60, 17);
            this.rdop3.TabIndex = 4;
            this.rdop3.TabStop = true;
            this.rdop3.Text = "Nível 3";
            this.rdop3.UseVisualStyleBackColor = true;
            this.rdop3.CheckedChanged += new System.EventHandler(this.rdop3_CheckedChanged);
            // 
            // rdop4
            // 
            this.rdop4.AutoSize = true;
            this.rdop4.Location = new System.Drawing.Point(34, 160);
            this.rdop4.Name = "rdop4";
            this.rdop4.Size = new System.Drawing.Size(60, 17);
            this.rdop4.TabIndex = 5;
            this.rdop4.TabStop = true;
            this.rdop4.Text = "Nível 4";
            this.rdop4.UseVisualStyleBackColor = true;
            this.rdop4.CheckedChanged += new System.EventHandler(this.rdop4_CheckedChanged);
            // 
            // rdop5
            // 
            this.rdop5.AutoSize = true;
            this.rdop5.Location = new System.Drawing.Point(34, 205);
            this.rdop5.Name = "rdop5";
            this.rdop5.Size = new System.Drawing.Size(60, 17);
            this.rdop5.TabIndex = 6;
            this.rdop5.TabStop = true;
            this.rdop5.Text = "Nível 5";
            this.rdop5.UseVisualStyleBackColor = true;
            this.rdop5.CheckedChanged += new System.EventHandler(this.rdop5_CheckedChanged);
            // 
            // Tela_Escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 320);
            this.Controls.Add(this.rdop5);
            this.Controls.Add(this.rdop4);
            this.Controls.Add(this.rdop3);
            this.Controls.Add(this.rdop2);
            this.Controls.Add(this.rdop1);
            this.Controls.Add(this.btnProceguir);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Tela_Escolha";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnProceguir;
        private System.Windows.Forms.RadioButton rdop1;
        private System.Windows.Forms.RadioButton rdop2;
        private System.Windows.Forms.RadioButton rdop3;
        private System.Windows.Forms.RadioButton rdop4;
        private System.Windows.Forms.RadioButton rdop5;
    }
}