using Microsoft.EntityFrameworkCore;
using ProbandoAndo.API.Mapping;
using ProbandoAndo.API.Request;
using ProbandoAndo.Infrastructure.Persistence;

namespace ProbandoAndo.API.Endpoints.Persona;

public static class CreatePersonaEndpoint
{
    //private readonly ProbandoAndoContextDb _dbContext;
    //public CreatePersonaEndpoint(ProbandoAndoContextDb probandoAndoContextDb)
    //{
    //    _dbContext = probandoAndoContextDb;
    //}
    public const string Name = "CreatePersona";

    public static IEndpointRouteBuilder MapCreatePersona(this IEndpointRouteBuilder app)
    {
        _ = app.MapPost("/", async (
        CreatePersonaRequest request,
        ProbandoAndoContextDb probandoAndoContextDb
            ) =>
        {
            var persona = request.MapToPersona();
            var person = await probandoAndoContextDb.AddAsync(persona);
            await probandoAndoContextDb.SaveChangesAsync();
            //Aqui debe de vernir el repositorio para poder realizar la logica necesaria
            //_dbContext.
        }).WithName(Name);
        return app;
    }
}
