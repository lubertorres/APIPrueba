namespace apiPrueba.Dtos
{
    public class UsuarioDto
    {
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public int Edad { get; set; }
        public Guid IRol { get; set; }

    }
}
