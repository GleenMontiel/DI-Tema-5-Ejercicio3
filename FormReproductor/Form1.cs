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

namespace FormReproductor
{
    public partial class Form1 : Form
    {
        string ruta;
        FolderBrowserDialog carpeta;
        List<string> rutaImagenes;
        int indice;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = false;
            timer2.Interval = 1000;
            timer2.Enabled = true;
            indice = 0;
            rutaImagenes = new List<string>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(rutaImagenes[indice]);
            pictureBox1.Image = bitmap;
            pictureBox1.Size = new Size(bitmap.Width, bitmap.Height);
            indice++;
            if (indice >= rutaImagenes.Count()) { indice = 0; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            reproductor1.YY++;
        }

        private void reproductor1_PlayPause(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void btnBuscarDirectorios_Click(object sender, EventArgs e)
        {
            carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
                ruta = carpeta.SelectedPath;
            rutaImagenes.Clear();
            DirectoryInfo directory = new DirectoryInfo(ruta);
            FileInfo[] listaArchivos = directory.GetFiles();
            foreach (FileInfo file in listaArchivos)
            {
                if (file.Name.EndsWith(".png") || file.Name.EndsWith(".jpg"))
                {
                    rutaImagenes.Add(file.FullName);
                }
            }
        }

        private void reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.XX++;
        }
    }
}
