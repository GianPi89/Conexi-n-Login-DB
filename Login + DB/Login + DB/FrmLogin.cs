using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login___DB
{
    public partial class FrmLogin : Form
    {
        OleDbConnection conexion = new OleDbConnection();

         
        public FrmLogin()
        {
            InitializeComponent();
            conexion.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Documents\Visual Studio 2022\Login + DB\Login + DB\bin\Debug\DB_Login.accdb;";

        }
        

        private void tblPersonaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPersonaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TiendaDataSet);

        }

        private void tblPersonaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPersonaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TiendaDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conexión Exitosa");
                conexion.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al conectar", "ERROR" + a.ToString());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            if (txt_Nombre.Text == string.Empty || txt_Contraseña.Text == string.Empty)
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            string Nombre = txt_Nombre.Text;
            string Contraseña= txt_Contraseña.Text;

            conexion.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tblUsuario WHERE Nombre ='" + txt_Nombre.Text + "'and Contraseña='" + txt_Contraseña.Text + "'", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int contador = dt.Rows.Count;
            if (contador > 0)
            {
                string tipo = dt.Rows[0]["TipoUsuario"].ToString();
                if (tipo == "1")
                {
                    MessageBox.Show("Usuario Admin");
                }
                else if (tipo == "2")
                {
                    MessageBox.Show("Usuario Estandar");
                }
                else
                {
                    MessageBox.Show("Usuario no Autorizado");
                }
            }
            
            conexion.Close();
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

        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar frm = new FrmRegistrar();
            frm.Show();
        }
    }
}
