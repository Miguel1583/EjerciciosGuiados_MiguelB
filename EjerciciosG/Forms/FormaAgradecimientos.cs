﻿using System;
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
    public partial class FormaAgradecimientos : Form
    {
        public FormaAgradecimientos()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormaHome back = new FormaHome();
            back.Show();
        }
    }
}
