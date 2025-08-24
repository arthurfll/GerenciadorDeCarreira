namespace DotnetApi.Models;
using System.ComponentModel.DataAnnotations;

public class Tarefa
{
  [Key]
  public Guid Id { get; set; }
  public string Nome { get; set; }
  public string Descricao { get; set; }
  public StatusTarefa Status { get; set; }
}

public enum StatusTarefa
{
  ToDo, Doing, Standby, Done
}
