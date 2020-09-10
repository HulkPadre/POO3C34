namespace POO3C34.UI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_musicas = new System.Windows.Forms.Button();
            this.btn_cds = new System.Windows.Forms.Button();
            this.btn_gravadora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_musicas
            // 
            this.btn_musicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musicas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_musicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_musicas.Location = new System.Drawing.Point(14, 161);
            this.btn_musicas.Name = "btn_musicas";
            this.btn_musicas.Size = new System.Drawing.Size(100, 48);
            this.btn_musicas.TabIndex = 3;
            this.btn_musicas.Text = "Ir para Músicas";
            this.btn_musicas.UseVisualStyleBackColor = true;
            this.btn_musicas.Click += new System.EventHandler(this.btn_musicas_Click);
            // 
            // btn_cds
            // 
            this.btn_cds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cds.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cds.Location = new System.Drawing.Point(146, 161);
            this.btn_cds.Name = "btn_cds";
            this.btn_cds.Size = new System.Drawing.Size(100, 48);
            this.btn_cds.TabIndex = 4;
            this.btn_cds.Text = "Ver Cds";
            this.btn_cds.UseVisualStyleBackColor = true;
            this.btn_cds.Click += new System.EventHandler(this.btn_cds_Click);
            // 
            // btn_gravadora
            // 
            this.btn_gravadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gravadora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravadora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_gravadora.Location = new System.Drawing.Point(278, 161);
            this.btn_gravadora.Name = "btn_gravadora";
            this.btn_gravadora.Size = new System.Drawing.Size(100, 48);
            this.btn_gravadora.TabIndex = 5;
            this.btn_gravadora.Text = "Ver Gravadoras";
            this.btn_gravadora.UseVisualStyleBackColor = true;
            this.btn_gravadora.Click += new System.EventHandler(this.btn_gravadora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // btn_sair
            // 
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.Image = global::POO3C34.Properties.Resources.x;
            this.btn_sair.Location = new System.Drawing.Point(337, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(53, 46);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POO3C34.Properties.Resources.gravadora;
            this.pictureBox3.Location = new System.Drawing.Point(278, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POO3C34.Properties.Resources.cd;
            this.pictureBox2.Location = new System.Drawing.Point(146, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POO3C34.Properties.Resources.Music;
            this.pictureBox1.Location = new System.Drawing.Point(14, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gravadora);
            this.Controls.Add(this.btn_cds);
            this.Controls.Add(this.btn_musicas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_musicas;
        private System.Windows.Forms.Button btn_cds;
        private System.Windows.Forms.Button btn_gravadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
    }
}