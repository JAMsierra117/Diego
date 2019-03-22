namespace Diego.Models.Catalogos
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Clasificacion { get; set; }
        public Clasificacion Clasificacion { get; set; }
    }
}