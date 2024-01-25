using Examen_backend.Models.DTO;

public class MaterieRepository : IMaterieRepository
{
    private readonly ApplicationContext _context;

    public MaterieRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Materie> GetMaterii()
    {
        return _context.Materii.Include(m => m.Asignari).ToList();
    }

    public void AdaugaMaterie(Materie materie)
    {
        _context.Materii.Add(materie);
        _context.SaveChanges();
    }
}