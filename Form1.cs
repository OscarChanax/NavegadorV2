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
        
        List<URL> urls = new List<URL>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelfecha.Visible = false;
            labelvisitado.Visible = false;
            webBrowser1.GoHome();
            dataGridView1.Visible = false;
            webBrowser1.Visible = true;
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
        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VISIBILIDAD DE RECURSOS
            button1.Visible = true;
            comboBoxurl.Visible = true;
            labelfecha.Visible = false;
            labelvisitado.Visible = false;
            dataGridView1.Visible = false;
            webBrowser1.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelfecha.Visible = false;
            labelvisitado.Visible = false;
            dataGridView1.Visible = false;

            webBrowser1.GoHome();
            Leer("Historial.txt");
        }
        private void Leer(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                URL dato = new URL();
                dato.texto = reader.ReadLine();
                dato.numero = int.Parse(reader.ReadLine());
                dato.fecha = Convert.ToDateTime(reader.ReadLine());

                urls.Add(dato);
            }
            reader.Close();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fechaDeVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VISIBILIDAD DE RECURSOS
            button1.Visible = false;
            comboBoxurl.Visible = false;
            labelfecha.Visible = true;
            labelvisitado.Visible = false;
            dataGridView1.Visible = true;
            webBrowser1.Visible = false;

            urls = urls.OrderByDescending(f => f.fecha).ToList();
            Mostrar();
        }

        private void másVisitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VISIBILIDAD DE RECURSOS
            button1.Visible = false;
            comboBoxurl.Visible = false;
            labelfecha.Visible = false;
            labelvisitado.Visible = true;
            dataGridView1.Visible = true;
            webBrowser1.Visible = false;

            urls = urls.OrderByDescending(x => x.numero).ToList();
            Mostrar();

            
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
            ////////////////////////
            //BUSCA EL VALOR DEL TEXBOX EN LA LISTA Y DEVUELVE EN QUE POSICION LO ENCONTRO
            int posicion = urls.FindIndex(t => t.texto == comboBoxurl.Text);
            //SINO LO ENCUENTRA DEVUELVE -1
            if (posicion == -1)
            {
                URL dato = new URL();
                dato.texto = comboBoxurl.Text;//SI DESEO ALMACENAR LA DIRECCIÓN CAMBIAR POR "uri"
                dato.numero = 1; //ALMACENA DATO DEL NUMERO DE INGRESO TEMPORALMENTE
                dato.fecha = DateTime.Now;//DateTimenow ALMACENA DATOS DE FECHA Y HORA TEMPORALMENTE

                urls.Add(dato);
            }
            //SI LO ENCUENTRO LE CAMBIAMOS LOS VALORES
            else
            {
                urls[posicion].numero++;
                urls[posicion].fecha = DateTime.Now;
            }

            int Listo = 0;
            for (int i = 0; i< comboBoxurl.Items.Count; i++) 
            {
                if (uri == comboBoxurl.Items[i].ToString())
                    Listo++;
            }
            if (Listo==0)
            {
                comboBoxurl.Items.Add(uri);
                Guardar("Historial.txt");
            }
            
        }

        private void Guardar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write); //Append adjuntar datos al archivo de texto ||OpenOrCreade abrir archivo si existe si no crear uno y escribir en el
             StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in urls)
            {
                writer.WriteLine(dato.texto);
                writer.WriteLine(dato.numero);
                writer.WriteLine(dato.fecha);
            }
            writer.Close();
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = urls;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelfecha_Click(object sender, EventArgs e)
        {

        }
    }
}
