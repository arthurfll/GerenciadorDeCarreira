using DotnetApi.Repositories;
using DotnetApi.Models;

namespace DotnetApi.Services;


public class TarefaService
{
  private readonly TarefaRepository _r;

  public TarefaService(TarefaRepository r)
  {
    _r = r;
  }

  public Tarefa GetTarefaById(Guid Id)
  {
    var data = _r.GetTarefaById(Id);
    return data;
  }

  public List<Tarefa> GetAllTarefas()
  {
    var data = _r.GetAllTarefas();

    if (data == null) return new List<Tarefa>();

    return data;
  }

  public void AdicionarTarefa(Tarefa obj)
  {
    _r.AdicionarTarefa(obj);
  }
}

