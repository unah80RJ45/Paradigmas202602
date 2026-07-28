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
    public partial class frmMenu : Form
    {
        SqlConnection connect;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.Conectado)
            {
                connect = frm.Conexion;
            }
            else
                Close();
        }

        private void cmdAlumno_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno(connect);
            frm.ShowDialog();
        }
    }
}
