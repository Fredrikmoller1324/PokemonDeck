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
    }
}
