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
    public partial class Register : Form
    {

        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Register instance = null;
        public static Register Singleton()
        {
            if (instance == null)
            {
                instance = new Register();
                return instance;
            }
            return instance;
        }

        public Register()
        {
            InitializeComponent();

            wmpRegister.uiMode = "none";
            wmpRegister.URL = "videoRegister.mp4";
            wmpRegister.settings.mute = true;
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usuario = txtEmail.Text;
            string clave = txtClave.Text;
            string Rclave = txtRclave.Text;

            if (clave != Rclave)
            {
                MessageBox.Show("Contraseñas no coinciden","Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtClave.Text = string.Empty; txtRclave.Text = string.Empty;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("InsertarUsuario", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            // Agregar los parámetros al comando
                            command.Parameters.AddWithValue("@Usuario", usuario);
                            command.Parameters.AddWithValue("@Contraseña", clave);         

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cuenta creada.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear la cuenta: " + ex.Message);
                    }
                }
            }
        }

        private void wmpRegister_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (s, ev) =>
                {
                    wmpRegister.URL = "videoRegister.mp4";
                    wmpRegister.settings.mute = true;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void wmpRegister_Enter(object sender, EventArgs e)
        {

        }
    }
}
