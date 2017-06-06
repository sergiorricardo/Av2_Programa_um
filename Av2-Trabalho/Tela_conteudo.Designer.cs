namespace Av2_Trabalho
{
    partial class Tela_conteudo
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
            this.btnGerarNovo = new System.Windows.Forms.Button();
            this.btnGravarCont = new System.Windows.Forms.Button();
            this.btnAvanco = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lblqnt = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarNovo
            // 
            this.btnGerarNovo.Location = new System.Drawing.Point(21, 314);
            this.btnGerarNovo.Name = "btnGerarNovo";
            this.btnGerarNovo.Size = new System.Drawing.Size(144, 23);
            this.btnGerarNovo.TabIndex = 0;
            this.btnGerarNovo.Text = "Validar conteúdo reduzido ";
            this.btnGerarNovo.UseVisualStyleBackColor = true;
            this.btnGerarNovo.Click += new System.EventHandler(this.btnGerarNovo_Click);
            // 
            // btnGravarCont
            // 
            this.btnGravarCont.Location = new System.Drawing.Point(267, 313);
            this.btnGravarCont.Name = "btnGravarCont";
            this.btnGravarCont.Size = new System.Drawing.Size(110, 23);
            this.btnGravarCont.TabIndex = 1;
            this.btnGravarCont.Text = "Gravar conteúdo";
            this.btnGravarCont.UseVisualStyleBackColor = true;
            this.btnGravarCont.Visible = false;
            this.btnGravarCont.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnAvanco
            // 
            this.btnAvanco.Location = new System.Drawing.Point(461, 313);
            this.btnAvanco.Name = "btnAvanco";
            this.btnAvanco.Size = new System.Drawing.Size(86, 23);
            this.btnAvanco.TabIndex = 2;
            this.btnAvanco.Text = "Avançar";
            this.btnAvanco.UseVisualStyleBackColor = true;
            this.btnAvanco.Visible = false;
            this.btnAvanco.Click += new System.EventHandler(this.btnAvanco_Click);
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(21, 34);
            this.txtCont.Multiline = true;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(526, 261);
            this.txtCont.TabIndex = 3;
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Location = new System.Drawing.Point(132, 9);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(22, 13);
            this.lblqnt.TabIndex = 4;
            this.lblqnt.Text = "qnt";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(461, 9);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(0, 13);
            this.lblData2.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(21, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(95, 13);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.Text = "Poderá inserir até :";
            // 
            // Tela_conteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(663, 369);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblData2);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.btnAvanco);
            this.Controls.Add(this.btnGravarCont);
            this.Controls.Add(this.btnGerarNovo);
            this.Name = "Tela_conteudo";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarNovo;
        private System.Windows.Forms.Button btnGravarCont;
        private System.Windows.Forms.Button btnAvanco;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblMensagem;
    }
}