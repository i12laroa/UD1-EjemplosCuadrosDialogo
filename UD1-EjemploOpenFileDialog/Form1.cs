using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjemploOpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.Filter = "Text files (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    // Obtener el nombre del archivo seleccionado
                    string filePath = openFileDialog1.FileName;


                    // Leer todas las líneas del archivo
                    string[] lines = File.ReadAllLines(filePath);

                    // Limpiar el ListView antes de cargar nuevos datos
                    listBox1.Items.Clear();

                    // Agregar cada línea como un nuevo elemento al ListView
                    foreach (string line in lines)
                    {
                        // Añadir la línea como un nuevo item del ListView
                        listBox1.Items.Add(line);
                    }

                    MessageBox.Show("Archivo cargado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }

            }
        }
    }

