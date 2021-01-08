
namespace pokemon.UserControls
{
    partial class AbilityUsercontrol
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
            this.button_CreateAbility = new System.Windows.Forms.Button();
            this.label_MaxDmg = new System.Windows.Forms.Label();
            this.label_MinDmg = new System.Windows.Forms.Label();
            this.label1_AbilityName = new System.Windows.Forms.Label();
            this.textBox_MinDmg = new System.Windows.Forms.TextBox();
            this.textBox_MaxDmg = new System.Windows.Forms.TextBox();
            this.textBox_AbilityName = new System.Windows.Forms.TextBox();
            this.button_ModifyAbility = new System.Windows.Forms.Button();
            this.button_DeleteAbility = new System.Windows.Forms.Button();
            this.dataGridView_AbilityDisplayer = new System.Windows.Forms.DataGridView();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimalDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximalDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AbilityDisplayer)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button_CreateAbility);
            this.splitContainer1.Panel1.Controls.Add(this.label_MaxDmg);
            this.splitContainer1.Panel1.Controls.Add(this.label_MinDmg);
            this.splitContainer1.Panel1.Controls.Add(this.label1_AbilityName);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MinDmg);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MaxDmg);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_AbilityName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel2.Controls.Add(this.button_ModifyAbility);
            this.splitContainer1.Panel2.Controls.Add(this.button_DeleteAbility);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_AbilityDisplayer);
            this.splitContainer1.Size = new System.Drawing.Size(814, 487);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_BackToMain
            // 
            this.button_BackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_BackToMain.Location = new System.Drawing.Point(17, 405);
            this.button_BackToMain.Name = "button_BackToMain";
            this.button_BackToMain.Size = new System.Drawing.Size(108, 37);
            this.button_BackToMain.TabIndex = 7;
            this.button_BackToMain.Text = "Back";
            this.button_BackToMain.UseVisualStyleBackColor = true;
            this.button_BackToMain.Click += new System.EventHandler(this.button_BackToMain_Click);
            // 
            // button_CreateAbility
            // 
            this.button_CreateAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CreateAbility.Location = new System.Drawing.Point(141, 405);
            this.button_CreateAbility.Name = "button_CreateAbility";
            this.button_CreateAbility.Size = new System.Drawing.Size(108, 37);
            this.button_CreateAbility.TabIndex = 6;
            this.button_CreateAbility.Text = "Create Ability";
            this.button_CreateAbility.UseVisualStyleBackColor = true;
            this.button_CreateAbility.Click += new System.EventHandler(this.button_CreateAbility_Click);
            // 
            // label_MaxDmg
            // 
            this.label_MaxDmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MaxDmg.AutoSize = true;
            this.label_MaxDmg.Location = new System.Drawing.Point(23, 328);
            this.label_MaxDmg.Name = "label_MaxDmg";
            this.label_MaxDmg.Size = new System.Drawing.Size(100, 15);
            this.label_MaxDmg.TabIndex = 5;
            this.label_MaxDmg.Text = "Maximal Damage";
            // 
            // label_MinDmg
            // 
            this.label_MinDmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MinDmg.AutoSize = true;
            this.label_MinDmg.Location = new System.Drawing.Point(23, 198);
            this.label_MinDmg.Name = "label_MinDmg";
            this.label_MinDmg.Size = new System.Drawing.Size(98, 15);
            this.label_MinDmg.TabIndex = 4;
            this.label_MinDmg.Text = "Minimal Damage";
            // 
            // label1_AbilityName
            // 
            this.label1_AbilityName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_AbilityName.AutoSize = true;
            this.label1_AbilityName.Location = new System.Drawing.Point(23, 80);
            this.label1_AbilityName.Name = "label1_AbilityName";
            this.label1_AbilityName.Size = new System.Drawing.Size(76, 15);
            this.label1_AbilityName.TabIndex = 3;
            this.label1_AbilityName.Text = "Ability Name";
            // 
            // textBox_MinDmg
            // 
            this.textBox_MinDmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MinDmg.Location = new System.Drawing.Point(132, 195);
            this.textBox_MinDmg.Name = "textBox_MinDmg";
            this.textBox_MinDmg.Size = new System.Drawing.Size(100, 23);
            this.textBox_MinDmg.TabIndex = 2;
            // 
            // textBox_MaxDmg
            // 
            this.textBox_MaxDmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MaxDmg.Location = new System.Drawing.Point(132, 325);
            this.textBox_MaxDmg.Name = "textBox_MaxDmg";
            this.textBox_MaxDmg.Size = new System.Drawing.Size(100, 23);
            this.textBox_MaxDmg.TabIndex = 1;
            // 
            // textBox_AbilityName
            // 
            this.textBox_AbilityName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AbilityName.Location = new System.Drawing.Point(132, 77);
            this.textBox_AbilityName.Name = "textBox_AbilityName";
            this.textBox_AbilityName.Size = new System.Drawing.Size(100, 23);
            this.textBox_AbilityName.TabIndex = 0;
            // 
            // button_ModifyAbility
            // 
            this.button_ModifyAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ModifyAbility.Location = new System.Drawing.Point(274, 405);
            this.button_ModifyAbility.Name = "button_ModifyAbility";
            this.button_ModifyAbility.Size = new System.Drawing.Size(90, 36);
            this.button_ModifyAbility.TabIndex = 2;
            this.button_ModifyAbility.Text = "Modify Ability";
            this.button_ModifyAbility.UseVisualStyleBackColor = true;
            this.button_ModifyAbility.Click += new System.EventHandler(this.button_ModifyAbility_Click);
            // 
            // button_DeleteAbility
            // 
            this.button_DeleteAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteAbility.Location = new System.Drawing.Point(420, 405);
            this.button_DeleteAbility.Name = "button_DeleteAbility";
            this.button_DeleteAbility.Size = new System.Drawing.Size(90, 36);
            this.button_DeleteAbility.TabIndex = 1;
            this.button_DeleteAbility.Text = "Delete Ability";
            this.button_DeleteAbility.UseVisualStyleBackColor = true;
            this.button_DeleteAbility.Click += new System.EventHandler(this.button_DeleteAbility_Click);
            // 
            // dataGridView_AbilityDisplayer
            // 
            this.dataGridView_AbilityDisplayer.AllowUserToAddRows = false;
            this.dataGridView_AbilityDisplayer.AllowUserToDeleteRows = false;
            this.dataGridView_AbilityDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AbilityDisplayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AbilityDisplayer.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView_AbilityDisplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AbilityDisplayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ability,
            this.MinimalDamage,
            this.MaximalDamage,
            this.ID});
            this.dataGridView_AbilityDisplayer.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_AbilityDisplayer.MultiSelect = false;
            this.dataGridView_AbilityDisplayer.Name = "dataGridView_AbilityDisplayer";
            this.dataGridView_AbilityDisplayer.RowHeadersVisible = false;
            this.dataGridView_AbilityDisplayer.RowTemplate.Height = 25;
            this.dataGridView_AbilityDisplayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AbilityDisplayer.Size = new System.Drawing.Size(539, 384);
            this.dataGridView_AbilityDisplayer.TabIndex = 0;
            this.dataGridView_AbilityDisplayer.SelectionChanged += new System.EventHandler(this.dataGridView_AbilityDisplayer_SelectionChanged);
            // 
            // Ability
            // 
            this.Ability.HeaderText = "Ability";
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            // 
            // MinimalDamage
            // 
            this.MinimalDamage.HeaderText = "Minimal Damage";
            this.MinimalDamage.Name = "MinimalDamage";
            this.MinimalDamage.ReadOnly = true;
            // 
            // MaximalDamage
            // 
            this.MaximalDamage.HeaderText = "Maximal Damage";
            this.MaximalDamage.Name = "MaximalDamage";
            this.MaximalDamage.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // AbilityUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AbilityUsercontrol";
            this.Size = new System.Drawing.Size(814, 487);
            this.Load += new System.EventHandler(this.AbilityUsercontrol_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AbilityDisplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_AbilityDisplayer;
        private System.Windows.Forms.Button button_CreateAbility;
        private System.Windows.Forms.Label label_MaxDmg;
        private System.Windows.Forms.Label label_MinDmg;
        private System.Windows.Forms.Label label1_AbilityName;
        private System.Windows.Forms.TextBox textBox_MinDmg;
        private System.Windows.Forms.TextBox textBox_MaxDmg;
        private System.Windows.Forms.TextBox textBox_AbilityName;
        private System.Windows.Forms.Button button_BackToMain;
        private System.Windows.Forms.Button button_DeleteAbility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimalDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximalDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button button_ModifyAbility;
    }
}
