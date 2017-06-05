namespace Av2_Trabalho
{
    partial class Form4
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
            this.btnEntendido = new System.Windows.Forms.Button();
            this.btnConfuso = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.lblseguinte = new System.Windows.Forms.Label();
            this.lblDataTres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntendido
            // 
            this.btnEntendido.Location = new System.Drawing.Point(89, 280);
            this.btnEntendido.Name = "btnEntendido";
            this.btnEntendido.Size = new System.Drawing.Size(118, 23);
            this.btnEntendido.TabIndex = 1;
            this.btnEntendido.Text = "Entendi o conteúdo ";
            this.btnEntendido.UseVisualStyleBackColor = true;
            this.btnEntendido.Click += new System.EventHandler(this.btnEntendido_Click);
            // 
            // btnConfuso
            // 
            this.btnConfuso.Location = new System.Drawing.Point(285, 280);
            this.btnConfuso.Name = "btnConfuso";
            this.btnConfuso.Size = new System.Drawing.Size(112, 23);
            this.btnConfuso.TabIndex = 2;
            this.btnConfuso.Text = "Conteúdo confuso ";
            this.btnConfuso.UseVisualStyleBackColor = true;
            this.btnConfuso.Click += new System.EventHandler(this.btnConfuso_Click);
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(502, 280);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(134, 23);
            this.btnAvaliar.TabIndex = 4;
            this.btnAvaliar.Text = "Avaliação de conteúdo ";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Visible = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // lblseguinte
            // 
            this.lblseguinte.AutoSize = true;
            this.lblseguinte.Location = new System.Drawing.Point(28, 25);
            this.lblseguinte.Name = "lblseguinte";
            this.lblseguinte.Size = new System.Drawing.Size(31, 13);
            this.lblseguinte.TabIndex = 5;
            this.lblseguinte.Text = "........";
            // 
            // lblDataTres
            // 
            this.lblDataTres.AutoSize = true;
            this.lblDataTres.Location = new System.Drawing.Point(12, 252);
            this.lblDataTres.Name = "lblDataTres";
            this.lblDataTres.Size = new System.Drawing.Size(35, 13);
            this.lblDataTres.TabIndex = 6;
            this.lblDataTres.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 333);
            this.Controls.Add(this.lblDataTres);
            this.Controls.Add(this.lblseguinte);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btnConfuso);
            this.Controls.Add(this.btnEntendido);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntendido;
        private System.Windows.Forms.Button btnConfuso;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.Label lblseguinte;
        private System.Windows.Forms.Label lblDataTres;
    }
}