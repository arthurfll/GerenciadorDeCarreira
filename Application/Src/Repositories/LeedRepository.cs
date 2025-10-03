using Source.Data;
using Source.Models;

namespace Source.Repositories;

public class LeedRepository
{
  readonly AppDbContext _db;
  public LeedRepository(AppDbContext db)
  {
    _db = db;
  }

  public List<LeedListRowDto> GetLeedsByUser(string userId)
  {
    var data = _db.Leeds
      .Where(x => x.UserId == userId)
      .Select(L => new LeedListRowDto
      {
        Empresa = L.Empresa,
        VagaTitulo = L.VagaTitulo,
        FaseCandidatura = L.FaseCandidatura,
        DataAtualizacao = L.DataAtualizacao
      })
      .ToList();

    return data;
  }

  public void AddLeed(Leed obj)
  {
    _db.Leeds.Add(obj);
    _db.SaveChanges();
  }
}


public class LeedListRowDto
{
    public string Empresa { get; set; }
    public string VagaTitulo { get; set; }
    public FaseCandidatura FaseCandidatura { get; set; }
    public DateTime DataAtualizacao { get; set; }
}

