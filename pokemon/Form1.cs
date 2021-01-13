using pokemon.Properties;
using pokemon.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_PokemonInfo.Text = "By pressing 'Pokemons' you see what\npokemons exist in the pokedex,\nYou can create your own pokemon\nor even modify old ones!";
            label_AbilityInfo.Text = "By pressing 'Abilities' you see what\nabilities exist.\nYou can create your own abilities\nor even modify old ones!";
            label_DeckInfo.Text = "By pressing 'Decks' you see what\ndecks exist.\nYou can create new decks\nor modify the name of old ones!";

            var picOfChar = Resources._char;
            pictureBox_load.Image = picOfChar;
            pictureBox_load.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Pokemons_Click(object sender, EventArgs e)
        {
            PokemonsUserControl pokemonsUserControl = new PokemonsUserControl();

            Controls.Add(pokemonsUserControl);
            pokemonsUserControl.Visible = true;
            pokemonsUserControl.Dock = DockStyle.Fill;
            pokemonsUserControl.BringToFront();
        }

        private void button1_Abilities_Click(object sender, EventArgs e)
        {
            AbilityUsercontrol abilityUsercontrol = new AbilityUsercontrol();
            Controls.Add(abilityUsercontrol);
            abilityUsercontrol.Visible = true;
            abilityUsercontrol.Dock = DockStyle.Fill;
            abilityUsercontrol.BringToFront();
        }

        private void button2_Decks_Click(object sender, EventArgs e)
        {
            DeckUserControl deckUserControl = new DeckUserControl();
            Controls.Add(deckUserControl);
            deckUserControl.Visible = true;
            deckUserControl.Dock = DockStyle.Fill;
            deckUserControl.BringToFront();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this != null)
            {
                button1_Pokemons.Left = (this.Width - button1_Pokemons.Width) / 2;
                label_PokemonInfo.Left = (this.Width - button1_Pokemons.Width) / 2 + 205;


                button1_Abilities.Left = (this.Width - button1_Abilities.Width) / 2;
                label_AbilityInfo.Left = (this.Width - button1_Pokemons.Width) / 2 + 205;


                button2_Decks.Left = (this.Width - button2_Decks.Width) / 2;
                label_DeckInfo.Left = (this.Width - button1_Pokemons.Width) / 2 + 205;

                pictureBox_load.Left = (this.Width - pictureBox_load.Width) / 2 - 245;
                



            }
        }
    }
}
