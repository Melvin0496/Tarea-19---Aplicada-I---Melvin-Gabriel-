namespace RegistroPeliculas2
{
    partial class RegistrarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPelicula));
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnotextBox = new System.Windows.Forms.TextBox();
            this.IMDBtextBox = new System.Windows.Forms.TextBox();
            this.CategoriaIdtextBox = new System.Windows.Forms.TextBox();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalificaciontextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PeliculaIdtextBox = new System.Windows.Forms.TextBox();
            this.ImagenesopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.Videosbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Examinarbutton = new System.Windows.Forms.Button();
            this.ImagenespictureBox = new System.Windows.Forms.PictureBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GenerocomboBox = new System.Windows.Forms.ComboBox();
            this.ActorcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EstudiocomboBox = new System.Windows.Forms.ComboBox();
            this.ActoreslistBox = new System.Windows.Forms.ListBox();
            this.GeneroslistBox = new System.Windows.Forms.ListBox();
            this.AgregarActoresbutton = new System.Windows.Forms.Button();
            this.AgregarGenerosbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenespictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(87, 63);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(194, 20);
            this.TitulotextBox.TabIndex = 0;
            this.TitulotextBox.TextChanged += new System.EventHandler(this.TitulotextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMDB:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CategoriaId:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AnotextBox
            // 
            this.AnotextBox.Location = new System.Drawing.Point(87, 98);
            this.AnotextBox.Name = "AnotextBox";
            this.AnotextBox.Size = new System.Drawing.Size(194, 20);
            this.AnotextBox.TabIndex = 7;
            this.AnotextBox.TextChanged += new System.EventHandler(this.AnotextBox_TextChanged);
            // 
            // IMDBtextBox
            // 
            this.IMDBtextBox.Location = new System.Drawing.Point(87, 169);
            this.IMDBtextBox.Name = "IMDBtextBox";
            this.IMDBtextBox.Size = new System.Drawing.Size(194, 20);
            this.IMDBtextBox.TabIndex = 8;
            this.IMDBtextBox.TextChanged += new System.EventHandler(this.IMDBtextBox_TextChanged);
            // 
            // CategoriaIdtextBox
            // 
            this.CategoriaIdtextBox.Location = new System.Drawing.Point(87, 207);
            this.CategoriaIdtextBox.Name = "CategoriaIdtextBox";
            this.CategoriaIdtextBox.Size = new System.Drawing.Size(194, 20);
            this.CategoriaIdtextBox.TabIndex = 9;
            this.CategoriaIdtextBox.TextChanged += new System.EventHandler(this.CategoriaIdtextBox_TextChanged);
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(87, 364);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(194, 116);
            this.DescripcionrichTextBox.TabIndex = 10;
            this.DescripcionrichTextBox.Text = "";
            this.DescripcionrichTextBox.TextChanged += new System.EventHandler(this.DescripcionrichTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calificacion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CalificaciontextBox
            // 
            this.CalificaciontextBox.Location = new System.Drawing.Point(87, 133);
            this.CalificaciontextBox.Name = "CalificaciontextBox";
            this.CalificaciontextBox.Size = new System.Drawing.Size(194, 20);
            this.CalificaciontextBox.TabIndex = 14;
            this.CalificaciontextBox.TextChanged += new System.EventHandler(this.CalificaciontextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "PeliculaId";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PeliculaIdtextBox
            // 
            this.PeliculaIdtextBox.Location = new System.Drawing.Point(87, 27);
            this.PeliculaIdtextBox.Name = "PeliculaIdtextBox";
            this.PeliculaIdtextBox.Size = new System.Drawing.Size(194, 20);
            this.PeliculaIdtextBox.TabIndex = 17;
            this.PeliculaIdtextBox.TextChanged += new System.EventHandler(this.PeliculaIdtextBox_TextChanged);
            // 
            // ImagenesopenFileDialog
            // 
            this.ImagenesopenFileDialog.FileName = "Imagenes";
            this.ImagenesopenFileDialog.Filter = "Fotos|*.jpg|Imagenes|*.png";
            this.ImagenesopenFileDialog.FilterIndex = 2;
            this.ImagenesopenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImagenesopenFileDialog_FileOk);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(532, 22);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(356, 197);
            this.Reproductor.TabIndex = 22;
            // 
            // Videosbutton
            // 
            this.Videosbutton.Image = ((System.Drawing.Image)(resources.GetObject("Videosbutton.Image")));
            this.Videosbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Videosbutton.Location = new System.Drawing.Point(675, 242);
            this.Videosbutton.Name = "Videosbutton";
            this.Videosbutton.Size = new System.Drawing.Size(86, 40);
            this.Videosbutton.TabIndex = 23;
            this.Videosbutton.Text = "Videos";
            this.Videosbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Videosbutton.UseVisualStyleBackColor = true;
            this.Videosbutton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(341, 502);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(86, 45);
            this.Buscarbutton.TabIndex = 21;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Examinarbutton
            // 
            this.Examinarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Examinarbutton.Image")));
            this.Examinarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Examinarbutton.Location = new System.Drawing.Point(690, 515);
            this.Examinarbutton.Name = "Examinarbutton";
            this.Examinarbutton.Size = new System.Drawing.Size(86, 43);
            this.Examinarbutton.TabIndex = 20;
            this.Examinarbutton.Text = "Examinar";
            this.Examinarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Examinarbutton.UseVisualStyleBackColor = true;
            this.Examinarbutton.Click += new System.EventHandler(this.Examinarbutton_Click);
            // 
            // ImagenespictureBox
            // 
            this.ImagenespictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagenespictureBox.Location = new System.Drawing.Point(532, 299);
            this.ImagenespictureBox.Name = "ImagenespictureBox";
            this.ImagenespictureBox.Size = new System.Drawing.Size(356, 190);
            this.ImagenespictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenespictureBox.TabIndex = 19;
            this.ImagenespictureBox.TabStop = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(19, 502);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(86, 45);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.Image")));
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(234, 502);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 45);
            this.Cancelarbutton.TabIndex = 12;
            this.Cancelarbutton.Text = "Eliminar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(127, 502);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 45);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Genero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Actor:";
            // 
            // GenerocomboBox
            // 
            this.GenerocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenerocomboBox.FormattingEnabled = true;
            this.GenerocomboBox.Location = new System.Drawing.Point(87, 247);
            this.GenerocomboBox.Name = "GenerocomboBox";
            this.GenerocomboBox.Size = new System.Drawing.Size(194, 21);
            this.GenerocomboBox.TabIndex = 26;
            // 
            // ActorcomboBox
            // 
            this.ActorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActorcomboBox.FormattingEnabled = true;
            this.ActorcomboBox.Location = new System.Drawing.Point(87, 285);
            this.ActorcomboBox.Name = "ActorcomboBox";
            this.ActorcomboBox.Size = new System.Drawing.Size(194, 21);
            this.ActorcomboBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(16, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Estudio:";
            // 
            // EstudiocomboBox
            // 
            this.EstudiocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiocomboBox.FormattingEnabled = true;
            this.EstudiocomboBox.Location = new System.Drawing.Point(87, 328);
            this.EstudiocomboBox.Name = "EstudiocomboBox";
            this.EstudiocomboBox.Size = new System.Drawing.Size(194, 21);
            this.EstudiocomboBox.TabIndex = 29;
            // 
            // ActoreslistBox
            // 
            this.ActoreslistBox.FormattingEnabled = true;
            this.ActoreslistBox.Location = new System.Drawing.Point(309, 27);
            this.ActoreslistBox.Name = "ActoreslistBox";
            this.ActoreslistBox.Size = new System.Drawing.Size(185, 95);
            this.ActoreslistBox.TabIndex = 30;
            // 
            // GeneroslistBox
            // 
            this.GeneroslistBox.FormattingEnabled = true;
            this.GeneroslistBox.Location = new System.Drawing.Point(309, 173);
            this.GeneroslistBox.Name = "GeneroslistBox";
            this.GeneroslistBox.Size = new System.Drawing.Size(185, 95);
            this.GeneroslistBox.TabIndex = 31;
            // 
            // AgregarActoresbutton
            // 
            this.AgregarActoresbutton.Location = new System.Drawing.Point(364, 133);
            this.AgregarActoresbutton.Name = "AgregarActoresbutton";
            this.AgregarActoresbutton.Size = new System.Drawing.Size(75, 23);
            this.AgregarActoresbutton.TabIndex = 32;
            this.AgregarActoresbutton.Text = "Agregar";
            this.AgregarActoresbutton.UseVisualStyleBackColor = true;
            this.AgregarActoresbutton.Click += new System.EventHandler(this.AgregarActoresbutton_Click);
            // 
            // AgregarGenerosbutton
            // 
            this.AgregarGenerosbutton.Location = new System.Drawing.Point(364, 288);
            this.AgregarGenerosbutton.Name = "AgregarGenerosbutton";
            this.AgregarGenerosbutton.Size = new System.Drawing.Size(75, 23);
            this.AgregarGenerosbutton.TabIndex = 33;
            this.AgregarGenerosbutton.Text = "Agregar";
            this.AgregarGenerosbutton.UseVisualStyleBackColor = true;
            this.AgregarGenerosbutton.Click += new System.EventHandler(this.AgregarGenerosbutton_Click);
            // 
            // RegistrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.AgregarGenerosbutton);
            this.Controls.Add(this.AgregarActoresbutton);
            this.Controls.Add(this.GeneroslistBox);
            this.Controls.Add(this.ActoreslistBox);
            this.Controls.Add(this.EstudiocomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ActorcomboBox);
            this.Controls.Add(this.GenerocomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Videosbutton);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Examinarbutton);
            this.Controls.Add(this.ImagenespictureBox);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PeliculaIdtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalificaciontextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.CategoriaIdtextBox);
            this.Controls.Add(this.IMDBtextBox);
            this.Controls.Add(this.AnotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitulotextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarPelicula";
            this.Text = "Registrar pelicula";
            this.Load += new System.EventHandler(this.RegistrarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenespictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AnotextBox;
        private System.Windows.Forms.TextBox IMDBtextBox;
        private System.Windows.Forms.TextBox CategoriaIdtextBox;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalificaciontextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox PeliculaIdtextBox;
        public System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.PictureBox ImagenespictureBox;
        private System.Windows.Forms.Button Examinarbutton;
        private System.Windows.Forms.OpenFileDialog ImagenesopenFileDialog;
        private System.Windows.Forms.Button Buscarbutton;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Button Videosbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GenerocomboBox;
        private System.Windows.Forms.ComboBox ActorcomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EstudiocomboBox;
        private System.Windows.Forms.ListBox ActoreslistBox;
        private System.Windows.Forms.ListBox GeneroslistBox;
        private System.Windows.Forms.Button AgregarActoresbutton;
        private System.Windows.Forms.Button AgregarGenerosbutton;
    }
}