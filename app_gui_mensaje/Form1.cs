using System.Windows.Forms;

namespace app_gui_mensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollo de aplicaciones");


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Desea salir de la aplicacion?", "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }




        }
    }
}
