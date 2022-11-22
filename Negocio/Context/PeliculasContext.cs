using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaentity.Models
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext ():base("PeliculaDbkey"){}

        public DbSet<Pelicula> Peliculas{ get; set; }
        public DbSet<Genero>Generos  { get; set; }

        public DbSet<Clasificacion> Clasificaciones { get; set; }

    }
}
