namespace Diego.Dtos.Catalogos
{
    public class ProductoToReturnDTO
    {
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Clasificacion { get; set; }
        public string Clasificacion { get; set; }
    }
}