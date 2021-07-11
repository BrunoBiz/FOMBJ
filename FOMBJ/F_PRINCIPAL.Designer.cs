
namespace FOMBJ
{
    partial class F_PRINCIPAL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PRINCIPAL));
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.HoraData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(234, 40);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(412, 89);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "HH:mm:ss";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHorario.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial", 25F);
            this.lblData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblData.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData.Location = new System.Drawing.Point(190, 115);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(522, 39);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "xxxxxxx, 00 de xxxxxxxxx de 0000 ";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HoraData
            // 
            this.HoraData.Enabled = true;
            this.HoraData.Tick += new System.EventHandler(this.HoraData_Tick);
            // 
            // F_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHorario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_PRINCIPAL";
            this.Size = new System.Drawing.Size(802, 540);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_PRINCIPAL_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer HoraData;
    }
}
