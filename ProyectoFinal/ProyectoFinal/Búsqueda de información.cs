using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoFinal.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class Búsqueda_de_información : Form
    {
        public PictureBox PictureBoxDeBusqueda => pictureBox1;
        public System.Windows.Forms.ComboBox ComboBoxdeBusqueda_1 => comboBox1;
        public System.Windows.Forms.ComboBox ComboBoxdeBusqueda_2 => comboBox2;
        public List<(string nombre, int x, int y)> ListaPuntos { get; private set; }
        public List<Linea> ListaLineas { get; private set; }
        private int[,] MatrizdeAdyacencia;
        private int dimensionmatriz;
        public Búsqueda_de_información(List<(string nombre, int x, int y)> listaPuntos,  List<Linea> listaLineas)
        {
            InitializeComponent();
            pictureBox1.Paint += pictureBox1_Paint;
            ListaPuntos = listaPuntos;
            ListaLineas = listaLineas;
            this.FormClosing += Búsqueda_de_información_FormClosing;

        }

        private int[,] CrearMatrizAdyacencia()
        {
            dimensionmatriz = ListaPuntos.Count;
            MatrizdeAdyacencia = new int[dimensionmatriz, dimensionmatriz];


            for (int x = 0; x < dimensionmatriz; x++)
                for (int y = 0; y < dimensionmatriz; y++)
                    MatrizdeAdyacencia[x, y] = 0;

            foreach (var linea in ListaLineas)
            {
                int indicep1 = ListaLineas.FindIndex(z => z.Nombre == linea.PuntoInicio);
                int indicep2 = ListaLineas.FindIndex(z => z.Nombre == linea.PuntoFinal);
                MatrizdeAdyacencia[indicep1, indicep2] = linea.Distancia;
                MatrizdeAdyacencia[indicep2, indicep1] = linea.Distancia;
            }
            return MatrizdeAdyacencia;
        }

        private void Búsqueda_de_información_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Evita que el formulario se cierre.
            this.Hide();     // Oculta el formulario en lugar de cerrarlo.
        }
 
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafica = e.Graphics;
            grafica.Clear(Color.White);
            SolidBrush Brush = new SolidBrush(Color.Black);
    
            foreach (var punto in ListaPuntos)
            {
            grafica.FillEllipse(Brush, punto.x, punto.y, 10, 10);
            grafica.DrawString(punto.nombre,
                new Font("Arial", 10),
                Brushes.Red,
                new Point(punto.x + 10, punto.y + 10));
            }

            foreach (var linea in ListaLineas)
            {
                int Indicep1, Indicep2;
                Indicep1 = ListaPuntos.FindIndex(x => x.nombre == linea.PuntoInicio);
                Indicep2 = ListaPuntos.FindIndex(x => x.nombre == linea.PuntoFinal);
                Font font = new Font("new roman", 8);
                Pen pen = new Pen(Color.Black, 2);
                SolidBrush brush = new SolidBrush(Color.Blue);
                Point p1 = new Point();
                Point p2 = new Point();
                p1.X = ListaPuntos[Indicep1].x + 5;
                p1.Y = ListaPuntos[Indicep1].y + 5;
                p2.X = ListaPuntos[Indicep2].x + 5;
                p2.Y = ListaPuntos[Indicep2].y + 5;
                Point K1 = new Point();
                Point K2 = new Point();
                K1.X = (p1.X + p2.X + 10) / 2;
                K2.Y = (p1.Y + p2.Y + 10) / 2;
                grafica.DrawLine(pen, p1, p2);
                grafica.DrawString(linea.Nombre, font, brush, K1.X, K2.Y);
            }
        }

        private void Búsqueda_de_información_Shown(object sender, EventArgs e)
        {
            
        }



        private void Búsqueda_de_información_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string puntoInicio, puntoFinal;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("La ciudad de inicio y destino se tienen que definir");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("El medio de transporte tiene que estar definido");
                return;
            }
            if (radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false )
            {
                MessageBox.Show("Elige un criterio de búsqueda");
                return;
            }

            puntoInicio = comboBox1.Text;
            puntoFinal = comboBox2.Text;

            MatrizdeAdyacencia = CrearMatrizAdyacencia();
            dimensionmatriz = ListaPuntos.Count;

            int indiceInicio = ListaPuntos.FindIndex(p => p.nombre == puntoInicio);
            int indiceFinal = ListaPuntos.FindIndex(p => p.nombre == puntoFinal);

            (int distancia, List<int> camino) = Dijkstra(MatrizdeAdyacencia, dimensionmatriz, indiceInicio, indiceFinal);




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
