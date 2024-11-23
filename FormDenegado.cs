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
    public partial class FormDenegado : Form
    {
        private int opc;//Recibe por referencia un numero para saber lo que se va a imprimir
        public FormDenegado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con parametros
        /// Recibe el identificador del Form en el cual se dio clik para asi saber que informacion 
        /// debe imprimir
        /// </summary>
        /// <param name="opc"></param>
        public FormDenegado(int opc)
        {
            InitializeComponent();
            this.opc = opc;
        }

        /// <summary>
        /// ImprimeAviso(), ImprimirRestriccion(), ImprimirLimite()
        /// Dos Forms son los que requieren del el FormDenegado, a cada uno se le asigno un numero, este se recibe como
        /// referencia y se usa para saber que informacion imprimir, si es uno se imprimira la informacion para
        /// FormAgregarDisco, y si es dos se imprimira la informacion de FormEliminarDisco
        /// </summary>
        private void ImprimeAviso()
        {
            if (opc == 1)
            {
                labeltxtAviso.Text = "NO SE PUEDE AGREGAR DISCO";
            }//if
            else
            {
                labeltxtAviso.Text = "NO SE PUEDE ELIMINAR DISCO";
            }//else
        }//ImprimeAviso

        private void ImprimirRestriccion()
        {
            if (opc == 1)
            {
                labelRestriccion.Text = "NÚMERO MÁXIMO DE DISCOS ALCANZADO";
            }//if
            else
            {
                labelRestriccion.Text = "NÚMERO MINIMO DE DISCOS ALCANZADO";
            }//else
        }//ImprimeRestricciones
        private void ImprimirLimite()
        {
            if (opc == 1)
            {
                labelLimite.Text = "10/10 DISCOS";
            }//if
            else
            {
                labelLimite.Text = "6/10 DISCOS";
            }//else
        }//ImprimirLimite

        /// <summary>
        /// FormDenegado_Load
        /// Al cargar el FormDenegado esta funcion se ejecuta automaticamente, mandando llamar a las fucniones que 
        /// cambian la informacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDenegado_Load(object sender, EventArgs e)
        {
            ImprimeAviso();
            ImprimirRestriccion();
            ImprimirLimite();
        }

        private void labeltxtAviso_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cierra el Formulario buttonRegresa_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelRestriccion_Click(object sender, EventArgs e)
        {

        }
    }
}
