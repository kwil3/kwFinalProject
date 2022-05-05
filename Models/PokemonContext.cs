using Microsoft.EntityFrameworkCore;

namespace kwFinalProject.models
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext (DbContextOptions<PokemonDbContext> options)
            : base(options)
            {
            }
            public DbSet<User> Pokemons {get; set;}
    }
}