using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMovies
{
    public partial class InfoBoton : Form
    {
        public InfoBoton(List<Actor> list)
        {
            InitializeComponent();
            foreach(Actor a in list)
            {
                listBox1.Items.Add(a);
            }
        }
        public InfoBoton(List<Productor> list)
        {
            InitializeComponent();
            foreach (Productor p in list)
            {
                listBox1.Items.Add(p);
            }
        }
        public InfoBoton(List<Director> list)
        {
            InitializeComponent();
            foreach (Director d in list)
            {
                listBox1.Items.Add(d);
            }
        }
        public InfoBoton(List<Estudio> list)
        {
            InitializeComponent();
            foreach (Estudio e in list)
            {
                listBox1.Items.Add(e);
            }
        }
        public InfoBoton(List<Pelicula> list)
        {
            InitializeComponent();
            foreach (Pelicula e in list)
            {
                listBox1.Items.Add(e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Persona)
            {
                DetallePersona detallePersona = new DetallePersona(listBox1.SelectedItem);
                Close();
                detallePersona.Show();
            }
            else if (listBox1.SelectedItem is Estudio)
            {
                DetalleEstudio detalleEstudio = new DetalleEstudio(listBox1.SelectedItem);
                Close();
                detalleEstudio.Show();
            }
            else if (listBox1.SelectedItem is Pelicula)
            {
                DetallePelicula detallePelicula = new DetallePelicula(listBox1.SelectedItem);
                Close();
                detallePelicula.Show();
            }
            
        }
    }
}
