using Microsoft.EntityFrameworkCore;
using ProbandoAndo.Domain.Persona.Entities;

namespace ProbandoAndo.Infrastructure.Persistence;

public class ProbandoAndoContextDb : DbContext
{
    public ProbandoAndoContextDb(DbContextOptions options) : base(options) { }

    public DbSet<Persona> Persona => Set<Persona>();
}
