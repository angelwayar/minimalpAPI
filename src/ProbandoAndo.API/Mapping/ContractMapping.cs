using ProbandoAndo.API.Request;
using ProbandoAndo.Domain.Persona.Entities;

namespace ProbandoAndo.API.Mapping;

//Extension del command - Te permite crear el objeto de la entidad para rearlizar las acciones necesarias
public static class ContractMappingRequest
{
    public static Persona MapToPersona(this CreatePersonaRequest request)
    {
        return new Persona
        {
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Edad = request.Edad,
        };
    }
}
