using Source.Models;
using Source.Repositories;

namespace Source.Services;

public class LeedService
{
  private readonly LeedRepository _r;

  public LeedService(LeedRepository r)
  {
    _r = r;
  }

  public List<LeedListRowDto> GetLeedsByUser(string userId)
  {
    var data = _r.GetLeedsByUser(userId);
    return data;
  }

  public void AddLeed(Leed obj)
  {
    _r.AddLeed(obj);
  }
}

