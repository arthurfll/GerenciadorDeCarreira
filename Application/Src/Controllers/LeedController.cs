using Microsoft.AspNetCore.Mvc;
using Source.Services;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Source.Models;


namespace Source.Controllers;

public class LeadController : Controller
{
  private readonly LeedService _s;
  public LeadController(LeedService s)
  {
    _s = s;
  }

  [HttpGet, Authorize]
  public IActionResult Index()
  {
    string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

    if (userId == null) return NotFound();

    var data = _s.GetLeedsByUser(userId);

    return View(data);
  }

  [HttpGet, Authorize]
  public IActionResult New()
  {
    return View();
  }
  [HttpPost, Authorize]
  public IActionResult New(Leed obj)
  {
    string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    obj.UserId = userId;
    _s.AddLeed(obj);
    return Redirect("/Lead");
  }
}

