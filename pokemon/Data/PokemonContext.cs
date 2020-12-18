using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class PokemonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PokmonDeck;Trusted_Connection=True;");
        }

        //DBSet representerar en entity som kan användas för att skapa, läsa, uppdatera och delete operationer
        public virtual DbSet<Pokemon> Pokemons {get;set;}
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Pokemon_Ability_JT> Pokemon_Ability_JTs { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Deck> Decks { get; set; }
        public virtual DbSet<Pokemon_Deck_JT> Pokemon_Deck_JTs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
