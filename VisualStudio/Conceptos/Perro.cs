using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public class Perro : Animal
    {
        public void Sonido() { MessageBox.Show("Ladra"); }
        public void Tipo() { MessageBox.Show("Mamiferao"); }
        public void Patas() { MessageBox.Show("4"); }
    }
}
