using Examen_backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/profesori")]
public class ProfesorController : ControllerBase
{
    private readonly IProfesorRepository _profesorRepository;

    public ProfesorController(IProfesorRepository profesorRepository)
    {
        _profesorRepository = profesorRepository;
    }

    [HttpGet]
    public IActionResult GetProfesori()
    {
        var profesori = _profesorRepository.GetProfesori();
        return Ok(profesori);
    }

    [HttpPost]
    public IActionResult AdaugaProfesor([FromBody] Profesor profesor)
    {
        _profesorRepository.AdaugaProfesor(profesor);
        return Ok(profesor);
    }
}