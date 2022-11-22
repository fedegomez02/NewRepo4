using Negocio.AdmAdmin;
using Practicaentity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string Clasificacion = textBox2.Text;
           string  fecha = textBox3.Text;
            string duracion = textBox4.Text;
            string genero = textBox5.Text;
            string idioma = textBox6.Text;
            string sinopsis = textBox7.Text;
            Pelicula pelicula = new Pelicula() { Nombre = nombre, Clasificacion = new Clasificacion { Id = 1}, CantMinutos = (int)Convert.ToInt64(duracion), FechaEstreno = fecha, Genero = new Genero { Id = 1 }, Idioma =idioma, Sinapsis=sinopsis};
            AdmPelicula.Nuevo(pelicula);
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
