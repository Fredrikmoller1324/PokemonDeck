using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class PokemonsUserControl : UserControl
    {
        public List<Pokemon> pokemonslist;
        public List<Trainer> trainers;
        public List<Type> types;
        public List<Ability> abilities;
        public List<Pokemon_Ability_JT> ability_JTs;
        public List<Deck> decks;
        public List<Pokemon_Deck_JT> pokemon_Deck_JTs;

        public PokemonContext db = new PokemonContext();

        DataGridViewSelectedCellCollection Selectedcellcollection;

        DisplayDetailedInfo detailedInfo;
        CreateNewPokemon newPokemon;
        ModifyPokemon modifyPokemon;

        public PokemonsUserControl()
        {
            InitializeComponent();
        }

        private void PokemonsUserControl_Load(object sender, EventArgs e)
        {
            LoadAllPokemons();

            foreach (DataGridViewColumn dc in dataGridView1_PokemonsDisplay.Columns)
            {
                if (dc.Index.Equals(0) || dc.Index.Equals(1))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }

        private void LoadAllPokemons()
        {

            if (db.Database.CanConnect())
            {
                pokemonslist = db.Pokemons.ToList();

                trainers = db.Trainers.ToList();

                abilities = db.Abilities.ToList();

                types = db.Types.ToList();

                ability_JTs = db.Pokemon_Ability_JTs.ToList();

                decks = db.Decks.ToList();

                pokemon_Deck_JTs = db.Pokemon_Deck_JTs.ToList();
            }
            else
            {
                MessageBox.Show("failed to connected");
            }

            dataGridView1_PokemonsDisplay.Rows.Clear();

            foreach (Pokemon pokemon in pokemonslist)
            {
                int rowIndex = dataGridView1_PokemonsDisplay.Rows.Add();

                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["pokemons"].Value = pokemon.Name;

                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["HP"].Value = pokemon.HP;

                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["Trainer"].Value = pokemon.Trainer.Name;

                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["Level"].Value = pokemon.Level;

                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["Type"].Value = pokemon.Type.Name;

                //Add ID column to easier modify a specific pokemon, visable set to false because info is irrelevent to user
                dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["ID"].Value = pokemon.ID;
                dataGridView1_PokemonsDisplay.Columns["ID"].Visible = false;

                dataGridView1_PokemonsDisplay.Columns["Abilities"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                string abilityString = "";
                foreach (var ability in ability_JTs)
                {
                    if (pokemon.ID == ability.PokemonID)
                    {
                        if (abilityString.Length == 0)
                        {
                            abilityString += ability.Ability.Name;
                        }
                        else
                        {
                            abilityString += "\n" + ability.Ability.Name;
                        }
                    }

                    dataGridView1_PokemonsDisplay.Rows[rowIndex].Cells["Abilities"].Value = abilityString;
                }
            }
            dataGridView1_PokemonsDisplay.BorderStyle = BorderStyle.None;
        }

        private void button1_BackToMenue_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_DetailedStats_Click(object sender, EventArgs e)
        {
            detailedInfo = new DisplayDetailedInfo(Selectedcellcollection, trainers, ability_JTs, abilities, decks);

            Controls.Add(detailedInfo);
            detailedInfo.Visible = true;
            detailedInfo.BringToFront();

            detailedInfo.Left = (this.Width - detailedInfo.Width) / 2;
            detailedInfo.Top = (this.Height - detailedInfo.Height) / 2;

        }

        private void button1_deletePokemon_Click(object sender, EventArgs e) //Updatera så tar bort i databas
        {
            var removeThisPokemon = Selectedcellcollection[0].Value.ToString();

            foreach (Pokemon pokemon in db.Pokemons)
            {
                if (removeThisPokemon == pokemon.Name)
                {
                    db.Pokemons.Remove(pokemon);
                }
            }


            dataGridView1_PokemonsDisplay.Rows.RemoveAt(dataGridView1_PokemonsDisplay.SelectedRows[0].Index);


            db.SaveChanges();
            //db.Dispose();
        }

        private void dataGridView1_PokemonsDisplay_SelectionChanged(object sender, EventArgs e)
        {
            Selectedcellcollection = dataGridView1_PokemonsDisplay.SelectedCells;
        }

        private void PokemonsUserControl_SizeChanged(object sender, EventArgs e)
        {
            if (detailedInfo != null)
            {
                detailedInfo.Left = (this.Width - detailedInfo.Width) / 2;
                detailedInfo.Top = (this.Height - detailedInfo.Height) / 2;
            }

            if (newPokemon != null)
            {
                newPokemon.Left = (this.Width - newPokemon.Width) / 2;
                newPokemon.Top = (this.Height - newPokemon.Height) / 2;
            }

            if (modifyPokemon != null)
            {
                modifyPokemon.Left = (this.Width - modifyPokemon.Width) / 2;
                modifyPokemon.Top = (this.Height - modifyPokemon.Height) / 2;
            }
        }

        private void button1_Addpokemon_Click(object sender, EventArgs e)
        {
            newPokemon = new CreateNewPokemon(dataGridView1_PokemonsDisplay, trainers, types, decks, abilities);
            Controls.Add(newPokemon);
            newPokemon.Visible = true;
            newPokemon.BringToFront();

            newPokemon.Left = (this.Width - newPokemon.Width) / 2;
            newPokemon.Top = (this.Height - newPokemon.Height) / 2;
        }

        private void button1_ModifyPokemon_Click(object sender, EventArgs e)
        {
            modifyPokemon = new ModifyPokemon(Selectedcellcollection);
            Controls.Add(modifyPokemon);
            modifyPokemon.Visible = true;
            modifyPokemon.BringToFront();

            modifyPokemon.Left = (this.Width - modifyPokemon.Width) / 2;
            modifyPokemon.Top = (this.Height - modifyPokemon.Height) / 2;
        }
    }
}
