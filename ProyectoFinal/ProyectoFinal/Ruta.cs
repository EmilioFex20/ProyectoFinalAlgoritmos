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
    public partial class Ruta : Form
    {
        public System.Windows.Forms.ComboBox ComboBoxdeRuta_1 => comboBox1;
        public System.Windows.Forms.ComboBox ComboBoxdeRuta_2 => comboBox2;
        public List<(string nombre, int x, int y)> ListaPuntos { get; private set; }
        public List<Linea> ListaLineas {  get; private set; }

        public Ruta(List<(string nombre, int x, int y)> listaPuntos, List<Linea> listaLineas)
        {
            InitializeComponent();
            ListaPuntos = listaPuntos;
            ListaLineas = listaLineas;
            this.FormClosing += Ruta_FormClosing;
        }

        private void Ruta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Evita que el formulario se cierre.
            this.Hide();     // Oculta el formulario en lugar de cerrarlo.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ruta_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string punto1, punto2;
            int Indicep1, Indicep2;
            int distancia;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("El punto inicial y final deben definirse");
                return;
            }
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("El punto inicial y final deben de ser distintos");
                return;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("La distancia tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("El tiempo en auto rentado tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("El costo en auto rentado tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("El tiempo en transporte público tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("El costo en transporte público tiene que ser mayor a 0");
                return;
            }
            distancia = int.Parse(textBox3.Text);
            punto1 = comboBox1.Text;
            punto2 = comboBox2.Text;
            Indicep1 = ListaPuntos.FindIndex(x => x.nombre == punto1);
            Indicep2 = ListaPuntos.FindIndex(x => x.nombre == punto2);
            if (ListaLineas.Any(x => (x.PuntoInicio == punto1 && x.PuntoFinal == punto2)) ||
            ListaLineas.Any(x => (x.PuntoInicio == punto2 && x.PuntoFinal == punto1)))
            {
                MessageBox.Show("La línea " + textBox1.Text + " ya existe");
                textBox1.Text = String.Empty;
                comboBox1.Text = String.Empty;
                comboBox2.Text = String.Empty;
                return;
            }

            Linea nuevaLinea = new Linea
            {
                Nombre = textBox1.Text,
                PuntoInicio = punto1,
                PuntoFinal = punto2,
                Distancia = distancia,
                TiempoTransPublico = int.Parse(textBox8.Text),
                CostoTransPublico = decimal.Parse(textBox7.Text),
                TiempoAutoRentado = int.Parse(textBox5.Text),
                CostoAutoRentado = decimal.Parse(textBox6.Text),
            };
            ListaLineas.Add(nuevaLinea);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 length = ListaLineas.Count;
            if (length != 0)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    if (ListaLineas[i].Nombre == textBox1.Text)
                    {
                        ListaLineas.RemoveAt(i);
                        length = ListaLineas.Count;
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string punto1, punto2;
            int Indicep1, Indicep2;
            int distancia;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("El punto inicial y final deben definirse");
                return;
            }
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("El punto inicial y final deben de ser distintos");
                return;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("La distancia tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("El tiempo en auto rentado tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("El costo en auto rentado tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("El tiempo en transporte público tiene que ser mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("El costo en transporte público tiene que ser mayor a 0");
                return;
            }
            distancia = int.Parse(textBox3.Text);
            punto1 = comboBox1.Text;
            punto2 = comboBox2.Text;
            Indicep1 = ListaPuntos.FindIndex(x => x.nombre == punto1);
            Indicep2 = ListaPuntos.FindIndex(x => x.nombre == punto2);
            if (ListaLineas.Any(x => (x.PuntoInicio == punto1 && x.PuntoFinal == punto2)) ||
            ListaLineas.Any(x => (x.PuntoInicio == punto2 && x.PuntoFinal == punto1)))
            {
                MessageBox.Show("La línea " + textBox1.Text + " ya existe");
                textBox1.Text = String.Empty;
                comboBox1.Text = String.Empty;
                comboBox2.Text = String.Empty;
                return;
            }

            string nuevo_nombre = textBox1.Text;
            bool cambio = false;
            int index = 0;

            Int32 length = ListaLineas.Count;
            if (length != 0)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    if (ListaLineas[i].Nombre == textBox1.Text)
                    {
                        index = i;
                        cambio = true;
                    }
                }
            }
            if (cambio)
            {
                ListaLineas[index] = new Linea
                {
                    Nombre = textBox1.Text,
                    PuntoInicio = punto1,
                    PuntoFinal = punto2,
                    Distancia = distancia,
                    TiempoTransPublico = int.Parse(textBox8.Text),
                    CostoTransPublico = decimal.Parse(textBox7.Text),
                    TiempoAutoRentado = int.Parse(textBox5.Text),
                    CostoAutoRentado = decimal.Parse(textBox6.Text),
                };

            }
        }
    }
}
