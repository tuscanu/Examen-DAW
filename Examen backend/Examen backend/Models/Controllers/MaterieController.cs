using Examen_backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/materii")]
public class MaterieController : ControllerBase
{
    private readonly IMaterieRepository _materieRepository;

    public MaterieController(IMaterieRepository materieRepository)
    {
        _materieRepository = materieRepository;
    }

    [HttpGet]
    public IActionResult GetMaterii()
    {
        var materii = _materieRepository.GetMaterii();
        return Ok(materii);
    }

    [HttpPost]
    public IActionResult AdaugaMaterie([FromBody] Materie materie)
    {
        _materieRepository.AdaugaMaterie(materie);
        return Ok(materie);
    }
}