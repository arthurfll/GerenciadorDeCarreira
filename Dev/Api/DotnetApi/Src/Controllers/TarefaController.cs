using DotnetApi.Models;
using DotnetApi.Services;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class TarefaController : ControllerBase
{
  private readonly TarefaService _s;
  public TarefaController(TarefaService s)
  {
    _s = s;
  }

  [HttpGet]
  public IActionResult Index()
  {
    var data = _s.GetAllTarefas();
    return Ok(data);
  }
}
