public class AsignareRepository : IAsignareRepository
{
    private readonly ApplicationContext _context;

    public AsignareRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Asignare> GetAsignari()
    {
        return _context.Asignari.Include(a => a.Profesor).Include(a => a.Materie).ToList();
    }

    public void AdaugaAsignare(Asignare asignare)
    {
        _context.Asignari.Add(asignare);
        _context.SaveChanges();
    }
}
