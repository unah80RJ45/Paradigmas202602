using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptos
{
    public abstract partial class frmMatematicas : Form
    {
        private int num1, num2;
        public int Numero1 => num1;
        public int Numero2 { get { return num2; } }
        
        public frmMatematicas()
        {
            InitializeComponent();
        }
        public  void Datos()
        {
            num1 = Int16.Parse( txtNumero1.Text);
            num2 = Int16.Parse( txtNumero2.Text);
        }
        public abstract void Calculo();
        public void setResultado(int result)
        {
            txtResultado.Text = result.ToString(); 
        }

        private void frmMatematicas_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Datos();
            Calculo();
        }
    }
}
