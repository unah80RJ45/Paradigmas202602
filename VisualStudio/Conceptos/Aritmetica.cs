using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    internal class Aritmetica
    {
        private int altura = 0;
        public int Altura { get { return altura; } set { if(value > 0) altura = value; } }
        public int Soporte { get; set; }
        public Aritmetica(int a, int b) { altura = a; Soporte = b; }
        public Aritmetica() { } 

        public int Resultado { get { return altura * Soporte; } }       
        public void Mostrar()
        {
            MessageBox.Show("El Resultado es :" + Resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
