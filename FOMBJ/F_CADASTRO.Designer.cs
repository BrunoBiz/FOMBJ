namespace FOMBJ
{
    partial class F_CADASTRO
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtCadastro = new System.Windows.Forms.TextBox();
            this.LblInsereAltera = new System.Windows.Forms.Label();
            this.GrpDimensoes = new System.Windows.Forms.GroupBox();
            this.TxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.TxtComprimento = new System.Windows.Forms.MaskedTextBox();
            this.TxtLargura = new System.Windows.Forms.MaskedTextBox();
            this.LblCmComprimento = new System.Windows.Forms.Label();
            this.LblComprimento = new System.Windows.Forms.Label();
            this.LblCmAltura = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblLargura = new System.Windows.Forms.Label();
            this.LblCmLargura = new System.Windows.Forms.Label();
            this.LblCodBarras = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblDtPrevia = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtCodBarras = new System.Windows.Forms.TextBox();
            this.LblKgPeso = new System.Windows.Forms.Label();
            this.TxtDtPrevia = new System.Windows.Forms.MaskedTextBox();
            this.TxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.LblCodigoInterno = new System.Windows.Forms.Label();
            this.TxtCodigoInterno = new System.Windows.Forms.TextBox();
            this.TxtLocalizacao = new System.Windows.Forms.TextBox();
            this.LblLocalizacao = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.GrpDimensoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtCadastro);
            this.panel2.Controls.Add(this.LblInsereAltera);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 51);
            this.panel2.TabIndex = 0;
            // 
            // TxtCadastro
            // 
            this.TxtCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCadastro.Font = new System.Drawing.Font("Consolas", 14F);
            this.TxtCadastro.Location = new System.Drawing.Point(359, 10);
            this.TxtCadastro.Name = "TxtCadastro";
            this.TxtCadastro.Size = new System.Drawing.Size(318, 29);
            this.TxtCadastro.TabIndex = 1;
            this.TxtCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadastro_KeyPress);
            // 
            // LblInsereAltera
            // 
            this.LblInsereAltera.AutoSize = true;
            this.LblInsereAltera.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.LblInsereAltera.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblInsereAltera.Location = new System.Drawing.Point(3, 13);
            this.LblInsereAltera.Name = "LblInsereAltera";
            this.LblInsereAltera.Size = new System.Drawing.Size(350, 22);
            this.LblInsereAltera.TabIndex = 0;
            this.LblInsereAltera.Text = "Código Interno / Código de Barras:";
            // 
            // GrpDimensoes
            // 
            this.GrpDimensoes.Controls.Add(this.TxtAltura);
            this.GrpDimensoes.Controls.Add(this.TxtComprimento);
            this.GrpDimensoes.Controls.Add(this.TxtLargura);
            this.GrpDimensoes.Controls.Add(this.LblCmComprimento);
            this.GrpDimensoes.Controls.Add(this.LblComprimento);
            this.GrpDimensoes.Controls.Add(this.LblCmAltura);
            this.GrpDimensoes.Controls.Add(this.LblAltura);
            this.GrpDimensoes.Controls.Add(this.LblLargura);
            this.GrpDimensoes.Controls.Add(this.LblCmLargura);
            this.GrpDimensoes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDimensoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GrpDimensoes.Location = new System.Drawing.Point(11, 281);
            this.GrpDimensoes.Name = "GrpDimensoes";
            this.GrpDimensoes.Size = new System.Drawing.Size(252, 147);
            this.GrpDimensoes.TabIndex = 6;
            this.GrpDimensoes.TabStop = false;
            this.GrpDimensoes.Text = "Dimensões";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Enabled = false;
            this.TxtAltura.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtAltura.Location = new System.Drawing.Point(145, 22);
            this.TxtAltura.Mask = "000000";
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.PromptChar = ' ';
            this.TxtAltura.Size = new System.Drawing.Size(65, 28);
            this.TxtAltura.TabIndex = 1;
            this.TxtAltura.ValidatingType = typeof(int);
            // 
            // TxtComprimento
            // 
            this.TxtComprimento.Enabled = false;
            this.TxtComprimento.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtComprimento.Location = new System.Drawing.Point(145, 99);
            this.TxtComprimento.Mask = "000000";
            this.TxtComprimento.Name = "TxtComprimento";
            this.TxtComprimento.PromptChar = ' ';
            this.TxtComprimento.Size = new System.Drawing.Size(65, 28);
            this.TxtComprimento.TabIndex = 3;
            this.TxtComprimento.ValidatingType = typeof(int);
            // 
            // TxtLargura
            // 
            this.TxtLargura.Enabled = false;
            this.TxtLargura.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtLargura.Location = new System.Drawing.Point(145, 58);
            this.TxtLargura.Mask = "000000";
            this.TxtLargura.Name = "TxtLargura";
            this.TxtLargura.PromptChar = ' ';
            this.TxtLargura.Size = new System.Drawing.Size(65, 28);
            this.TxtLargura.TabIndex = 2;
            this.TxtLargura.ValidatingType = typeof(int);
            // 
            // LblCmComprimento
            // 
            this.LblCmComprimento.AutoSize = true;
            this.LblCmComprimento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCmComprimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCmComprimento.Location = new System.Drawing.Point(216, 108);
            this.LblCmComprimento.Name = "LblCmComprimento";
            this.LblCmComprimento.Size = new System.Drawing.Size(27, 19);
            this.LblCmComprimento.TabIndex = 16;
            this.LblCmComprimento.Text = "Cm";
            // 
            // LblComprimento
            // 
            this.LblComprimento.AutoSize = true;
            this.LblComprimento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComprimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblComprimento.Location = new System.Drawing.Point(22, 108);
            this.LblComprimento.Name = "LblComprimento";
            this.LblComprimento.Size = new System.Drawing.Size(117, 19);
            this.LblComprimento.TabIndex = 2;
            this.LblComprimento.Text = "Comprimento:";
            // 
            // LblCmAltura
            // 
            this.LblCmAltura.AutoSize = true;
            this.LblCmAltura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCmAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCmAltura.Location = new System.Drawing.Point(216, 31);
            this.LblCmAltura.Name = "LblCmAltura";
            this.LblCmAltura.Size = new System.Drawing.Size(27, 19);
            this.LblCmAltura.TabIndex = 14;
            this.LblCmAltura.Text = "Cm";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblAltura.Location = new System.Drawing.Point(22, 31);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(72, 19);
            this.LblAltura.TabIndex = 5;
            this.LblAltura.Text = "Altura:";
            // 
            // LblLargura
            // 
            this.LblLargura.AutoSize = true;
            this.LblLargura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLargura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLargura.Location = new System.Drawing.Point(22, 67);
            this.LblLargura.Name = "LblLargura";
            this.LblLargura.Size = new System.Drawing.Size(81, 19);
            this.LblLargura.TabIndex = 3;
            this.LblLargura.Text = "Largura:";
            // 
            // LblCmLargura
            // 
            this.LblCmLargura.AutoSize = true;
            this.LblCmLargura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCmLargura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCmLargura.Location = new System.Drawing.Point(216, 67);
            this.LblCmLargura.Name = "LblCmLargura";
            this.LblCmLargura.Size = new System.Drawing.Size(27, 19);
            this.LblCmLargura.TabIndex = 15;
            this.LblCmLargura.Text = "Cm";
            // 
            // LblCodBarras
            // 
            this.LblCodBarras.AutoSize = true;
            this.LblCodBarras.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodBarras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCodBarras.Location = new System.Drawing.Point(7, 107);
            this.LblCodBarras.Name = "LblCodBarras";
            this.LblCodBarras.Size = new System.Drawing.Size(180, 22);
            this.LblCodBarras.TabIndex = 6;
            this.LblCodBarras.Text = "Código de Barras:";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPeso.Location = new System.Drawing.Point(7, 147);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(60, 22);
            this.LblPeso.TabIndex = 7;
            this.LblPeso.Text = "Peso:";
            // 
            // LblDtPrevia
            // 
            this.LblDtPrevia.AutoSize = true;
            this.LblDtPrevia.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblDtPrevia.Location = new System.Drawing.Point(7, 188);
            this.LblDtPrevia.Name = "LblDtPrevia";
            this.LblDtPrevia.Size = new System.Drawing.Size(190, 22);
            this.LblDtPrevia.TabIndex = 8;
            this.LblDtPrevia.Text = "Prévia de Entrega:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(585, 414);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(101, 30);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmar.Location = new System.Drawing.Point(478, 414);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(101, 30);
            this.BtnConfirmar.TabIndex = 7;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtCodBarras
            // 
            this.TxtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodBarras.Enabled = false;
            this.TxtCodBarras.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtCodBarras.Location = new System.Drawing.Point(203, 104);
            this.TxtCodBarras.Name = "TxtCodBarras";
            this.TxtCodBarras.Size = new System.Drawing.Size(173, 28);
            this.TxtCodBarras.TabIndex = 2;
            // 
            // LblKgPeso
            // 
            this.LblKgPeso.AutoSize = true;
            this.LblKgPeso.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKgPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblKgPeso.Location = new System.Drawing.Point(276, 147);
            this.LblKgPeso.Name = "LblKgPeso";
            this.LblKgPeso.Size = new System.Drawing.Size(30, 22);
            this.LblKgPeso.TabIndex = 17;
            this.LblKgPeso.Text = "Kg";
            // 
            // TxtDtPrevia
            // 
            this.TxtDtPrevia.Enabled = false;
            this.TxtDtPrevia.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtDtPrevia.Location = new System.Drawing.Point(203, 185);
            this.TxtDtPrevia.Mask = "00/00/0000";
            this.TxtDtPrevia.Name = "TxtDtPrevia";
            this.TxtDtPrevia.Size = new System.Drawing.Size(100, 28);
            this.TxtDtPrevia.TabIndex = 4;
            this.TxtDtPrevia.ValidatingType = typeof(System.DateTime);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Enabled = false;
            this.TxtPeso.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtPeso.Location = new System.Drawing.Point(203, 144);
            this.TxtPeso.Mask = "000000";
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.PromptChar = ' ';
            this.TxtPeso.Size = new System.Drawing.Size(67, 28);
            this.TxtPeso.TabIndex = 3;
            this.TxtPeso.ValidatingType = typeof(int);
            // 
            // LblCodigoInterno
            // 
            this.LblCodigoInterno.AutoSize = true;
            this.LblCodigoInterno.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoInterno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCodigoInterno.Location = new System.Drawing.Point(7, 71);
            this.LblCodigoInterno.Name = "LblCodigoInterno";
            this.LblCodigoInterno.Size = new System.Drawing.Size(160, 22);
            this.LblCodigoInterno.TabIndex = 18;
            this.LblCodigoInterno.Text = "Código Interno:";
            // 
            // TxtCodigoInterno
            // 
            this.TxtCodigoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigoInterno.Enabled = false;
            this.TxtCodigoInterno.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtCodigoInterno.Location = new System.Drawing.Point(203, 68);
            this.TxtCodigoInterno.Name = "TxtCodigoInterno";
            this.TxtCodigoInterno.Size = new System.Drawing.Size(89, 28);
            this.TxtCodigoInterno.TabIndex = 2;
            // 
            // TxtLocalizacao
            // 
            this.TxtLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLocalizacao.Enabled = false;
            this.TxtLocalizacao.Font = new System.Drawing.Font("Consolas", 13F);
            this.TxtLocalizacao.Location = new System.Drawing.Point(203, 229);
            this.TxtLocalizacao.Name = "TxtLocalizacao";
            this.TxtLocalizacao.Size = new System.Drawing.Size(478, 28);
            this.TxtLocalizacao.TabIndex = 5;
            // 
            // LblLocalizacao
            // 
            this.LblLocalizacao.AutoSize = true;
            this.LblLocalizacao.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalizacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLocalizacao.Location = new System.Drawing.Point(7, 232);
            this.LblLocalizacao.Name = "LblLocalizacao";
            this.LblLocalizacao.Size = new System.Drawing.Size(130, 22);
            this.LblLocalizacao.TabIndex = 20;
            this.LblLocalizacao.Text = "Localização:";
            // 
            // F_CADASTRO
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TxtLocalizacao);
            this.Controls.Add(this.LblLocalizacao);
            this.Controls.Add(this.TxtCodigoInterno);
            this.Controls.Add(this.LblCodigoInterno);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtDtPrevia);
            this.Controls.Add(this.LblKgPeso);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtCodBarras);
            this.Controls.Add(this.LblDtPrevia);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblCodBarras);
            this.Controls.Add(this.GrpDimensoes);
            this.Controls.Add(this.panel2);
            this.Name = "F_CADASTRO";
            this.Size = new System.Drawing.Size(691, 449);
            this.Load += new System.EventHandler(this.F_CADASTRO_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GrpDimensoes.ResumeLayout(false);
            this.GrpDimensoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtCadastro;
        private System.Windows.Forms.Label LblInsereAltera;
        private System.Windows.Forms.GroupBox GrpDimensoes;
        private System.Windows.Forms.Label LblComprimento;
        private System.Windows.Forms.Label LblLargura;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblCodBarras;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblDtPrevia;
        private System.Windows.Forms.Label LblCmComprimento;
        private System.Windows.Forms.Label LblCmLargura;
        private System.Windows.Forms.Label LblCmAltura;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtCodBarras;
        private System.Windows.Forms.Label LblKgPeso;
        private System.Windows.Forms.MaskedTextBox TxtDtPrevia;
        private System.Windows.Forms.MaskedTextBox TxtPeso;
        private System.Windows.Forms.MaskedTextBox TxtLargura;
        private System.Windows.Forms.MaskedTextBox TxtAltura;
        private System.Windows.Forms.MaskedTextBox TxtComprimento;
        private System.Windows.Forms.Label LblCodigoInterno;
        private System.Windows.Forms.TextBox TxtCodigoInterno;
        private System.Windows.Forms.TextBox TxtLocalizacao;
        private System.Windows.Forms.Label LblLocalizacao;
    }
}
