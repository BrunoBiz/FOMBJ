using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOMBJ
{
    public partial class F_CADASTRO : UserControl
    {
        public F_CADASTRO()
        {
            InitializeComponent();
        }

        private void HabilitaDesabilitaComponentes (Boolean Acao)
        {
            this.TxtCodBarras.Enabled   = Acao;
            this.TxtPeso.Enabled        = Acao;
            this.TxtDtPrevia.Enabled    = Acao;
            this.TxtAltura.Enabled      = Acao;
            this.TxtLargura.Enabled     = Acao;
            this.TxtComprimento.Enabled = Acao;

            this.BtnConfirmar.Enabled = Acao;
            this.BtnCancelar.Enabled  = Acao;
        }

        private void LimparCampos()
        {
            this.TxtCadastro.Enabled = true;
            this.TxtCadastro.Focus();
            
            this.TxtCodigoInterno.Text = "";
            this.TxtCodBarras.Text     = "";
            this.TxtPeso.Text          = "";
            this.TxtDtPrevia.Text      = "";
            this.TxtAltura.Text        = "";
            this.TxtComprimento.Text   = "";
            this.TxtLargura.Text       = "";

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaComponentes(false);
            LimparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaComponentes(false);
            LimparCampos();
        }

        private void F_CADASTRO_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void TxtCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // INCLUINDO
            {
                HabilitaDesabilitaComponentes(true);

                this.TxtCodigoInterno.Text = "INCLUINDO";
                this.TxtCadastro.Enabled   = false;
                this.TxtCodBarras.Focus();
            }
        }
    }
}
