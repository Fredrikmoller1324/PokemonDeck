
namespace pokemon.UserControls
{
    partial class ModifyPokemon
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
            this.textBox_ChangeHp = new System.Windows.Forms.TextBox();
            this.comboBox_ChangeType = new System.Windows.Forms.ComboBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox_Decks = new System.Windows.Forms.ListBox();
            this.listBox_Abilties = new System.Windows.Forms.ListBox();
            this.button_AddToDeck = new System.Windows.Forms.Button();
            this.button_AddAbility = new System.Windows.Forms.Button();
            this.comboBox_ChangeDeck = new System.Windows.Forms.ComboBox();
            this.comboBox_ChangeAbilities = new System.Windows.Forms.ComboBox();
            this.comboBox_ChangeTrainer = new System.Windows.Forms.ComboBox();
            this.numericUpDown_ChangeLevel = new System.Windows.Forms.NumericUpDown();
            this.textBox_ChangeName = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label1_Trainer = new System.Windows.Forms.Label();
            this.label1_level = new System.Windows.Forms.Label();
            this.label_Abilties = new System.Windows.Forms.Label();
            this.label_HP = new System.Windows.Forms.Label();
            this.label1_NameInfo = new System.Windows.Forms.Label();
            this.button1_deleteAbility = new System.Windows.Forms.Button();
            this.button1_deleteDeck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ChangeLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ChangeHp
            // 
            this.textBox_ChangeHp.Location = new System.Drawing.Point(152, 153);
            this.textBox_ChangeHp.Name = "textBox_ChangeHp";
            this.textBox_ChangeHp.Size = new System.Drawing.Size(121, 23);
            this.textBox_ChangeHp.TabIndex = 42;
            // 
            // comboBox_ChangeType
            // 
            this.comboBox_ChangeType.FormattingEnabled = true;
            this.comboBox_ChangeType.Location = new System.Drawing.Point(152, 234);
            this.comboBox_ChangeType.Name = "comboBox_ChangeType";
            this.comboBox_ChangeType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ChangeType.TabIndex = 41;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Type.Location = new System.Drawing.Point(67, 233);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(51, 25);
            this.label_Type.TabIndex = 40;
            this.label_Type.Text = "Type";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(594, 401);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(85, 34);
            this.button_Cancel.TabIndex = 39;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(702, 401);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(81, 34);
            this.button_Save.TabIndex = 38;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // listBox_Decks
            // 
            this.listBox_Decks.FormattingEnabled = true;
            this.listBox_Decks.ItemHeight = 15;
            this.listBox_Decks.Location = new System.Drawing.Point(634, 223);
            this.listBox_Decks.Name = "listBox_Decks";
            this.listBox_Decks.Size = new System.Drawing.Size(149, 139);
            this.listBox_Decks.TabIndex = 37;
            // 
            // listBox_Abilties
            // 
            this.listBox_Abilties.FormattingEnabled = true;
            this.listBox_Abilties.ItemHeight = 15;
            this.listBox_Abilties.Location = new System.Drawing.Point(634, 34);
            this.listBox_Abilties.Name = "listBox_Abilties";
            this.listBox_Abilties.Size = new System.Drawing.Size(149, 139);
            this.listBox_Abilties.TabIndex = 36;
            // 
            // button_AddToDeck
            // 
            this.button_AddToDeck.Location = new System.Drawing.Point(575, 252);
            this.button_AddToDeck.Name = "button_AddToDeck";
            this.button_AddToDeck.Size = new System.Drawing.Size(40, 23);
            this.button_AddToDeck.TabIndex = 35;
            this.button_AddToDeck.Text = "Add";
            this.button_AddToDeck.UseVisualStyleBackColor = true;
            // 
            // button_AddAbility
            // 
            this.button_AddAbility.Location = new System.Drawing.Point(575, 63);
            this.button_AddAbility.Name = "button_AddAbility";
            this.button_AddAbility.Size = new System.Drawing.Size(40, 23);
            this.button_AddAbility.TabIndex = 34;
            this.button_AddAbility.Text = "Add";
            this.button_AddAbility.UseVisualStyleBackColor = true;
            // 
            // comboBox_ChangeDeck
            // 
            this.comboBox_ChangeDeck.FormattingEnabled = true;
            this.comboBox_ChangeDeck.Location = new System.Drawing.Point(448, 252);
            this.comboBox_ChangeDeck.Name = "comboBox_ChangeDeck";
            this.comboBox_ChangeDeck.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ChangeDeck.TabIndex = 33;
            // 
            // comboBox_ChangeAbilities
            // 
            this.comboBox_ChangeAbilities.FormattingEnabled = true;
            this.comboBox_ChangeAbilities.Location = new System.Drawing.Point(448, 63);
            this.comboBox_ChangeAbilities.Name = "comboBox_ChangeAbilities";
            this.comboBox_ChangeAbilities.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ChangeAbilities.TabIndex = 32;
            // 
            // comboBox_ChangeTrainer
            // 
            this.comboBox_ChangeTrainer.FormattingEnabled = true;
            this.comboBox_ChangeTrainer.Location = new System.Drawing.Point(152, 408);
            this.comboBox_ChangeTrainer.Name = "comboBox_ChangeTrainer";
            this.comboBox_ChangeTrainer.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ChangeTrainer.TabIndex = 31;
            // 
            // numericUpDown_ChangeLevel
            // 
            this.numericUpDown_ChangeLevel.Location = new System.Drawing.Point(152, 328);
            this.numericUpDown_ChangeLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ChangeLevel.Name = "numericUpDown_ChangeLevel";
            this.numericUpDown_ChangeLevel.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_ChangeLevel.TabIndex = 30;
            this.numericUpDown_ChangeLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_ChangeName
            // 
            this.textBox_ChangeName.Location = new System.Drawing.Point(152, 62);
            this.textBox_ChangeName.Name = "textBox_ChangeName";
            this.textBox_ChangeName.Size = new System.Drawing.Size(121, 23);
            this.textBox_ChangeName.TabIndex = 29;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Info.Location = new System.Drawing.Point(18, 7);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(166, 25);
            this.label_Info.TabIndex = 28;
            this.label_Info.Text = "Modify Pokemon";
            // 
            // label_Decks
            // 
            this.label_Decks.AutoSize = true;
            this.label_Decks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Decks.Location = new System.Drawing.Point(363, 250);
            this.label_Decks.Name = "label_Decks";
            this.label_Decks.Size = new System.Drawing.Size(53, 25);
            this.label_Decks.TabIndex = 27;
            this.label_Decks.Text = "Deck";
            // 
            // label1_Trainer
            // 
            this.label1_Trainer.AutoSize = true;
            this.label1_Trainer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_Trainer.Location = new System.Drawing.Point(67, 408);
            this.label1_Trainer.Name = "label1_Trainer";
            this.label1_Trainer.Size = new System.Drawing.Size(70, 25);
            this.label1_Trainer.TabIndex = 26;
            this.label1_Trainer.Text = "Trainer";
            // 
            // label1_level
            // 
            this.label1_level.AutoSize = true;
            this.label1_level.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_level.Location = new System.Drawing.Point(67, 327);
            this.label1_level.Name = "label1_level";
            this.label1_level.Size = new System.Drawing.Size(55, 25);
            this.label1_level.TabIndex = 25;
            this.label1_level.Text = "Level";
            // 
            // label_Abilties
            // 
            this.label_Abilties.AutoSize = true;
            this.label_Abilties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Abilties.Location = new System.Drawing.Point(363, 61);
            this.label_Abilties.Name = "label_Abilties";
            this.label_Abilties.Size = new System.Drawing.Size(79, 25);
            this.label_Abilties.TabIndex = 24;
            this.label_Abilties.Text = "Abilities";
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HP.Location = new System.Drawing.Point(66, 148);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(36, 25);
            this.label_HP.TabIndex = 23;
            this.label_HP.Text = "Hp";
            // 
            // label1_NameInfo
            // 
            this.label1_NameInfo.AutoSize = true;
            this.label1_NameInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_NameInfo.Location = new System.Drawing.Point(67, 60);
            this.label1_NameInfo.Name = "label1_NameInfo";
            this.label1_NameInfo.Size = new System.Drawing.Size(62, 25);
            this.label1_NameInfo.TabIndex = 22;
            this.label1_NameInfo.Text = "Name";
            // 
            // button1_deleteAbility
            // 
            this.button1_deleteAbility.Location = new System.Drawing.Point(732, 179);
            this.button1_deleteAbility.Name = "button1_deleteAbility";
            this.button1_deleteAbility.Size = new System.Drawing.Size(51, 23);
            this.button1_deleteAbility.TabIndex = 43;
            this.button1_deleteAbility.Text = "Delete";
            this.button1_deleteAbility.UseVisualStyleBackColor = true;
            // 
            // button1_deleteDeck
            // 
            this.button1_deleteDeck.Location = new System.Drawing.Point(732, 365);
            this.button1_deleteDeck.Name = "button1_deleteDeck";
            this.button1_deleteDeck.Size = new System.Drawing.Size(51, 23);
            this.button1_deleteDeck.TabIndex = 44;
            this.button1_deleteDeck.Text = "Delete";
            this.button1_deleteDeck.UseVisualStyleBackColor = true;
            // 
            // ModifyPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1_deleteDeck);
            this.Controls.Add(this.button1_deleteAbility);
            this.Controls.Add(this.textBox_ChangeHp);
            this.Controls.Add(this.comboBox_ChangeType);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.listBox_Decks);
            this.Controls.Add(this.listBox_Abilties);
            this.Controls.Add(this.button_AddToDeck);
            this.Controls.Add(this.button_AddAbility);
            this.Controls.Add(this.comboBox_ChangeDeck);
            this.Controls.Add(this.comboBox_ChangeAbilities);
            this.Controls.Add(this.comboBox_ChangeTrainer);
            this.Controls.Add(this.numericUpDown_ChangeLevel);
            this.Controls.Add(this.textBox_ChangeName);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_Decks);
            this.Controls.Add(this.label1_Trainer);
            this.Controls.Add(this.label1_level);
            this.Controls.Add(this.label_Abilties);
            this.Controls.Add(this.label_HP);
            this.Controls.Add(this.label1_NameInfo);
            this.Name = "ModifyPokemon";
            this.Size = new System.Drawing.Size(814, 487);
            this.Load += new System.EventHandler(this.ModifyPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ChangeLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ChangeHp;
        private System.Windows.Forms.ComboBox comboBox_ChangeType;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_Decks;
        private System.Windows.Forms.ListBox listBox_Abilties;
        private System.Windows.Forms.Button button_AddToDeck;
        private System.Windows.Forms.Button button_AddAbility;
        private System.Windows.Forms.ComboBox comboBox_ChangeDeck;
        private System.Windows.Forms.ComboBox comboBox_ChangeAbilities;
        private System.Windows.Forms.ComboBox comboBox_ChangeTrainer;
        private System.Windows.Forms.NumericUpDown numericUpDown_ChangeLevel;
        private System.Windows.Forms.TextBox textBox_ChangeName;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_Decks;
        private System.Windows.Forms.Label label1_Trainer;
        private System.Windows.Forms.Label label1_level;
        private System.Windows.Forms.Label label_Abilties;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label1_NameInfo;
        private System.Windows.Forms.Button button1_deleteAbility;
        private System.Windows.Forms.Button button1_deleteDeck;
    }
}
