
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
            this.OptPendenteDespacho = new System.Windows.Forms.RadioButton();
            this.OptDespachado = new System.Windows.Forms.RadioButton();
            this.LblStatus = new System.Windows.Forms.Label();
            this.GrpDimensoes = new System.Windows.Forms.GroupBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblDtDespacho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDtDespachoInicial = new System.Windows.Forms.MaskedTextBox();
            this.TxtDtDespachoFinal = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDtCadastroFinal = new System.Windows.Forms.MaskedTextBox();
            this.TxtDtCadastroInicial = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDtPreviaFinal = new System.Windows.Forms.MaskedTextBox();
            this.TxtDtPreviaInicial = new System.Windows.Forms.MaskedTextBox();
            this.LblPrevia = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.ChkApenasAtrasados = new System.Windows.Forms.CheckBox();
            this.GrpDimensoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptPendenteDespacho
            // 
            this.OptPendenteDespacho.AutoSize = true;
            this.OptPendenteDespacho.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.OptPendenteDespacho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OptPendenteDespacho.Location = new System.Drawing.Point(409, 15);
            this.OptPendenteDespacho.Name = "OptPendenteDespacho";
            this.OptPendenteDespacho.Size = new System.Drawing.Size(228, 26);
            this.OptPendenteDespacho.TabIndex = 11;
            this.OptPendenteDespacho.Text = "Pendente de Despacho";
            this.OptPendenteDespacho.UseVisualStyleBackColor = true;
            this.OptPendenteDespacho.CheckedChanged += new System.EventHandler(this.OptPendenteDespacho_CheckedChanged_1);
            // 
            // OptDespachado
            // 
            this.OptDespachado.AutoSize = true;
            this.OptDespachado.Checked = true;
            this.OptDespachado.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.OptDespachado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OptDespachado.Location = new System.Drawing.Point(209, 15);
            this.OptDespachado.Name = "OptDespachado";
            this.OptDespachado.Size = new System.Drawing.Size(198, 26);
            this.OptDespachado.TabIndex = 12;
            this.OptDespachado.TabStop = true;
            this.OptDespachado.Text = "Despacho Efetuado";
            this.OptDespachado.UseVisualStyleBackColor = true;
            this.OptDespachado.CheckedChanged += new System.EventHandler(this.OptDespachado_CheckedChanged_1);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblStatus.Location = new System.Drawing.Point(3, 17);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(200, 22);
            this.LblStatus.TabIndex = 13;
            this.LblStatus.Text = "Status do Despacho:";
            // 
            // GrpDimensoes
            // 
            this.GrpDimensoes.Controls.Add(this.TxtPlaca);
            this.GrpDimensoes.Controls.Add(this.LblPlaca);
            this.GrpDimensoes.Controls.Add(this.LblDtDespacho);
            this.GrpDimensoes.Controls.Add(this.label2);
            this.GrpDimensoes.Controls.Add(this.TxtDtDespachoInicial);
            this.GrpDimensoes.Controls.Add(this.TxtDtDespachoFinal);
            this.GrpDimensoes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDimensoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GrpDimensoes.Location = new System.Drawing.Point(10, 47);
            this.GrpDimensoes.Name = "GrpDimensoes";
            this.GrpDimensoes.Size = new System.Drawing.Size(789, 89);
            this.GrpDimensoes.TabIndex = 26;
            this.GrpDimensoes.TabStop = false;
            this.GrpDimensoes.Text = "Despacho";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPlaca.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtPlaca.Location = new System.Drawing.Point(292, 54);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(142, 28);
            this.TxtPlaca.TabIndex = 31;
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPlaca.Location = new System.Drawing.Point(6, 57);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(171, 19);
            this.LblPlaca.TabIndex = 32;
            this.LblPlaca.Text = "Placa do Caminhão:";
            // 
            // LblDtDespacho
            // 
            this.LblDtDespacho.AutoSize = true;
            this.LblDtDespacho.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtDespacho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblDtDespacho.Location = new System.Drawing.Point(6, 26);
            this.LblDtDespacho.Name = "LblDtDespacho";
            this.LblDtDespacho.Size = new System.Drawing.Size(162, 19);
            this.LblDtDespacho.TabIndex = 28;
            this.LblDtDespacho.Text = "Data de Despacho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(398, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "até";
            // 
            // TxtDtDespachoInicial
            // 
            this.TxtDtDespachoInicial.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtDespachoInicial.Location = new System.Drawing.Point(292, 20);
            this.TxtDtDespachoInicial.Mask = "00/00/0000";
            this.TxtDtDespachoInicial.Name = "TxtDtDespachoInicial";
            this.TxtDtDespachoInicial.Size = new System.Drawing.Size(100, 28);
            this.TxtDtDespachoInicial.TabIndex = 27;
            this.TxtDtDespachoInicial.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDtDespachoFinal
            // 
            this.TxtDtDespachoFinal.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtDespachoFinal.Location = new System.Drawing.Point(444, 20);
            this.TxtDtDespachoFinal.Mask = "00/00/0000";
            this.TxtDtDespachoFinal.Name = "TxtDtDespachoFinal";
            this.TxtDtDespachoFinal.Size = new System.Drawing.Size(100, 28);
            this.TxtDtDespachoFinal.TabIndex = 29;
            this.TxtDtDespachoFinal.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkApenasAtrasados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtDtCadastroFinal);
            this.groupBox1.Controls.Add(this.TxtDtCadastroInicial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtDtPreviaFinal);
            this.groupBox1.Controls.Add(this.TxtDtPreviaInicial);
            this.groupBox1.Controls.Add(this.LblPrevia);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(10, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 124);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mercadorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(398, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "até";
            // 
            // TxtDtCadastroFinal
            // 
            this.TxtDtCadastroFinal.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtCadastroFinal.Location = new System.Drawing.Point(444, 57);
            this.TxtDtCadastroFinal.Mask = "00/00/0000";
            this.TxtDtCadastroFinal.Name = "TxtDtCadastroFinal";
            this.TxtDtCadastroFinal.Size = new System.Drawing.Size(100, 28);
            this.TxtDtCadastroFinal.TabIndex = 32;
            this.TxtDtCadastroFinal.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDtCadastroInicial
            // 
            this.TxtDtCadastroInicial.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtCadastroInicial.Location = new System.Drawing.Point(292, 57);
            this.TxtDtCadastroInicial.Mask = "00/00/0000";
            this.TxtDtCadastroInicial.Name = "TxtDtCadastroInicial";
            this.TxtDtCadastroInicial.Size = new System.Drawing.Size(100, 28);
            this.TxtDtCadastroInicial.TabIndex = 30;
            this.TxtDtCadastroInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Data de Chegada/Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(398, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "até";
            // 
            // TxtDtPreviaFinal
            // 
            this.TxtDtPreviaFinal.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtPreviaFinal.Location = new System.Drawing.Point(444, 23);
            this.TxtDtPreviaFinal.Mask = "00/00/0000";
            this.TxtDtPreviaFinal.Name = "TxtDtPreviaFinal";
            this.TxtDtPreviaFinal.Size = new System.Drawing.Size(100, 28);
            this.TxtDtPreviaFinal.TabIndex = 28;
            this.TxtDtPreviaFinal.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDtPreviaInicial
            // 
            this.TxtDtPreviaInicial.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtPreviaInicial.Location = new System.Drawing.Point(292, 23);
            this.TxtDtPreviaInicial.Mask = "00/00/0000";
            this.TxtDtPreviaInicial.Name = "TxtDtPreviaInicial";
            this.TxtDtPreviaInicial.Size = new System.Drawing.Size(100, 28);
            this.TxtDtPreviaInicial.TabIndex = 26;
            this.TxtDtPreviaInicial.ValidatingType = typeof(System.DateTime);
            // 
            // LblPrevia
            // 
            this.LblPrevia.AutoSize = true;
            this.LblPrevia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPrevia.Location = new System.Drawing.Point(6, 26);
            this.LblPrevia.Name = "LblPrevia";
            this.LblPrevia.Size = new System.Drawing.Size(171, 19);
            this.LblPrevia.TabIndex = 27;
            this.LblPrevia.Text = "Prévia de Entrega:";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmar.Location = new System.Drawing.Point(698, 502);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(101, 30);
            this.BtnConfirmar.TabIndex = 28;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ChkApenasAtrasados
            // 
            this.ChkApenasAtrasados.AutoSize = true;
            this.ChkApenasAtrasados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkApenasAtrasados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkApenasAtrasados.Location = new System.Drawing.Point(6, 92);
            this.ChkApenasAtrasados.Name = "ChkApenasAtrasados";
            this.ChkApenasAtrasados.Size = new System.Drawing.Size(280, 23);
            this.ChkApenasAtrasados.TabIndex = 34;
            this.ChkApenasAtrasados.Text = "Apenas Mercadorias Atrasadas";
            this.ChkApenasAtrasados.UseVisualStyleBackColor = true;
            // 
            // F_RELATORIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpDimensoes);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.OptDespachado);
            this.Controls.Add(this.OptPendenteDespacho);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_RELATORIO";
            this.Size = new System.Drawing.Size(802, 535);
            this.Load += new System.EventHandler(this.F_RELATORIO_Load);
            this.GrpDimensoes.ResumeLayout(false);
            this.GrpDimensoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton OptPendenteDespacho;
        private System.Windows.Forms.RadioButton OptDespachado;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.GroupBox GrpDimensoes;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblDtDespacho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtDtDespachoInicial;
        private System.Windows.Forms.MaskedTextBox TxtDtDespachoFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtDtCadastroFinal;
        private System.Windows.Forms.MaskedTextBox TxtDtCadastroInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtDtPreviaFinal;
        private System.Windows.Forms.MaskedTextBox TxtDtPreviaInicial;
        private System.Windows.Forms.Label LblPrevia;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.CheckBox ChkApenasAtrasados;
    }
}
