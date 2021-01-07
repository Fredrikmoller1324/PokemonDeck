using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class ModifyPokemon : UserControl
    {
        private DataGridViewSelectedCellCollection SelectedPokemon;
        List<Deck> decks;
        List<Ability> abilities;
        List<Pokemon_Ability_JT> pokemon_Ability_JTs;
        List<Pokemon_Deck_JT> pokemon_Deck_JTs;

        PokemonsUserControl pokemonsUserControl = new PokemonsUserControl();

        public ModifyPokemon(DataGridViewSelectedCellCollection selectedPokemon, List<Deck> decks, List<Ability> abilities, List<Pokemon_Ability_JT> pokemon_Ability_JTs, List<Pokemon_Deck_JT> pokemon_Deck_JTs)
        {
            InitializeComponent();
            SelectedPokemon = selectedPokemon;
            this.decks = decks;
            this.abilities = abilities;
            this.pokemon_Ability_JTs = pokemon_Ability_JTs;
            this.pokemon_Deck_JTs = pokemon_Deck_JTs;
        }

        private void ModifyPokemon_Load(object sender, EventArgs e)
        {
            loadExistingValuesOfSelectedPokemon();
        }

        private void loadExistingValuesOfSelectedPokemon()
        {
            textBox_ChangeName.Text = SelectedPokemon[0].Value.ToString();
            textBox_ChangeHp.Text = SelectedPokemon[3].Value.ToString();

            numericUpDown_ChangeLevel.Value = int.Parse(SelectedPokemon[4].Value.ToString());

            foreach (var ability in SelectedPokemon[2].Value.ToString().Split('\n'))
            {
                listBox_Abilties.Items.Add(ability);
            }

            foreach (var deck in pokemonsUserControl.db.Pokemon_Deck_JTs)
            {
                foreach (var allDecks in decks)
                {
                    if (deck.PokemonID.ToString() == SelectedPokemon[6].Value.ToString())
                    {
                        listBox_Decks.Items.Add(allDecks.Name);
                    }
                }

            }

            foreach (var trainer in pokemonsUserControl.db.Trainers)
            {
                comboBox_ChangeTrainer.Items.Add(trainer.Name);
            }

            foreach (var type in pokemonsUserControl.db.Types)
            {
                comboBox_ChangeType.Items.Add(type.Name);
            }

            foreach (var deck in pokemonsUserControl.db.Decks)
            {
                comboBox_ChangeDeck.Items.Add(deck.Name);
            }

            foreach (var ability in pokemonsUserControl.db.Abilities)
            {
                comboBox_ChangeAbilities.Items.Add(ability.Name);
            }


            int selectedTrainerID = 0;
            foreach (var trainer in pokemonsUserControl.db.Trainers)
            {
                if (trainer.Name == SelectedPokemon[5].Value.ToString())
                {
                    selectedTrainerID = trainer.ID;
                }
            }
            comboBox_ChangeTrainer.SelectedIndex = selectedTrainerID - 1;

            comboBox_ChangeDeck.SelectedIndex = 0;
            comboBox_ChangeAbilities.SelectedIndex = 0;

            foreach (var pokiname in pokemonsUserControl.db.Pokemons)
            {
                if (pokiname.Name == SelectedPokemon[0].Value.ToString())
                {
                    comboBox_ChangeType.SelectedIndex = pokiname.TypeID - 1;
                }
            }


        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            if (textBox_ChangeName.TextLength != 0 && System.Text.RegularExpressions.Regex.IsMatch(textBox_ChangeHp.Text, "^[0-9]*$") &&
                listBox_Abilties.Items.Count != 0 && listBox_Decks.Items.Count != 0)
            {
                int changedTrainerID = 0;
                foreach (var trainer in pokemonsUserControl.db.Trainers)
                {
                    if (trainer.Name == comboBox_ChangeTrainer.SelectedItem.ToString())
                    {
                        changedTrainerID = trainer.ID;
                    }
                }

                int changedTypeID = comboBox_ChangeType.SelectedIndex;


                foreach (var pokemon in pokemonsUserControl.db.Pokemons)
                {
                    if (pokemon.ID == int.Parse(SelectedPokemon[6].Value.ToString()))
                    {
                        pokemon.Name = textBox_ChangeName.Text;
                        pokemon.HP = int.Parse(textBox_ChangeHp.Text);
                        pokemon.Level = int.Parse(numericUpDown_ChangeLevel.Value.ToString());
                        pokemon.TrainerID = changedTrainerID;
                        pokemon.TypeID = changedTypeID + 1;

                    }
                }
                SelectedPokemon[0].Value = textBox_ChangeName.Text;
                SelectedPokemon[3].Value = textBox_ChangeHp.Text;
                SelectedPokemon[4].Value = numericUpDown_ChangeLevel.Value;
                SelectedPokemon[5].Value = comboBox_ChangeTrainer.SelectedItem;

                string abilityNames = "";
                foreach (var ability in listBox_Abilties.Items)
                {
                    if (abilityNames.Length == 0)
                    {
                        abilityNames += ability;
                    }
                    else
                    {
                        abilityNames += "\n" + ability;
                    }
                    SelectedPokemon[2].Value = abilityNames;
                }
                pokemonsUserControl.db.SaveChanges();

                this.Hide();

            }

            if (listBox_Abilties.Items.Count == 0 || listBox_Decks.Items.Count == 0)
            {
                MessageBox.Show("You need to add atleast one ability and one deck", "Invalidate Input");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_ChangeHp.Text, "^[0-9]*$"))
            {
                MessageBox.Show("The Hp of pokemon can only have a numeric value", "Invalid input");
            }


        }

        private void button_AddAbility_Click(object sender, EventArgs e)
        {
            if (!listBox_Abilties.Items.Contains($"{comboBox_ChangeAbilities.SelectedItem}"))
            {
                listBox_Abilties.Items.Add(comboBox_ChangeAbilities.SelectedItem.ToString());

                int abilityID = 0;
                foreach (var ability in abilities)
                {
                    if (comboBox_ChangeAbilities.SelectedItem.ToString() == ability.Name)
                    {
                        abilityID = ability.ID;
                    }
                }
                Pokemon_Ability_JT newJTpokeabi = new Pokemon_Ability_JT()
                {
                    PokemonID = int.Parse(SelectedPokemon[6].Value.ToString()),
                    AbilityID = abilityID

                };

                pokemonsUserControl.db.Pokemon_Ability_JTs.Add(newJTpokeabi);
                pokemonsUserControl.db.SaveChanges();
            }
            else { MessageBox.Show("Pokemon already know this ability!", "Add ability failed"); }
        }

        private void button_AddToDeck_Click(object sender, EventArgs e)
        {
            if (!listBox_Decks.Items.Contains($"{comboBox_ChangeDeck.SelectedItem}"))
            {
                listBox_Decks.Items.Add(comboBox_ChangeDeck.SelectedItem.ToString());

                int deckID = 0;
                foreach (var deck in pokemonsUserControl.db.Pokemon_Deck_JTs)
                {
                    if (comboBox_ChangeDeck.SelectedItem.ToString() == deck.Deck.Name) { deckID = deck.Deck.ID; }
                }
                Pokemon_Deck_JT newJTdeckpoke = new Pokemon_Deck_JT()
                {
                    PokemonID = int.Parse(SelectedPokemon[6].Value.ToString()),
                    DeckID = deckID
                };
                pokemonsUserControl.db.Entry(newJTdeckpoke).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                pokemonsUserControl.db.Pokemon_Deck_JTs.Add(newJTdeckpoke);
                pokemonsUserControl.db.SaveChanges();
            }
            else { MessageBox.Show("This pokemon is already assigned to this deck!", "Add Deck failed"); }

        }

        private void button1_deleteDeck_Click(object sender, EventArgs e)
        {
            if (listBox_Decks.SelectedItem != null)
            {
                int deckid = 0;
                foreach (var deck in pokemon_Deck_JTs)
                {
                    if (listBox_Decks.SelectedItem.ToString() == deck.Deck.Name)
                    {
                        deckid = deck.DeckID;
                    }
                }

                foreach (var deckCombo in pokemon_Deck_JTs)
                {
                    if (deckCombo.DeckID == deckid && int.Parse(SelectedPokemon[6].Value.ToString()) == deckCombo.PokemonID)
                    {
                        pokemonsUserControl.db.Entry(deckCombo).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                        pokemonsUserControl.db.Pokemon_Deck_JTs.Remove(deckCombo);
                    }
                }

                listBox_Decks.Items.Remove(listBox_Decks.SelectedItem);
                pokemonsUserControl.db.SaveChanges();
            }
        }
        private void button1_deleteAbility_Click(object sender, EventArgs e)
        {
            if (listBox_Abilties.SelectedItem != null)
            {
                int abilityID = 0;
                foreach (var ability in abilities)
                {
                    if (listBox_Abilties.SelectedItem.ToString() == ability.Name)
                    {
                        abilityID = ability.ID;
                    }
                }


                foreach (var abilityCombo in pokemon_Ability_JTs)
                {
                    if (abilityCombo.AbilityID == abilityID && int.Parse(SelectedPokemon[6].Value.ToString()) == abilityCombo.PokemonID)
                    {
                        pokemonsUserControl.db.Entry(abilityCombo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        pokemonsUserControl.db.Pokemon_Ability_JTs.Remove(abilityCombo);
                    }
                }

                listBox_Abilties.Items.Remove(listBox_Abilties.SelectedItem);
                pokemonsUserControl.db.SaveChanges();
            }
        }
    }
}
