using Examen_backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/asignari")]
public class AsignareController : ControllerBase
{
    private readonly IAsignareRepository _asignareRepository;

    public AsignareController(IAsignareRepository asignareRepository)
    {
        _asignareRepository = asignareRepository;
    }

    [HttpGet]
    public IActionResult GetAsignari()
    {
        var asignari = _asignareRepository.GetAsignari();
        return Ok(asignari);
    }

    [HttpPost]
    public IActionResult AdaugaAsignare([FromBody] Asignare asignare)
    {
        _asignareRepository.AdaugaAsignare(asignare);
        return Ok(asignare);
    }
}