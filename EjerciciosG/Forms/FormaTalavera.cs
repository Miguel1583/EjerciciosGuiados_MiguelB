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
    public partial class FormaTalavera : Form
    {
        public FormaTalavera()
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
            string text = textSalario.Text;
            if (decimal.TryParse(text, out decimal salario))
            {
                decimal nuevoSalario = CalcularNuevoSalario(salario);
                MessageBox.Show($"Tu nuevo salario es: {nuevoSalario:C}", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingrese un salario válido.", "Error");
            }
        }

        private decimal CalcularNuevoSalario(decimal salariol)
        {
            decimal incremento = salariol * 0.25M;
            decimal nuevoSalario = salariol + incremento;
            return nuevoSalario;
        }
    }
}
