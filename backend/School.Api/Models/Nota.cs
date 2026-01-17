using System.ComponentModel.DataAnnotations.Schema;

namespace School.Api.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }

        public int IdEstudiante { get; set; }
        public Estudiante Estudiante { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Valor { get; set; }

    }
}
