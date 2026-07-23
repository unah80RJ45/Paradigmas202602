using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Matricula
{
    public partial class frmLogin : Form
    {
        private SqlConnection conexion;
        private bool conectado;

        public SqlConnection Conexion => conexion;
        public bool Conectado => conectado;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "Server = " + txtServidor.Text + "; DataBase = " + txtBaseDatos.Text + 
                             "; User ID = " + txtUsuario.Text + "; Password = " + txtPassword.Text;
                conexion = new SqlConnection(url);
                conectado = false;
                conexion.Open ();
                conectado = true;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Number == 18456)
                    MessageBox.Show("Error con el usuario", "Error - " + ex.Errors[0].Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error - " + ex.Errors[0].Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
