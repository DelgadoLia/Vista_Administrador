namespace Vista_Administrador
{
    partial class FormAdminMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            labelMenu = new Label();
            buttonAgregarDisco = new Button();
            buttonVentasTotales = new Button();
            buttonEliminaDisco = new Button();
            buttonGraficas = new Button();
            buttonListado = new Button();
            buttonSalir = new Button();
            buttonMusica = new Button();
            buttonUsuario = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            labelLinea = new Label();
            labelTitulo = new Label();
            labelFrase = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(602, 193);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(79, 36);
            labelMenu.TabIndex = 7;
            labelMenu.Text = "MENU";
            labelMenu.Click += label3_Click;
            // 
            // buttonAgregarDisco
            // 
            buttonAgregarDisco.FlatStyle = FlatStyle.Popup;
            buttonAgregarDisco.Image = (Image)resources.GetObject("buttonAgregarDisco.Image");
            buttonAgregarDisco.Location = new Point(183, 269);
            buttonAgregarDisco.Name = "buttonAgregarDisco";
            buttonAgregarDisco.Size = new Size(247, 102);
            buttonAgregarDisco.TabIndex = 7;
            buttonAgregarDisco.Text = "button3";
            buttonAgregarDisco.UseVisualStyleBackColor = true;
            buttonAgregarDisco.Click += buttonAgregarDisco_Click;
            // 
            // buttonVentasTotales
            // 
            buttonVentasTotales.FlatStyle = FlatStyle.Popup;
            buttonVentasTotales.Image = (Image)resources.GetObject("buttonVentasTotales.Image");
            buttonVentasTotales.Location = new Point(503, 269);
            buttonVentasTotales.Name = "buttonVentasTotales";
            buttonVentasTotales.Size = new Size(247, 102);
            buttonVentasTotales.TabIndex = 8;
            buttonVentasTotales.Text = "button4";
            buttonVentasTotales.UseVisualStyleBackColor = true;
            buttonVentasTotales.Click += button4_Click;
            // 
            // buttonEliminaDisco
            // 
            buttonEliminaDisco.FlatStyle = FlatStyle.Popup;
            buttonEliminaDisco.Image = (Image)resources.GetObject("buttonEliminaDisco.Image");
            buttonEliminaDisco.Location = new Point(841, 269);
            buttonEliminaDisco.Name = "buttonEliminaDisco";
            buttonEliminaDisco.Size = new Size(245, 102);
            buttonEliminaDisco.TabIndex = 9;
            buttonEliminaDisco.Text = "button5";
            buttonEliminaDisco.UseVisualStyleBackColor = true;
            buttonEliminaDisco.Click += buttonEliminaDisco_Click;
            // 
            // buttonGraficas
            // 
            buttonGraficas.FlatStyle = FlatStyle.Popup;
            buttonGraficas.Image = (Image)resources.GetObject("buttonGraficas.Image");
            buttonGraficas.Location = new Point(349, 412);
            buttonGraficas.Name = "buttonGraficas";
            buttonGraficas.Size = new Size(247, 102);
            buttonGraficas.TabIndex = 10;
            buttonGraficas.Text = "button6";
            buttonGraficas.UseVisualStyleBackColor = true;
            // 
            // buttonListado
            // 
            buttonListado.FlatStyle = FlatStyle.Popup;
            buttonListado.Image = (Image)resources.GetObject("buttonListado.Image");
            buttonListado.Location = new Point(705, 412);
            buttonListado.Name = "buttonListado";
            buttonListado.Size = new Size(247, 102);
            buttonListado.TabIndex = 11;
            buttonListado.Text = "button7";
            buttonListado.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.Location = new Point(555, 558);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(187, 50);
            buttonSalir.TabIndex = 13;
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonMusica
            // 
            buttonMusica.FlatStyle = FlatStyle.Popup;
            buttonMusica.Image = (Image)resources.GetObject("buttonMusica.Image");
            buttonMusica.Location = new Point(1093, 45);
            buttonMusica.Name = "buttonMusica";
            buttonMusica.Size = new Size(93, 89);
            buttonMusica.TabIndex = 21;
            buttonMusica.UseVisualStyleBackColor = true;
            // 
            // buttonUsuario
            // 
            buttonUsuario.FlatStyle = FlatStyle.Popup;
            buttonUsuario.Image = Properties.Resources.Captura_de_pantalla_2024_11_21_093731;
            buttonUsuario.Location = new Point(1182, 45);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(93, 89);
            buttonUsuario.TabIndex = 16;
            buttonUsuario.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.LOGO1;
            pictureBox1.Location = new Point(28, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(422, 112);
            label2.Name = "label2";
            label2.Size = new Size(455, 50);
            label2.TabIndex = 20;
            label2.Text = "A D M I N I S T R A D O R\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 183);
            label1.Name = "label1";
            label1.Size = new Size(893, 3);
            label1.TabIndex = 19;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLinea
            // 
            labelLinea.AutoSize = true;
            labelLinea.BackColor = Color.White;
            labelLinea.Font = new Font("Consolas", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLinea.ForeColor = Color.White;
            labelLinea.Location = new Point(194, 92);
            labelLinea.Name = "labelLinea";
            labelLinea.Size = new Size(893, 3);
            labelLinea.TabIndex = 18;
            labelLinea.Text = resources.GetString("labelLinea.Text");
            labelLinea.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(401, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(493, 50);
            labelTitulo.TabIndex = 14;
            labelTitulo.Text = "T U R N T A B L E   T A L E S";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFrase
            // 
            labelFrase.AutoSize = true;
            labelFrase.BackColor = Color.Transparent;
            labelFrase.ForeColor = Color.White;
            labelFrase.Location = new Point(522, 64);
            labelFrase.Name = "labelFrase";
            labelFrase.Size = new Size(264, 18);
            labelFrase.TabIndex = 15;
            labelFrase.Text = "\"TU VIDA, TU MUSICA, TU VINILO.\"\r\n";
            // 
            // FormAdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1302, 633);
            Controls.Add(buttonMusica);
            Controls.Add(buttonUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLinea);
            Controls.Add(labelTitulo);
            Controls.Add(labelFrase);
            Controls.Add(buttonSalir);
            Controls.Add(buttonListado);
            Controls.Add(buttonGraficas);
            Controls.Add(buttonEliminaDisco);
            Controls.Add(buttonVentasTotales);
            Controls.Add(buttonAgregarDisco);
            Controls.Add(labelMenu);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormAdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMenu;
        private Button buttonAgregarDisco;
        private Button buttonVentasTotales;
        private Button buttonEliminaDisco;
        private Button buttonGraficas;
        private Button buttonListado;
        private Button buttonSalir;
        private Button buttonMusica;
        private Button buttonUsuario;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label labelLinea;
        private Label labelTitulo;
        private Label labelFrase;
    }
}
