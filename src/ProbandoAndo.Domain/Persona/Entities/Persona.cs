
using System.ComponentModel.DataAnnotations.Schema;

namespace ProbandoAndo.Domain.Persona.Entities;

public class Persona
{
    [Column("id")]
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public int? Edad { get; set; }

}
