using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    internal class Algebra : Aritmetica
    {
        public void Mostrar()
        {
            string msg = "El resultado de una figua con altrua " + Altura + " y Base " + Soporte + " es " + Resultado;
            MessageBox.Show(msg, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }

}
