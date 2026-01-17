namespace School.Api.DTOs
{
    public class NotaCreateDto
    {
        public string Nombre { get; set; }
        public int IdProfesor { get; set; }
        public int IdEstudiante { get; set; }
        public decimal Valor { get; set; }
    }

}
