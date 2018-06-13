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
    public partial class DetalleEstudio : Form
    {
        Estudio estudio;
        public DetalleEstudio(object sender)
        {
            InitializeComponent();
            if (sender is Estudio)
            {
                estudio = (Estudio)sender;
                label_Name.Text = estudio.GetName();
                label_FechaA.Text = estudio.GetFecha();
                label_NameD.Text = estudio.GetDirector().ToString();
                label_bdateD.Text = estudio.GetDirector().GetCumpleanos();
                label_BioD.Text = estudio.GetDirector().GetBiografia();
                foreach (Pelicula p in estudio.GetPeliculas())
                {
                    listView_Movies.Items.Add(p.GetName());
                }
            }
        }
    }
}
