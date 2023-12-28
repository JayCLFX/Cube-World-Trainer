namespace Cube_World_Trainer_C_
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HealthCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoldCheckbox = new System.Windows.Forms.CheckBox();
            this.ManaCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KeepGoldCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BlockPowerCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StalthCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.Save1Button = new System.Windows.Forms.Button();
            this.Save2Button = new System.Windows.Forms.Button();
            this.Teleport1Button = new System.Windows.Forms.Button();
            this.Teleport2Button = new System.Windows.Forms.Button();
            this.ResetTPButton = new System.Windows.Forms.Button();
            this.ForceTimeLabel = new System.Windows.Forms.Label();
            this.TimeCheckbox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemEditorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HealthCheckbox
            // 
            this.HealthCheckbox.AutoSize = true;
            this.HealthCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.HealthCheckbox.Location = new System.Drawing.Point(18, 297);
            this.HealthCheckbox.Name = "HealthCheckbox";
            this.HealthCheckbox.Size = new System.Drawing.Size(15, 14);
            this.HealthCheckbox.TabIndex = 0;
            this.HealthCheckbox.UseVisualStyleBackColor = false;
            this.HealthCheckbox.CheckedChanged += new System.EventHandler(this.HealthCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infinite Health";
            // 
            // GoldCheckbox
            // 
            this.GoldCheckbox.AutoSize = true;
            this.GoldCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.GoldCheckbox.Location = new System.Drawing.Point(18, 373);
            this.GoldCheckbox.Name = "GoldCheckbox";
            this.GoldCheckbox.Size = new System.Drawing.Size(15, 14);
            this.GoldCheckbox.TabIndex = 2;
            this.GoldCheckbox.UseVisualStyleBackColor = false;
            this.GoldCheckbox.CheckedChanged += new System.EventHandler(this.GoldCheckbox_CheckedChanged);
            // 
            // ManaCheckbox
            // 
            this.ManaCheckbox.AutoSize = true;
            this.ManaCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ManaCheckbox.Location = new System.Drawing.Point(18, 333);
            this.ManaCheckbox.Name = "ManaCheckbox";
            this.ManaCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ManaCheckbox.TabIndex = 4;
            this.ManaCheckbox.UseVisualStyleBackColor = false;
            this.ManaCheckbox.CheckedChanged += new System.EventHandler(this.ManaCheckbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(39, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Infinite Mana";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(12, 442);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(720, 442);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Infinite Gold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(707, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Keep Gold";
            // 
            // KeepGoldCheckbox
            // 
            this.KeepGoldCheckbox.AutoSize = true;
            this.KeepGoldCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.KeepGoldCheckbox.Checked = true;
            this.KeepGoldCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeepGoldCheckbox.Location = new System.Drawing.Point(686, 287);
            this.KeepGoldCheckbox.Name = "KeepGoldCheckbox";
            this.KeepGoldCheckbox.Size = new System.Drawing.Size(15, 14);
            this.KeepGoldCheckbox.TabIndex = 11;
            this.KeepGoldCheckbox.UseVisualStyleBackColor = false;
            this.KeepGoldCheckbox.CheckedChanged += new System.EventHandler(this.KeepGoldCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(107, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "CHEATS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(39, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Infinite Stamina";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(18, 411);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(207, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Infinte Block Power";
            // 
            // BlockPowerCheckbox
            // 
            this.BlockPowerCheckbox.AutoSize = true;
            this.BlockPowerCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.BlockPowerCheckbox.Location = new System.Drawing.Point(186, 298);
            this.BlockPowerCheckbox.Name = "BlockPowerCheckbox";
            this.BlockPowerCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BlockPowerCheckbox.TabIndex = 16;
            this.BlockPowerCheckbox.UseVisualStyleBackColor = false;
            this.BlockPowerCheckbox.CheckedChanged += new System.EventHandler(this.BlockPowerCheckbox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(207, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Infinte Stealth";
            // 
            // StalthCheckbox
            // 
            this.StalthCheckbox.AutoSize = true;
            this.StalthCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.StalthCheckbox.Location = new System.Drawing.Point(186, 333);
            this.StalthCheckbox.Name = "StalthCheckbox";
            this.StalthCheckbox.Size = new System.Drawing.Size(15, 14);
            this.StalthCheckbox.TabIndex = 18;
            this.StalthCheckbox.UseVisualStyleBackColor = false;
            this.StalthCheckbox.CheckedChanged += new System.EventHandler(this.StalthCheckbox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(466, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "CORDINATES";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.Color.Transparent;
            this.XLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XLabel.Location = new System.Drawing.Point(506, 281);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(16, 23);
            this.XLabel.TabIndex = 21;
            this.XLabel.Text = "-";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(465, 281);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(35, 30);
            this.X.TabIndex = 22;
            this.X.Text = "X:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.BackColor = System.Drawing.Color.Transparent;
            this.Y.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.ForeColor = System.Drawing.Color.Blue;
            this.Y.Location = new System.Drawing.Point(466, 358);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(35, 30);
            this.Y.TabIndex = 23;
            this.Y.Text = "Y:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.BackColor = System.Drawing.Color.Transparent;
            this.YLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YLabel.Location = new System.Drawing.Point(507, 365);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(16, 23);
            this.YLabel.TabIndex = 24;
            this.YLabel.Text = "-";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.BackColor = System.Drawing.Color.Transparent;
            this.Z.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z.ForeColor = System.Drawing.Color.Lime;
            this.Z.Location = new System.Drawing.Point(466, 319);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(34, 30);
            this.Z.TabIndex = 25;
            this.Z.Text = "Z:";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.BackColor = System.Drawing.Color.Transparent;
            this.ZLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZLabel.Location = new System.Drawing.Point(506, 326);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(16, 23);
            this.ZLabel.TabIndex = 26;
            this.ZLabel.Text = "-";
            // 
            // Save1Button
            // 
            this.Save1Button.Location = new System.Drawing.Point(459, 402);
            this.Save1Button.Name = "Save1Button";
            this.Save1Button.Size = new System.Drawing.Size(75, 23);
            this.Save1Button.TabIndex = 27;
            this.Save1Button.Text = "Save 1";
            this.Save1Button.UseVisualStyleBackColor = true;
            this.Save1Button.Click += new System.EventHandler(this.Save1Button_Click);
            // 
            // Save2Button
            // 
            this.Save2Button.Location = new System.Drawing.Point(545, 402);
            this.Save2Button.Name = "Save2Button";
            this.Save2Button.Size = new System.Drawing.Size(75, 23);
            this.Save2Button.TabIndex = 28;
            this.Save2Button.Text = "Save 2";
            this.Save2Button.UseVisualStyleBackColor = true;
            this.Save2Button.Click += new System.EventHandler(this.Save2Button_Click);
            // 
            // Teleport1Button
            // 
            this.Teleport1Button.Location = new System.Drawing.Point(459, 431);
            this.Teleport1Button.Name = "Teleport1Button";
            this.Teleport1Button.Size = new System.Drawing.Size(75, 23);
            this.Teleport1Button.TabIndex = 29;
            this.Teleport1Button.Text = "Teleport 1";
            this.Teleport1Button.UseVisualStyleBackColor = true;
            this.Teleport1Button.Click += new System.EventHandler(this.Teleport1Button_Click);
            // 
            // Teleport2Button
            // 
            this.Teleport2Button.Location = new System.Drawing.Point(545, 431);
            this.Teleport2Button.Name = "Teleport2Button";
            this.Teleport2Button.Size = new System.Drawing.Size(75, 23);
            this.Teleport2Button.TabIndex = 30;
            this.Teleport2Button.Text = "Teleport 2";
            this.Teleport2Button.UseVisualStyleBackColor = true;
            this.Teleport2Button.Click += new System.EventHandler(this.Teleport2Button_Click);
            // 
            // ResetTPButton
            // 
            this.ResetTPButton.Location = new System.Drawing.Point(720, 413);
            this.ResetTPButton.Name = "ResetTPButton";
            this.ResetTPButton.Size = new System.Drawing.Size(75, 23);
            this.ResetTPButton.TabIndex = 31;
            this.ResetTPButton.Text = "Reset TP";
            this.ResetTPButton.UseVisualStyleBackColor = true;
            this.ResetTPButton.Click += new System.EventHandler(this.ResetTPButton_Click);
            // 
            // ForceTimeLabel
            // 
            this.ForceTimeLabel.AutoSize = true;
            this.ForceTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForceTimeLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ForceTimeLabel.Location = new System.Drawing.Point(207, 364);
            this.ForceTimeLabel.Name = "ForceTimeLabel";
            this.ForceTimeLabel.Size = new System.Drawing.Size(139, 23);
            this.ForceTimeLabel.TabIndex = 35;
            this.ForceTimeLabel.Text = "Force 10AM Time";
            // 
            // TimeCheckbox
            // 
            this.TimeCheckbox.AutoSize = true;
            this.TimeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.TimeCheckbox.Location = new System.Drawing.Point(186, 371);
            this.TimeCheckbox.Name = "TimeCheckbox";
            this.TimeCheckbox.Size = new System.Drawing.Size(15, 14);
            this.TimeCheckbox.TabIndex = 34;
            this.TimeCheckbox.UseVisualStyleBackColor = false;
            this.TimeCheckbox.CheckedChanged += new System.EventHandler(this.TimeCheckbox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(698, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "SETTINGS";
            // 
            // ItemEditorButton
            // 
            this.ItemEditorButton.Location = new System.Drawing.Point(126, 442);
            this.ItemEditorButton.Name = "ItemEditorButton";
            this.ItemEditorButton.Size = new System.Drawing.Size(75, 23);
            this.ItemEditorButton.TabIndex = 37;
            this.ItemEditorButton.Text = "Item Editor";
            this.ItemEditorButton.UseVisualStyleBackColor = true;
            this.ItemEditorButton.Click += new System.EventHandler(this.ItemEditorButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Cube_World_Trainer_C_.Properties.Resources.capsule_616x353;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.ItemEditorButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ForceTimeLabel);
            this.Controls.Add(this.TimeCheckbox);
            this.Controls.Add(this.ResetTPButton);
            this.Controls.Add(this.Teleport2Button);
            this.Controls.Add(this.Teleport1Button);
            this.Controls.Add(this.Save2Button);
            this.Controls.Add(this.Save1Button);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StalthCheckbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BlockPowerCheckbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KeepGoldCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManaCheckbox);
            this.Controls.Add(this.GoldCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HealthCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Cube World Trainer v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HealthCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GoldCheckbox;
        private System.Windows.Forms.CheckBox ManaCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox KeepGoldCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox BlockPowerCheckbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox StalthCheckbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Button Save1Button;
        private System.Windows.Forms.Button Save2Button;
        private System.Windows.Forms.Button Teleport1Button;
        private System.Windows.Forms.Button Teleport2Button;
        private System.Windows.Forms.Button ResetTPButton;
        private System.Windows.Forms.Label ForceTimeLabel;
        private System.Windows.Forms.CheckBox TimeCheckbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ItemEditorButton;
    }
}

