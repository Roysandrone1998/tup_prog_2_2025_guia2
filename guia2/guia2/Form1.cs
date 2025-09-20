using guia2.Models;

namespace guia2
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();

            if (formDatos.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(formDatos.textBox1.Text);
                string nombre = formDatos.textBox2.Text;

                Persona nueva = new Persona(dni, nombre);
                if (servicio.AgregarPersona(nueva) == true)
                {
                    MessageBox.Show("se agrego la persona.");
                }
                else
                {
                    MessageBox.Show("error mismo dni");
                }

                

                
            }
        }
    }
}
