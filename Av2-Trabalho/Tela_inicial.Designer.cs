namespace Av2_Trabalho
{
    partial class Tela_inicial
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtArtigo = new System.Windows.Forms.TextBox();
            this.lblEstudante = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(202, 319);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(121, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gravar artigo";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtArtigo
            // 
            this.txtArtigo.Location = new System.Drawing.Point(12, 77);
            this.txtArtigo.Multiline = true;
            this.txtArtigo.Name = "txtArtigo";
            this.txtArtigo.Size = new System.Drawing.Size(613, 220);
            this.txtArtigo.TabIndex = 2;
            // 
            // lblEstudante
            // 
            this.lblEstudante.AutoSize = true;
            this.lblEstudante.Location = new System.Drawing.Point(144, 47);
            this.lblEstudante.Name = "lblEstudante";
            this.lblEstudante.Size = new System.Drawing.Size(340, 13);
            this.lblEstudante.TabIndex = 4;
            this.lblEstudante.Text = "Olá estudante vamos verificar se consegue explicar o que aprendeu ? ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(409, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(484, 17);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 8;
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(657, 354);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEstudante);
            this.Controls.Add(this.txtArtigo);
            this.Controls.Add(this.btnGerar);
            this.Name = "Tela_inicial";
            this.Text = "Tela Inicial ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtArtigo;
        private System.Windows.Forms.Label lblEstudante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblData;
    }
}

