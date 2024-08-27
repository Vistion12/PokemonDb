using Microsoft.EntityFrameworkCore;
using PokemonDb.Model;

namespace PokemonDb.Data
{
    public class PokemonContext (DbContextOptions<PokemonContext> options) : DbContext(options)
    {
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
