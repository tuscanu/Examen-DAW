using Examen_backend.Models.DTO;

public interface IAsignareRepository
{
    IEnumerable<Asignare> GetAsignari();
    void AdaugaAsignare(Asignare asignare);
}