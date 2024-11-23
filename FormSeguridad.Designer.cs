namespace Vista_Administrador
{
    partial class FormSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguridad));
            labeltxtAviso = new Label();
            pictureBoxImagen = new PictureBox();
            labelShowId = new Label();
            labeltxtId = new Label();
            labeltxtTitulo = new Label();
            labeltxtArtista = new Label();
            labeltxtGenero = new Label();
            labeltxtPrecio = new Label();
            labeltxtExistencias = new Label();
            labelShowArtista = new Label();
            labelShowTitulo = new Label();
            labelShowGenero = new Label();
            labelShowPrecio = new Label();
            labelShowExistencias = new Label();
            buttonActualizar = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // labeltxtAviso
            // 
            labeltxtAviso.BackColor = Color.Transparent;
            labeltxtAviso.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtAviso.ForeColor = Color.White;
            labeltxtAviso.Location = new Point(64, 24);
            labeltxtAviso.Name = "labeltxtAviso";
            labeltxtAviso.Size = new Size(660, 39);
            labeltxtAviso.TabIndex = 9;
            labeltxtAviso.Text = "¿SEGURO QUE DESEA ELIMINAR EL DISCO?";
            labeltxtAviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Location = new Point(38, 86);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(260, 260);
            pictureBoxImagen.TabIndex = 57;
            pictureBoxImagen.TabStop = false;
            // 
            // labelShowId
            // 
            labelShowId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowId.ForeColor = Color.White;
            labelShowId.Location = new Point(413, 86);
            labelShowId.Name = "labelShowId";
            labelShowId.Size = new Size(311, 28);
            labelShowId.TabIndex = 51;
            labelShowId.Text = "...\r\n\r\n";
            labelShowId.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtId
            // 
            labeltxtId.AutoSize = true;
            labeltxtId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtId.ForeColor = Color.White;
            labeltxtId.Location = new Point(316, 86);
            labeltxtId.Name = "labeltxtId";
            labeltxtId.Size = new Size(38, 28);
            labeltxtId.TabIndex = 50;
            labeltxtId.Text = "ID:";
            labeltxtId.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtTitulo
            // 
            labeltxtTitulo.AutoSize = true;
            labeltxtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtTitulo.ForeColor = Color.White;
            labeltxtTitulo.Location = new Point(316, 132);
            labeltxtTitulo.Name = "labeltxtTitulo";
            labeltxtTitulo.Size = new Size(86, 28);
            labeltxtTitulo.TabIndex = 59;
            labeltxtTitulo.Text = "TITULO:";
            labeltxtTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtArtista
            // 
            labeltxtArtista.AutoSize = true;
            labeltxtArtista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtArtista.ForeColor = Color.White;
            labeltxtArtista.Location = new Point(316, 182);
            labeltxtArtista.Name = "labeltxtArtista";
            labeltxtArtista.Size = new Size(98, 28);
            labeltxtArtista.TabIndex = 60;
            labeltxtArtista.Text = "ARTISTA:";
            labeltxtArtista.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtGenero
            // 
            labeltxtGenero.AutoSize = true;
            labeltxtGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtGenero.ForeColor = Color.White;
            labeltxtGenero.Location = new Point(312, 226);
            labeltxtGenero.Name = "labeltxtGenero";
            labeltxtGenero.Size = new Size(97, 28);
            labeltxtGenero.TabIndex = 61;
            labeltxtGenero.Text = "GENERO:";
            labeltxtGenero.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtPrecio
            // 
            labeltxtPrecio.AutoSize = true;
            labeltxtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtPrecio.ForeColor = Color.White;
            labeltxtPrecio.Location = new Point(316, 270);
            labeltxtPrecio.Name = "labeltxtPrecio";
            labeltxtPrecio.Size = new Size(86, 28);
            labeltxtPrecio.TabIndex = 62;
            labeltxtPrecio.Text = "PRECIO:";
            labeltxtPrecio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltxtExistencias
            // 
            labeltxtExistencias.AutoSize = true;
            labeltxtExistencias.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtExistencias.ForeColor = Color.White;
            labeltxtExistencias.Location = new Point(316, 326);
            labeltxtExistencias.Name = "labeltxtExistencias";
            labeltxtExistencias.Size = new Size(92, 17);
            labeltxtExistencias.TabIndex = 63;
            labeltxtExistencias.Text = "EXISTENCIAS:";
            labeltxtExistencias.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowArtista
            // 
            labelShowArtista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowArtista.ForeColor = Color.White;
            labelShowArtista.Location = new Point(413, 182);
            labelShowArtista.Name = "labelShowArtista";
            labelShowArtista.Size = new Size(311, 28);
            labelShowArtista.TabIndex = 64;
            labelShowArtista.Text = "...\r\n\r\n";
            labelShowArtista.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowTitulo
            // 
            labelShowTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowTitulo.ForeColor = Color.White;
            labelShowTitulo.Location = new Point(413, 132);
            labelShowTitulo.Name = "labelShowTitulo";
            labelShowTitulo.Size = new Size(311, 28);
            labelShowTitulo.TabIndex = 65;
            labelShowTitulo.Text = "...\r\n\r\n";
            labelShowTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowGenero
            // 
            labelShowGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowGenero.ForeColor = Color.White;
            labelShowGenero.Location = new Point(413, 226);
            labelShowGenero.Name = "labelShowGenero";
            labelShowGenero.Size = new Size(311, 28);
            labelShowGenero.TabIndex = 66;
            labelShowGenero.Text = "...\r\n\r\n";
            labelShowGenero.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowPrecio
            // 
            labelShowPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowPrecio.ForeColor = Color.White;
            labelShowPrecio.Location = new Point(413, 270);
            labelShowPrecio.Name = "labelShowPrecio";
            labelShowPrecio.Size = new Size(311, 28);
            labelShowPrecio.TabIndex = 67;
            labelShowPrecio.Text = "...\r\n\r\n";
            labelShowPrecio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelShowExistencias
            // 
            labelShowExistencias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShowExistencias.ForeColor = Color.White;
            labelShowExistencias.Location = new Point(414, 318);
            labelShowExistencias.Name = "labelShowExistencias";
            labelShowExistencias.Size = new Size(311, 28);
            labelShowExistencias.TabIndex = 68;
            labelShowExistencias.Text = "...\r\n\r\n";
            labelShowExistencias.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonActualizar
            // 
            buttonActualizar.FlatStyle = FlatStyle.Popup;
            buttonActualizar.ForeColor = SystemColors.ButtonHighlight;
            buttonActualizar.Image = (Image)resources.GetObject("buttonActualizar.Image");
            buttonActualizar.Location = new Point(38, 370);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(337, 55);
            buttonActualizar.TabIndex = 69;
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelar.Image = (Image)resources.GetObject("buttonCancelar.Image");
            buttonCancelar.Location = new Point(466, 370);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(258, 55);
            buttonCancelar.TabIndex = 70;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonActualizar);
            Controls.Add(labelShowExistencias);
            Controls.Add(labelShowPrecio);
            Controls.Add(labelShowGenero);
            Controls.Add(labelShowTitulo);
            Controls.Add(labelShowArtista);
            Controls.Add(labeltxtExistencias);
            Controls.Add(labeltxtPrecio);
            Controls.Add(labeltxtGenero);
            Controls.Add(labeltxtArtista);
            Controls.Add(labeltxtTitulo);
            Controls.Add(pictureBoxImagen);
            Controls.Add(labelShowId);
            Controls.Add(labeltxtId);
            Controls.Add(labeltxtAviso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeguridad";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltxtAviso;
        private PictureBox pictureBoxImagen;
        private Label labelShowId;
        private Label labeltxtId;
        private Label labeltxtTitulo;
        private Label labeltxtArtista;
        private Label labeltxtGenero;
        private Label labeltxtPrecio;
        private Label labeltxtExistencias;
        private Label labelShowArtista;
        private Label labelShowTitulo;
        private Label labelShowGenero;
        private Label labelShowPrecio;
        private Label labelShowExistencias;
        private Button buttonActualizar;
        private Button buttonCancelar;
    }
}