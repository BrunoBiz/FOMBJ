using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FOMBJ
{
    public partial class F_CADASTRO : UserControl
    {

        private DataSet mDataSet;
        private MySqlDataAdapter mAdapter;
        public MySqlConnection mConn;
        public MySqlCommand cmdInsertMercadorias;

        public F_CADASTRO()
        {
            InitializeComponent();
        }

        private void HabilitaDesabilitaComponentes (Boolean Acao)
        {
            this.TxtCodBarras.Enabled   = Acao;
            this.TxtPeso.Enabled        = Acao;
            this.TxtDtPrevia.Enabled    = Acao;
            this.TxtLocalizacao.Enabled = Acao;
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
            this.TxtLocalizacao.Text   = "";
            this.TxtAltura.Text        = "";
            this.TxtComprimento.Text   = "";
            this.TxtLargura.Text       = "";

        }

        public Boolean SalvarMercadorias()
        {
            Conexao GravarMercadorias = new Conexao();
            if (GravarMercadorias.CriaConexao())
            {
                cmdInsertMercadorias = new MySqlCommand(
                    "INSERT INTO CADASTRO_MERCADORIA  " +
                    "	(                             " +
                    "		ALTURA           ,        " +
                    "		LARGURA          ,        " +
                    "		COMPRIMENTO      ,        " +
                    "		PESO             ,        " +
                    "		CODIGO_BARRAS    ,        " +
                    "       LOCALIZACAO      ,        " +
                    "		PREVIA_ENTREGA            " +
                    "	)VALUES(                      " +
                            this.TxtAltura.Text      + " ," +
                            this.TxtLargura.Text     + " ," +
                            this.TxtComprimento.Text + " ," +
                            this.TxtPeso.Text        + " ," +
                    "'" +   this.TxtCodBarras.Text   + "'," +
                    "'" +   this.TxtLocalizacao.Text + "'," +
                    "'" +   this.TxtDtPrevia.Text.Substring(6, 4) + "-" + this.TxtDtPrevia.Text.Substring(3, 2) + "-" + this.TxtDtPrevia.Text.Substring(0, 2) + "'" + // GAMBIARRA - Transforma a data em um formato válido AAAA-MM-DD
                    "	)                             ");;

                Insert InsertMercadorias = new Insert(GravarMercadorias.mConn, cmdInsertMercadorias);

                InsertMercadorias.Executar();
                GravarMercadorias.FecharConexao();

                MessageBox.Show("Mercadoria Gravada com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha de conexão com o banco de dados!");
            }

            return true;
        }

        public void BtnConfirmar_Click(object sender, EventArgs e)
        {
            SalvarMercadorias();
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
