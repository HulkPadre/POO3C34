using System;
using POO3C34.BLL;
using POO3C34.DTO;
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
    public partial class FrmGravadoras : Form
    {
        tblGravadoraBLL bllGravadora = new tblGravadoraBLL();
        tblGravadoraDTO dtoGravadora = new tblGravadoraDTO();
        public FrmGravadoras()
        {
            InitializeComponent();
        }

        private void FrmGravadoras_Load(object sender, EventArgs e)
        {
            GridGravadoras.DataSource = bllGravadora.ListarTodasGravadoras();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GridGravadoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
