﻿
namespace ReproductorDeMusica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBoxCanciones = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumImagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.TrackBarSubirVolumen = new System.Windows.Forms.TrackBar();
            this.btnConfigurarRuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSubirVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(7)))), ((int)(((byte)(221)))));
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(176, 234);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(7)))), ((int)(((byte)(221)))));
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(116, 234);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(7)))), ((int)(((byte)(221)))));
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(238, 234);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listBoxCanciones
            // 
            this.listBoxCanciones.BackColor = System.Drawing.Color.Black;
            this.listBoxCanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCanciones.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBoxCanciones.FormattingEnabled = true;
            this.listBoxCanciones.ItemHeight = 15;
            this.listBoxCanciones.Location = new System.Drawing.Point(20, 109);
            this.listBoxCanciones.Name = "listBoxCanciones";
            this.listBoxCanciones.Size = new System.Drawing.Size(345, 109);
            this.listBoxCanciones.TabIndex = 3;
            // 
            // pictureBoxAlbumImagen
            // 
            this.pictureBoxAlbumImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlbumImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAlbumImagen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlbumImagen.Image")));
            this.pictureBoxAlbumImagen.Location = new System.Drawing.Point(433, 45);
            this.pictureBoxAlbumImagen.Name = "pictureBoxAlbumImagen";
            this.pictureBoxAlbumImagen.Size = new System.Drawing.Size(165, 173);
            this.pictureBoxAlbumImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumImagen.TabIndex = 4;
            this.pictureBoxAlbumImagen.TabStop = false;
            this.pictureBoxAlbumImagen.Click += new System.EventHandler(this.pictureBoxAlbumCover_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(572, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(604, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 25);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Enabled = false;
            this.picture.Image = global::ReproductorDeMusica.Properties.Resources.FocusedNeatHen_max_1mb;
            this.picture.Location = new System.Drawing.Point(20, 45);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(396, 50);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TrackBarSubirVolumen
            // 
            this.TrackBarSubirVolumen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrackBarSubirVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBarSubirVolumen.Location = new System.Drawing.Point(371, 109);
            this.TrackBarSubirVolumen.Name = "TrackBarSubirVolumen";
            this.TrackBarSubirVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarSubirVolumen.Size = new System.Drawing.Size(45, 109);
            this.TrackBarSubirVolumen.TabIndex = 8;
            this.TrackBarSubirVolumen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarSubirVolumen.Value = 5;
            // 
            // btnConfigurarRuta
            // 
            this.btnConfigurarRuta.BackgroundImage = global::ReproductorDeMusica.Properties.Resources.simbolo_de_interfaz_de_dos_carpetas_negras;
            this.btnConfigurarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigurarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigurarRuta.Location = new System.Drawing.Point(1, 0);
            this.btnConfigurarRuta.Name = "btnConfigurarRuta";
            this.btnConfigurarRuta.Size = new System.Drawing.Size(29, 25);
            this.btnConfigurarRuta.TabIndex = 9;
            this.btnConfigurarRuta.UseVisualStyleBackColor = true;
            this.btnConfigurarRuta.Click += new System.EventHandler(this.btnConfigurarRuta_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 320);
            this.Controls.Add(this.btnConfigurarRuta);
            this.Controls.Add(this.TrackBarSubirVolumen);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxAlbumImagen);
            this.Controls.Add(this.listBoxCanciones);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor-Musical";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSubirVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBoxCanciones;
        private System.Windows.Forms.PictureBox pictureBoxAlbumImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TrackBar TrackBarSubirVolumen;
        private System.Windows.Forms.Button btnConfigurarRuta;
    }
}

