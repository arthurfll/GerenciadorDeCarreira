using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Source.Models;

public class Leed
{
  [Key]
  public Guid Id { get; set; }
  [Required]
  public string UserId { get; set; }
  [ForeignKey(nameof(UserId))]
  public IdentityUser User { get; set; }

  [Required]
  [StringLength(50, ErrorMessage = "O nome da empresa deve ter no máximo 100 caracteres.")]
  public string Empresa { get; set; }

  [Required]
  [StringLength(100, ErrorMessage = "O título da vaga deve ter no máximo 100 caracteres.")]
  public string VagaTitulo { get; set; }

  [Required]
  [StringLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres.")]
  public string Descricao { get; set; }
  public DateTime DataRegistro { get; set; } = DateTime.UtcNow;
  public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;
  [Required]
  public FaseCandidatura FaseCandidatura { get; set; }
}

public enum FaseCandidatura
{
  CURRICULO = 1,
  ENTREVISTA_RH = 2,
  TESTE_TECNICO = 3,
  ENTREVISTA_TECNICA = 4,
  EXAMES_MEDICOS = 5,
  APROVADA = 6,
  REPROVADA = 7,
}

