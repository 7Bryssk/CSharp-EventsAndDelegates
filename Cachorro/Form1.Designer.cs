﻿namespace Cachorro
{
    partial class frmLatidoCachorro
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
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgbItensidadeLatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(12, 12);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(75, 23);
            this.btnLatir.TabIndex = 0;
            this.btnLatir.Text = "Latir";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgbItensidadeLatido
            // 
            this.pgbItensidadeLatido.Location = new System.Drawing.Point(12, 42);
            this.pgbItensidadeLatido.Name = "pgbItensidadeLatido";
            this.pgbItensidadeLatido.Size = new System.Drawing.Size(261, 23);
            this.pgbItensidadeLatido.TabIndex = 1;
            // 
            // frmLatidoCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 77);
            this.Controls.Add(this.pgbItensidadeLatido);
            this.Controls.Add(this.btnLatir);
            this.Name = "frmLatidoCachorro";
            this.Text = "Latido Cahorro";
            this.Load += new System.EventHandler(this.frmLatidoCachorro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgbItensidadeLatido;
    }
}

