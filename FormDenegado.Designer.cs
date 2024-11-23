namespace Vista_Administrador
{
    partial class FormDenegado
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
            labeltxtAviso = new Label();
            labelLimite = new Label();
            labelRestriccion = new Label();
            buttonRegresa = new Button();
            SuspendLayout();
            // 
            // labeltxtAviso
            // 
            labeltxtAviso.BackColor = Color.Transparent;
            labeltxtAviso.Font = new Font("Consolas", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltxtAviso.ForeColor = Color.White;
            labeltxtAviso.Location = new Point(89, 22);
            labeltxtAviso.Name = "labeltxtAviso";
            labeltxtAviso.Size = new Size(323, 86);
            labeltxtAviso.TabIndex = 8;
            labeltxtAviso.TextAlign = ContentAlignment.MiddleCenter;
            labeltxtAviso.Click += labeltxtAviso_Click;
            // 
            // labelLimite
            // 
            labelLimite.BackColor = Color.Transparent;
            labelLimite.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLimite.ForeColor = Color.White;
            labelLimite.Location = new Point(89, 210);
            labelLimite.Name = "labelLimite";
            labelLimite.Size = new Size(323, 36);
            labelLimite.TabIndex = 9;
            labelLimite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRestriccion
            // 
            labelRestriccion.BackColor = Color.Transparent;
            labelRestriccion.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRestriccion.ForeColor = Color.White;
            labelRestriccion.Location = new Point(49, 145);
            labelRestriccion.Name = "labelRestriccion";
            labelRestriccion.Size = new Size(414, 36);
            labelRestriccion.TabIndex = 10;
            labelRestriccion.TextAlign = ContentAlignment.MiddleCenter;
            labelRestriccion.Click += labelRestriccion_Click;
            // 
            // buttonRegresa
            // 
            buttonRegresa.FlatStyle = FlatStyle.Popup;
            buttonRegresa.Image = Properties.Resources.Captura_de_pantalla_2024_11_22_225105;
            buttonRegresa.Location = new Point(443, 12);
            buttonRegresa.Name = "buttonRegresa";
            buttonRegresa.Size = new Size(61, 47);
            buttonRegresa.TabIndex = 11;
            buttonRegresa.UseVisualStyleBackColor = true;
            buttonRegresa.Click += buttonRegresa_Click;
            // 
            // FormDenegado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(516, 274);
            Controls.Add(buttonRegresa);
            Controls.Add(labelRestriccion);
            Controls.Add(labelLimite);
            Controls.Add(labeltxtAviso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDenegado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += FormDenegado_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labeltxtAviso;
        private Label labelLimite;
        private Label labelRestriccion;
        private Button buttonRegresa;
    }
}