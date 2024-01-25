using Examen_backend.Models.Domain;

namespace Examen_backend.Models.DTO
{
    public class Asignare
    {
        public int AsignareId { get; set; }
        public int ProfesorId { get; set; }
        public int MaterieId { get; set; }
        public Profesor Profesor { get; set; }
        public Materie Materie { get; set; }
    }
}
