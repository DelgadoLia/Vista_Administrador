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
    public partial class FormEliminarDisco : Form
    {
        public static int opcion = 2;//Identiificador del Form, se usa apara
                                     //saber que se debe imprimir en el formDenegado

        public static bool s = false;//ESTA VARIABLE SE ELIMINARA, es solo para
                                     //probar si funciona el FormDenegado
        public FormEliminarDisco()
        {
            InitializeComponent();
        }

        private void FormEliminarDisco_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //CAMBIAR A CONSTRUCTOR CON PARAMETROS
            //PONER RESTRICCION PARA ASEGURAR QUE SE HAYA INSERTADO ID
            FormSeguridad formSeguridad = new FormSeguridad();
            formSeguridad.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
