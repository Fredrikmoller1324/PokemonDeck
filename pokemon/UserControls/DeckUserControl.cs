using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class DeckUserControl : UserControl
    {
        public PokemonContext db = new PokemonContext();
        private List<Deck> decks;
        private List<Pokemon> pokemons;
        private List<Pokemon_Deck_JT> pokemon_decks;
        ChangeDeckName changeDeckName;
        string DeckName;

        public DeckUserControl()
        {
            InitializeComponent();
            if (db.Database.CanConnect())
            {
                decks = db.Decks.ToList();
                pokemons = db.Pokemons.ToList();
                pokemon_decks = db.Pokemon_Deck_JTs.ToList();

                foreach (var deck in decks)
                {
                    listBox_Decks.Items.Add(deck.Name);
                }

                listBox_Decks.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Failed to connect", "Connection Error");
            }
        }

        private void button_BackToMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DeckUserControl_Load(object sender, EventArgs e)
        {
            //if (db.Database.CanConnect())
            //{
            //    decks = db.Decks.ToList();
            //    pokemons = db.Pokemons.ToList();
            //    pokemon_decks = db.Pokemon_Deck_JTs.ToList();

            //    foreach (var deck in decks)
            //    {
            //        listBox_Decks.Items.Add(deck.Name);
            //    }

            //    listBox_Decks.SelectedIndex = 0;

            //}
            //else
            //{
            //    MessageBox.Show("Failed to connect", "Connection Error");
            //}
        }

        private void listBox_Decks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_PokemonsInDeck.Items.Clear();
            DisplayPokemonsInDeck();
            if (listBox_Decks.SelectedItem != null)
            {
                DeckName = listBox_Decks.SelectedItem.ToString();
            }
        }
        private void DisplayPokemonsInDeck()
        {
            foreach (var pokemon in pokemon_decks)
            {
                if (listBox_Decks.SelectedItem != null && pokemon.Deck.Name != null)
                {
                    if (listBox_Decks.SelectedItem.ToString() == pokemon.Deck.Name)
                    {
                        listBox_PokemonsInDeck.Items.Add(pokemon.Pokemon.Name);
                    }
                }

            }
        }

        private void button_CreateDeck_Click(object sender, EventArgs e)
        {
            if (textBox_NewDeckName.Text == "Standard")
            {
                MessageBox.Show("You can´t create a deck called 'Standard'");
                return;
            }
            if (textBox_NewDeckName.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(textBox_NewDeckName.Text, "^[A-Za-z ]*$") &&
                !string.IsNullOrWhiteSpace(textBox_NewDeckName.Text))
            {
                Deck newDeck = new Deck() { Name = textBox_NewDeckName.Text };
                db.Decks.Add(newDeck);
                db.SaveChanges();

                listBox_Decks.Items.Add(textBox_NewDeckName.Text);
            }
            if (textBox_NewDeckName.Text.Length < 0 || !System.Text.RegularExpressions.Regex.IsMatch(textBox_NewDeckName.Text, "^[A-Za-z ]*$"))
            { MessageBox.Show("Deck Name can only contain letters", "Invalid Input"); }

            if (string.IsNullOrWhiteSpace(textBox_NewDeckName.Text)) { MessageBox.Show("Deck name can´t only be whitespace", "Invalid input"); }

            textBox_NewDeckName.Clear();
        }

        private void button_DeleteDeck_Click(object sender, EventArgs e)
        {
            if (listBox_Decks.SelectedItem != null)
            {
                if (listBox_Decks.SelectedItem.ToString() != "Standard")
                {
                    foreach (var deck in db.Decks)
                    {
                        if (deck.Name == listBox_Decks.SelectedItem.ToString())
                        {
                            db.Decks.Remove(deck);
                        }
                    }

                    db.SaveChanges();
                    listBox_Decks.Items.Remove(listBox_Decks.SelectedItem);
                }
                else { MessageBox.Show("The Deck 'Standard' can not be deleted", "Error"); }

            }
        }

        private void button_ChangeName_Click(object sender, EventArgs e)
        {
            if (listBox_Decks.SelectedItem.ToString() != "Standard")
            {
                changeDeckName = new ChangeDeckName(DeckName, this, listBox_Decks);
                Controls.Add(changeDeckName);
                changeDeckName.Show();
                changeDeckName.BringToFront();
            }
            else { MessageBox.Show("You can´t change the name of the 'Standard' deck", "Error"); }


            if (changeDeckName != null)
            {
                changeDeckName.Left = (this.Width - changeDeckName.Width) / 2;
                changeDeckName.Top = (this.Height - changeDeckName.Height) / 2;
            }
        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if (changeDeckName != null)
            {
                changeDeckName.Left = (this.Width - changeDeckName.Width) / 2;
                changeDeckName.Top = (this.Height - changeDeckName.Height) / 2;
            }
        }

    }
}
