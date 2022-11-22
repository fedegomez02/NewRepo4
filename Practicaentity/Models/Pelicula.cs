using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaentity.Models
{
   public class Pelicula
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string FechaEstreno { get; set; }
       

        public int CantMinutos{ get; set; }
        public string Idioma { get; set; }
        public string Sinapsis { get; set; }

        #region Propiedades de navegacion
        public virtual Genero Genero { get; set; }

        public virtual Clasificacion Clasificacion{ get; set; }

    

        #endregion

    }
}
