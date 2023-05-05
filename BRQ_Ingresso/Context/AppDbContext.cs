using BRQ_Ingresso.Models;
using Microsoft.EntityFrameworkCore;

namespace BRQ_Ingresso.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<EnderecoUsuario> EnderecoUsuarios { get; set; }

}
