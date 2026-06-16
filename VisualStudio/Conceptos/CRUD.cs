using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public abstract class CRUD
    {
        public abstract DataTable SELECT();
        public abstract void INSERT(DataRow row);
        public void Mostar()
        {
            DataTable tabla = SELECT();
            foreach (DataRow row in tabla.Rows)
            {
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    string texto = row[i].ToString(); string nombre = tabla.Columns[i].ColumnName;
                    MessageBox.Show(texto, nombre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
