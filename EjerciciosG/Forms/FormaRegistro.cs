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
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();
        }

        private void Registros_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
