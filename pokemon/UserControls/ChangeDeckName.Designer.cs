
namespace pokemon.UserControls
{
    partial class ChangeDeckName
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
            this.label1_changeNamelabel = new System.Windows.Forms.Label();
            this.textBox1_changeNameDeck = new System.Windows.Forms.TextBox();
            this.button1_ConfirmChangeName = new System.Windows.Forms.Button();
            this.button1_cancelchangeName = new System.Windows.Forms.Button();
            this.label_DeckName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_changeNamelabel
            // 
            this.label1_changeNamelabel.AutoSize = true;
            this.label1_changeNamelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_changeNamelabel.Location = new System.Drawing.Point(16, 8);
            this.label1_changeNamelabel.Name = "label1_changeNamelabel";
            this.label1_changeNamelabel.Size = new System.Drawing.Size(50, 20);
            this.label1_changeNamelabel.TabIndex = 0;
            this.label1_changeNamelabel.Text = "label1";
            // 
            // textBox1_changeNameDeck
            // 
            this.textBox1_changeNameDeck.Location = new System.Drawing.Point(50, 72);
            this.textBox1_changeNameDeck.Name = "textBox1_changeNameDeck";
            this.textBox1_changeNameDeck.Size = new System.Drawing.Size(100, 23);
            this.textBox1_changeNameDeck.TabIndex = 1;
            // 
            // button1_ConfirmChangeName
            // 
            this.button1_ConfirmChangeName.Location = new System.Drawing.Point(156, 71);
            this.button1_ConfirmChangeName.Name = "button1_ConfirmChangeName";
            this.button1_ConfirmChangeName.Size = new System.Drawing.Size(64, 23);
            this.button1_ConfirmChangeName.TabIndex = 2;
            this.button1_ConfirmChangeName.Text = "Confirm";
            this.button1_ConfirmChangeName.UseVisualStyleBackColor = true;
            this.button1_ConfirmChangeName.Click += new System.EventHandler(this.button1_ConfirmChangeName_Click);
            // 
            // button1_cancelchangeName
            // 
            this.button1_cancelchangeName.Location = new System.Drawing.Point(210, 98);
            this.button1_cancelchangeName.Name = "button1_cancelchangeName";
            this.button1_cancelchangeName.Size = new System.Drawing.Size(64, 23);
            this.button1_cancelchangeName.TabIndex = 3;
            this.button1_cancelchangeName.Text = "Cancel";
            this.button1_cancelchangeName.UseVisualStyleBackColor = true;
            this.button1_cancelchangeName.Click += new System.EventHandler(this.button1_cancelchangeName_Click);
            // 
            // label_DeckName
            // 
            this.label_DeckName.AutoSize = true;
            this.label_DeckName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DeckName.Location = new System.Drawing.Point(89, 36);
            this.label_DeckName.Name = "label_DeckName";
            this.label_DeckName.Size = new System.Drawing.Size(50, 20);
            this.label_DeckName.TabIndex = 4;
            this.label_DeckName.Text = "label1";
            // 
            // ChangeDeckName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_DeckName);
            this.Controls.Add(this.button1_cancelchangeName);
            this.Controls.Add(this.button1_ConfirmChangeName);
            this.Controls.Add(this.textBox1_changeNameDeck);
            this.Controls.Add(this.label1_changeNamelabel);
            this.Name = "ChangeDeckName";
            this.Size = new System.Drawing.Size(282, 133);
            this.Load += new System.EventHandler(this.ChangeDeckName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_changeNamelabel;
        private System.Windows.Forms.TextBox textBox1_changeNameDeck;
        private System.Windows.Forms.Button button1_ConfirmChangeName;
        private System.Windows.Forms.Button button1_cancelchangeName;
        private System.Windows.Forms.Label label_DeckName;
    }
}
