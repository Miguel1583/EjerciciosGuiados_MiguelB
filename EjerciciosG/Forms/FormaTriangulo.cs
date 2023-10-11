using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosG.Forms
{
    public partial class FormaTriangulo : Form
    {
        public FormaTriangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FormaHome back = new FormaHome();
            back.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (float.TryParse(textoBase.Text, out float baseT) && float.TryParse(textoAltura.Text, out float altura))
            {
                MessageBox.Show("Área del Triángulo:   " + (baseT * altura / 2));
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la base y la altura.", "Error");
            }
        }
    }
}
