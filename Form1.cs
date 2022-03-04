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
        List<URL> urlList = new List<URL>();
        public Form1()
        {
            InitializeComponent();
        }
        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            dataGridView1.Visible = false;
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void haciaAtrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }



        private void Leer(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() != -1)
            {
                URL aux = new URL();
                aux.Resource = reader.ReadLine();
                aux.TimesVisited = Convert.ToInt32(reader.ReadLine());
                aux.Date = Convert.ToDateTime(reader.ReadLine());
                urlList.Add(aux);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Leer("Historial.txt");
            foreach (URL url in urlList)
            {
                comboBoxurl.Items.Add(url.Resource);

            }
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "";
            if (comboBoxurl.Text != null)
            {
                url = comboBoxurl.Text;
            }
            else if (comboBoxurl.SelectedItem.ToString() != null)
            {
                url = comboBoxurl.SelectedItem.ToString();

            }
            if (!url.Contains("."))
            {
                url = "http://www.google.com/search?q=" + url;
            }
            else
            {
                url = "http://" + url;
            }
            webBrowser1.Navigate(new Uri(url));
            bool isRegisted = false;
            foreach (var aux in urlList)
            {
                if (aux.Resource.Contains(url))
                {
                    aux.TimesVisited++;
                    aux.Date = DateTime.Now;
                    isRegisted = true;
                }

            }
            //ACTUALIZACIÓN
            if (!isRegisted)
            {
                URL aux = new URL();
                comboBoxurl.Items.Add(url);
                aux.Resource = url;
                aux.TimesVisited++;
                aux.Date = DateTime.Now;
                urlList.Add(aux);
            }

            Guardar ("Historial.txt");
            comboBoxurl.Text = url;
        

    }
        private void Guardar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var url in urlList)
            {
                foreach (string s in url.getUrlData())
                {
                    writer.WriteLine(s);
                }
            }
            writer.Close();
        }
        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = urlList;
        }

        private void fechaDeVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urlList.OrderByDescending(url => url.Date).ToList();
        }

        private void másVisitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urlList.OrderByDescending(url => url.TimesVisited).ToList();
        }

    }
}
