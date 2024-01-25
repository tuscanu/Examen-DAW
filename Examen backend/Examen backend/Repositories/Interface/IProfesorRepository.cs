using Examen_backend.Models.DTO;

public interface IProfesorRepository
{
    IEnumerable<Profesor> GetProfesori();
    void AdaugaProfesor(Profesor profesor);
}