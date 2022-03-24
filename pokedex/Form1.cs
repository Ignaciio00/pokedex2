using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nombrePokemons_Click(object sender, EventArgs e)
        {

        }

        private void nombre2_Click(object sender, EventArgs e)
        {

        }
        public void descripcion(String des) {
            nombre2.Text = des;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void descripcion2(String des2)
        {
            label1.Text = des2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void descripcion3(String des3)
        {
            label2.Text = des3;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void descripcion4(String des4)
        {
            label3.Text = des4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void imagen2(Image ima2)
        {
            pictureBox2.Image = ima2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void descripcion5(String des5)
        {
            label4.Text = des5;
        }
    }
}
