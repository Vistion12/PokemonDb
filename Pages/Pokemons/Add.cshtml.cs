using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonDb.Data;
using PokemonDb.Model;

namespace PokemonDb.Pages.Pokemons;

public class AddModel(PokemonContext pokemonContext) : PageModel
{
    
    public void OnGet()
    {
        ViewData["Title"] = "���������� �������� � ����";
    }
    [BindProperty]
    public Pokemon? Pokemon { get; set; }
    public async Task <IActionResult> OnPostAsync()
    {       
        if (Pokemon is null || !ModelState.IsValid)
        {
            return Page();
        }

        await pokemonContext.Pokemons.AddAsync(Pokemon);
        await pokemonContext.SaveChangesAsync();

        return RedirectToPage("./Index");

    }
}
