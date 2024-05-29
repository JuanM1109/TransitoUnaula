using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransitoUnaula
{
    public partial class Agentes : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Agentes instance = null;
        public static Agentes Singleton()
        {
            if (instance == null)
            {
                instance = new Agentes();
                return instance;
            }
            return instance;
        }
        public Agentes()
        {
            InitializeComponent();

        }
        public void BtnAgregarAgenteInvisible()
        {
            btnAgregarAgente.Visible = false;
        }
        public void BtnModificarAgenteInvisible()
        {
            btnModificarAgente.Visible = false;
        }

        private void Agentes_Load(object sender, EventArgs e)
        {

        }

        private void Agentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Admin admin = Admin.Singleton();
                Agentes agentes = Agentes.Singleton();
                agentes.Hide();
                admin.Show();
                admin.BringToFront();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = Admin.Singleton();
            admin.Show();
        }

        private void btnAgregarAgente_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaAgente.Text;
            string nombre = txtNombreAgente.Text;
            string apellido = txtApellidoAgente.Text;
            if (!int.TryParse(txtEdadAgente.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
                return;
            }
            if (!float.TryParse(txtSalario.Text, out float salario))
            {
                MessageBox.Show("Por favor, ingresa un salario válido.");
                return;
            }
            string telefono = txtTelefonoAgente.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertarAgente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Salario", salario);
                        command.Parameters.AddWithValue("@Telefono", telefono);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Agente insertado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el agente: " + ex.Message);
                }
            }
        }

        private void btnModificarAgente_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaAgente.Text;
            string nombre = txtNombreAgente.Text;
            string apellido = txtApellidoAgente.Text;
            if (!int.TryParse(txtEdadAgente.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
                return;
            }
            if (!float.TryParse(txtSalario.Text, out float salario))
            {
                MessageBox.Show("Por favor, ingresa un salario válido.");
                return;
            }
            string telefono = txtTelefonoAgente.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ModificarAgente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Salario", salario);
                        command.Parameters.AddWithValue("@Telefono", telefono);

                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Agente modificado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el agente: " + ex.Message);
                }
            }
        }
    }
}
