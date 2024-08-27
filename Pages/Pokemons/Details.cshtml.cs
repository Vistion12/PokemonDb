using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokemonDb.Data;
using PokemonDb.Model;

namespace PokemonDb.Pages.Pokemons;

public class DetailsModel(PokemonContext pokemonContext) : PageModel
{
    public Pokemon? Pokemon { get; set; }
    public async Task OnGetAsync(int id)
    {
        Pokemon = await pokemonContext.Pokemons.FirstAsync(pokemon => pokemon.Id == id);

        

    }
}
