namespace Vista_Administrador
{
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        } 

        /// <summary>
        /// buttonAgregarDisco_Clic
        /// En caso de que se puedan agregar discos mandara llamar al FomrAgregarDisco, para luego volver
        /// Si no mandara llamar al FormDenegado, mandando como parametro el identificador que tiene el
        /// FormAgregarDisco, para asi saber que imprimir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarDisco_Click(object sender, EventArgs e)
        {
            if (!FormAgregarDisco.s)
            {
                FormAgregarDisco formAgregarDisco = new FormAgregarDisco();
                this.Hide();
                formAgregarDisco.ShowDialog();
                this.Show();
            }//if
            else//En caso de que este lleno sale la restriccion
            {
                FormDenegado formDenegado = new FormDenegado(FormAgregarDisco.opcion);
                formDenegado.ShowDialog();
            }//else

        }//buttonAgregarDisco_Clic

        /// <summary>
        /// buttonEliminaDisco_Click
        /// En caso de que se puedan agregar discos mandara llamar al FomrEliminaDisco, para luego volver
        /// Si no mandara llamar al FormDenegado, mandando como parametro el identificador que tiene el
        /// FomrEliminaDisco, para asi saber que imprimir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminaDisco_Click(object sender, EventArgs e)
        {
            if (!FormEliminarDisco.s)
            {
                FormEliminarDisco formEliminarDisco = new FormEliminarDisco();
                this.Hide();
                formEliminarDisco.ShowDialog();
                this.Show();
            }//if
            else//En caso de que este lleno sale la restriccion
            {
                FormDenegado formDenegado = new FormDenegado(FormEliminarDisco.opcion);
                formDenegado.ShowDialog();
            }//else
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
