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
    public partial class Multas : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";


        private static Multas instance = null;
        public static Multas Singleton()
        {
            if (instance == null)
            {
                instance = new Multas();
                return instance;
            }
            return instance;
        }

        public Multas()
        {
            InitializeComponent();

            CargarDepartamentos();

            CargarAgentes();

            CargarInfracciones();
        }

        private void Multas_Load(object sender, EventArgs e)
        {

        }

        private void Multas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Admin admin = Admin.Singleton();
                Multas multas = Multas.Singleton();
                multas.Hide();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            cbAgente.Text = string.Empty;
            cbCiudad.Text = string.Empty;
            cbDepartamento.Text = string.Empty;
            cbFotomulta.Text = string.Empty;
            cbInfraccion.Text = string.Empty;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string descripcion = txtDescripcion.Text;
            string agente = cbAgente.Text;
            DateTime fecha = dtpFecha.Value;
            string direccion = txtDireccion.Text;
            string ciudad = cbCiudad.Text;
            string departamento = cbDepartamento.Text;
            bool fotomulta = cbFotomulta.SelectedItem.ToString().ToLower() == "Si" ? true : false;
            string infractor = txtIdentificacion.Text;
            int infraccion = ObtenerIdporDescripcion();
            float precio = Convert.ToSingle(txtPrecio.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertarMulta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Placa", placa);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@Agente", agente);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Ciudad", ciudad);
                        command.Parameters.AddWithValue("@Departamento", departamento);
                        command.Parameters.AddWithValue("@Fotomulta", fotomulta);
                        command.Parameters.AddWithValue("@Infractor", infractor);
                        command.Parameters.AddWithValue("@Infraccion", infraccion);
                        command.Parameters.AddWithValue("@Precio", precio);


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Multa insertada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la multa: " + ex.Message);
                }
            }
        }

        private void btnModificarMulta_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string descripcion = txtDescripcion.Text;
            string agente = cbAgente.Text;
            DateTime fecha = dtpFecha.Value;
            string direccion = txtDireccion.Text;
            int ciudad = ObtenerIdporNombre();
            int departamento = ObtenerIdporNombreDepartamento();
            bool fotomulta = cbFotomulta.SelectedItem.ToString().ToLower() == "Si" ? true : false;
            string infractor = txtIdentificacion.Text;
            int infraccion = ObtenerIdporDescripcion();
            float precio = Convert.ToSingle(txtPrecio.Text);
            int idMulta = Convert.ToInt32(cbIdMulta.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ModificarMulta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IdMulta", idMulta);
                        command.Parameters.AddWithValue("@Placa", placa);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@Agente", agente);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Ciudad", ciudad);
                        command.Parameters.AddWithValue("@Departamento", departamento);
                        command.Parameters.AddWithValue("@Fotomulta", fotomulta);
                        command.Parameters.AddWithValue("@Infractor", infractor);
                        command.Parameters.AddWithValue("@Infraccion", infraccion);
                        command.Parameters.AddWithValue("@Precio", precio);


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Multa modificada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la multa: " + ex.Message);
                }
            }
        }

        private void CargarDepartamentos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ObtenerDepartamentos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Enlazar los datos al ComboBox
                            cbDepartamento.DataSource = dataTable;
                            cbDepartamento.DisplayMember = "NombreDepartamento"; // Mostrar el nombre del departamento
                            cbDepartamento.ValueMember = "Codigo"; // Utilizar el código como valor seleccionado
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los departamentos: " + ex.Message);
                }
            }
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idDepartamento = Convert.ToInt32(((DataRowView)cbDepartamento.SelectedItem)["Codigo"]);

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "EXEC ObtenerCiudadesPorDepartamento @IdDepartamento";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdDepartamento", idDepartamento);

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                cbCiudad.Items.Clear(); // Limpiar los elementos anteriores en el ComboBox de ciudades

                while (lector.Read())
                {
                    string nombreCiudad = lector["NombreCiudad"].ToString();
                    cbCiudad.Items.Add(nombreCiudad);
                }

                lector.Close();
            }
        }

        private void CargarAgentes()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "EXEC ObtenerCedulaAgente";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                cbAgente.Items.Clear(); // Limpiar los elementos anteriores en el ComboBox de agentes

                while (lector.Read())
                {
                    string nombreAgente = lector["Cedula"].ToString();
                    cbAgente.Items.Add(nombreAgente);
                }

                lector.Close();
            }
        }

        private void CargarInfracciones()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "EXEC ObtenerInfracciones";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                cbInfraccion.Items.Clear(); // Limpiar los elementos anteriores en el ComboBox de agentes

                while (lector.Read())
                {
                    string descripcion = lector["Descripcion"].ToString();
                    cbInfraccion.Items.Add(descripcion);
                }

                lector.Close();
            }
        }

        public int ObtenerIdporDescripcion()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand("ObtenerCodigoInfraccion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Descripcion", cbInfraccion.SelectedItem.ToString());

                    conexion.Open();

                    int codigoInfraccion = Convert.ToInt32(comando.ExecuteScalar());

                    return codigoInfraccion;
                }
            }
        }

        public int ObtenerIdporNombre()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand("ObtenerIdPorNombre", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NombreCiudad", cbCiudad.SelectedItem.ToString());

                    conexion.Open();

                    int codigoCiudad = Convert.ToInt32(comando.ExecuteScalar());

                    return codigoCiudad;
                }
            }
        }

        public int ObtenerIdporNombreDepartamento()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand("ObtenerIdPorNombre", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NombreCiudad", cbDepartamento.SelectedItem.ToString());

                    conexion.Open();

                    int codigoDepartamento = Convert.ToInt32(comando.ExecuteScalar());

                    return codigoDepartamento;
                }
            }
        }
    }
}
