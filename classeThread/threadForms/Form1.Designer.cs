namespace threadForms
{
    partial class Form1
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnprincipal = new System.Windows.Forms.Button();
            this.btncontador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(13, 13);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(506, 136);
            this.lblresultado.TabIndex = 0;
            // 
            // btnprincipal
            // 
            this.btnprincipal.Location = new System.Drawing.Point(12, 260);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Size = new System.Drawing.Size(155, 76);
            this.btnprincipal.TabIndex = 1;
            this.btnprincipal.Text = "Principal";
            this.btnprincipal.UseVisualStyleBackColor = true;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // btncontador
            // 
            this.btncontador.Location = new System.Drawing.Point(384, 260);
            this.btncontador.Name = "btncontador";
            this.btncontador.Size = new System.Drawing.Size(155, 76);
            this.btncontador.TabIndex = 2;
            this.btncontador.Text = "Contador";
            this.btncontador.UseVisualStyleBackColor = true;
            this.btncontador.Click += new System.EventHandler(this.btncontador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 348);
            this.Controls.Add(this.btncontador);
            this.Controls.Add(this.btnprincipal);
            this.Controls.Add(this.lblresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnprincipal;
        private System.Windows.Forms.Button btncontador;
    }
}

