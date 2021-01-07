
namespace pokemon.UserControls
{
    partial class CreateNewPokemon
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
            this.label1_NameInfo = new System.Windows.Forms.Label();
            this.label_HP = new System.Windows.Forms.Label();
            this.label_Abilties = new System.Windows.Forms.Label();
            this.label1_level = new System.Windows.Forms.Label();
            this.label1_Trainer = new System.Windows.Forms.Label();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label_ControlInfo = new System.Windows.Forms.Label();
            this.textBox_PokemonName = new System.Windows.Forms.TextBox();
            this.numericUpDown_Level = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Trainer = new System.Windows.Forms.ComboBox();
            this.comboBox_Abilities = new System.Windows.Forms.ComboBox();
            this.comboBox_Deck = new System.Windows.Forms.ComboBox();
            this.button_AddAbility = new System.Windows.Forms.Button();
            this.button_AddToDeck = new System.Windows.Forms.Button();
            this.listBox_Abilties = new System.Windows.Forms.ListBox();
            this.listBox_Decks = new System.Windows.Forms.ListBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.textBox_Hp = new System.Windows.Forms.TextBox();
            this.button_RemoveAbility = new System.Windows.Forms.Button();
            this.button1_deleteDeck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Level)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_NameInfo
            // 
            this.label1_NameInfo.AutoSize = true;
            this.label1_NameInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_NameInfo.Location = new System.Drawing.Point(49, 53);
            this.label1_NameInfo.Name = "label1_NameInfo";
            this.label1_NameInfo.Size = new System.Drawing.Size(62, 25);
            this.label1_NameInfo.TabIndex = 0;
            this.label1_NameInfo.Text = "Name";
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HP.Location = new System.Drawing.Point(48, 141);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(36, 25);
            this.label_HP.TabIndex = 1;
            this.label_HP.Text = "Hp";
            // 
            // label_Abilties
            // 
            this.label_Abilties.AutoSize = true;
            this.label_Abilties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Abilties.Location = new System.Drawing.Point(360, 53);
            this.label_Abilties.Name = "label_Abilties";
            this.label_Abilties.Size = new System.Drawing.Size(79, 25);
            this.label_Abilties.TabIndex = 2;
            this.label_Abilties.Text = "Abilities";
            // 
            // label1_level
            // 
            this.label1_level.AutoSize = true;
            this.label1_level.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_level.Location = new System.Drawing.Point(49, 320);
            this.label1_level.Name = "label1_level";
            this.label1_level.Size = new System.Drawing.Size(55, 25);
            this.label1_level.TabIndex = 3;
            this.label1_level.Text = "Level";
            // 
            // label1_Trainer
            // 
            this.label1_Trainer.AutoSize = true;
            this.label1_Trainer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_Trainer.Location = new System.Drawing.Point(49, 401);
            this.label1_Trainer.Name = "label1_Trainer";
            this.label1_Trainer.Size = new System.Drawing.Size(70, 25);
            this.label1_Trainer.TabIndex = 4;
            this.label1_Trainer.Text = "Trainer";
            // 
            // label_Decks
            // 
            this.label_Decks.AutoSize = true;
            this.label_Decks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Decks.Location = new System.Drawing.Point(360, 233);
            this.label_Decks.Name = "label_Decks";
            this.label_Decks.Size = new System.Drawing.Size(53, 25);
            this.label_Decks.TabIndex = 5;
            this.label_Decks.Text = "Deck";
            // 
            // label_ControlInfo
            // 
            this.label_ControlInfo.AutoSize = true;
            this.label_ControlInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ControlInfo.Location = new System.Drawing.Point(0, 0);
            this.label_ControlInfo.Name = "label_ControlInfo";
            this.label_ControlInfo.Size = new System.Drawing.Size(216, 25);
            this.label_ControlInfo.TabIndex = 6;
            this.label_ControlInfo.Text = "Create a new Pokemon";
            // 
            // textBox_PokemonName
            // 
            this.textBox_PokemonName.Location = new System.Drawing.Point(134, 55);
            this.textBox_PokemonName.Name = "textBox_PokemonName";
            this.textBox_PokemonName.Size = new System.Drawing.Size(121, 23);
            this.textBox_PokemonName.TabIndex = 7;
            // 
            // numericUpDown_Level
            // 
            this.numericUpDown_Level.Location = new System.Drawing.Point(134, 321);
            this.numericUpDown_Level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Level.Name = "numericUpDown_Level";
            this.numericUpDown_Level.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_Level.TabIndex = 9;
            this.numericUpDown_Level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Trainer
            // 
            this.comboBox_Trainer.FormattingEnabled = true;
            this.comboBox_Trainer.Location = new System.Drawing.Point(134, 401);
            this.comboBox_Trainer.Name = "comboBox_Trainer";
            this.comboBox_Trainer.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Trainer.TabIndex = 10;
            // 
            // comboBox_Abilities
            // 
            this.comboBox_Abilities.FormattingEnabled = true;
            this.comboBox_Abilities.Location = new System.Drawing.Point(445, 55);
            this.comboBox_Abilities.Name = "comboBox_Abilities";
            this.comboBox_Abilities.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Abilities.TabIndex = 11;
            // 
            // comboBox_Deck
            // 
            this.comboBox_Deck.FormattingEnabled = true;
            this.comboBox_Deck.Location = new System.Drawing.Point(445, 235);
            this.comboBox_Deck.Name = "comboBox_Deck";
            this.comboBox_Deck.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Deck.TabIndex = 12;
            // 
            // button_AddAbility
            // 
            this.button_AddAbility.Location = new System.Drawing.Point(572, 55);
            this.button_AddAbility.Name = "button_AddAbility";
            this.button_AddAbility.Size = new System.Drawing.Size(40, 23);
            this.button_AddAbility.TabIndex = 13;
            this.button_AddAbility.Text = "Add";
            this.button_AddAbility.UseVisualStyleBackColor = true;
            this.button_AddAbility.Click += new System.EventHandler(this.button_AddAbility_Click);
            // 
            // button_AddToDeck
            // 
            this.button_AddToDeck.Location = new System.Drawing.Point(572, 235);
            this.button_AddToDeck.Name = "button_AddToDeck";
            this.button_AddToDeck.Size = new System.Drawing.Size(40, 23);
            this.button_AddToDeck.TabIndex = 14;
            this.button_AddToDeck.Text = "Add";
            this.button_AddToDeck.UseVisualStyleBackColor = true;
            this.button_AddToDeck.Click += new System.EventHandler(this.button_AddToDeck_Click);
            // 
            // listBox_Abilties
            // 
            this.listBox_Abilties.FormattingEnabled = true;
            this.listBox_Abilties.ItemHeight = 15;
            this.listBox_Abilties.Location = new System.Drawing.Point(631, 26);
            this.listBox_Abilties.Name = "listBox_Abilties";
            this.listBox_Abilties.Size = new System.Drawing.Size(149, 139);
            this.listBox_Abilties.TabIndex = 15;
            // 
            // listBox_Decks
            // 
            this.listBox_Decks.FormattingEnabled = true;
            this.listBox_Decks.ItemHeight = 15;
            this.listBox_Decks.Location = new System.Drawing.Point(631, 206);
            this.listBox_Decks.Name = "listBox_Decks";
            this.listBox_Decks.Size = new System.Drawing.Size(149, 139);
            this.listBox_Decks.TabIndex = 16;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(702, 390);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(81, 34);
            this.button_Save.TabIndex = 17;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(594, 390);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(85, 34);
            this.button_Cancel.TabIndex = 18;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(134, 227);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 23);
            this.comboBox_type.TabIndex = 20;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Type.Location = new System.Drawing.Point(49, 226);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(51, 25);
            this.label_Type.TabIndex = 19;
            this.label_Type.Text = "Type";
            // 
            // textBox_Hp
            // 
            this.textBox_Hp.Location = new System.Drawing.Point(134, 146);
            this.textBox_Hp.Name = "textBox_Hp";
            this.textBox_Hp.Size = new System.Drawing.Size(121, 23);
            this.textBox_Hp.TabIndex = 21;
            // 
            // button_RemoveAbility
            // 
            this.button_RemoveAbility.Location = new System.Drawing.Point(732, 171);
            this.button_RemoveAbility.Name = "button_RemoveAbility";
            this.button_RemoveAbility.Size = new System.Drawing.Size(48, 23);
            this.button_RemoveAbility.TabIndex = 22;
            this.button_RemoveAbility.Text = "delete";
            this.button_RemoveAbility.UseVisualStyleBackColor = true;
            this.button_RemoveAbility.Click += new System.EventHandler(this.button_RemoveAbility_Click);
            // 
            // button1_deleteDeck
            // 
            this.button1_deleteDeck.Location = new System.Drawing.Point(732, 351);
            this.button1_deleteDeck.Name = "button1_deleteDeck";
            this.button1_deleteDeck.Size = new System.Drawing.Size(48, 23);
            this.button1_deleteDeck.TabIndex = 23;
            this.button1_deleteDeck.Text = "delete";
            this.button1_deleteDeck.UseVisualStyleBackColor = true;
            this.button1_deleteDeck.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateNewPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1_deleteDeck);
            this.Controls.Add(this.button_RemoveAbility);
            this.Controls.Add(this.textBox_Hp);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.listBox_Decks);
            this.Controls.Add(this.listBox_Abilties);
            this.Controls.Add(this.button_AddToDeck);
            this.Controls.Add(this.button_AddAbility);
            this.Controls.Add(this.comboBox_Deck);
            this.Controls.Add(this.comboBox_Abilities);
            this.Controls.Add(this.comboBox_Trainer);
            this.Controls.Add(this.numericUpDown_Level);
            this.Controls.Add(this.textBox_PokemonName);
            this.Controls.Add(this.label_ControlInfo);
            this.Controls.Add(this.label_Decks);
            this.Controls.Add(this.label1_Trainer);
            this.Controls.Add(this.label1_level);
            this.Controls.Add(this.label_Abilties);
            this.Controls.Add(this.label_HP);
            this.Controls.Add(this.label1_NameInfo);
            this.Name = "CreateNewPokemon";
            this.Size = new System.Drawing.Size(814, 487);
            this.Load += new System.EventHandler(this.CreateNewPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_NameInfo;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label_Abilties;
        private System.Windows.Forms.Label label1_level;
        private System.Windows.Forms.Label label1_Trainer;
        private System.Windows.Forms.Label label_Decks;
        private System.Windows.Forms.Label label_ControlInfo;
        private System.Windows.Forms.TextBox textBox_PokemonName;
        private System.Windows.Forms.NumericUpDown numericUpDown_Level;
        private System.Windows.Forms.ComboBox comboBox_Trainer;
        private System.Windows.Forms.ComboBox comboBox_Abilities;
        private System.Windows.Forms.ComboBox comboBox_Deck;
        private System.Windows.Forms.Button button_AddAbility;
        private System.Windows.Forms.Button button_AddToDeck;
        private System.Windows.Forms.ListBox listBox_Abilties;
        private System.Windows.Forms.ListBox listBox_Decks;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.TextBox textBox_Hp;
        private System.Windows.Forms.Button button_RemoveAbility;
        private System.Windows.Forms.Button button1_deleteDeck;
    }
}
