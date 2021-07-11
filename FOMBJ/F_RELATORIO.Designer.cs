
namespace FOMBJ
{
    partial class F_RELATORIO
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblRelatorio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRelatorio.Location = new System.Drawing.Point(38, 38);
            this.lblRelatorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(475, 119);
            this.lblRelatorio.TabIndex = 1;
            this.lblRelatorio.Text = "Relatorio";
            // 
            // F_RELATORIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRelatorio);
            this.Name = "F_RELATORIO";
            this.Size = new System.Drawing.Size(1070, 658);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorio;
    }
}
