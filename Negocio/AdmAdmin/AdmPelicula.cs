using Practicaentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.AdmAdmin
{
   public static  class AdmPelicula
    {
        public static PeliculasContext context = new  PeliculasContext();
        public static List<Pelicula> Lista()
        {
            List<Pelicula> lista = new List<Pelicula>() { };
            lista = context.Peliculas.ToList();
            return lista;

        }


        public static Pelicula TraerUno(string id)
        {


            Pelicula peliculas = new Pelicula();
            peliculas = context.Peliculas.Find(id);
            return peliculas;
        }
        public static int Nuevo(Pelicula peliculas)
        {
            context.Peliculas.Add(peliculas);
            int filasafectadas = context.SaveChanges();

            return filasafectadas;

        }

        public static int Eliminar(Pelicula pelicula)
        {

            int idabuscar = pelicula.Id;
            Pelicula peliculaAbuscar = context.Peliculas.Find(idabuscar);

            if (peliculaAbuscar != null)
            {

                context.Peliculas.Remove(peliculaAbuscar);


            }
            int filasafectadas = context.SaveChanges();
            return filasafectadas;

        }

    }
}
