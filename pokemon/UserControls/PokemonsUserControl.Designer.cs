
namespace pokemon.UserControls
{
    partial class PokemonsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1_PokemonsDisplay = new System.Windows.Forms.DataGridView();
            this.pokemons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1_Addpokemon = new System.Windows.Forms.Button();
            this.button1_BackToMenue = new System.Windows.Forms.Button();
            this.button1_DetailedStats = new System.Windows.Forms.Button();
            this.button1_ModifyPokemon = new System.Windows.Forms.Button();
            this.button1_deletePokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_PokemonsDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_PokemonsDisplay
            // 
            this.dataGridView1_PokemonsDisplay.AllowUserToAddRows = false;
            this.dataGridView1_PokemonsDisplay.AllowUserToDeleteRows = false;
            this.dataGridView1_PokemonsDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_PokemonsDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_PokemonsDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_PokemonsDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1_PokemonsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_PokemonsDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokemons,
            this.Type,
            this.Abilities,
            this.HP,
            this.Level,
            this.Trainer,
            this.ID});
            this.dataGridView1_PokemonsDisplay.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1_PokemonsDisplay.MultiSelect = false;
            this.dataGridView1_PokemonsDisplay.Name = "dataGridView1_PokemonsDisplay";
            this.dataGridView1_PokemonsDisplay.RowHeadersVisible = false;
            this.dataGridView1_PokemonsDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1_PokemonsDisplay.RowTemplate.Height = 25;
            this.dataGridView1_PokemonsDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_PokemonsDisplay.Size = new System.Drawing.Size(816, 385);
            this.dataGridView1_PokemonsDisplay.TabIndex = 0;
            this.dataGridView1_PokemonsDisplay.SelectionChanged += new System.EventHandler(this.dataGridView1_PokemonsDisplay_SelectionChanged);
            // 
            // pokemons
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pokemons.DefaultCellStyle = dataGridViewCellStyle1;
            this.pokemons.HeaderText = "Pokemon";
            this.pokemons.Name = "pokemons";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Abilities
            // 
            this.Abilities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Abilities.DefaultCellStyle = dataGridViewCellStyle2;
            this.Abilities.HeaderText = "Abilities";
            this.Abilities.Name = "Abilities";
            this.Abilities.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HP
            // 
            this.HP.HeaderText = "HP";
            this.HP.Name = "HP";
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // Trainer
            // 
            this.Trainer.HeaderText = "Trainer";
            this.Trainer.Name = "Trainer";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // button1_Addpokemon
            // 
            this.button1_Addpokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_Addpokemon.Location = new System.Drawing.Point(544, 391);
            this.button1_Addpokemon.Name = "button1_Addpokemon";
            this.button1_Addpokemon.Size = new System.Drawing.Size(122, 45);
            this.button1_Addpokemon.TabIndex = 2;
            this.button1_Addpokemon.Text = "Create new Pokemon";
            this.button1_Addpokemon.UseVisualStyleBackColor = true;
            this.button1_Addpokemon.Click += new System.EventHandler(this.button1_Addpokemon_Click);
            // 
            // button1_BackToMenue
            // 
            this.button1_BackToMenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1_BackToMenue.Location = new System.Drawing.Point(9, 391);
            this.button1_BackToMenue.Name = "button1_BackToMenue";
            this.button1_BackToMenue.Size = new System.Drawing.Size(122, 44);
            this.button1_BackToMenue.TabIndex = 3;
            this.button1_BackToMenue.Text = "Back";
            this.button1_BackToMenue.UseVisualStyleBackColor = true;
            this.button1_BackToMenue.Click += new System.EventHandler(this.button1_BackToMenue_Click);
            // 
            // button1_DetailedStats
            // 
            this.button1_DetailedStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_DetailedStats.Location = new System.Drawing.Point(416, 392);
            this.button1_DetailedStats.Name = "button1_DetailedStats";
            this.button1_DetailedStats.Size = new System.Drawing.Size(122, 44);
            this.button1_DetailedStats.TabIndex = 4;
            this.button1_DetailedStats.Text = "Detailed Info";
            this.button1_DetailedStats.UseVisualStyleBackColor = true;
            this.button1_DetailedStats.Click += new System.EventHandler(this.button1_DetailedStats_Click);
            // 
            // button1_ModifyPokemon
            // 
            this.button1_ModifyPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_ModifyPokemon.Location = new System.Drawing.Point(672, 392);
            this.button1_ModifyPokemon.Name = "button1_ModifyPokemon";
            this.button1_ModifyPokemon.Size = new System.Drawing.Size(122, 44);
            this.button1_ModifyPokemon.TabIndex = 5;
            this.button1_ModifyPokemon.Text = "Modify Pokemon ";
            this.button1_ModifyPokemon.UseVisualStyleBackColor = true;
            this.button1_ModifyPokemon.Click += new System.EventHandler(this.button1_ModifyPokemon_Click);
            // 
            // button1_deletePokemon
            // 
            this.button1_deletePokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_deletePokemon.Location = new System.Drawing.Point(288, 391);
            this.button1_deletePokemon.Name = "button1_deletePokemon";
            this.button1_deletePokemon.Size = new System.Drawing.Size(122, 44);
            this.button1_deletePokemon.TabIndex = 6;
            this.button1_deletePokemon.Text = "Delete Pokemon";
            this.button1_deletePokemon.UseVisualStyleBackColor = true;
            this.button1_deletePokemon.Click += new System.EventHandler(this.button1_deletePokemon_Click);
            // 
            // PokemonsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_deletePokemon);
            this.Controls.Add(this.button1_ModifyPokemon);
            this.Controls.Add(this.button1_DetailedStats);
            this.Controls.Add(this.button1_BackToMenue);
            this.Controls.Add(this.button1_Addpokemon);
            this.Controls.Add(this.dataGridView1_PokemonsDisplay);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PokemonsUserControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.PokemonsUserControl_Load);
            this.SizeChanged += new System.EventHandler(this.PokemonsUserControl_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_PokemonsDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_PokemonsDisplay;
        private System.Windows.Forms.Button button1_Addpokemon;
        private System.Windows.Forms.Button button1_BackToMenue;
        private System.Windows.Forms.Button button1_DetailedStats;
        private System.Windows.Forms.Button button1_ModifyPokemon;
        private System.Windows.Forms.Button button1_deletePokemon;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokemons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
