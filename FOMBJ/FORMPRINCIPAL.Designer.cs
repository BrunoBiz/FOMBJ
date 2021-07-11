using System;
using System.Windows.Forms;

namespace FOMBJ
{
    partial class FORMPRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMPRINCIPAL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.BtnDespacho = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnPrincipal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnNotifica = new System.Windows.Forms.Button();
            this.BtnConfiguracao = new System.Windows.Forms.Button();
            this.F_PRINCIPAL = new FOMBJ.F_PRINCIPAL();
            this.F_DESPACHO = new FOMBJ.F_DESPACHO();
            this.F_CADASTRO = new FOMBJ.F_CADASTRO();
            this.F_RELATORIO = new FOMBJ.F_RELATORIO();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.BtnRelatorio);
            this.panel1.Controls.Add(this.BtnDespacho);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnCadastro);
            this.panel1.Controls.Add(this.BtnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 583);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 102);
            this.SidePanel.TabIndex = 4;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.FlatAppearance.BorderSize = 0;
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorio.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelatorio.Image")));
            this.BtnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorio.Location = new System.Drawing.Point(12, 366);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(210, 102);
            this.BtnRelatorio.TabIndex = 4;
            this.BtnRelatorio.Text = "   Relatório";
            this.BtnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // BtnDespacho
            // 
            this.BtnDespacho.FlatAppearance.BorderSize = 0;
            this.BtnDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDespacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDespacho.ForeColor = System.Drawing.Color.White;
            this.BtnDespacho.Image = ((System.Drawing.Image)(resources.GetObject("BtnDespacho.Image")));
            this.BtnDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDespacho.Location = new System.Drawing.Point(12, 264);
            this.BtnDespacho.Name = "BtnDespacho";
            this.BtnDespacho.Size = new System.Drawing.Size(210, 102);
            this.BtnDespacho.TabIndex = 3;
            this.BtnDespacho.Text = "    Despacho de Mercadoria";
            this.BtnDespacho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDespacho.UseVisualStyleBackColor = true;
            this.BtnDespacho.Click += new System.EventHandler(this.BtnDespacho_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.White;
            this.BtnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelp.Location = new System.Drawing.Point(12, 539);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(36, 34);
            this.BtnHelp.TabIndex = 4;
            this.BtnHelp.Text = "?";
            this.BtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastro.ForeColor = System.Drawing.Color.White;
            this.BtnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastro.Image")));
            this.BtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastro.Location = new System.Drawing.Point(12, 162);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(210, 102);
            this.BtnCadastro.TabIndex = 2;
            this.BtnCadastro.Text = "   Cadastro de Mercadoria";
            this.BtnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnPrincipal
            // 
            this.BtnPrincipal.FlatAppearance.BorderSize = 0;
            this.BtnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrincipal.ForeColor = System.Drawing.Color.White;
            this.BtnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrincipal.Image")));
            this.BtnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrincipal.Location = new System.Drawing.Point(12, 61);
            this.BtnPrincipal.Name = "BtnPrincipal";
            this.BtnPrincipal.Size = new System.Drawing.Size(210, 102);
            this.BtnPrincipal.TabIndex = 1;
            this.BtnPrincipal.Text = "   Principal";
            this.BtnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrincipal.UseVisualStyleBackColor = true;
            this.BtnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.lblNomeSistema);
            this.panel2.Controls.Add(this.pictLogo);
            this.panel2.Controls.Add(this.BtnSair);
            this.panel2.Controls.Add(this.BtnNotifica);
            this.panel2.Controls.Add(this.BtnConfiguracao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 49);
            this.panel2.TabIndex = 1;
            // 
            // lblNomeSistema
            // 
            this.lblNomeSistema.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeSistema.AutoSize = true;
            this.lblNomeSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblNomeSistema.ForeColor = System.Drawing.Color.White;
            this.lblNomeSistema.Location = new System.Drawing.Point(49, 8);
            this.lblNomeSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(294, 36);
            this.lblNomeSistema.TabIndex = 8;
            this.lblNomeSistema.Text = "FOMBJ SOLUTIONS";
            this.lblNomeSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictLogo
            // 
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(0, 0);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(45, 49);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 4;
            this.pictLogo.TabStop = false;
            this.pictLogo.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.Location = new System.Drawing.Point(760, 8);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(32, 35);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnNotifica
            // 
            this.BtnNotifica.FlatAppearance.BorderSize = 0;
            this.BtnNotifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotifica.ForeColor = System.Drawing.Color.White;
            this.BtnNotifica.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotifica.Image")));
            this.BtnNotifica.Location = new System.Drawing.Point(681, 8);
            this.BtnNotifica.Name = "BtnNotifica";
            this.BtnNotifica.Size = new System.Drawing.Size(32, 35);
            this.BtnNotifica.TabIndex = 5;
            this.BtnNotifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNotifica.UseVisualStyleBackColor = true;
            this.BtnNotifica.Click += new System.EventHandler(this.BtnNotifica_Click);
            // 
            // BtnConfiguracao
            // 
            this.BtnConfiguracao.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracao.Image")));
            this.BtnConfiguracao.Location = new System.Drawing.Point(721, 8);
            this.BtnConfiguracao.Name = "BtnConfiguracao";
            this.BtnConfiguracao.Size = new System.Drawing.Size(32, 35);
            this.BtnConfiguracao.TabIndex = 6;
            this.BtnConfiguracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracao.UseVisualStyleBackColor = true;
            this.BtnConfiguracao.Click += new System.EventHandler(this.BtnConfiguracao_Click);
            // 
            // F_PRINCIPAL
            // 
            this.F_PRINCIPAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F_PRINCIPAL.BackgroundImage")));
            this.F_PRINCIPAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.F_PRINCIPAL.Location = new System.Drawing.Point(224, 49);
            this.F_PRINCIPAL.Margin = new System.Windows.Forms.Padding(2);
            this.F_PRINCIPAL.Name = "F_PRINCIPAL";
            this.F_PRINCIPAL.Size = new System.Drawing.Size(802, 535);
            this.F_PRINCIPAL.TabIndex = 2;
            this.F_PRINCIPAL.Load += new System.EventHandler(this.F_PRINCIPAL_Load);
            // 
            // F_DESPACHO
            // 
            this.F_DESPACHO.Location = new System.Drawing.Point(224, 49);
            this.F_DESPACHO.Name = "F_DESPACHO";
            this.F_DESPACHO.Size = new System.Drawing.Size(802, 535);
            this.F_DESPACHO.TabIndex = 4;
            // 
            // F_CADASTRO
            // 
            this.F_CADASTRO.Location = new System.Drawing.Point(224, 49);
            this.F_CADASTRO.Name = "F_CADASTRO";
            this.F_CADASTRO.Size = new System.Drawing.Size(802, 535);
            this.F_CADASTRO.TabIndex = 3;
            // 
            // F_RELATORIO
            // 
            this.F_RELATORIO.Location = new System.Drawing.Point(224, 49);
            this.F_RELATORIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F_RELATORIO.Name = "F_RELATORIO";
            this.F_RELATORIO.Size = new System.Drawing.Size(802, 535);
            this.F_RELATORIO.TabIndex = 5;
            // 
            // FORMPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.F_PRINCIPAL);
            this.Controls.Add(this.F_DESPACHO);
            this.Controls.Add(this.F_CADASTRO);
            this.Controls.Add(this.F_RELATORIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORMPRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.FORMPRINCIPAL_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void FORMPRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.Button BtnDespacho;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnNotifica;
        private System.Windows.Forms.Button BtnConfiguracao;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label lblNomeSistema;
        private F_PRINCIPAL F_PRINCIPAL;
        private F_CADASTRO F_CADASTRO;
        private F_DESPACHO F_DESPACHO;
        private F_RELATORIO F_RELATORIO;
    }
}