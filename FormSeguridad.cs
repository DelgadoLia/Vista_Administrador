using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Administrador
{
    public partial class FormSeguridad : Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }

        //SE TENDRA QUE REALIZAR UN CONSTRUCTOR CON PARAMETROS PARA PASAR EL ID
        //DEL DISCO A ELIMINAR

        private void labeltxtImagen_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
