using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemon.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinDmg = table.Column<int>(type: "int", nullable: false),
                    MaxDmg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pokemons_Trainers_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Ability_JTs",
                columns: table => new
                {
                    PokemonID = table.Column<int>(type: "int", nullable: false),
                    AbilityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Ability_JTs", x => new { x.AbilityID, x.PokemonID });
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JTs_Abilities_AbilityID",
                        column: x => x.AbilityID,
                        principalTable: "Abilities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JTs_Pokemons_PokemonID",
                        column: x => x.PokemonID,
                        principalTable: "Pokemons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Deck_JTs",
                columns: table => new
                {
                    DeckID = table.Column<int>(type: "int", nullable: false),
                    PokemonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Deck_JTs", x => new { x.DeckID, x.PokemonID });
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JTs_Decks_DeckID",
                        column: x => x.DeckID,
                        principalTable: "Decks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JTs_Pokemons_PokemonID",
                        column: x => x.PokemonID,
                        principalTable: "Pokemons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "ID", "MaxDmg", "MinDmg", "Name" },
                values: new object[,]
                {
                    { 1, 23, 10, "Lightning Bolt" },
                    { 2, 37, 15, "Thunder" },
                    { 3, 21, 11, "Bubble" },
                    { 4, 55, 20, "Hydro Pump" },
                    { 5, 24, 11, "Psy beam" },
                    { 6, 19, 9, "Razor Leaf" },
                    { 7, 57, 16, "Flamethrower" },
                    { 8, 52, 17, "Eathquake" },
                    { 9, 26, 15, "Bite" }
                });

            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Standard" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "ID", "Age", "Name", "location" },
                values: new object[,]
                {
                    { 4, 13, "Tarot", "Cinnibar Island" },
                    { 3, 19, "Brook", "Cerulean City" },
                    { 1, 15, "Ash", "Pallet Town" },
                    { 2, 17, "Misty", "Anistar City" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 10, "Dragon" },
                    { 16, "Posion" },
                    { 15, "Steel" },
                    { 14, "Water" },
                    { 13, "Dark" },
                    { 12, "Fairy" },
                    { 11, "Grass" },
                    { 9, "Psychic" },
                    { 2, "Ground" },
                    { 7, "Bug" },
                    { 6, "Fighting" },
                    { 5, "Flying" },
                    { 4, "Rock" },
                    { 3, "Fire" },
                    { 17, "Normal" },
                    { 1, "Electric" },
                    { 8, "Ghost" },
                    { 18, "Ice" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "ID", "HP", "Level", "Name", "TrainerID", "TypeID" },
                values: new object[] { 1, 50, 22, "Pikachu", 1, 1 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "ID", "HP", "Level", "Name", "TrainerID", "TypeID" },
                values: new object[] { 2, 50, 59, "Blastoise", 2, 14 });

            migrationBuilder.InsertData(
                table: "Pokemon_Ability_JTs",
                columns: new[] { "AbilityID", "PokemonID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pokemon_Deck_JTs",
                columns: new[] { "DeckID", "PokemonID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_JTs_PokemonID",
                table: "Pokemon_Ability_JTs",
                column: "PokemonID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Deck_JTs_PokemonID",
                table: "Pokemon_Deck_JTs",
                column: "PokemonID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TrainerID",
                table: "Pokemons",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeID",
                table: "Pokemons",
                column: "TypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_Ability_JTs");

            migrationBuilder.DropTable(
                name: "Pokemon_Deck_JTs");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
