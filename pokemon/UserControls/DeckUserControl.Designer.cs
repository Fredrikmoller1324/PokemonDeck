
namespace pokemon.UserControls
{
    partial class DeckUserControl
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
            this.button_BackToMain = new System.Windows.Forms.Button();
            this.button_CreateDeck = new System.Windows.Forms.Button();
            this.textBox_NewDeckName = new System.Windows.Forms.TextBox();
            this.label_EnterDeckName = new System.Windows.Forms.Label();
            this.label_CreateNewDeckInfo = new System.Windows.Forms.Label();
            this.button_DeleteDeck = new System.Windows.Forms.Button();
            this.label_PokesInDeck = new System.Windows.Forms.Label();
            this.listBox_PokemonsInDeck = new System.Windows.Forms.ListBox();
            this.listBox_Decks = new System.Windows.Forms.ListBox();
            this.label_ExistingDecks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel1.Controls.Add(this.button_BackToMain);
            this.splitContainer1.Panel1.Controls.Add(this.button_CreateDeck);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_NewDeckName);
            this.splitContainer1.Panel1.Controls.Add(this.label_EnterDeckName);
            this.splitContainer1.Panel1.Controls.Add(this.label_CreateNewDeckInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel2.Controls.Add(this.button_DeleteDeck);
            this.splitContainer1.Panel2.Controls.Add(this.label_PokesInDeck);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_PokemonsInDeck);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_Decks);
            this.splitContainer1.Panel2.Controls.Add(this.label_ExistingDecks);
            this.splitContainer1.Size = new System.Drawing.Size(814, 487);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_BackToMain
            // 
            this.button_BackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_BackToMain.Location = new System.Drawing.Point(43, 403);
            this.button_BackToMain.Name = "button_BackToMain";
            this.button_BackToMain.Size = new System.Drawing.Size(75, 23);
            this.button_BackToMain.TabIndex = 4;
            this.button_BackToMain.Text = "Back";
            this.button_BackToMain.UseVisualStyleBackColor = true;
            this.button_BackToMain.Click += new System.EventHandler(this.button_BackToMain_Click);
            // 
            // button_CreateDeck
            // 
            this.button_CreateDeck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_CreateDeck.Location = new System.Drawing.Point(81, 264);
            this.button_CreateDeck.Name = "button_CreateDeck";
            this.button_CreateDeck.Size = new System.Drawing.Size(91, 34);
            this.button_CreateDeck.TabIndex = 3;
            this.button_CreateDeck.Text = "Create Deck";
            this.button_CreateDeck.UseVisualStyleBackColor = true;
            this.button_CreateDeck.Click += new System.EventHandler(this.button_CreateDeck_Click);
            // 
            // textBox_NewDeckName
            // 
            this.textBox_NewDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NewDeckName.Location = new System.Drawing.Point(59, 201);
            this.textBox_NewDeckName.Name = "textBox_NewDeckName";
            this.textBox_NewDeckName.Size = new System.Drawing.Size(142, 23);
            this.textBox_NewDeckName.TabIndex = 2;
            // 
            // label_EnterDeckName
            // 
            this.label_EnterDeckName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_EnterDeckName.AutoSize = true;
            this.label_EnterDeckName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EnterDeckName.Location = new System.Drawing.Point(59, 156);
            this.label_EnterDeckName.Name = "label_EnterDeckName";
            this.label_EnterDeckName.Size = new System.Drawing.Size(142, 21);
            this.label_EnterDeckName.TabIndex = 1;
            this.label_EnterDeckName.Text = "Enter a Deck Name";
            // 
            // label_CreateNewDeckInfo
            // 
            this.label_CreateNewDeckInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CreateNewDeckInfo.AutoSize = true;
            this.label_CreateNewDeckInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CreateNewDeckInfo.Location = new System.Drawing.Point(43, 65);
            this.label_CreateNewDeckInfo.Name = "label_CreateNewDeckInfo";
            this.label_CreateNewDeckInfo.Size = new System.Drawing.Size(175, 25);
            this.label_CreateNewDeckInfo.TabIndex = 0;
            this.label_CreateNewDeckInfo.Text = "Create a new Deck";
            // 
            // button_DeleteDeck
            // 
            this.button_DeleteDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteDeck.Location = new System.Drawing.Point(181, 345);
            this.button_DeleteDeck.Name = "button_DeleteDeck";
            this.button_DeleteDeck.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteDeck.TabIndex = 4;
            this.button_DeleteDeck.Text = "Delete Deck";
            this.button_DeleteDeck.UseVisualStyleBackColor = true;
            this.button_DeleteDeck.Click += new System.EventHandler(this.button_DeleteDeck_Click);
            // 
            // label_PokesInDeck
            // 
            this.label_PokesInDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PokesInDeck.AutoSize = true;
            this.label_PokesInDeck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_PokesInDeck.Location = new System.Drawing.Point(298, 45);
            this.label_PokesInDeck.Name = "label_PokesInDeck";
            this.label_PokesInDeck.Size = new System.Drawing.Size(207, 21);
            this.label_PokesInDeck.TabIndex = 3;
            this.label_PokesInDeck.Text = "Pokemons in chosen deck";
            // 
            // listBox_PokemonsInDeck
            // 
            this.listBox_PokemonsInDeck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_PokemonsInDeck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_PokemonsInDeck.FormattingEnabled = true;
            this.listBox_PokemonsInDeck.ItemHeight = 21;
            this.listBox_PokemonsInDeck.Location = new System.Drawing.Point(278, 80);
            this.listBox_PokemonsInDeck.Name = "listBox_PokemonsInDeck";
            this.listBox_PokemonsInDeck.Size = new System.Drawing.Size(239, 256);
            this.listBox_PokemonsInDeck.TabIndex = 2;
            // 
            // listBox_Decks
            // 
            this.listBox_Decks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Decks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Decks.FormattingEnabled = true;
            this.listBox_Decks.ItemHeight = 21;
            this.listBox_Decks.Location = new System.Drawing.Point(17, 80);
            this.listBox_Decks.Name = "listBox_Decks";
            this.listBox_Decks.Size = new System.Drawing.Size(239, 256);
            this.listBox_Decks.TabIndex = 1;
            this.listBox_Decks.SelectedIndexChanged += new System.EventHandler(this.listBox_Decks_SelectedIndexChanged);
            // 
            // label_ExistingDecks
            // 
            this.label_ExistingDecks.AutoSize = true;
            this.label_ExistingDecks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ExistingDecks.Location = new System.Drawing.Point(89, 45);
            this.label_ExistingDecks.Name = "label_ExistingDecks";
            this.label_ExistingDecks.Size = new System.Drawing.Size(94, 21);
            this.label_ExistingDecks.TabIndex = 0;
            this.label_ExistingDecks.Text = "Your Decks";
            // 
            // DeckUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.splitContainer1);
            this.Name = "DeckUserControl";
            this.Size = new System.Drawing.Size(814, 487);
            this.Load += new System.EventHandler(this.DeckUserControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_BackToMain;
        private System.Windows.Forms.Button button_CreateDeck;
        private System.Windows.Forms.TextBox textBox_NewDeckName;
        private System.Windows.Forms.Label label_EnterDeckName;
        private System.Windows.Forms.Label label_CreateNewDeckInfo;
        private System.Windows.Forms.Label label_PokesInDeck;
        private System.Windows.Forms.ListBox listBox_PokemonsInDeck;
        private System.Windows.Forms.ListBox listBox_Decks;
        private System.Windows.Forms.Label label_ExistingDecks;
        private System.Windows.Forms.Button button_DeleteDeck;
    }
}
