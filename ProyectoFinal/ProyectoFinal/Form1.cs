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
        public List<(string nombre, int x, int y)> listaPuntos = new List<(string nombre, int x, int y)>();
        public class Linea
        {
            public string Nombre { get; set; }
            public string PuntoInicio { get; set; }
            public string PuntoFinal { get; set; }
            public double Distancia { get; set; } 
            public double TiempoTransPublico { get; set; } 
            public double CostoTransPublico { get; set; }
            public double TiempoAutoRentado { get; set; }
            public double CostoAutoRentado { get; set; } 
        }

        public List<Linea> listaLineas = new List<Linea>();
        private Búsqueda_de_información busquedaForm;
        private Ruta rutaForm;
        private Ciudad ciudadForm;

        public Form1()
        {
            InitializeComponent();
            busquedaForm = new Búsqueda_de_información(listaPuntos, listaLineas);
            rutaForm = new Ruta(listaPuntos, listaLineas);
            ciudadForm = new Ciudad(listaPuntos, listaLineas, rutaForm, rutaForm, busquedaForm, busquedaForm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ciudadForm.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaForm.Show();
        }

        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaForm.Show();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Información informacion = new Información();
            informacion.Show();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
