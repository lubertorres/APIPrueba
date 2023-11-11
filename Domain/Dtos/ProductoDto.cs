namespace apiPrueba.Dtos
{
    public class ProductoDto
    {


        public string Nombre { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public bool Estado { get; set; }

        public Guid IdEstadoProducto { get; set; }
    }
}
