using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemon.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
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
                    table.PrimaryKey("PK_Ability", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
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
                    table.PrimaryKey("PK_Trainer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
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
                    table.PrimaryKey("PK_Pokemon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pokemon_Trainer_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Type_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Ability_JT",
                columns: table => new
                {
                    PokemonID = table.Column<int>(type: "int", nullable: false),
                    AbilityID = table.Column<int>(type: "int", nullable: false),
                    PokemonID1 = table.Column<int>(type: "int", nullable: true),
                    AbilityID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Ability_JT", x => new { x.AbilityID, x.PokemonID });
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JT_Ability_AbilityID",
                        column: x => x.AbilityID,
                        principalTable: "Ability",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JT_Ability_AbilityID1",
                        column: x => x.AbilityID1,
                        principalTable: "Ability",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JT_Pokemon_PokemonID",
                        column: x => x.PokemonID,
                        principalTable: "Pokemon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_JT_Pokemon_PokemonID1",
                        column: x => x.PokemonID1,
                        principalTable: "Pokemon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Deck_JT",
                columns: table => new
                {
                    DeckID = table.Column<int>(type: "int", nullable: false),
                    PokemonID = table.Column<int>(type: "int", nullable: false),
                    DeckID1 = table.Column<int>(type: "int", nullable: true),
                    PokemonID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Deck_JT", x => new { x.DeckID, x.PokemonID });
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JT_Deck_DeckID",
                        column: x => x.DeckID,
                        principalTable: "Deck",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JT_Deck_DeckID1",
                        column: x => x.DeckID1,
                        principalTable: "Deck",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JT_Pokemon_PokemonID",
                        column: x => x.PokemonID,
                        principalTable: "Pokemon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Deck_JT_Pokemon_PokemonID1",
                        column: x => x.PokemonID1,
                        principalTable: "Pokemon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_TrainerID",
                table: "Pokemon",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_TypeID",
                table: "Pokemon",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_JT_AbilityID1",
                table: "Pokemon_Ability_JT",
                column: "AbilityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_JT_PokemonID",
                table: "Pokemon_Ability_JT",
                column: "PokemonID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_JT_PokemonID1",
                table: "Pokemon_Ability_JT",
                column: "PokemonID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Deck_JT_DeckID1",
                table: "Pokemon_Deck_JT",
                column: "DeckID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Deck_JT_PokemonID",
                table: "Pokemon_Deck_JT",
                column: "PokemonID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Deck_JT_PokemonID1",
                table: "Pokemon_Deck_JT",
                column: "PokemonID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_Ability_JT");

            migrationBuilder.DropTable(
                name: "Pokemon_Deck_JT");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
