using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public class Perro : Animal, Mascota
    {
        private string nombre;
        private string dueno;
        private int edad;
        public string Sonido() { return "Ladra"; }
        public string Tipo() { return "Mamiferao"; }
        public string Patas() { return "4"; }
        public string Nombre() { return nombre; }
        public string Dueno() {return dueno; }
        public int Edad() { return edad; }
    }
}
