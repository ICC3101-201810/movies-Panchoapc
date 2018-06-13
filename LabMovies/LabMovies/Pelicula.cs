using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMovies
{
    public class Pelicula
    {
        string nombre;
        Director director;
        Productor Productor;
        List<Actor> Actores;
        string fecha;
        string descripcion;
        string presupuesto;
        Estudio estudio;

        public Pelicula(string miNombre, Director miDirector, Productor miProductor, string miFecha, string miDescripcion, string miPresupuesto, Estudio miEstudio)
        {
            nombre = miNombre;
            director = miDirector;
            miDirector.AddPelicula(this);
            Productor = miProductor;
            miProductor.AddPelicula(this);
            Actores = new List<Actor>();
            fecha = miFecha;
            descripcion = miDescripcion;
            presupuesto = miPresupuesto;
            estudio = miEstudio;
            miEstudio.AddPelicula(this);
        }
        public void AddActor(Actor actor)
        {
            actor.AddPelicula(this);
            Actores.Add(actor);
        }
        public string GetName()
        {
            return nombre;
        }
        public Director GetDirector()
        {
            return director;
        }
        public Productor GetProductor()
        {
            return Productor;
        }
        public List<Actor> GetActores()
        {
            return Actores;
        }
        public string GetFecha()
        {
            return fecha;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public string GetPresupuesto()
        {
            return presupuesto;
        }
        public Estudio GetEstudio()
        {
            return estudio;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
