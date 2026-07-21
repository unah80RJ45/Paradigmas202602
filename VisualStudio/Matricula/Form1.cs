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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "Server=3.128.144.165; DataBase=PP202602; User ID=db2; Password=123";
                SqlConnection conexion = new SqlConnection( url );
                SqlCommand cmd = new SqlCommand("insert into Maestro values(@codigo, @nombre)", conexion);
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close(); 

                txtCodigo.Clear(); txtNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string url = "Server=3.128.144.165; DataBase=PP202602; User ID=db2; Password=123";
                SqlConnection conexion = new SqlConnection(url);
                SqlCommand cmd = new SqlCommand("select * from Maestro where MaestroID = " + txtCodigo.Text, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["nombre"].ToString();
                    conexion.Close();
                }
                else
                    MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
