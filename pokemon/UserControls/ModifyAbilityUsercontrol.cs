using System;
using System.Windows.Forms;

namespace pokemon.UserControls
{
    public partial class ModifyAbilityUsercontrol : UserControl
    {
        private DataGridViewSelectedCellCollection SelectedAbility;
        private AbilityUsercontrol abilityUsercontrol = new AbilityUsercontrol();

        public ModifyAbilityUsercontrol(DataGridViewSelectedCellCollection selectedAbility)
        {
            InitializeComponent();
            SelectedAbility = selectedAbility;
        }

        private void ModifyAbilityUsercontrol_Load(object sender, EventArgs e)
        {
            label_ModifySelectedAbility.Text = SelectedAbility[0].Value.ToString();
            textBox_ChangeAbilityName.Text = SelectedAbility[0].Value.ToString();
            textBox_changeMinimalDamage.Text = SelectedAbility[1].Value.ToString();
            textBox_changeMaximalDamage.Text = SelectedAbility[2].Value.ToString();
        }

        private void button_SaveChangedAbility_Click(object sender, EventArgs e)
        {
            if (textBox_ChangeAbilityName.Text.Length > 0 &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_ChangeAbilityName.Text, "^[A-Za-z ]*$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_changeMinimalDamage.Text, "^[0-9]*$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_changeMaximalDamage.Text, "^[0-9]*$") &&
                int.Parse(textBox_changeMinimalDamage.Text) < int.Parse(textBox_changeMaximalDamage.Text))
            {
                foreach (var ability in abilityUsercontrol.db.Abilities)
                {
                    if (ability.ID == int.Parse(SelectedAbility[3].Value.ToString()))
                    {
                        ability.Name = textBox_ChangeAbilityName.Text;
                        ability.MinDmg = int.Parse(textBox_changeMinimalDamage.Text);
                        ability.MaxDmg = int.Parse(textBox_changeMaximalDamage.Text);
                    };
                }

                SelectedAbility[0].Value = textBox_ChangeAbilityName.Text;
                SelectedAbility[1].Value = textBox_changeMinimalDamage.Text;
                SelectedAbility[2].Value = textBox_changeMaximalDamage.Text;

                abilityUsercontrol.db.SaveChanges();
                Hide();
            }
            if (textBox_ChangeAbilityName.Text.Length == 0 ||
                 !System.Text.RegularExpressions.Regex.IsMatch(textBox_changeMinimalDamage.Text, "^[0-9]*$") ||
                 !System.Text.RegularExpressions.Regex.IsMatch(textBox_changeMaximalDamage.Text, "^[0-9]*$") ||
                 !System.Text.RegularExpressions.Regex.IsMatch(textBox_ChangeAbilityName.Text, "^[A-Za-z ]*$"))
            {
                MessageBox.Show($"All Fields needs to be filled in! \nMinimal and Maximal Damage has to be numeric values", "Invaild Input");
            }

            int min = 0;
            int max = 0;
            bool SuccesMin = int.TryParse(textBox_changeMinimalDamage.Text, out min);
            bool SuccesMax = int.TryParse(textBox_changeMaximalDamage.Text, out max);
            if(SuccesMax && SuccesMin && min > max)
            {
                MessageBox.Show($"Minimal Damage needs to be lower than Maximal Damage", "Invalid Input");
            };
        }
    }
}
