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

            Matematicas s = new Matematicas(10, 20);
            MessageBox.Show(s.Suma.ToString());
            MessageBox.Show(s.Resta.ToString());

            //MessageBox.Show(a1.Resultado.ToString(), "Area", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //MessageBox.Show(a2.Resultado.ToString());
        }
    }
}
