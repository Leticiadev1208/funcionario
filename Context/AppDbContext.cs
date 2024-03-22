using apifuncionario.models;
using Microsoft.EntityFrameworkCore;

namespace apifuncionario.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base (options)

    {}

    public DbSet<Funcionario> Items {get;set;}
    public DbSet<Setor> Setors {get;set;}
}
