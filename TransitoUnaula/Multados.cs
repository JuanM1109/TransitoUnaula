using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransitoUnaula
{
    public partial class Multados : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Multados instance = null;
        public static Multados Singleton()
        {
            if (instance == null)
            {
                instance = new Multados();
                return instance;
            }
            return instance;
        }
        public Multados()
        {
            InitializeComponent();
        }

        private void Multados_Load(object sender, EventArgs e)
        {

        }
        public void BtnAgregarMultadoInvisible()
        {
            btnAgregarMultado.Visible = false;
        }
        public void BtnModificarMultadoInvisible()
        {
            btnModificarMultado.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = Admin.Singleton();
            admin.Show();
            this.Hide();         
        }

        private void Multados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Admin admin = Admin.Singleton();
                Multados multados = Multados.Singleton();
                multados.Hide();
                admin.Show();
                admin.BringToFront();
            }
        }

        private void btnAgregarMultado_Click(object sender, EventArgs e)
        {
            string cedula = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertarInfractor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Direccion", direccion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Multado insertado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el multado: " + ex.Message);
                }
            }
        }

        private void btnModificarMultado_Click(object sender, EventArgs e)
        {
            string cedula = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ModificarInfractor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Direccion", direccion);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Infractor modificado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el infractor: " + ex.Message);
                }
            }
        }
    }
}
