namespace Cube_World_Trainer_C_
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.PreGoldCheckbox = new System.Windows.Forms.CheckBox();
            this.SettingsSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keep Original Gold";
            // 
            // PreGoldCheckbox
            // 
            this.PreGoldCheckbox.AutoSize = true;
            this.PreGoldCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.PreGoldCheckbox.Checked = true;
            this.PreGoldCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PreGoldCheckbox.Location = new System.Drawing.Point(27, 29);
            this.PreGoldCheckbox.Name = "PreGoldCheckbox";
            this.PreGoldCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PreGoldCheckbox.TabIndex = 2;
            this.PreGoldCheckbox.UseVisualStyleBackColor = false;
            this.PreGoldCheckbox.CheckedChanged += new System.EventHandler(this.PreGoldCheckbox_CheckedChanged);
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.Location = new System.Drawing.Point(713, 31);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsSaveButton.TabIndex = 4;
            this.SettingsSaveButton.Text = "Save";
            this.SettingsSaveButton.UseVisualStyleBackColor = true;
            this.SettingsSaveButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 66);
            this.Controls.Add(this.SettingsSaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreGoldCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Cube World Trainer v1.0.0";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox PreGoldCheckbox;
        private System.Windows.Forms.Button SettingsSaveButton;
    }
}