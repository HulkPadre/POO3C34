namespace POO3C34
{
    partial class frmMusica
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusica));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridMusicas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_idGravadora = new System.Windows.Forms.TextBox();
            this.txt_idCD = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMusicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(12, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 107);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(12, 153);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 20);
            this.txt_autor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Músicas 🎶";
            // 
            // GridMusicas
            // 
            this.GridMusicas.BackgroundColor = System.Drawing.Color.White;
            this.GridMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMusicas.GridColor = System.Drawing.Color.White;
            this.GridMusicas.Location = new System.Drawing.Point(171, 37);
            this.GridMusicas.Name = "GridMusicas";
            this.GridMusicas.Size = new System.Drawing.Size(349, 135);
            this.GridMusicas.TabIndex = 6;
            this.GridMusicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMusicas_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Autor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(12, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Id Gravadora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(12, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Id Cd";
            // 
            // txt_idGravadora
            // 
            this.txt_idGravadora.AllowDrop = true;
            this.txt_idGravadora.Location = new System.Drawing.Point(12, 199);
            this.txt_idGravadora.Name = "txt_idGravadora";
            this.txt_idGravadora.Size = new System.Drawing.Size(100, 20);
            this.txt_idGravadora.TabIndex = 20;
            // 
            // txt_idCD
            // 
            this.txt_idCD.Location = new System.Drawing.Point(12, 245);
            this.txt_idCD.Name = "txt_idCD";
            this.txt_idCD.Size = new System.Drawing.Size(100, 20);
            this.txt_idCD.TabIndex = 21;
            // 
            // btn_editar
            // 
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Red;
            this.btn_editar.Image = global::POO3C34.Properties.Resources.Edit1;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(171, 232);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(91, 49);
            this.btn_editar.TabIndex = 23;
            this.btn_editar.Text = "Inserir";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POO3C34.Properties.Resources.cotemig;
            this.pictureBox2.Location = new System.Drawing.Point(269, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Image = global::POO3C34.Properties.Resources.exit;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(429, 232);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(91, 49);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "        Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Red;
            this.btn_excluir.Image = global::POO3C34.Properties.Resources.x;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(429, 178);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(91, 49);
            this.btn_excluir.TabIndex = 9;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.Red;
            this.btn_inserir.Image = global::POO3C34.Properties.Resources.add;
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(171, 178);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(91, 49);
            this.btn_inserir.TabIndex = 7;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // frmMusica
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 284);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_idCD);
            this.Controls.Add(this.txt_idGravadora);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.GridMusicas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Músicas";
            this.Load += new System.EventHandler(this.frmMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMusicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridMusicas;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_idGravadora;
        private System.Windows.Forms.TextBox txt_idCD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_editar;
    }
}

