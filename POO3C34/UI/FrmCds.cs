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
    public partial class FrmCds : Form
    {

        tblCdBLL bllCd = new tblCdBLL();
        tblCdDTO dtoCD = new tblCdDTO();

        public FrmCds()
        {
            InitializeComponent();
        }

        private void FrmCds_Load(object sender, EventArgs e)
        {
            GridCds.DataSource = bllCd.ListarTodosCd();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
        }
    }
}
