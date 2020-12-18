using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pokemon.UserControls
{

    public partial class DisplayDetailedInfo : UserControl
    {
        private List<Trainer> trainers;
        private DataGridViewSelectedCellCollection selectedCells;
        private List<Pokemon_Ability_JT> ability_JTs;
        private List<Ability> abilities;
        private List<Deck> deckList;

        public DisplayDetailedInfo(DataGridViewSelectedCellCollection cellsfromgrid, List<Trainer> trainerlist, List<Pokemon_Ability_JT> abilityList, List<Ability> abilitiesgo,
            List<Deck> decks)
        {
            InitializeComponent();

            trainers = trainerlist;
            selectedCells = cellsfromgrid;
            ability_JTs = abilityList;
            abilities = abilitiesgo;
            deckList = decks;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayDetailedInfo_Load(object sender, EventArgs e)
        {
            foreach (var trainerInfo in trainers)
            {
                if (trainerInfo.Name == selectedCells[5].Value.ToString())
                {
                    label_DisplayTrainerAge.Text = trainerInfo.Age.ToString();
                    label_DisplayTrainerName.Text = trainerInfo.Name.ToString();
                    label_DisplayTrainerLocation.Text = trainerInfo.location.ToString();
                }
            }

            string[] singleAbility = selectedCells[2].Value.ToString().Split('\n');

            foreach (var ability in singleAbility)
            {
                foreach (var abilityInfo in abilities)
                {
                    if (ability == abilityInfo.Name)
                    {
                        int rowIndex = dataGridView1_AbilityInfo.Rows.Add();

                        dataGridView1_AbilityInfo.Rows[rowIndex].Cells["Abilitys"].Value = abilityInfo.Name;
                        dataGridView1_AbilityInfo.Rows[rowIndex].Cells["MaximumDamage"].Value = abilityInfo.MaxDmg;
                        dataGridView1_AbilityInfo.Rows[rowIndex].Cells["MinimumDamage"].Value = abilityInfo.MinDmg;
                    }
                }
            }

            label_DisplayPokemonName.Text = selectedCells[0].Value.ToString();
            label_DisplayPokemonType.Text = selectedCells[1].Value.ToString();
            label_DisplayPokemonHp.Text = selectedCells[3].Value.ToString();
            label_DisplayPokemonLevel.Text = selectedCells[4].Value.ToString();

            foreach (var deck in deckList)
            {
                listBox_Decks.Items.Add(deck.Name.ToString().ToLower());
            }

            label_Deckinfos.Text = $"{selectedCells[0].Value.ToString()}\ncan be found \nin these decks";
        }

        private void button1_Closing_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
