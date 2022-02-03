using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = tarea1.Properties.Resources.AZUL;
        }

        private void AZUL(object sender, EventArgs e)
        {
            pictureBox1.Image = tarea1.Properties.Resources.AZUL;
        }

        private void ROJO(object sender, EventArgs e)
        {
            pictureBox1.Image = tarea1.Properties.Resources.ROJO;
        }

        private void AMARRILO(object sender, EventArgs e)
        {
            pictureBox1.Image = tarea1.Properties.Resources.AMARILLO;

        }
    }
}
