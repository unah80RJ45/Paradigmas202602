using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public partial class Form1 : Form
    {
        Empleado empleado = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            Aritmetica a1 = new Aritmetica();
            a1.Altura = 10;
            a1.Soporte = 10;
            
            Aritmetica a2 = new Aritmetica(15, 20);
            Aritmetica g1 = new Geometria();
            Geometria g2 = (Geometria) new Aritmetica();

            g1.Soporte = 10;
            g1.Altura = 20;

            ((Geometria) g1).Area();

            Matematicas s = new Matematicas(10, 20);
            //MessageBox.Show(s.Potencia(15).ToString());
            //MessageBox.Show(s.Potencia().ToString());
            MessageBox.Show("El area es " + g1.Resultado);

            //MessageBox.Show(a1.Resultado.ToString(), "Area", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //MessageBox.Show(a2.Resultado.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria(); Algebra alg = new Algebra();
            geo.Altura = 10; geo.Soporte = 20;

            alg.Altura = int.Parse( txtNumero1.Text); 
            alg.Soporte = int.Parse(txtNumero2.Text);

            /*geo.Mostrar();*/ 
            alg.Mostrar();
        }

        private void cmdEmpleado_Click(object sender, EventArgs e)
        {
            DataRow nRow = empleado.tabEmpleado.NewRow();

            nRow[0] = txtNumero1.Text; nRow[1] = txtNumero2.Text; nRow[2] = txtNumero3.Text;
            empleado.INSERT(nRow); txtNumero1.Clear(); txtNumero2.Clear(); txtNumero3.Clear();
        }
        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            empleado.Mostar();
        }
    }
}
