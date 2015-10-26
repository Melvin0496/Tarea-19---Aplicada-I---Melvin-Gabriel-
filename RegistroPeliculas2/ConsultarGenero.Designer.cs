namespace RegistroPeliculas2
{
    partial class ConsultarGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarGenero));
            this.GeneroConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.GeneroConsultacomboBox = new System.Windows.Forms.ComboBox();
            this.GeneroConsultatextBox = new System.Windows.Forms.TextBox();
            this.BuscarGenerobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneroConsultadataGridView
            // 
            this.GeneroConsultadataGridView.AllowUserToAddRows = false;
            this.GeneroConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneroConsultadataGridView.Location = new System.Drawing.Point(12, 142);
            this.GeneroConsultadataGridView.Name = "GeneroConsultadataGridView";
            this.GeneroConsultadataGridView.Size = new System.Drawing.Size(385, 150);
            this.GeneroConsultadataGridView.TabIndex = 0;
            // 
            // GeneroConsultacomboBox
            // 
            this.GeneroConsultacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneroConsultacomboBox.FormattingEnabled = true;
            this.GeneroConsultacomboBox.Items.AddRange(new object[] {
            "GeneroId",
            "Descripcion"});
            this.GeneroConsultacomboBox.Location = new System.Drawing.Point(12, 56);
            this.GeneroConsultacomboBox.Name = "GeneroConsultacomboBox";
            this.GeneroConsultacomboBox.Size = new System.Drawing.Size(121, 21);
            this.GeneroConsultacomboBox.TabIndex = 1;
            // 
            // GeneroConsultatextBox
            // 
            this.GeneroConsultatextBox.Location = new System.Drawing.Point(139, 57);
            this.GeneroConsultatextBox.Name = "GeneroConsultatextBox";
            this.GeneroConsultatextBox.Size = new System.Drawing.Size(176, 20);
            this.GeneroConsultatextBox.TabIndex = 2;
            // 
            // BuscarGenerobutton
            // 
            this.BuscarGenerobutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarGenerobutton.Image")));
            this.BuscarGenerobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarGenerobutton.Location = new System.Drawing.Point(321, 46);
            this.BuscarGenerobutton.Name = "BuscarGenerobutton";
            this.BuscarGenerobutton.Size = new System.Drawing.Size(76, 40);
            this.BuscarGenerobutton.TabIndex = 3;
            this.BuscarGenerobutton.Text = "Buscar";
            this.BuscarGenerobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarGenerobutton.UseVisualStyleBackColor = true;
            this.BuscarGenerobutton.Click += new System.EventHandler(this.BuscarGenerobutton_Click);
            // 
            // ConsultarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(411, 330);
            this.Controls.Add(this.BuscarGenerobutton);
            this.Controls.Add(this.GeneroConsultatextBox);
            this.Controls.Add(this.GeneroConsultacomboBox);
            this.Controls.Add(this.GeneroConsultadataGridView);
            this.Name = "ConsultarGenero";
            this.Text = "ConsultarGenero";
            ((System.ComponentModel.ISupportInitialize)(this.GeneroConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GeneroConsultadataGridView;
        private System.Windows.Forms.ComboBox GeneroConsultacomboBox;
        private System.Windows.Forms.TextBox GeneroConsultatextBox;
        private System.Windows.Forms.Button BuscarGenerobutton;
    }
}