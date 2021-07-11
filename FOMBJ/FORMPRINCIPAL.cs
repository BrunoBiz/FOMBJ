using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOMBJ
{
    public partial class FORMPRINCIPAL : Form
    {
        public FORMPRINCIPAL()
        {
            InitializeComponent();
            SidePanel.Height = BtnPrincipal.Height;
            SidePanel.Top = BtnPrincipal.Top;
            F_PRINCIPAL.BringToFront();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnPrincipal.Height;
            SidePanel.Top = BtnPrincipal.Top;
            F_PRINCIPAL.BringToFront();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnCadastro.Height;
            SidePanel.Top = BtnCadastro.Top;
            F_CADASTRO.BringToFront();
            
        }

        private void BtnDespacho_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnDespacho.Height;
            SidePanel.Top = BtnDespacho.Top;
            F_DESPACHO.BringToFront();
            
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnRelatorio.Height;
            SidePanel.Top = BtnRelatorio.Top;
            F_RELATORIO.BringToFront();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnHelp.Height;
            SidePanel.Top = BtnHelp.Top;
            SidePanel.Height = BtnPrincipal.Height;
            SidePanel.Top = BtnPrincipal.Top;
            F_PRINCIPAL.BringToFront();
            MessageBox.Show("Ajuda Ainda não está Dísponivel!");
        }

        private void BtnNotifica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não possuí notificações!");
        }

        private void BtnConfiguracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As Configurações ainda não estão Dísponíveis!");
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_PRINCIPAL_Load(object sender, EventArgs e)
        {
            
        }
    }
}
