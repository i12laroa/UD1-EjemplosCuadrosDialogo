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

namespace UD1_EjemploSaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string FileName = saveFileDialog1.FileName;
                    StreamWriter fichero = new StreamWriter(FileName);

                    fichero.WriteLine("Usuaio :" + txtUsuario.Text + " con contraseña: " + txtPasswd.Text);
                    MessageBox.Show("Fichero creado en: " + FileName);
                    fichero.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de escritura en el fichero :" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (fontDialog1.ShowDialog() == DialogResult.OK )
            {
                txtUsuario.Font = fontDialog1.Font;
            }
        }
    }
}
