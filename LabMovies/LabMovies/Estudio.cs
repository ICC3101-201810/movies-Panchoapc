using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMovies
{
    public class Estudio
    {
        string nombre;
        Director director;
        string fechaApertura;
        List<Pelicula> peliculas;
        public Estudio(string miNombre, Director miDirector, string miFecha)
        {
            nombre = miNombre;
            director = miDirector;
            fechaApertura = miFecha;
            peliculas = new List<Pelicula>();
        }
        public void AddPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        public List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }
        public string GetName()
        {
            return nombre;
        }
        public Director GetDirector()
        {
            return director;
        }
        public string GetFecha()
        {
            return fechaApertura;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
