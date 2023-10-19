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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void menuAreaTriangulo_Click(object sender, EventArgs e)
        {
            FormaTriangulo triangulo = new FormaTriangulo();
            triangulo.Show();
            Hide();
        }

        private void pesosEurosDolaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPED Ped = new FormaPED();
            Ped.Show();
            Hide();
        }

        private void latidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaLatidos latidos = new FormaLatidos();
            latidos.Show();
            Hide();
        }

        private void fabricaDeTalaveraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTalavera talavera = new FormaTalavera();
            talavera.Show();
            Hide();
        }

        private void ecuaciónDeSegundoGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuación2 ecuacion2 = new FormaEcuación2();
            ecuacion2.Show();
            Hide();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVideo1 video1 = new FormaVideo1();
            video1.Show();
            Hide();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRegistro registro = new FormaRegistro();
            registro.Show();
            Hide();
        }

        private void visorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisor visor = new FormaVisor();
            visor.Show();
            Hide();
        }

        private void agradecimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAgradecimientos agra = new FormaAgradecimientos();
            agra.Show();
            Hide();
        }

        private void reportarErroresOSugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaOpiniones op = new FormaOpiniones();
            op.Show();
            Hide();
        }

        private void inisiarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormaLinks links = new FormaLinks();
            links.Show();
        }

        private void juegoDeFormarParejasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaJuego juego = new FormaJuego();
            juego.Show();
        }
    }
}
