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
    public partial class DetallePersona : Form
    {
        Persona persona;
        public DetallePersona(object sender)
        {
            InitializeComponent();
            if (sender is Persona)
            {
                persona = (Persona)sender;
                label_Name.Text = persona.GetName();
                label_Lastname.Text = persona.GetApellido();
                label_Birth.Text = persona.GetCumpleanos();
                label_Biography.Text = persona.GetBiografia();
                foreach (Pelicula p in persona.GetPeliculas())
                {
                    listView_Movies.Items.Add(p.GetName());
                }
            }
        }
    }
}
