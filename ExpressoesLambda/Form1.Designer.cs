namespace ExpressoesLambda
{
    partial class frmLambda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbTexto1 = new System.Windows.Forms.TextBox();
            this.txbTexto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConcatenacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto 1:";
            // 
            // txbTexto1
            // 
            this.txbTexto1.Location = new System.Drawing.Point(64, 6);
            this.txbTexto1.Name = "txbTexto1";
            this.txbTexto1.Size = new System.Drawing.Size(302, 20);
            this.txbTexto1.TabIndex = 1;
            // 
            // txbTexto2
            // 
            this.txbTexto2.Location = new System.Drawing.Point(64, 32);
            this.txbTexto2.Name = "txbTexto2";
            this.txbTexto2.Size = new System.Drawing.Size(302, 20);
            this.txbTexto2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto 2:";
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(15, 58);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(75, 23);
            this.btnConcatenar.TabIndex = 4;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Concatenação:";
            // 
            // lblConcatenacao
            // 
            this.lblConcatenacao.AutoSize = true;
            this.lblConcatenacao.Location = new System.Drawing.Point(182, 63);
            this.lblConcatenacao.Name = "lblConcatenacao";
            this.lblConcatenacao.Size = new System.Drawing.Size(10, 13);
            this.lblConcatenacao.TabIndex = 6;
            this.lblConcatenacao.Text = " ";
            // 
            // frmLambda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 91);
            this.Controls.Add(this.lblConcatenacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.txbTexto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTexto1);
            this.Controls.Add(this.label1);
            this.Name = "frmLambda";
            this.Text = "Lambda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTexto1;
        private System.Windows.Forms.TextBox txbTexto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConcatenacao;
    }
}

