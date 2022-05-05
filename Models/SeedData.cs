using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace kwFinalProject.Models
{
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Pokemons(
            serviceProvider.GetRequiredService<DbContextOptions<PokemonDbContext>>()))
            {
                // Look for any Pokemon.
                if (context.Pokemons.Any())
                {
                    return; // DB has been seeded
                }
                context.Pokemons.AddRange(
                    new Pokemon
                    {
                        pokeName= "Bulbasaur"
                    },
                    new Pokemon
                    {
                        pokeName = "Charmander"
                    }
                );
            context.SaveChanges();
            }
        }
    }

    
}