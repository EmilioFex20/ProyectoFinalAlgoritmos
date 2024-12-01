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
    public partial class Ciudad : Form
    {
        private Ruta combobox1;
        private Ruta combobox2;

        private Búsqueda_de_información combobox3;
        private Búsqueda_de_información combobox4;
        public List<(string nombre, int x, int y)> ListaPuntos { get; private set; }
        public List<Linea> ListaLineas { get; private set; }
        public Ciudad(List<(string nombre, int x, int y)> listaPuntos, List<Linea> listaLineas, Ruta comboBox1, Ruta comboBox2, Búsqueda_de_información comboBox3, Búsqueda_de_información comboBox4)
        {
            InitializeComponent();
            ListaPuntos = listaPuntos;
            ListaLineas = listaLineas;

            combobox1 = comboBox1;
            combobox2 = comboBox2;
            combobox3 = comboBox3;
            combobox4 = comboBox4;
            this.FormClosing += Ciudad_FormClosing;
        }

        private void Ciudad_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 
            this.Hide();    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ciudad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comboBox1 = combobox1.ComboBoxdeRuta_1;
            var comboBox2 = combobox2.ComboBoxdeRuta_2;
            var comboBox3 = combobox3.ComboBoxdeBusqueda_1;
            var comboBox4 = combobox4.ComboBoxdeBusqueda_2;

            int Enx = (int)numericUpDown1.Value;
            int Eny = (int)numericUpDown2.Value;

            if (ListaPuntos.Any(z => (z.nombre == textBox1.Text)))
            {
                MessageBox.Show("El punto " + textBox1.Text + " ya existe");
                textBox1.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                return;
            }
            if (ListaPuntos.Any(z => (z.x == Enx && z.y == Eny)))
            {
                MessageBox.Show("Las coordenadas proporcionadas ya existen");
                textBox1.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                return;
            }
            (string nombre, int x, int y) puntos = (textBox1.Text, Enx, Eny);
            ListaPuntos.Add(puntos);

            combobox1.ComboBoxdeRuta_1.Items.Add(textBox1.Text);
            combobox2.ComboBoxdeRuta_2.Items.Add(textBox1.Text);
            combobox3.ComboBoxdeBusqueda_1.Items.Add(textBox1.Text);
            combobox4.ComboBoxdeBusqueda_2.Items.Add(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListaPuntos.Count == 0)
            {
                MessageBox.Show("No hay ciudades para eliminar.");
                return;
            }
            Int32 length = ListaPuntos.Count;
            bool ciudadEnUso = ListaLineas.Any(linea =>
       linea.PuntoInicio == textBox1.Text || linea.PuntoFinal == textBox1.Text);

            if (ciudadEnUso)
            {
                MessageBox.Show($"No se puede eliminar la ciudad '{textBox1.Text}' porque está asociada a una o más rutas.");
                return;
            }

            else if (length != 0)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    if (ListaPuntos[i].nombre == textBox1.Text)
                    {
                        ListaPuntos.RemoveAt(i);
                        length = ListaPuntos.Count;
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Enx = (int)numericUpDown1.Value;
            int Eny = (int)numericUpDown2.Value;
            Int32 length = ListaPuntos.Count;

            if (ListaPuntos.Any(z => (z.x == Enx && z.y == Eny)))
            {
                MessageBox.Show("Las coordenadas proporcionadas ya existen");
                textBox1.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                return;
            }  
            
            string nuevo_nombre = textBox1.Text;
            bool cambio = false;
            int index = 0;

            if (length != 0)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    if (ListaPuntos[i].nombre == textBox1.Text)
                    {
                        index = i;
                        cambio = true;
                    }
                }
                (string nombre, int x, int y) puntos = (textBox1.Text, Enx, Eny);
                if (cambio)
                {
                    ListaPuntos[index] = puntos;
                }
                length = ListaPuntos.Count;
            }
        }
    }
}
