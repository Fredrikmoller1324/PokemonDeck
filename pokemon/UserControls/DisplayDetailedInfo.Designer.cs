
namespace pokemon.UserControls
{
    partial class DisplayDetailedInfo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1_AbilityInfo = new System.Windows.Forms.DataGridView();
            this.Abilitys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_AbilityInfo = new System.Windows.Forms.Label();
            this.label_DisplayPokemonLevel = new System.Windows.Forms.Label();
            this.label_DisplayPokemonHp = new System.Windows.Forms.Label();
            this.label_DisplayPokemonType = new System.Windows.Forms.Label();
            this.label_DisplayPokemonName = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_HP = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Pokemon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Closing = new System.Windows.Forms.Button();
            this.label_Deckinfos = new System.Windows.Forms.Label();
            this.listBox_Decks = new System.Windows.Forms.ListBox();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label_DisplayTrainerAge = new System.Windows.Forms.Label();
            this.label_DisplayTrainerLocation = new System.Windows.Forms.Label();
            this.label_DisplayTrainerName = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Location = new System.Windows.Forms.Label();
            this.label_Trainer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_AbilityInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1_AbilityInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label_AbilityInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label_DisplayPokemonLevel);
            this.splitContainer1.Panel1.Controls.Add(this.label_DisplayPokemonHp);
            this.splitContainer1.Panel1.Controls.Add(this.label_DisplayPokemonType);
            this.splitContainer1.Panel1.Controls.Add(this.label_DisplayPokemonName);
            this.splitContainer1.Panel1.Controls.Add(this.label_Level);
            this.splitContainer1.Panel1.Controls.Add(this.label_HP);
            this.splitContainer1.Panel1.Controls.Add(this.label_Type);
            this.splitContainer1.Panel1.Controls.Add(this.label_Pokemon);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.button1_Closing);
            this.splitContainer1.Panel2.Controls.Add(this.label_Deckinfos);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_Decks);
            this.splitContainer1.Panel2.Controls.Add(this.label_Decks);
            this.splitContainer1.Panel2.Controls.Add(this.label_DisplayTrainerAge);
            this.splitContainer1.Panel2.Controls.Add(this.label_DisplayTrainerLocation);
            this.splitContainer1.Panel2.Controls.Add(this.label_DisplayTrainerName);
            this.splitContainer1.Panel2.Controls.Add(this.label_Age);
            this.splitContainer1.Panel2.Controls.Add(this.label_Location);
            this.splitContainer1.Panel2.Controls.Add(this.label_Trainer);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(814, 487);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1_AbilityInfo
            // 
            this.dataGridView1_AbilityInfo.AllowUserToAddRows = false;
            this.dataGridView1_AbilityInfo.AllowUserToDeleteRows = false;
            this.dataGridView1_AbilityInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_AbilityInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_AbilityInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abilitys,
            this.MinimumDamage,
            this.MaximumDamage});
            this.dataGridView1_AbilityInfo.Location = new System.Drawing.Point(41, 284);
            this.dataGridView1_AbilityInfo.Name = "dataGridView1_AbilityInfo";
            this.dataGridView1_AbilityInfo.RowHeadersVisible = false;
            this.dataGridView1_AbilityInfo.RowTemplate.Height = 25;
            this.dataGridView1_AbilityInfo.Size = new System.Drawing.Size(307, 142);
            this.dataGridView1_AbilityInfo.TabIndex = 11;
            // 
            // Abilitys
            // 
            this.Abilitys.HeaderText = "Ability";
            this.Abilitys.Name = "Abilitys";
            this.Abilitys.ReadOnly = true;
            // 
            // MinimumDamage
            // 
            this.MinimumDamage.HeaderText = "Minimum Damage";
            this.MinimumDamage.Name = "MinimumDamage";
            // 
            // MaximumDamage
            // 
            this.MaximumDamage.HeaderText = "Maximum Damage";
            this.MaximumDamage.Name = "MaximumDamage";
            this.MaximumDamage.ReadOnly = true;
            // 
            // label_AbilityInfo
            // 
            this.label_AbilityInfo.AutoSize = true;
            this.label_AbilityInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AbilityInfo.Location = new System.Drawing.Point(152, 241);
            this.label_AbilityInfo.Name = "label_AbilityInfo";
            this.label_AbilityInfo.Size = new System.Drawing.Size(79, 25);
            this.label_AbilityInfo.TabIndex = 10;
            this.label_AbilityInfo.Text = "Abilities";
            // 
            // label_DisplayPokemonLevel
            // 
            this.label_DisplayPokemonLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_DisplayPokemonLevel.AutoSize = true;
            this.label_DisplayPokemonLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayPokemonLevel.Location = new System.Drawing.Point(180, 160);
            this.label_DisplayPokemonLevel.Name = "label_DisplayPokemonLevel";
            this.label_DisplayPokemonLevel.Size = new System.Drawing.Size(55, 25);
            this.label_DisplayPokemonLevel.TabIndex = 8;
            this.label_DisplayPokemonLevel.Text = "Level";
            // 
            // label_DisplayPokemonHp
            // 
            this.label_DisplayPokemonHp.AutoSize = true;
            this.label_DisplayPokemonHp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayPokemonHp.Location = new System.Drawing.Point(180, 121);
            this.label_DisplayPokemonHp.Name = "label_DisplayPokemonHp";
            this.label_DisplayPokemonHp.Size = new System.Drawing.Size(36, 25);
            this.label_DisplayPokemonHp.TabIndex = 7;
            this.label_DisplayPokemonHp.Text = "HP";
            // 
            // label_DisplayPokemonType
            // 
            this.label_DisplayPokemonType.AutoSize = true;
            this.label_DisplayPokemonType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayPokemonType.Location = new System.Drawing.Point(180, 78);
            this.label_DisplayPokemonType.Name = "label_DisplayPokemonType";
            this.label_DisplayPokemonType.Size = new System.Drawing.Size(51, 25);
            this.label_DisplayPokemonType.TabIndex = 6;
            this.label_DisplayPokemonType.Text = "Type";
            // 
            // label_DisplayPokemonName
            // 
            this.label_DisplayPokemonName.AutoSize = true;
            this.label_DisplayPokemonName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayPokemonName.Location = new System.Drawing.Point(180, 32);
            this.label_DisplayPokemonName.Name = "label_DisplayPokemonName";
            this.label_DisplayPokemonName.Size = new System.Drawing.Size(90, 25);
            this.label_DisplayPokemonName.TabIndex = 5;
            this.label_DisplayPokemonName.Text = "Pokemon";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Level.Location = new System.Drawing.Point(53, 160);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(55, 25);
            this.label_Level.TabIndex = 4;
            this.label_Level.Text = "Level";
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HP.Location = new System.Drawing.Point(53, 121);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(36, 25);
            this.label_HP.TabIndex = 3;
            this.label_HP.Text = "HP";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Type.Location = new System.Drawing.Point(53, 78);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(51, 25);
            this.label_Type.TabIndex = 2;
            this.label_Type.Text = "Type";
            // 
            // label_Pokemon
            // 
            this.label_Pokemon.AutoSize = true;
            this.label_Pokemon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Pokemon.Location = new System.Drawing.Point(53, 32);
            this.label_Pokemon.Name = "label_Pokemon";
            this.label_Pokemon.Size = new System.Drawing.Size(90, 25);
            this.label_Pokemon.TabIndex = 1;
            this.label_Pokemon.Text = "Pokemon";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-44, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 2);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1_Closing
            // 
            this.button1_Closing.BackColor = System.Drawing.Color.DarkRed;
            this.button1_Closing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1_Closing.Location = new System.Drawing.Point(319, 3);
            this.button1_Closing.Name = "button1_Closing";
            this.button1_Closing.Size = new System.Drawing.Size(75, 23);
            this.button1_Closing.TabIndex = 15;
            this.button1_Closing.Text = "Close";
            this.button1_Closing.UseVisualStyleBackColor = false;
            this.button1_Closing.Click += new System.EventHandler(this.button1_Closing_Click);
            // 
            // label_Deckinfos
            // 
            this.label_Deckinfos.AutoSize = true;
            this.label_Deckinfos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Deckinfos.Location = new System.Drawing.Point(47, 314);
            this.label_Deckinfos.Name = "label_Deckinfos";
            this.label_Deckinfos.Size = new System.Drawing.Size(121, 21);
            this.label_Deckinfos.TabIndex = 14;
            this.label_Deckinfos.Text = "pokemonindeck";
            // 
            // listBox_Decks
            // 
            this.listBox_Decks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Decks.FormattingEnabled = true;
            this.listBox_Decks.ItemHeight = 21;
            this.listBox_Decks.Location = new System.Drawing.Point(181, 296);
            this.listBox_Decks.Name = "listBox_Decks";
            this.listBox_Decks.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Decks.Size = new System.Drawing.Size(173, 130);
            this.listBox_Decks.TabIndex = 13;
            // 
            // label_Decks
            // 
            this.label_Decks.AutoSize = true;
            this.label_Decks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Decks.Location = new System.Drawing.Point(175, 241);
            this.label_Decks.Name = "label_Decks";
            this.label_Decks.Size = new System.Drawing.Size(61, 25);
            this.label_Decks.TabIndex = 12;
            this.label_Decks.Text = "Decks";
            // 
            // label_DisplayTrainerAge
            // 
            this.label_DisplayTrainerAge.AutoSize = true;
            this.label_DisplayTrainerAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayTrainerAge.Location = new System.Drawing.Point(217, 160);
            this.label_DisplayTrainerAge.Name = "label_DisplayTrainerAge";
            this.label_DisplayTrainerAge.Size = new System.Drawing.Size(45, 25);
            this.label_DisplayTrainerAge.TabIndex = 11;
            this.label_DisplayTrainerAge.Text = "Age";
            // 
            // label_DisplayTrainerLocation
            // 
            this.label_DisplayTrainerLocation.AutoSize = true;
            this.label_DisplayTrainerLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayTrainerLocation.Location = new System.Drawing.Point(217, 97);
            this.label_DisplayTrainerLocation.Name = "label_DisplayTrainerLocation";
            this.label_DisplayTrainerLocation.Size = new System.Drawing.Size(84, 25);
            this.label_DisplayTrainerLocation.TabIndex = 10;
            this.label_DisplayTrainerLocation.Text = "Location";
            // 
            // label_DisplayTrainerName
            // 
            this.label_DisplayTrainerName.AutoSize = true;
            this.label_DisplayTrainerName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayTrainerName.Location = new System.Drawing.Point(217, 32);
            this.label_DisplayTrainerName.Name = "label_DisplayTrainerName";
            this.label_DisplayTrainerName.Size = new System.Drawing.Size(70, 25);
            this.label_DisplayTrainerName.TabIndex = 9;
            this.label_DisplayTrainerName.Text = "Trainer";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Age.Location = new System.Drawing.Point(66, 160);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(45, 25);
            this.label_Age.TabIndex = 8;
            this.label_Age.Text = "Age";
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Location.Location = new System.Drawing.Point(66, 97);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(84, 25);
            this.label_Location.TabIndex = 7;
            this.label_Location.Text = "Location";
            // 
            // label_Trainer
            // 
            this.label_Trainer.AutoSize = true;
            this.label_Trainer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Trainer.Location = new System.Drawing.Point(66, 32);
            this.label_Trainer.Name = "label_Trainer";
            this.label_Trainer.Size = new System.Drawing.Size(70, 25);
            this.label_Trainer.TabIndex = 6;
            this.label_Trainer.Text = "Trainer";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(-226, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(831, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Ability
            // 
            this.Ability.HeaderText = "Ability";
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ability";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ability";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DisplayDetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Location = new System.Drawing.Point(204, 122);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DisplayDetailedInfo";
            this.Size = new System.Drawing.Size(814, 487);
            this.Load += new System.EventHandler(this.DisplayDetailedInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_AbilityInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_DisplayPokemonLevel;
        private System.Windows.Forms.Label label_DisplayPokemonHp;
        private System.Windows.Forms.Label label_DisplayPokemonType;
        private System.Windows.Forms.Label label_DisplayPokemonName;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Pokemon;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Label label_Trainer;
        private System.Windows.Forms.Label label_DisplayTrainerAge;
        private System.Windows.Forms.Label label_DisplayTrainerLocation;
        private System.Windows.Forms.Label label_DisplayTrainerName;
        private System.Windows.Forms.Label label_AbilityInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView1_AbilityInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abilitys;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ListBox listBox_Decks;
        private System.Windows.Forms.Label label_Decks;
        private System.Windows.Forms.Label label_Deckinfos;
        private System.Windows.Forms.Button button1_Closing;
    }
}
