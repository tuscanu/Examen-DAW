using Examen_backend.Models.DTO;

public class ProfesorRepository : IProfesorRepository
{
    private readonly ApplicationContext _context;

    public ProfesorRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Profesor> GetProfesori()
    {
        return _context.Profesori.Include(p => p.Asignari).ToList();
    }

    public void AdaugaProfesor(Profesor profesor)
    {
        _context.Profesori.Add(profesor);
        _context.SaveChanges();
    }
}
