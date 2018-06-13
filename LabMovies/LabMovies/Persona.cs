using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMovies
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        string cumpleanos;
        string biografia;
        List<Pelicula> peliculas;
        public Persona(string miNombre, string miApellido, string miCumpleanos, string miBiografia)
        {
            nombre = miNombre;
            apellido = miApellido;
            cumpleanos = miCumpleanos;
            biografia = miBiografia;
            peliculas = new List<Pelicula>();
        }
        public void AddPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        public string GetName()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetCumpleanos()
        {
            return cumpleanos;
        }
        public string GetBiografia()
        {
            return biografia;
        }
        public List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
