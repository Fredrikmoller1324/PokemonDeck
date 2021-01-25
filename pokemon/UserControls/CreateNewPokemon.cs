using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class CreateNewPokemon : UserControl
    {
        DataGridView pokedata = new DataGridView();
        List<Trainer> trainers;
        List<Type> types;
        List<Deck> decks;
        List<Ability> abilities;

        public CreateNewPokemon(DataGridView datagridPokemon, List<Trainer> trainers, List<Type> types, List<Deck> decks, List<Ability> abilities)
        {
            InitializeComponent();
            pokedata = datagridPokemon;
            this.trainers = trainers;
            this.types = types;
            this.decks = decks;
            this.abilities = abilities;

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_PokemonName.TextLength != 0 && System.Text.RegularExpressions.Regex.IsMatch(textBox_Hp.Text, "^[0-9]*$") &&
                listBox_Abilties.Items.Count != 0 && listBox_Decks.Items.Count != 0)
            {

                PokemonsUserControl pokemonsUserControl = new PokemonsUserControl();

                int rowIndex = pokedata.Rows.Add();

                pokedata.Rows[rowIndex].Cells["pokemons"].Value = textBox_PokemonName.Text;

                pokedata.Rows[rowIndex].Cells["HP"].Value = textBox_Hp.Text;

                pokedata.Rows[rowIndex].Cells["Trainer"].Value = comboBox_Trainer.SelectedItem.ToString();

                pokedata.Rows[rowIndex].Cells["Level"].Value = numericUpDown_Level.Value.ToString();

                pokedata.Rows[rowIndex].Cells["Type"].Value = comboBox_type.SelectedItem.ToString();

                List<string> newPokemonAbilityName = new List<string>();

                string abilityNames = "";
                foreach (var ability in listBox_Abilties.Items)
                {

                    newPokemonAbilityName.Add(ability.ToString());

                    if (abilityNames.Length == 0)
                    {
                        abilityNames += ability;
                    }
                    else
                    {
                        abilityNames += "\n" + ability;
                    }
                    pokedata.Rows[rowIndex].Cells["Abilities"].Value = abilityNames;
                }


                List<int> newpokemonAbilityID = new List<int>();

                foreach (var ability in abilities)
                {
                    foreach (var abilityAdded in newPokemonAbilityName)
                    {
                        if (ability.Name == abilityAdded)
                        {
                            newpokemonAbilityID.Add(int.Parse(ability.ID.ToString()));
                        }
                    }
                }

                int trainerID = 0;
                foreach (var trainer in trainers)
                {
                    if (comboBox_Trainer.SelectedItem.ToString() == trainer.Name) { trainerID = trainer.ID; }
                }

                int typeID = 0;
                foreach (var type in types)
                {
                    if (comboBox_type.SelectedItem.ToString() == type.Name) { typeID = type.ID; }
                }


                Pokemon newPokemon = new Pokemon()
                {
                    Name = textBox_PokemonName.Text,
                    HP = int.Parse(textBox_Hp.Text),
                    Level = int.Parse(numericUpDown_Level.Value.ToString()),
                    TrainerID = trainerID,
                    TypeID = typeID
                };

                pokemonsUserControl.db.Pokemons.Add(newPokemon);
                pokemonsUserControl.db.SaveChanges();
                pokedata.Rows[rowIndex].Cells["ID"].Value = newPokemon.ID;

                //Controller added to not insert duplicates
                int controller = 0;
                foreach (var abilty in newPokemonAbilityName)
                {
                    foreach (var abilityID in newpokemonAbilityID)
                    {
                        foreach (var abiltyObject in abilities)
                        {
                            if (abiltyObject.Name == abilty)
                            {
                                controller++;

                                Pokemon_Ability_JT newJTpokeabi = new Pokemon_Ability_JT()
                                {
                                    PokemonID = newPokemon.ID,
                                    AbilityID = abilityID,
                                };

                                if (controller <= newpokemonAbilityID.Count)
                                {
                                    pokemonsUserControl.db.Pokemon_Ability_JTs.Add(newJTpokeabi);
                                }

                            }
                        }
                    }
                }
                pokemonsUserControl.db.SaveChanges();
                
                List<int> deckid = new List<int>();
                foreach (var deck in listBox_Decks.Items)
                {
                    foreach (var existingDecks in decks)
                    {
                        if (deck.ToString() == existingDecks.Name)
                        {
                            deckid.Add(existingDecks.ID);
                        }
                    }
                }

                foreach (var deck in deckid)
                {
                    Pokemon_Deck_JT newJTpokeDeck = new Pokemon_Deck_JT()
                    {
                        PokemonID = newPokemon.ID,
                        DeckID = deck,
                    };
                    pokemonsUserControl.db.Pokemon_Deck_JTs.Add(newJTpokeDeck);
                    
                }

                pokemonsUserControl.db.SaveChanges();
                pokemonsUserControl.LoadAllPokemons();
                this.Hide();
            }

            if (listBox_Abilties.Items.Count == 0 || listBox_Decks.Items.Count == 0)
            {
                MessageBox.Show("You need to add atleast one ability and one deck", "Invalidate Input");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_Hp.Text, "^[0-9]*$"))
            {
                MessageBox.Show("The Hp of pokemon can only have a numeric value", "Invalid input");
            }

        }

        private void CreateNewPokemon_Load(object sender, EventArgs e)
        {
            foreach (var trainer in trainers)
            {
                comboBox_Trainer.Items.Add(trainer.Name);
            }

            foreach (var type in types)
            {
                comboBox_type.Items.Add(type.Name);
            }

            if(decks != null)
            {
                foreach (var deck in decks)
                {
                    comboBox_Deck.Items.Add(deck.Name);
                }
            }
            
            if(abilities != null)
            {
                foreach (var ability in abilities)
                {
                    comboBox_Abilities.Items.Add(ability.Name);
                }
            }

            comboBox_Trainer.SelectedIndex = 0;
            comboBox_type.SelectedIndex = 0;
            comboBox_Deck.SelectedIndex = 0;
            comboBox_Abilities.SelectedIndex = 0;
        }

        private void button_AddAbility_Click(object sender, EventArgs e)
        {
            if (!listBox_Abilties.Items.Contains($"{comboBox_Abilities.SelectedItem}"))
            {
                listBox_Abilties.Items.Add(comboBox_Abilities.SelectedItem.ToString());
            }
            else { MessageBox.Show("Pokemon already know this ability!","Add ability failed"); }
        }

        private void button_AddToDeck_Click(object sender, EventArgs e)
        {
            if (!listBox_Decks.Items.Contains($"{comboBox_Deck.SelectedItem}"))
            {
                listBox_Decks.Items.Add(comboBox_Deck.SelectedItem.ToString());
            }
            else { MessageBox.Show("This pokemon is already assigned to this deck!", "Add Deck failed");}
        }

        private void button_RemoveAbility_Click(object sender, EventArgs e)
        {
            if(listBox_Abilties.SelectedItem != null)
            {
                listBox_Abilties.Items.Remove(listBox_Abilties.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox_Decks.SelectedItem != null)
            {
                listBox_Decks.Items.Remove(listBox_Decks.SelectedItem);
            }
        }
    }
}
