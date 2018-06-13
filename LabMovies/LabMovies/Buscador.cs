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
    public partial class Buscador : Form
    {
        BaseDeDatos bd;
        public Buscador()
        {
            InitializeComponent();
            bd = new BaseDeDatos();
            Actor Chris = new Actor("Chris", "Hemerworth", "27/05/1993", "Australiano");
            bd.AddActor(Chris);
            Actor Robert = new Actor("Robert", "Jr", "16/12/1968", "Real life IronMan");
            bd.AddActor(Robert);
            Director director = new Director("Steven", "Spilberg", "20/03/1950","Ha hecho muchas peliculas");
            bd.AddDirector(director);
            Productor productor = new Productor("Pancho", "Pieper", "10/04/1980", "Nadie lo cacha");
            bd.AddProductor(productor);
            Estudio estudio = new Estudio("20th Century Fox", director, "05/01/1995");
            bd.AddEstudio(estudio);
            Pelicula Avengers = new Pelicula("Avengers", director, productor, "25/06/2018", "A better lovestory than twilight", "US$ 1.000.000.000", estudio);
            Avengers.AddActor(Chris);
            Avengers.AddActor(Robert);
            bd.AddPelicula(Avengers);
            Pelicula Avengers2 = new Pelicula("Avengers2", director, productor, "25/06/2018", "A better lovestory than twilight", "US$ 1.000.000.000", estudio);
            Avengers2.AddActor(Chris);
            Avengers2.AddActor(Robert);
            bd.AddPelicula(Avengers2);
        }
        private void button_Peliculas_Click(object sender, EventArgs e)
        {
            InfoBoton infoActor = new InfoBoton(bd.GetPeliculas());
            infoActor.Show();
        }

        private void button_Actores_Click(object sender, EventArgs e)
        {
            InfoBoton infoActor = new InfoBoton(bd.GetActores());
            infoActor.Show();
        }

        private void button_Directores_Click(object sender, EventArgs e)
        {
            InfoBoton infoActor = new InfoBoton(bd.GetDirectores());
            infoActor.Show();
        }

        private void button_Productores_Click(object sender, EventArgs e)
        {
            InfoBoton infoActor = new InfoBoton(bd.GetProductores());
            infoActor.Show();
        }

        private void button_estudios_Click(object sender, EventArgs e)
        {
            InfoBoton infoActor = new InfoBoton(bd.GetEstudios());
            infoActor.Show();
        }
        
    }
}
