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
    public partial class FormaPED : Form
    {
        public FormaPED()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormaHome back = new FormaHome();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cantidadPesosMexicanos;
            if (!decimal.TryParse(textPesos.Text, out cantidadPesosMexicanos) || cantidadPesosMexicanos < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;

            }

            // Definir las tasas de cambio actuales
            decimal tasaCambioDolares = 0.050M;
            decimal tasaCambioEuros = 0.045M;

            decimal cantidadDolares = (cantidadPesosMexicanos / 2) * tasaCambioDolares;
            decimal cantidadEuros = (cantidadPesosMexicanos / 2) * tasaCambioEuros;

            MessageBox.Show($"Total de dólares americanos: {cantidadDolares:C}\nTotal de euros: {cantidadEuros:C}");
        }
    }
}