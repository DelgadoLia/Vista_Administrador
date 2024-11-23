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
    public partial class FormAgregarDisco : Form
    {
        public static int opcion = 1;//Identiificador del Form, se usa apara
                                     //saber que se debe imprimir en el formDenegado

        public static bool s = false;//ESTA VARIABLE SE ELIMINARA, es solo para
                                    //probar si funciona el FormDenegado

        public FormAgregarDisco()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cierra el FormAgregarDisco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAgregarDisco_Load(object sender, EventArgs e)
        {

        }
    }
}
