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


    public partial class Admin : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Admin instance = null;
        public static Admin Singleton()
        {
            if (instance == null)
            {
                instance = new Admin();
                return instance;
            }
            return instance;
        }

        public Admin()
        {
            InitializeComponent();
        }

        private void tsmiMultas_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiGenerarMulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multas multas = Multas.Singleton();
            multas.Show();
        }

        private void tsmiAgregarMultados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multados multados = Multados.Singleton();
            multados.BtnModificarMultadoInvisible();
            multados.Show();
        }

        private void tsmiModificarMultados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multados multados = Multados.Singleton();
            multados.BtnAgregarMultadoInvisible();
            multados.Show();
        }

        private void tsmiAgregarVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehiculos vehiculos = Vehiculos.Singleton();
            vehiculos.BtnModificarVehiculoInvisible();
            vehiculos.Show();
        }

        private void tsmiModificarVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehiculos vehiculos = Vehiculos.Singleton();
            vehiculos.BtnAgregarVehiculoInvisible();
            vehiculos.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agentes agentes = Agentes.Singleton();
            agentes.BtnModificarAgenteInvisible();
            agentes.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agentes agentes = Agentes.Singleton();
            agentes.BtnAgregarAgenteInvisible();
            agentes.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Login login = Login.Singleton();
                Admin admin = Admin.Singleton();
                admin.Hide();
                login.Show();
                login.BringToFront();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedulaInfractor;
            if (int.TryParse(txtCedula.Text, out cedulaInfractor))
            {
                ObtenerMultasPorCedula(cedulaInfractor);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido.");
            }
        }

        private void ObtenerMultasPorCedula(int cedulaInfractor)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand("ObtenerMultasPorCedula", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@CedulaInfractor", cedulaInfractor);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaMultas = new DataTable();

                    conexion.Open();
                    adaptador.Fill(tablaMultas);
                    conexion.Close();

                    dgvMultas.DataSource = tablaMultas;
                }
            }
        }
    }
}
