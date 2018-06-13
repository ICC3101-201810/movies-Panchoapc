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
    public partial class DetallePelicula : Form
    {
        Pelicula pelicula;
        public DetallePelicula(object sender)
        {
            InitializeComponent();
            if (sender is Pelicula)
            {
                pelicula = (Pelicula)sender;
                label_Name.Text = pelicula.GetName();
                label_NameD.Text = pelicula.GetDirector().ToString();
                label_bdateD.Text = pelicula.GetDirector().GetCumpleanos();
                label_BioD.Text = pelicula.GetDirector().GetBiografia();
                label_NameP.Text = pelicula.GetProductor().ToString();
                label_bdateP.Text = pelicula.GetProductor().GetCumpleanos();
                label_BioP.Text = pelicula.GetProductor().GetBiografia();
                label_Info.Text = pelicula.GetDescripcion();
                label_NameE.Text = pelicula.GetEstudio().GetName();
                label_DateM.Text = pelicula.GetFecha();
                label_Budget.Text = pelicula.GetPresupuesto();
                foreach (Actor p in pelicula.GetActores())
                {
                    listView_Movies.Items.Add(p.ToString());
                }
            }
        }
    }
}
