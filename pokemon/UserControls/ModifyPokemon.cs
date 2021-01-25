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

            if (SelectedPokemon[2].Value != null)
            {
                foreach (var ability in SelectedPokemon[2].Value.ToString().Split('\n'))
                {
                    listBox_Abilties.Items.Add(ability);
                }
            }

            if (SelectedPokemon[7].Value != null)
            {
                foreach (var deck in SelectedPokemon[7].Value.ToString().Split('\n'))
                {
                    listBox_Decks.Items.Add(deck);
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

            if (pokemonsUserControl.db.Abilities != null)
            {
                foreach (var ability in pokemonsUserControl.db.Abilities)
                {
                    comboBox_ChangeAbilities.Items.Add(ability.Name);
                }
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

            if (SelectedPokemon[2].Value != null) { comboBox_ChangeAbilities.SelectedIndex = 0; }

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

                foreach (var abilityCombo in pokemonsUserControl.db.Pokemon_Ability_JTs)
                {
                    if (int.Parse(SelectedPokemon[6].Value.ToString()) == abilityCombo.PokemonID)
                    {
                        pokemonsUserControl.db.Entry(abilityCombo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        pokemonsUserControl.db.Pokemon_Ability_JTs.Remove(abilityCombo);
                    }
                }

                pokemonsUserControl.db.SaveChanges();

                List<int> abilityID = new List<int>();

                foreach (var ability in listBox_Abilties.Items)
                {
                    foreach (var dbability in abilities)
                    {
                        if (ability.ToString() == dbability.Name)
                        {
                            abilityID.Add(dbability.ID);
                        }
                    }
                }

                foreach (var ability in abilityID)
                {
                    Pokemon_Ability_JT newJTpokeabi = new Pokemon_Ability_JT()
                    {
                        PokemonID = int.Parse(SelectedPokemon[6].Value.ToString()),
                        AbilityID = ability
                    };
                    pokemonsUserControl.db.Entry(newJTpokeabi).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    pokemonsUserControl.db.Pokemon_Ability_JTs.Add(newJTpokeabi);
                }

                pokemonsUserControl.db.SaveChanges();

                abilityID.Clear();

                foreach (var deckCombo in pokemonsUserControl.db.Pokemon_Deck_JTs)
                {
                    if (deckCombo.PokemonID == int.Parse(SelectedPokemon[6].Value.ToString()))
                    {
                        pokemonsUserControl.db.Entry(deckCombo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        pokemonsUserControl.db.Pokemon_Deck_JTs.Remove(deckCombo);
                    }
                }

                pokemonsUserControl.db.SaveChanges();

                List<int> deckID = new List<int>();

                foreach (var deck in listBox_Decks.Items)
                {
                    foreach (var dbDecks in decks)
                    {
                        if (deck.ToString() == dbDecks.Name)
                        {
                            deckID.Add(dbDecks.ID);
                        }
                    }
                }

                foreach (var deck in deckID)
                {
                    Pokemon_Deck_JT newJTpokedeck = new Pokemon_Deck_JT()
                    {
                        PokemonID = int.Parse(SelectedPokemon[6].Value.ToString()),
                        DeckID = deck
                    };
                    pokemonsUserControl.db.Entry(newJTpokedeck).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    pokemonsUserControl.db.Pokemon_Deck_JTs.Add(newJTpokedeck);
                    pokemonsUserControl.db.SaveChanges();
                }

                deckID.Clear();

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

                string modifiedDeckCombinations = "";
                foreach (var deck in listBox_Decks.Items)
                {
                    if (modifiedDeckCombinations.Length == 0)
                    {
                        modifiedDeckCombinations += deck;
                    }
                    else
                    {
                        modifiedDeckCombinations += "\n" + deck;
                    }

                    SelectedPokemon[7].Value = modifiedDeckCombinations;
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
            }
            else { MessageBox.Show("Pokemon already know this ability!", "Add ability failed"); }
        }
        private void button_AddToDeck_Click(object sender, EventArgs e)
        {
            if (!listBox_Decks.Items.Contains($"{comboBox_ChangeDeck.SelectedItem}"))
            {
                listBox_Decks.Items.Add(comboBox_ChangeDeck.SelectedItem.ToString());

                listBox_Decks.SelectedItem = comboBox_ChangeDeck.SelectedItem.ToString();
            }
            else { MessageBox.Show("This pokemon is already assigned to this deck!", "Add Deck failed"); }

        }
        private void button1_deleteDeck_Click(object sender, EventArgs e)
        {
            if (listBox_Decks.SelectedItem != null)
            {
                listBox_Decks.Items.Remove(listBox_Decks.SelectedItem);
                if(listBox_Decks.Items.Count > 0)
                {
                    listBox_Decks.SelectedIndex = 0;
                }
            }
        }
        private void button1_deleteAbility_Click(object sender, EventArgs e)
        {
            listBox_Abilties.Items.Remove(listBox_Abilties.SelectedItem);
        }

        private void button1_CancelModifyPokemon_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

