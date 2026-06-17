using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public partial class frmEmpleado : Form
    {
        Empleado empleado = new Empleado();
        public frmEmpleado()
        {
            InitializeComponent();
        }
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empleado.SELECT();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            DataRow nRow = empleado.tabEmpleado.NewRow();
            nRow["codigo"] = txtCodigo.Text;
            nRow["nombre"] = txtNombre.Text;
            nRow["sueldo"] = txtSueldo.Text;

            empleado.INSERT(nRow);
            txtCodigo.Clear(); txtNombre.Clear(); txtSueldo.Clear();
        }
    }
}
