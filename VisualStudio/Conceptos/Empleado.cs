using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos
{
    public class Empleado : CRUD
    {
        public DataTable tabEmpleado { get; set; }

        public override DataTable SELECT()
        {
            return tabEmpleado;
        }
        public override void INSERT(DataRow row)
        {
            tabEmpleado.Rows.Add(row);
        }
        public Empleado()
        {
            tabEmpleado = new DataTable();
            tabEmpleado.Columns.Add("Codigo"); tabEmpleado.Columns.Add("Nombre"); tabEmpleado.Columns.Add("Sueldo");
        }
    }
}
