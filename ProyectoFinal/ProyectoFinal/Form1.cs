using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta(); 
            ruta.Show();
        }

        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Búsqueda_de_información busqueda = new Búsqueda_de_información();
            busqueda.Show();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Información informacion = new Información();
            informacion.Show();
        }
    }
}
