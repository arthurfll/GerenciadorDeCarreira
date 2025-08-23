using DotnetApi.Data;
using DotnetApi.Models;

namespace DotnetApi.Repositories;

public class TarefaRepository
{
  private readonly AppDbContext _db;

  public TarefaRepository(AppDbContext db)
  {
    _db = db;
  }

  public Tarefa GetTarefaById(Guid Id)
  {
    var data = _db.Tarefas.FirstOrDefault(x => x.Id == Id);
    return data;
  }

  public List<Tarefa> GetAllTarefas()
  {
    var data = _db.Tarefas.ToList();

    if (data == null) return new List<Tarefa>();

    return data;
  }

  public void AdicionarTarefa(Tarefa obj)
  {
    _db.Tarefas.Add(obj);
    _db.SaveChanges();
  }
}


