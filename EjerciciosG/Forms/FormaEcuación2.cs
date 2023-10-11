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
    public partial class FormaEcuación2 : Form
    {
        public FormaEcuación2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormaHome back = new FormaHome();
            back.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textValorA.Text, out double a) &&
                double.TryParse(textValorB.Text, out double b) &&
                double.TryParse(textValorC.Text, out double c))
            {
                string resultado = CalcularRaices(a, b, c);
                MessageBox.Show(resultado, "Resultado");
            }
            else
            {
                MessageBox.Show("Ingrese Valores válidos.", "Error");
            }
        }

        private string CalcularRaices(double a, double b, double c)
        {
            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                return $"Las raíces son: x1 = {raiz1:F3}, x2 = {raiz2:F3}";
            }
            else if (discriminante == 0)
            {
                double raiz = -b / (2 * a);
                return $"La única raíz real es: x = {raiz:F3}";
            }
            else
            {
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                return $"Las raíces son complejas: x1 = {parteReal:F3} + {parteImaginaria:F3}i, x2 = {parteReal:F3} - {parteImaginaria:F3}i";
            }
        }
    }
}
