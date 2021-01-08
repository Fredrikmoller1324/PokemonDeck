
namespace pokemon.UserControls
{
    partial class ModifyAbilityUsercontrol
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
            this.label_ModifySelectedAbility = new System.Windows.Forms.Label();
            this.button_SaveChangedAbility = new System.Windows.Forms.Button();
            this.label_ChangeName = new System.Windows.Forms.Label();
            this.label_ChangeMinDmg = new System.Windows.Forms.Label();
            this.label_ChangeMaxDmg = new System.Windows.Forms.Label();
            this.textBox_ChangeAbilityName = new System.Windows.Forms.TextBox();
            this.textBox_changeMinimalDamage = new System.Windows.Forms.TextBox();
            this.textBox_changeMaximalDamage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_ModifySelectedAbility
            // 
            this.label_ModifySelectedAbility.AutoSize = true;
            this.label_ModifySelectedAbility.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ModifySelectedAbility.Location = new System.Drawing.Point(139, 23);
            this.label_ModifySelectedAbility.Name = "label_ModifySelectedAbility";
            this.label_ModifySelectedAbility.Size = new System.Drawing.Size(90, 30);
            this.label_ModifySelectedAbility.TabIndex = 0;
            this.label_ModifySelectedAbility.Text = "Thunder";
            // 
            // button_SaveChangedAbility
            // 
            this.button_SaveChangedAbility.Location = new System.Drawing.Point(254, 303);
            this.button_SaveChangedAbility.Name = "button_SaveChangedAbility";
            this.button_SaveChangedAbility.Size = new System.Drawing.Size(75, 23);
            this.button_SaveChangedAbility.TabIndex = 1;
            this.button_SaveChangedAbility.Text = "Save";
            this.button_SaveChangedAbility.UseVisualStyleBackColor = true;
            this.button_SaveChangedAbility.Click += new System.EventHandler(this.button_SaveChangedAbility_Click);
            // 
            // label_ChangeName
            // 
            this.label_ChangeName.AutoSize = true;
            this.label_ChangeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeName.Location = new System.Drawing.Point(40, 88);
            this.label_ChangeName.Name = "label_ChangeName";
            this.label_ChangeName.Size = new System.Drawing.Size(52, 21);
            this.label_ChangeName.TabIndex = 2;
            this.label_ChangeName.Text = "Name";
            // 
            // label_ChangeMinDmg
            // 
            this.label_ChangeMinDmg.AutoSize = true;
            this.label_ChangeMinDmg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeMinDmg.Location = new System.Drawing.Point(40, 141);
            this.label_ChangeMinDmg.Name = "label_ChangeMinDmg";
            this.label_ChangeMinDmg.Size = new System.Drawing.Size(129, 21);
            this.label_ChangeMinDmg.TabIndex = 3;
            this.label_ChangeMinDmg.Text = "Minimal Damage";
            // 
            // label_ChangeMaxDmg
            // 
            this.label_ChangeMaxDmg.AutoSize = true;
            this.label_ChangeMaxDmg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeMaxDmg.Location = new System.Drawing.Point(40, 208);
            this.label_ChangeMaxDmg.Name = "label_ChangeMaxDmg";
            this.label_ChangeMaxDmg.Size = new System.Drawing.Size(131, 21);
            this.label_ChangeMaxDmg.TabIndex = 4;
            this.label_ChangeMaxDmg.Text = "Maximal Damage";
            // 
            // textBox_ChangeAbilityName
            // 
            this.textBox_ChangeAbilityName.Location = new System.Drawing.Point(226, 90);
            this.textBox_ChangeAbilityName.Name = "textBox_ChangeAbilityName";
            this.textBox_ChangeAbilityName.Size = new System.Drawing.Size(100, 23);
            this.textBox_ChangeAbilityName.TabIndex = 5;
            // 
            // textBox_changeMinimalDamage
            // 
            this.textBox_changeMinimalDamage.Location = new System.Drawing.Point(226, 143);
            this.textBox_changeMinimalDamage.Name = "textBox_changeMinimalDamage";
            this.textBox_changeMinimalDamage.Size = new System.Drawing.Size(100, 23);
            this.textBox_changeMinimalDamage.TabIndex = 6;
            // 
            // textBox_changeMaximalDamage
            // 
            this.textBox_changeMaximalDamage.Location = new System.Drawing.Point(226, 210);
            this.textBox_changeMaximalDamage.Name = "textBox_changeMaximalDamage";
            this.textBox_changeMaximalDamage.Size = new System.Drawing.Size(100, 23);
            this.textBox_changeMaximalDamage.TabIndex = 7;
            // 
            // ModifyAbilityUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox_changeMaximalDamage);
            this.Controls.Add(this.textBox_changeMinimalDamage);
            this.Controls.Add(this.textBox_ChangeAbilityName);
            this.Controls.Add(this.label_ChangeMaxDmg);
            this.Controls.Add(this.label_ChangeMinDmg);
            this.Controls.Add(this.label_ChangeName);
            this.Controls.Add(this.button_SaveChangedAbility);
            this.Controls.Add(this.label_ModifySelectedAbility);
            this.Name = "ModifyAbilityUsercontrol";
            this.Size = new System.Drawing.Size(351, 343);
            this.Load += new System.EventHandler(this.ModifyAbilityUsercontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ModifySelectedAbility;
        private System.Windows.Forms.Button button_SaveChangedAbility;
        private System.Windows.Forms.Label label_ChangeName;
        private System.Windows.Forms.Label label_ChangeMinDmg;
        private System.Windows.Forms.Label label_ChangeMaxDmg;
        private System.Windows.Forms.TextBox textBox_ChangeAbilityName;
        private System.Windows.Forms.TextBox textBox_changeMinimalDamage;
        private System.Windows.Forms.TextBox textBox_changeMaximalDamage;
    }
}
