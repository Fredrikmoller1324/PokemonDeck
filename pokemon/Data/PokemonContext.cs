using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class PokemonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PokmonDeck;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PokemonEntityTypeConfiguration().Configure(modelBuilder.Entity<Pokemon>());
            new AbilityEntityTypeConfiguration().Configure(modelBuilder.Entity<Ability>());
            new DeckEntityTypeConfiguration().Configure(modelBuilder.Entity<Deck>());
            new PokemonAbilityEntityTypeConfiguration().Configure(modelBuilder.Entity<Pokemon_Ability_JT>());
            new PokemonDeckEntityTypeConfiguration().Configure(modelBuilder.Entity<Pokemon_Deck_JT>());
            new PokemonEntityTypeConfiguration().Configure(modelBuilder.Entity<Pokemon>());
            new TrainerEntityTypeConfiguration().Configure(modelBuilder.Entity<Trainer>());
            new TypeEntityTypeConfiguration().Configure(modelBuilder.Entity<Type>());

        }
    }
}
