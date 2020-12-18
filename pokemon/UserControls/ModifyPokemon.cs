using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class ModifyPokemon : UserControl
    {
        private DataGridViewSelectedCellCollection SelectedPokemon;

        PokemonsUserControl pokemonsUserControl = new PokemonsUserControl();

        public ModifyPokemon(DataGridViewSelectedCellCollection selectedPokemon)
        {
            InitializeComponent();
            SelectedPokemon = selectedPokemon;
        }

        private void ModifyPokemon_Load(object sender, EventArgs e)
        {
            loadExistingValuesOfSelectedPokemon();
        }

        private void loadExistingValuesOfSelectedPokemon()
        {
            textBox_ChangeName.Text = SelectedPokemon[0].Value.ToString();
            textBox_ChangeHp.Text = SelectedPokemon[3].Value.ToString();

            foreach (var ability in SelectedPokemon[2].Value.ToString().Split('\n'))
            {
                listBox_Abilties.Items.Add(ability);
            }

            foreach (var deck in pokemonsUserControl.db.Pokemon_Deck_JTs)
            {

                if (deck.PokemonID.ToString() == SelectedPokemon[6].Value.ToString())
                {
                    listBox_Decks.Items.Add(deck.DeckID.ToString());
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
