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
    public partial class FormaLatidos : Form
    {
        public FormaLatidos()
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
            string text = textLatidos.Text;
            if (int.TryParse(text, out int edad))
            {
                int fM = CalcularFrecuenciaMaxima(edad);
                MessageBox.Show($"Tu frecuencia máxima de latidos es: {fM} lpm", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.");
            }
        }

        private int CalcularFrecuenciaMaxima(int edad)
        {
            int fM = 220 - edad;
            return fM;
        }
    }
}
