using Examen_backend.Models.DTO;

public interface IMaterieRepository
{
    IEnumerable<Materie> GetMaterii();
    void AdaugaMaterie(Materie materie);
}