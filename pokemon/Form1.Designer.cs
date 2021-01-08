
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
            this.SuspendLayout();
            // 
            // button1_Pokemons
            // 
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
            this.button2_Decks.Location = new System.Drawing.Point(296, 312);
            this.button2_Decks.Name = "button2_Decks";
            this.button2_Decks.Size = new System.Drawing.Size(202, 94);
            this.button2_Decks.TabIndex = 1;
            this.button2_Decks.Text = "Decks";
            this.button2_Decks.UseVisualStyleBackColor = true;
            // 
            // button1_Abilities
            // 
            this.button1_Abilities.Location = new System.Drawing.Point(296, 175);
            this.button1_Abilities.Name = "button1_Abilities";
            this.button1_Abilities.Size = new System.Drawing.Size(202, 94);
            this.button1_Abilities.TabIndex = 2;
            this.button1_Abilities.Text = "Abilities";
            this.button1_Abilities.UseVisualStyleBackColor = true;
            this.button1_Abilities.Click += new System.EventHandler(this.button1_Abilities_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Abilities);
            this.Controls.Add(this.button2_Decks);
            this.Controls.Add(this.button1_Pokemons);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Deck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Pokemons;
        private System.Windows.Forms.Button button2_Decks;
        private System.Windows.Forms.Button button1_Abilities;
    }
}

