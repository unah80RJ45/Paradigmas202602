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
    public partial class frmAlumno : Form
    {
        SqlDataAdapter adpAlumno;
        DataTable tabAlumno;

        public frmAlumno()
        {
            InitializeComponent();
        }
        public frmAlumno(SqlConnection cnx)
        {
            InitializeComponent();

            adpAlumno = new SqlDataAdapter();
            adpAlumno.SelectCommand = new SqlCommand("select AlumnoID as Codigo, Nombre, Sexo, Civil, CarreraID from alumno", cnx);

            adpAlumno.InsertCommand = new SqlCommand("insert into Alumno values(@alu, @nom, @sex, @civ, @car)", cnx);
            adpAlumno.InsertCommand.Parameters.Add("@alu", SqlDbType.Int, 4, "Codigo");
            adpAlumno.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "Nombre");
            adpAlumno.InsertCommand.Parameters.Add("@sex", SqlDbType.VarChar, 1, "Sexo");
            adpAlumno.InsertCommand.Parameters.Add("@civ", SqlDbType.VarChar, 1, "Civil");
            adpAlumno.InsertCommand.Parameters.Add("@car", SqlDbType.Int, 4, "CarreraID");

            adpAlumno.UpdateCommand = new SqlCommand("update Alumno set Nombre = @nom, Sexo = @sex,  Civil = @civ, CarreraID = @car where AlumnoID = @alu", cnx);
            adpAlumno.UpdateCommand.Parameters.Add("@alu", SqlDbType.Int, 4, "Codigo");
            adpAlumno.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "Nombre");
            adpAlumno.UpdateCommand.Parameters.Add("@sex", SqlDbType.VarChar, 1, "Sexo");
            adpAlumno.UpdateCommand.Parameters.Add("@civ", SqlDbType.VarChar, 1, "Civil");
            adpAlumno.UpdateCommand.Parameters.Add("@car", SqlDbType.Int, 4, "CarreraID");

            adpAlumno.DeleteCommand = new SqlCommand("Delete from Alumno where AlumnoID = @alu", cnx);
            adpAlumno.DeleteCommand.Parameters.Add("@alu", SqlDbType.Int, 4, "Codigo");

        }
        private void frmAlumno_Load(object sender, EventArgs e)
        {
            tabAlumno = new DataTable();
            adpAlumno.Fill(tabAlumno);
            dgAlumno.DataSource = tabAlumno; 
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            adpAlumno.Update(tabAlumno);
            MessageBox.Show("Informacion Salvada");
        }
    }
}
