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

namespace NavegadorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void haciaAtrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Guardar(string fileName, string texto)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }

        private void Leer(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)

            {
                comboBoxurl.Items.Add(reader.ReadLine());
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "";
            uri = comboBoxurl.Text.ToString();
            if (comboBoxurl.SelectedIndex.Equals(-1))
            {

                if (uri.Contains(".") == true)
                {
                    uri = "http://" + uri;
                    webBrowser1.Navigate(uri);
                }
                else if (uri.Contains(".") == false)
                {
                    uri = "http://www.google.com/search?q=" + uri;
                    webBrowser1.Navigate(uri);
                }
            }
            else
            {
                webBrowser1.Navigate(uri);
            }
            int Listo = 0;
            for (int i = 0; i < comboBoxurl.Items.Count; i++)
            {
                if (uri == comboBoxurl.Items[i].ToString())
                    Listo++;
            }
            if (Listo == 0)
            {
                comboBoxurl.Items.Add(uri);
                Guardar("Historial.txt", uri);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            Leer("Historial.txt");
        }
    }
}
