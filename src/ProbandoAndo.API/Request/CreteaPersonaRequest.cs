namespace ProbandoAndo.API.Request;

//Command
public class CreatePersonaRequest 
{
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public int? Edad { get; set; }
}
