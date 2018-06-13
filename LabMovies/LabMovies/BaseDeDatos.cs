using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMovies
{
    public class BaseDeDatos
    {
        List<Actor> actores;
        List<Productor> productores;
        List<Director> directores;
        List<Estudio> estudios;
        List<Pelicula> peliculas;
        public BaseDeDatos()
        {
            actores = new List<Actor>();
            productores = new List<Productor>();
            directores = new List<Director>();
            estudios = new List<Estudio>();
            peliculas = new List<Pelicula>();
        }
        #region Add's
        public void AddActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void AddProductor(Productor productor)
        {
            productores.Add(productor);
        }
        public void AddDirector(Director director)
        {
            directores.Add(director);
        }
        public void AddEstudio(Estudio estudio)
        {
            estudios.Add(estudio);
        }
        public void AddPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        #endregion
        #region Geters
        public List<Actor> GetActores()
        {
            return actores;
        }
        public List<Productor> GetProductores()
        {
            return productores;
        }
        public List<Director> GetDirectores()
        {
            return directores;
        }
        public List<Estudio> GetEstudios()
        {
            return estudios;
        }
        public List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }
        #endregion
    }
}
