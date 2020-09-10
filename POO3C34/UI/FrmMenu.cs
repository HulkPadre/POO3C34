using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3C34.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_musicas_Click(object sender, EventArgs e)
        {
            var frmMusicas = new frmMusica();
            frmMusicas.Show();
            this.Visible = false;
        }

        private void btn_cds_Click(object sender, EventArgs e)
        {
            var frmCd = new FrmCds();
            frmCd.Show();
            this.Visible = false;
        }

        private void btn_gravadora_Click(object sender, EventArgs e)
        {
            var frmGrav = new FrmGravadoras();
            frmGrav.Show();
            this.Visible = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
