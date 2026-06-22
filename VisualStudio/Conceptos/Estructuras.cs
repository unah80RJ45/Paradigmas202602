using System;
using System.Collections;
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
    public partial class Estructuras : Form
    {
        ArrayList animales = new ArrayList();
        List<Perro> perros = new List<Perro>();

        public Estructuras()
        {
            InitializeComponent();
        }
        private void Estructuras_Load(object sender, EventArgs e)
        {

        }
        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            animales.Add(txtNombre.Text); txtNombre.Clear();
        }
        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            foreach (Perro item in animales)
            {
                MessageBox.Show(item.Nombre(), "Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            animales.Remove(txtNombre.Text);
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            animales.Clear();
        }
        private void cmdPerro_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro(txtNombre.Text); txtNombre.Clear();

            animales.Add(perro);
        }
        private void cmdMosquito_Click(object sender, EventArgs e)
        {
            Mosquito mosquito = new Mosquito();
            animales.Add(mosquito);
        }
        private void cmdSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animales.Count.ToString(), "Elementos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmdPerros_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro(txtNombre.Text, txtDueno.Text);
            
            perros.Add(perro);
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            foreach(Perro perro in perros)
                cmbPerros.Items.Add(perro.Nombre());
        }

        private void cmdDueno_Click(object sender, EventArgs e)
        {
            Perro perro = perros.ElementAt(cmbPerros.SelectedIndex);
            txtNombreDueno.Text = perro.Dueno();
        }
    }
}
