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
        public int Division { get { return operando1 / operando2; } }
        public Matematicas(int op1, int op2) { operando1 = op1; operando2 = op2; }
        public int Potencia(int numero)
        {
            return numero * numero;
        }
        public int Potencia()
        {
            int resultado = 1;

            for (int i = 0; i < operando2; i++)
            {
                resultado *= operando1;
            }

            return resultado;
        }
        public void Potencia(int numero1, float numero2)
        {

        }
        private void Potencia(float numero2, int numero1)
        {

        }
    }
}
