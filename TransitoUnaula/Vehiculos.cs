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
    public partial class Vehiculos : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Vehiculos instance = null;
        public static Vehiculos Singleton()
        {
            if (instance == null)
            {
                instance = new Vehiculos();
                return instance;
            }
            return instance;
        }
        public Vehiculos()
        {
            InitializeComponent();

            CargarCedula();
        }
        public void BtnAgregarVehiculoInvisible()
        {
            btnAñadirVehiculo.Visible = false;
        }
        public void BtnModificarVehiculoInvisible()
        {
            btnModificarVehiculo.Visible = false;
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = Admin.Singleton();
            admin.Show();
        }

        private void Vehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Admin admin = Admin.Singleton();
                Vehiculos vehiculos = Vehiculos.Singleton();
                vehiculos.Hide();
                admin.Show();
                admin.BringToFront();
            }
        }

        private void btnAñadirVehiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string tipo = cbTipo.Text;
            string propietario = cbPropietario.Text;
            string color = txtColor.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertarVehiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@Placa", placa);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Propietario", propietario);
                        command.Parameters.AddWithValue("@Color", color);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Vehículo insertado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el vehículo: " + ex.Message);
                }
            }
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string tipo = cbTipo.Text;
            string propietario = cbPropietario.Text;
            string color = txtColor.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ModificarVehiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@Placa", placa);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Propietario", propietario);
                        command.Parameters.AddWithValue("@Color", color);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Vehículo modificado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el vehículo: " + ex.Message);
                }
            }
        }

        private void CargarCedula()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "EXEC ObtenerCedula";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                cbPropietario.Items.Clear(); // Limpiar los elementos anteriores en el ComboBox de agentes

                while (lector.Read())
                {
                    string cedula = lector["Cedula"].ToString();
                    cbPropietario.Items.Add(cedula);
                }

                lector.Close();
            }
        }
    }
}
