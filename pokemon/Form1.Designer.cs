
namespace pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Pokemons = new System.Windows.Forms.Button();
            this.button2_Decks = new System.Windows.Forms.Button();
            this.button1_Abilities = new System.Windows.Forms.Button();
            this.label_PokemonInfo = new System.Windows.Forms.Label();
            this.label_AbilityInfo = new System.Windows.Forms.Label();
            this.label_DeckInfo = new System.Windows.Forms.Label();
            this.pictureBox_load = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_load)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Pokemons
            // 
            this.button1_Pokemons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1_Pokemons.Location = new System.Drawing.Point(296, 34);
            this.button1_Pokemons.Name = "button1_Pokemons";
            this.button1_Pokemons.Size = new System.Drawing.Size(202, 94);
            this.button1_Pokemons.TabIndex = 0;
            this.button1_Pokemons.Text = "Pokemons";
            this.button1_Pokemons.UseVisualStyleBackColor = true;
            this.button1_Pokemons.Click += new System.EventHandler(this.button1_Pokemons_Click);
            // 
            // button2_Decks
            // 
            this.button2_Decks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2_Decks.Location = new System.Drawing.Point(296, 312);
            this.button2_Decks.Name = "button2_Decks";
            this.button2_Decks.Size = new System.Drawing.Size(202, 94);
            this.button2_Decks.TabIndex = 1;
            this.button2_Decks.Text = "Decks";
            this.button2_Decks.UseVisualStyleBackColor = true;
            this.button2_Decks.Click += new System.EventHandler(this.button2_Decks_Click);
            // 
            // button1_Abilities
            // 
            this.button1_Abilities.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1_Abilities.Location = new System.Drawing.Point(296, 175);
            this.button1_Abilities.Name = "button1_Abilities";
            this.button1_Abilities.Size = new System.Drawing.Size(202, 94);
            this.button1_Abilities.TabIndex = 2;
            this.button1_Abilities.Text = "Abilities";
            this.button1_Abilities.UseVisualStyleBackColor = true;
            this.button1_Abilities.Click += new System.EventHandler(this.button1_Abilities_Click);
            // 
            // label_PokemonInfo
            // 
            this.label_PokemonInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_PokemonInfo.AutoSize = true;
            this.label_PokemonInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PokemonInfo.Location = new System.Drawing.Point(504, 34);
            this.label_PokemonInfo.Name = "label_PokemonInfo";
            this.label_PokemonInfo.Size = new System.Drawing.Size(50, 20);
            this.label_PokemonInfo.TabIndex = 3;
            this.label_PokemonInfo.Text = "label1";
            // 
            // label_AbilityInfo
            // 
            this.label_AbilityInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_AbilityInfo.AutoSize = true;
            this.label_AbilityInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AbilityInfo.Location = new System.Drawing.Point(504, 175);
            this.label_AbilityInfo.Name = "label_AbilityInfo";
            this.label_AbilityInfo.Size = new System.Drawing.Size(50, 20);
            this.label_AbilityInfo.TabIndex = 4;
            this.label_AbilityInfo.Text = "label2";
            // 
            // label_DeckInfo
            // 
            this.label_DeckInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_DeckInfo.AutoSize = true;
            this.label_DeckInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DeckInfo.Location = new System.Drawing.Point(504, 312);
            this.label_DeckInfo.Name = "label_DeckInfo";
            this.label_DeckInfo.Size = new System.Drawing.Size(50, 20);
            this.label_DeckInfo.TabIndex = 5;
            this.label_DeckInfo.Text = "label3";
            // 
            // pictureBox_load
            // 
            this.pictureBox_load.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_load.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_load.Name = "pictureBox_load";
            this.pictureBox_load.Size = new System.Drawing.Size(278, 417);
            this.pictureBox_load.TabIndex = 6;
            this.pictureBox_load.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_load);
            this.Controls.Add(this.label_DeckInfo);
            this.Controls.Add(this.label_AbilityInfo);
            this.Controls.Add(this.label_PokemonInfo);
            this.Controls.Add(this.button1_Abilities);
            this.Controls.Add(this.button2_Decks);
            this.Controls.Add(this.button1_Pokemons);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Deck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Pokemons;
        private System.Windows.Forms.Button button2_Decks;
        private System.Windows.Forms.Button button1_Abilities;
        private System.Windows.Forms.Label label_PokemonInfo;
        private System.Windows.Forms.Label label_AbilityInfo;
        private System.Windows.Forms.Label label_DeckInfo;
        private System.Windows.Forms.PictureBox pictureBox_load;
    }
}

