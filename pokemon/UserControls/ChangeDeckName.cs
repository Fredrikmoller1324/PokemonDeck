using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class ChangeDeckName : UserControl
    {
        string changeDeckName;
        private List<Deck> deckList;
        DeckUserControl deckUserControl;
        ListBox listBoxDecks;
        PokemonContext db = new PokemonContext();

        public ChangeDeckName(string changeDeckName, DeckUserControl deckUserControl, ListBox listBoxDecks)
        {
            InitializeComponent();
            this.changeDeckName = changeDeckName;
            this.deckUserControl = deckUserControl;
            this.listBoxDecks = listBoxDecks;
        }

        private void button1_cancelchangeName_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ChangeDeckName_Load(object sender, EventArgs e)
        {
            deckList = db.Decks.ToList();
            label1_changeNamelabel.Text = $"Enter a new name below to change:";
            label_DeckName.Text = $"'{changeDeckName}'";
        }

        private void button1_ConfirmChangeName_Click(object sender, EventArgs e)
        {
            if (textBox1_changeNameDeck.Text == "Standard")
            {
                MessageBox.Show("You can´t create a deck called 'Standard'");
                return;
            }

            if (textBox1_changeNameDeck.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(textBox1_changeNameDeck.Text, "^[A-Za-z ]*$") &&
                !string.IsNullOrWhiteSpace(textBox1_changeNameDeck.Text))
            {
                foreach (var deck in deckList)
                {
                    if (deck.Name == changeDeckName)
                    {
                        deck.Name = textBox1_changeNameDeck.Text;
                    }
                    db.SaveChanges();
                }

                listBoxDecks.Items.Clear();
                foreach (var deck in db.Decks)
                {
                    listBoxDecks.Items.Add(deck.Name);
                }

                Hide();
            }

            if (textBox1_changeNameDeck.Text.Length < 0 || !System.Text.RegularExpressions.Regex.IsMatch(textBox1_changeNameDeck.Text, "^[A-Za-z ]*$"))
            { MessageBox.Show("Deck Name can only contain letters", "Invalid Input"); }

            if (string.IsNullOrWhiteSpace(textBox1_changeNameDeck.Text)) { MessageBox.Show("Deck name can´t only be whitespace", "Invalid input"); }

        }
    }
}
