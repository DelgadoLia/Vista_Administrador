namespace Vista_Administrador
{
    partial class FormEliminarDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarDisco));
            buttonMusica = new Button();
            buttonUsuario = new Button();
            pictureBox1 = new PictureBox();
            labelAdministrador = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            labeltxtEliminardisco = new Label();
            labeltxtDiscoaEliminar = new Label();
            textBoxId = new TextBox();
            buttonEnter = new Button();
            buttonSalir = new Button();
            buttonRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1102, 45);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 30;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // buttonUsuario
            // 
            buttonUsuario.FlatStyle = FlatStyle.Popup;
            buttonUsuario.Image = Properties.Resources.Captura_de_pantalla_2024_11_21_093731;
            buttonUsuario.Location = new Point(1191, 45);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(93, 89);
            buttonUsuario.TabIndex = 25;
            buttonUsuario.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.LOGO1;
            pictureBox1.Location = new Point(37, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // labelAdministrador
            // 
            labelAdministrador.AutoSize = true;
            labelAdministrador.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdministrador.ForeColor = Color.White;
            labelAdministrador.Location = new Point(431, 112);
            labelAdministrador.Name = "labelAdministrador";
            labelAdministrador.Size = new Size(455, 50);
            labelAdministrador.TabIndex = 29;
            labelAdministrador.Text = "A D M I N I S T R A D O R\r\n";
            labelAdministrador.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 183);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 28;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(203, 92);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 27;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(410, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 23;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(531, 64);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(237, 20);
            labelFrase.TabIndex = 24;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // labeltxtEliminardisco
            // 
            labeltxtEliminardisco.AutoSize = true;
            labeltxtEliminardisco.BackColor = Color.Transparent;
            labeltxtEliminardisco.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltxtEliminardisco.ForeColor = Color.White;
            labeltxtEliminardisco.Location = new Point(531, 199);
            labeltxtEliminardisco.Name = "labeltxtEliminardisco";
            labeltxtEliminardisco.Size = new Size(239, 36);
            labeltxtEliminardisco.TabIndex = 22;
            labeltxtEliminardisco.Text = "ELIMINAR DISCO\r\n";
            // 
            // labeltxtDiscoaEliminar
            // 
            labeltxtDiscoaEliminar.AutoSize = true;
            labeltxtDiscoaEliminar.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltxtDiscoaEliminar.ForeColor = Color.White;
            labeltxtDiscoaEliminar.Location = new Point(410, 286);
            labeltxtDiscoaEliminar.Name = "labeltxtDiscoaEliminar";
            labeltxtDiscoaEliminar.Size = new Size(481, 50);
            labeltxtDiscoaEliminar.TabIndex = 31;
            labeltxtDiscoaEliminar.Text = "ID DEL DISCO A ELIMINAR";
            labeltxtDiscoaEliminar.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.InactiveCaptionText;
            textBoxId.Location = new Point(431, 371);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(438, 27);
            textBoxId.TabIndex = 32;
            textBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEnter
            // 
            buttonEnter.FlatStyle = FlatStyle.Popup;
            buttonEnter.Image = (Image)resources.GetObject("buttonEnter.Image");
            buttonEnter.Location = new Point(552, 425);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(196, 56);
            buttonEnter.TabIndex = 47;
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.Location = new Point(1090, 563);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(194, 58);
            buttonSalir.TabIndex = 48;
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Image = (Image)resources.GetObject("buttonRegresar.Image");
            buttonRegresar.Location = new Point(37, 286);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 97);
            buttonRegresar.TabIndex = 49;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // FormEliminarDisco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1302, 633);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxId);
            Controls.Add(labeltxtDiscoaEliminar);
            Controls.Add(buttonMusica);
            Controls.Add(buttonUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(labelAdministrador);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(labeltxtEliminardisco);
            Name = "FormEliminarDisco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += FormEliminarDisco_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMusica;
        private Button buttonUsuario;
        private PictureBox pictureBox1;
        private Label labelAdministrador;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
        private Label labeltxtEliminardisco;
        private Label labeltxtDiscoaEliminar;
        private TextBox textBoxId;
        private Button buttonEnter;
        private Button buttonSalir;
        private Button buttonRegresar;
    }
}