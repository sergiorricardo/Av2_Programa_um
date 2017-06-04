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
            this.dtGridaval = new System.Windows.Forms.DataGridView();
            this.btnEntendido = new System.Windows.Forms.Button();
            this.btnConfuso = new System.Windows.Forms.Button();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridaval)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridaval
            // 
            this.dtGridaval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridaval.Location = new System.Drawing.Point(29, 35);
            this.dtGridaval.Name = "dtGridaval";
            this.dtGridaval.Size = new System.Drawing.Size(618, 239);
            this.dtGridaval.TabIndex = 0;
            // 
            // btnEntendido
            // 
            this.btnEntendido.Location = new System.Drawing.Point(59, 280);
            this.btnEntendido.Name = "btnEntendido";
            this.btnEntendido.Size = new System.Drawing.Size(118, 23);
            this.btnEntendido.TabIndex = 1;
            this.btnEntendido.Text = "Entendi o conteúdo ";
            this.btnEntendido.UseVisualStyleBackColor = true;
            // 
            // btnConfuso
            // 
            this.btnConfuso.Location = new System.Drawing.Point(218, 280);
            this.btnConfuso.Name = "btnConfuso";
            this.btnConfuso.Size = new System.Drawing.Size(112, 23);
            this.btnConfuso.TabIndex = 2;
            this.btnConfuso.Text = "Conteúdo confuso ";
            this.btnConfuso.UseVisualStyleBackColor = true;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(420, 280);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(75, 23);
            this.btnSubmeter.TabIndex = 3;
            this.btnSubmeter.Text = "Enviar ";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(543, 280);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(134, 23);
            this.btnAvaliar.TabIndex = 4;
            this.btnAvaliar.Text = "Avaliação de conteúdo ";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 333);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.btnConfuso);
            this.Controls.Add(this.btnEntendido);
            this.Controls.Add(this.dtGridaval);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridaval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridaval;
        private System.Windows.Forms.Button btnEntendido;
        private System.Windows.Forms.Button btnConfuso;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Button btnAvaliar;
    }
}