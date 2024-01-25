// Startup.cs
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Alte configurări și servicii

        // Adăugarea contextului bazei de date
        services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Adăugarea repository-urilor
        services.AddScoped<IProfesorRepository, ProfesorRepository>();
        services.AddScoped<IMaterieRepository, MaterieRepository>();
        services.AddScoped<IAsignareRepository, AsignareRepository>();

        // Alte configurări ale serviciilor
    }
}
