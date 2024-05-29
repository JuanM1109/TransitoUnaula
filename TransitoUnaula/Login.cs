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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TransitoUnaula
{
    public partial class Login : Form
    {
        private string connectionString = "Server=DESKTOP-E4V4E5U;Database=dbTransito;Integrated Security=true;";

        private static Login instance = null;
        public static Login Singleton()
        {
            if (instance == null)
            {
                instance = new Login();
                return instance;
            }
            return instance;
        }

        public Login()
        {
            InitializeComponent();   
        }
        private void Login_Load(object sender, EventArgs e)
        {
            wmpLogin.uiMode = "none";
            wmpLogin.URL = "videoLogin.mp4";
        }
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
        private void wmpLogin_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (s, ev) =>
                {
                    wmpLogin.URL = "videoLogin.mp4";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string usuario = txtEmail.Text;
            string clave = txtClave.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("LoginUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", clave);

                        bool acceso = Convert.ToBoolean(command.ExecuteScalar());

                        if (!acceso)
                        {
                            using (SqlCommand cmd = new SqlCommand("LoginAdministrador", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@Usuario", usuario);
                                cmd.Parameters.AddWithValue("@Contraseña", clave);

                                bool accesoAdmin = Convert.ToBoolean(cmd.ExecuteScalar());

                                if (!accesoAdmin)
                                {
                                    MessageBox.Show("Cuenta Inexistente");
                                }
                                else
                                {
                                    this.Hide();
                                    Admin admin = new Admin();
                                    admin.Show();
                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            Usuario usuario1 = new Usuario();
                            usuario1.Show();
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, no se ha encontrado ninguna cuenta con estas credenciales" + ex.Message);
                }
            }
        }
    }
}
