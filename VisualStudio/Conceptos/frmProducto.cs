using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Conceptos
{
    public partial class frmProducto : Conceptos.frmMatematicas
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        public  override void  Calculo()
        {
            setResultado(Numero1 * Numero2);
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
