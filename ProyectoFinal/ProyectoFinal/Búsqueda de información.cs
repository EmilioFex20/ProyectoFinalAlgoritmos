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

        //private int[,] matrizSeleccionadaENTERO;
        private double[,] matrizSeleccionadaDECIMAL;

        private double[,] MatrizDistancias;
        private double[,] MatrizTiempoAuto;
        private double[,] MatrizCostoAuto;
        private double[,] MatrizTiempoPublico;
        private double[,] MatrizCostoPublico;

        private int dimensionmatriz;
        public Búsqueda_de_información(List<(string nombre, int x, int y)> listaPuntos,  List<Linea> listaLineas)
        {
            InitializeComponent();
            pictureBox1.Paint += pictureBox1_Paint;
            ListaPuntos = listaPuntos;
            ListaLineas = listaLineas;
            this.FormClosing += Búsqueda_de_información_FormClosing;

        }


        private void CrearMatrizAdyacencia()
        {
            dimensionmatriz = ListaPuntos.Count;

            MatrizDistancias = new double[dimensionmatriz, dimensionmatriz];
            MatrizTiempoAuto = new double[dimensionmatriz, dimensionmatriz];
            MatrizCostoAuto = new double[dimensionmatriz, dimensionmatriz];
            MatrizTiempoPublico = new double[dimensionmatriz, dimensionmatriz];
            MatrizCostoPublico = new double[dimensionmatriz, dimensionmatriz];


            for (int x = 0; x < dimensionmatriz; x++)
            {
                for (int y = 0; y < dimensionmatriz; y++)
                {
                    MatrizDistancias[x, y] = (x == y) ? 0 : double.MaxValue;
                    MatrizTiempoAuto[x, y] = (x == y) ? 0 : double.MaxValue;
                    MatrizCostoAuto[x, y] = (x == y) ? 0 : double.MaxValue;
                    MatrizTiempoPublico[x, y] = (x == y) ? 0 : double.MaxValue;
                    MatrizCostoPublico[x, y] = (x == y) ? 0 : double.MaxValue;
                }
            }


            foreach (var linea in ListaLineas)
            {
                int indicep1 = ListaPuntos.FindIndex(z => z.nombre == linea.PuntoInicio);
                int indicep2 = ListaPuntos.FindIndex(z => z.nombre == linea.PuntoFinal);
                if (indicep1 != -1 && indicep2 != -1)
                {
                    MatrizDistancias[indicep1, indicep2] = linea.Distancia;
                    MatrizDistancias[indicep2, indicep1] = linea.Distancia;

                    MatrizTiempoAuto[indicep1, indicep2] = linea.TiempoAutoRentado;
                    MatrizTiempoAuto[indicep2, indicep1] = linea.TiempoAutoRentado;

                    MatrizCostoAuto[indicep1, indicep2] = linea.CostoAutoRentado;
                    MatrizCostoAuto[indicep2, indicep1] = linea.CostoAutoRentado;

                    MatrizTiempoPublico[indicep1, indicep2] = linea.TiempoTransPublico;
                    MatrizTiempoPublico[indicep2, indicep1] = linea.TiempoTransPublico;

                    MatrizCostoPublico[indicep1, indicep2] = linea.CostoTransPublico;
                    MatrizCostoPublico[indicep2, indicep1] = linea.CostoTransPublico;
                }
            }
        }

        private void Búsqueda_de_información_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 
            this.Hide();    
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


        private (double distancia, List<int> camino) DijkstraDECIMAL(double[,] matriz, int n, int inicio, int destino)
        {
            double[] distancias = new double[n];
            bool[] visitado = new bool[n];
            int[] predecesores = new int[n];
            const double INF = double.MaxValue;

            // Inicializar distancias y predecesores
            for (int i = 0; i < n; i++)
            {
                distancias[i] = INF;
                visitado[i] = false;
                predecesores[i] = -1;
            }
            distancias[inicio] = 0;

            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar el nodo no visitado con la menor distancia
                int u = MinDistanceDECIMAL(distancias, visitado, n);
                if (u == -1) break; // Si no quedan nodos accesibles
                visitado[u] = true;

                // Actualizar las distancias de los vecinos
                for (int v = 0; v < n; v++)
                {
                    if (!visitado[v] && matriz[u, v] != 0 && distancias[u] != INF &&
                        distancias[u] + matriz[u, v] < distancias[v])
                    {
                        distancias[v] = distancias[u] + matriz[u, v];
                        predecesores[v] = u;
                    }
                }
            }

            // Reconstruir el camino
            List<int> camino = new List<int>();
            int actual = destino;
            while (actual != -1)
            {
                camino.Insert(0, actual);
                actual = predecesores[actual];
            }

            // Si el destino no es alcanzable
            if (distancias[destino] == INF)
            {
                return (INF, new List<int>());
            }

            return (distancias[destino], camino);
        }

        private int MinDistanceDECIMAL(double[] distancias, bool[] visitado, int n)
        {
            double min = double.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (!visitado[i] && distancias[i] <= min)
                {
                    min = distancias[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string puntoInicio, puntoFinal;
            //matrizSeleccionadaENTERO = null;
            matrizSeleccionadaDECIMAL = null;
            CrearMatrizAdyacencia();

            // Validación: Modo de transporte
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Seleccione un modo de transporte.");
                return;
            }

            // Validación: Criterio de optimización
            if (!radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Seleccione un criterio de optimización.");
                return;
            }

            if (radioButton1.Checked)
            {
                if (radioButton4.Checked)
                {
                    matrizSeleccionadaDECIMAL = MatrizTiempoAuto;
                }
                if (radioButton5.Checked)
                {
                    matrizSeleccionadaDECIMAL = MatrizCostoAuto;
                }
            }

            if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    matrizSeleccionadaDECIMAL = MatrizTiempoPublico;
                }
                if (radioButton5.Checked)
                {
                    matrizSeleccionadaDECIMAL = MatrizCostoPublico;
                }
            }

            if (radioButton3.Checked)
            {
                matrizSeleccionadaDECIMAL = MatrizDistancias;
            }

            listBox1.Items.Clear();
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Auto Rentado");
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("Transporte Público");
            }

            puntoInicio = comboBox1.Text;
            puntoFinal = comboBox2.Text;

            int indiceInicio = ListaPuntos.FindIndex(p => p.nombre == puntoInicio);
            int indiceFinal = ListaPuntos.FindIndex(p => p.nombre == puntoFinal);

            if (indiceInicio == -1 || indiceFinal == -1)
            {
                MessageBox.Show("Una o ambas ciudades no existen en la lista de puntos");
                return;
            }

            if (matrizSeleccionadaDECIMAL != null)
            {
               (double distancia, List<int> camino) = DijkstraDECIMAL(matrizSeleccionadaDECIMAL, dimensionmatriz, indiceInicio, indiceFinal);
                if (distancia == double.MaxValue)
                {
                    MessageBox.Show($"No hay un camino entre {puntoInicio} y {puntoFinal}");
                }
                else
                {
                    var nombresCamino = camino.Select(idx => ListaPuntos[idx].nombre).ToList();
                    MessageBox.Show($"Distancia mínima: {distancia}\nCamino: {string.Join(" -> ", nombresCamino)}");
                }
            }
            else
            {
                MessageBox.Show($"No hay un camino entre {puntoInicio} y {puntoFinal}");
            }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
