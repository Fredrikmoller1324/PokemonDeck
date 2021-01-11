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
        public DeckUserControl()
        {
            InitializeComponent();
        }

        private void button_BackToMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DeckUserControl_Load(object sender, EventArgs e)
        {
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

        private void listBox_Decks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_PokemonsInDeck.Items.Clear();
            DisplayPokemonsInDeck();
        }
        private void DisplayPokemonsInDeck()
        {
            foreach (var pokemon in pokemon_decks)
            {
                if(listBox_Decks.SelectedItem != null && pokemon.Deck.Name != null)
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
            if (textBox_NewDeckName.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(textBox_NewDeckName.Text, "^[A-Za-z ]*$"))
            {
                Deck newDeck = new Deck() { Name = textBox_NewDeckName.Text };
                db.Decks.Add(newDeck);
                db.SaveChanges();

                listBox_Decks.Items.Add(textBox_NewDeckName.Text);
            }
            else { MessageBox.Show("Deck Name can only contain letters", "Invalid Input"); }

        }

        private void button_DeleteDeck_Click(object sender, EventArgs e)
        {
            if(listBox_Decks.SelectedItem != null)
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
    }
}
