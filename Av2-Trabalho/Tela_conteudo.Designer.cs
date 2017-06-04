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
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lblqnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarNovo
            // 
            this.btnGerarNovo.Location = new System.Drawing.Point(21, 314);
            this.btnGerarNovo.Name = "btnGerarNovo";
            this.btnGerarNovo.Size = new System.Drawing.Size(144, 23);
            this.btnGerarNovo.TabIndex = 0;
            this.btnGerarNovo.Text = "Gerar conteúdo reduzido ";
            this.btnGerarNovo.UseVisualStyleBackColor = true;
            this.btnGerarNovo.Click += new System.EventHandler(this.btnGerarNovo_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(267, 313);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(110, 23);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(461, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.lblqnt.Location = new System.Drawing.Point(264, 9);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(22, 13);
            this.lblqnt.TabIndex = 4;
            this.lblqnt.Text = "qnt";
            // 
            // Tela_conteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 369);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnGerarNovo);
            this.Name = "Tela_conteudo";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarNovo;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lblqnt;
    }
}