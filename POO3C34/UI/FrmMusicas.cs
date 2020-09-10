using POO3C34.BLL;
using POO3C34.DTO;
using POO3C34.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3C34
{
    public partial class frmMusica : Form
    {
        tblMusicaBLL bllMusica = new tblMusicaBLL();
        tblMusicaDTO dtoMusica = new tblMusicaDTO();
        

        public frmMusica()
        {
            InitializeComponent();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                dtoMusica.Nome = txt_nome.Text.ToString();
                dtoMusica.NomeAutor = txt_autor.Text.ToString();
                dtoMusica.IdGravadora = int.Parse(txt_idGravadora.Text);
                dtoMusica.IdCD = int.Parse(txt_idCD.Text);

                bllMusica.InserirMusica(dtoMusica);
                MessageBox.Show("Música inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridMusicas.DataSource = bllMusica.ListarTodasMusicas();
                new LimpaForm(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridMusicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = GridMusicas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = GridMusicas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_autor.Text = GridMusicas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_idGravadora.Text = GridMusicas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_idCD.Text = GridMusicas.Rows[e.RowIndex].Cells[4].Value.ToString();           
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar a música selecionada e não poderá ser desfeito! deseja continuar?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoMusica.IdMusica = Convert.ToInt32(txt_id.Text);
                    bllMusica.ExcluirMusica(dtoMusica);
                    GridMusicas.DataSource = bllMusica.ListarTodasMusicas();
                    

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoMusica.IdMusica = int.Parse(txt_id.Text);
                dtoMusica.Nome = txt_nome.Text.ToString();
                dtoMusica.NomeAutor = txt_autor.Text.ToString();
                dtoMusica.IdGravadora = int.Parse(txt_idGravadora.Text);
                dtoMusica.IdCD = int.Parse(txt_idCD.Text);

                bllMusica.AlterarMusica(dtoMusica);
                MessageBox.Show("Alteração Feita com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridMusicas.DataSource = bllMusica.ListarTodasMusicas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
                                
        }

        private void frmMusica_Load(object sender, EventArgs e)
        {
            GridMusicas.DataSource = bllMusica.ListarTodasMusicas();
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dtoMusica.IdMusica = int.Parse(txt_id.Text);
                dtoMusica.Nome = txt_nome.Text.ToString();
                dtoMusica.NomeAutor = txt_autor.Text.ToString();
                dtoMusica.IdGravadora = int.Parse(txt_idGravadora.Text);
                dtoMusica.IdCD = int.Parse(txt_idCD.Text);

                bllMusica.AlterarMusica(dtoMusica);
                MessageBox.Show("Alteração Feita com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridMusicas.DataSource = bllMusica.ListarTodasMusicas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
