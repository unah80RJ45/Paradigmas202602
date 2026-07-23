using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class frmMenu : Form
    {
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
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else
                Close();
        }
    }
}
