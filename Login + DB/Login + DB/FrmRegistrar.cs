using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login___DB
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Visual Studio 2022\Login + DB\Login + DB\bin\Debug\DB_Login.accdb;Persist Security Info=False;";
        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            string Id = txt_Id.Text;
            string Nombre = txt_Nombre.Text;
            string Contraseña = txt_Contraseña.Text;
            string Correo = txt_Correo.Text;
            string TipoUsuario = txt_TipoUsuario.Text;

            // Verificar si el usuario ya existe en la base de datos
            bool userExists = CheckUserExists( Nombre);

            if (userExists)
            {
                MessageBox.Show("El nombre de usuario ya está registrado");
            }
            else
            {
                // Insertar el nuevo usuario en la base de datos
                bool registrationSuccess = RegisterUser(Id, Nombre, Contraseña, Correo, TipoUsuario);

                if (registrationSuccess)
                {
                    MessageBox.Show("Registro exitoso");
                    // Puedes realizar otras acciones después del registro exitoso, como abrir el formulario de inicio de sesión.
                    this.Hide();
                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario");
                }
            }
        }
        private bool CheckUserExists( string Nombre)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Abrir la conexión a la base de datos
                connection.Open();

                // Construir la consulta SQL para verificar si el usuario ya existe
                string query = "SELECT COUNT(*) FROM tblUsuario WHERE Nombre = @Nombre ";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);

                // Ejecutar la consulta y obtener el resultado
                int count = (int)command.ExecuteScalar();

                // Si el recuento es mayor que cero, el usuario ya existe
                return count > 0;
            }
        }

        private bool RegisterUser(string Id, string Nombre, string Contraseña, string Correo, string TipoUsuario)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Abrir la conexión a la base de datos
                connection.Open();

                // Construir la consulta SQL para insertar el nuevo usuario
                string query = "INSERT INTO tblUsuario (Id,Nombre, Contraseña, Correo, TipoUsuario) VALUES (@Id, @Nombre, @Contraseña, @Correo, @TipoUsuario)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Contraseña", Contraseña);
                command.Parameters.AddWithValue(" @Correo", Correo);
                command.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);

                // Ejecutar la consulta y obtener el número de filas afectadas
                int rowsAffected = command.ExecuteNonQuery();

                // Si se afectó una fila, el registro fue exitoso
                return rowsAffected > 0;
            }
        }

        private void txt_Id_Enter(object sender, EventArgs e)
        {
            if (txt_Id.Text == "ID")
            {
                txt_Id.Text = "";
                txt_Id.ForeColor = Color.LightGray;
            }
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            if (txt_Id.Text == "")
            {
                txt_Id.Text = "ID";
                txt_Id.ForeColor = Color.DimGray;
            }
        }

        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "Nombre")
            {
                txt_Nombre.Text = "";
                txt_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                txt_Nombre.Text = "Nombre";
                txt_Nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "Contraseña")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.LightGray;
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "Contraseña";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "Correo")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "Correo";
                txt_Correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_TipoUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_TipoUsuario.Text == "Tipo de Usuario")
            {
                txt_TipoUsuario.Text = "";
                txt_TipoUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_TipoUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_TipoUsuario.Text == "")
            {
                txt_TipoUsuario.Text = "Tipo de Usuario";
                txt_TipoUsuario.ForeColor = Color.DimGray;
            }
        }
    }
}
