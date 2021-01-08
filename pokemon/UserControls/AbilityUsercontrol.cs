using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class AbilityUsercontrol : UserControl
    {
        PokemonContext db = new PokemonContext();
        List<Ability> abilities;
        List<Pokemon_Ability_JT> pokemon_Ability_JTs;
        public AbilityUsercontrol()
        {
            InitializeComponent();
        }

        private void AbilityUsercontrol_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                abilities = db.Abilities.ToList();
                pokemon_Ability_JTs = db.Pokemon_Ability_JTs.ToList();
            }
            else
            {
                MessageBox.Show("failed to connected");
            }

            dataGridView_AbilityDisplayer.Rows.Clear();

            foreach (var ability in abilities)
            {
                int rowIndex = dataGridView_AbilityDisplayer.Rows.Add();

                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["Ability"].Value = ability.Name;
                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["MinimalDamage"].Value = ability.MinDmg;
                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["MaximalDamage"].Value = ability.MaxDmg;

                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["ID"].Value = ability.ID;
                dataGridView_AbilityDisplayer.Columns["ID"].Visible = false;

            }
        }

        private void button_CreateAbility_Click(object sender, EventArgs e)
        {
            if(textBox_AbilityName.Text.Length > 0 &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_MinDmg.Text, "^[0-9]*$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_MaxDmg.Text, "^[0-9]*$"))
            {
                Ability newAbility = new Ability()
                {
                    Name = textBox_AbilityName.Text,
                    MinDmg = int.Parse(textBox_MinDmg.Text),
                    MaxDmg = int.Parse(textBox_MaxDmg.Text)
                };

                db.Abilities.Add(newAbility);
                db.SaveChanges();

                int rowIndex = dataGridView_AbilityDisplayer.Rows.Add();

                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["Ability"].Value = textBox_AbilityName.Text;
                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["MinimalDamage"].Value = textBox_MinDmg.Text;
                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["MaximalDamage"].Value = textBox_MaxDmg.Text;

                dataGridView_AbilityDisplayer.Rows[rowIndex].Cells["ID"].Value = newAbility.ID;
                dataGridView_AbilityDisplayer.Columns["ID"].Visible = false;

            }
            else
            {
                MessageBox.Show($"All Fields needs to be filled in! \nMinimal and Maximal Damage has to be numeric values", "Invaild Input");
            }
        }

        private void button_BackToMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_DeleteAbility_Click(object sender, EventArgs e)
        {
            int abilityID = int.Parse(dataGridView_AbilityDisplayer.SelectedCells[3].Value.ToString());

            foreach (var abilityPokeCombo in pokemon_Ability_JTs)
            {
                if (abilityPokeCombo.AbilityID == abilityID)
                {
                    db.Pokemon_Ability_JTs.Remove(abilityPokeCombo);
                }
            }

            db.SaveChanges();

            foreach (var ability in abilities)
            {
                if(ability.ID == abilityID)
                {
                    db.Abilities.Remove(ability);
                }
            }
            dataGridView_AbilityDisplayer.Rows.RemoveAt(dataGridView_AbilityDisplayer.SelectedRows[0].Index);
            db.SaveChanges();

        }
    }
}
