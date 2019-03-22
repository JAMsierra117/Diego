using System.Collections.Generic;

namespace Diego.Models.Catalogos
{
    public class Clasificacion
    {
        public int ID_Clasificacion { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Producto> Productos { get;set; }
    }
}