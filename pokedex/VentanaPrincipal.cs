using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pokedex
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 0; //guarda el id que se esta viendo 
        public VentanaPrincipal()
        {
            InitializeComponent();
            Derecha.BackColor = Color.Transparent;

        }

        private void Izquerda_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 151; }
            misPokemons = miConexion.getPokemonPorid(idActual);
            nombrePokemons.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            dato1.Text = "Altura:" + misPokemons.Rows[0]["altura"].ToString();
            dato3.Text = "Peso:" + misPokemons.Rows[0]["peso"].ToString();
            dato5.Text = "Especie:" + misPokemons.Rows[0]["especie"].ToString();
            dato2.Text = "Habitat:" + misPokemons.Rows[0]["habitat"].ToString();
            dato4.Text = "Tipo1:" + misPokemons.Rows[0]["tipo1"].ToString();
            dato6.Text = "Tipo2:" + misPokemons.Rows[0]["tipo2"].ToString();
        }
        private Image convierteBlobAImagen(byte[] img) {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void label1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Derecha_Click(object sender, EventArgs e)
        {

            idActual++;
            if (idActual > 151) { idActual = 1; }
            misPokemons = miConexion.getPokemonPorid(idActual);
            nombrePokemons.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            dato1.Text = "Altura:" +misPokemons.Rows[0]["altura"].ToString();
            dato3.Text = "Peso:"+misPokemons.Rows[0]["peso"].ToString();
            dato5.Text = "Especie:"+ misPokemons.Rows[0]["especie"].ToString();
            dato2.Text = "Habitat:"+ misPokemons.Rows[0]["habitat"].ToString();
            dato4.Text = "Tipo1:"+  misPokemons.Rows[0]["tipo1"].ToString();
            dato6.Text = "Tipo2:"+  misPokemons.Rows[0]["tipo2"].ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPokemonPorid(idActual);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPokemonPorid(idActual);
            nombrePokemons.Text = misPokemons.Rows[0]["nombre"].ToString();
        }

        private void nombrePokemons_Click(object sender, EventArgs e)
        {

        }

        private void datosPokemon_Click(object sender, EventArgs e)
        {
            
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void peso_Click(object sender, EventArgs e)
        {

        }

        private void especie_Click(object sender, EventArgs e)
        {

        }

        private void habitat_Click(object sender, EventArgs e)
        {

        }

        private void tipo1_Click(object sender, EventArgs e)
        {

        }

        private void tipo2_Click(object sender, EventArgs e)
        {

        }

        private void movimientos_Click(object sender, EventArgs e)
        {
            
            misPokemons = miConexion.getPokemonPorid(idActual);
            dato2.Text = "";
            dato1.Text = "Habilidad : "+ misPokemons.Rows[0]["habilidad"].ToString();            
            dato3.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            dato5.Text = misPokemons.Rows[0]["movimiento2"].ToString();            
            dato4.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            dato6.Text = misPokemons.Rows[0]["movimiento4"].ToString();
        }

        private void informacion_Click(object sender, EventArgs e)
        {
            
            
            misPokemons = miConexion.getPokemonPorid(idActual);
            Form1 f1 = new Form1();
            f1.Show();
            f1.descripcion(misPokemons.Rows[0]["nombre"].ToString());
            f1.descripcion2(misPokemons.Rows[0]["altura"].ToString());
            f1.descripcion3(misPokemons.Rows[0]["peso"].ToString());
            f1.descripcion4("Tipo1:" + misPokemons.Rows[0]["tipo1"].ToString());
            f1.imagen2(convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]));
            f1.descripcion5(misPokemons.Rows[0]["descripcion"].ToString());
        }

        private void dato1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
