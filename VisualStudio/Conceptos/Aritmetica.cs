using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

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

        // Crear una clase llamada Matematicas que tenga para espificar
        // el valor de dos operandos y me permita mostar las 4 operaciones basicas
        // con esos dos operandos
    }
}
