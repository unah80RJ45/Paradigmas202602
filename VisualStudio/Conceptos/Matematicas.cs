using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos
{
    internal class Matematicas
    {
        private int operando1, operando2;
        public int Suma { get { return operando1 + operando2; } }
        public int Resta { get { return operando1 - operando2; } }
        public int Multiplicacion { get { return operando1 * operando2; } }
        public int Dividision { get { return operando1 / operando2; } }
        public Matematicas(int op1, int op2) { operando1 = op1; operando2 = op2; }
        
    }
}
