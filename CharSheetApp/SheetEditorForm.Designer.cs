namespace CharSheetApp
{
    partial class SheetEditorForm
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
            this.sheetTabControl = new System.Windows.Forms.TabControl();
            this.playerInfoTab = new System.Windows.Forms.TabPage();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.playerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.domainIDTextBox = new System.Windows.Forms.TextBox();
            this.domainIDLabel = new System.Windows.Forms.Label();
            this.coordEmailTextBox = new System.Windows.Forms.TextBox();
            this.coordEmailLabel = new System.Windows.Forms.Label();
            this.directCoordTextBox = new System.Windows.Forms.TextBox();
            this.directCoordLabel = new System.Windows.Forms.Label();
            this.stEmailTextBox = new System.Windows.Forms.TextBox();
            this.stEmailLabel = new System.Windows.Forms.Label();
            this.directSTTextBox = new System.Windows.Forms.TextBox();
            this.directSTLabel = new System.Windows.Forms.Label();
            this.currentMCLabel = new System.Windows.Forms.Label();
            this.mcAtCreationLabel = new System.Windows.Forms.Label();
            this.membershipNumberTextBox = new System.Windows.Forms.TextBox();
            this.membershipNumberLabel = new System.Windows.Forms.Label();
            this.playerEmailTextBox = new System.Windows.Forms.TextBox();
            this.playerEmailLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.characterInfoTab = new System.Windows.Forms.TabPage();
            this.mcAtCreationDropDown = new System.Windows.Forms.ComboBox();
            this.currentMCDropDown = new System.Windows.Forms.ComboBox();
            this.sheetTabControl.SuspendLayout();
            this.playerInfoTab.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.playerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheetTabControl
            // 
            this.sheetTabControl.Controls.Add(this.playerInfoTab);
            this.sheetTabControl.Controls.Add(this.characterInfoTab);
            this.sheetTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetTabControl.Location = new System.Drawing.Point(0, 0);
            this.sheetTabControl.Name = "sheetTabControl";
            this.sheetTabControl.SelectedIndex = 0;
            this.sheetTabControl.Size = new System.Drawing.Size(1004, 782);
            this.sheetTabControl.TabIndex = 0;
            // 
            // playerInfoTab
            // 
            this.playerInfoTab.Controls.Add(this.groupPanel);
            this.playerInfoTab.Location = new System.Drawing.Point(4, 22);
            this.playerInfoTab.Name = "playerInfoTab";
            this.playerInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerInfoTab.Size = new System.Drawing.Size(996, 756);
            this.playerInfoTab.TabIndex = 0;
            this.playerInfoTab.Text = "Player Info";
            this.playerInfoTab.UseVisualStyleBackColor = true;
            // 
            // groupPanel
            // 
            this.groupPanel.AutoScroll = true;
            this.groupPanel.Controls.Add(this.playerInfoGroupBox);
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.Location = new System.Drawing.Point(3, 3);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(990, 750);
            this.groupPanel.TabIndex = 0;
            // 
            // playerInfoGroupBox
            // 
            this.playerInfoGroupBox.Controls.Add(this.currentMCDropDown);
            this.playerInfoGroupBox.Controls.Add(this.mcAtCreationDropDown);
            this.playerInfoGroupBox.Controls.Add(this.countryTextBox);
            this.playerInfoGroupBox.Controls.Add(this.countryLabel);
            this.playerInfoGroupBox.Controls.Add(this.regionTextBox);
            this.playerInfoGroupBox.Controls.Add(this.regionLabel);
            this.playerInfoGroupBox.Controls.Add(this.domainIDTextBox);
            this.playerInfoGroupBox.Controls.Add(this.domainIDLabel);
            this.playerInfoGroupBox.Controls.Add(this.coordEmailTextBox);
            this.playerInfoGroupBox.Controls.Add(this.coordEmailLabel);
            this.playerInfoGroupBox.Controls.Add(this.directCoordTextBox);
            this.playerInfoGroupBox.Controls.Add(this.directCoordLabel);
            this.playerInfoGroupBox.Controls.Add(this.stEmailTextBox);
            this.playerInfoGroupBox.Controls.Add(this.stEmailLabel);
            this.playerInfoGroupBox.Controls.Add(this.directSTTextBox);
            this.playerInfoGroupBox.Controls.Add(this.directSTLabel);
            this.playerInfoGroupBox.Controls.Add(this.currentMCLabel);
            this.playerInfoGroupBox.Controls.Add(this.mcAtCreationLabel);
            this.playerInfoGroupBox.Controls.Add(this.membershipNumberTextBox);
            this.playerInfoGroupBox.Controls.Add(this.membershipNumberLabel);
            this.playerInfoGroupBox.Controls.Add(this.playerEmailTextBox);
            this.playerInfoGroupBox.Controls.Add(this.playerEmailLabel);
            this.playerInfoGroupBox.Controls.Add(this.playerNameTextBox);
            this.playerInfoGroupBox.Controls.Add(this.playerNameLabel);
            this.playerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoGroupBox.Location = new System.Drawing.Point(5, 3);
            this.playerInfoGroupBox.Name = "playerInfoGroupBox";
            this.playerInfoGroupBox.Size = new System.Drawing.Size(982, 326);
            this.playerInfoGroupBox.TabIndex = 0;
            this.playerInfoGroupBox.TabStop = false;
            this.playerInfoGroupBox.Text = "Player Info";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.Location = new System.Drawing.Point(795, 200);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(144, 26);
            this.countryTextBox.TabIndex = 23;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(616, 206);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(71, 20);
            this.countryLabel.TabIndex = 22;
            this.countryLabel.Text = "Country";
            // 
            // regionTextBox
            // 
            this.regionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionTextBox.Location = new System.Drawing.Point(463, 200);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(144, 26);
            this.regionTextBox.TabIndex = 21;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionLabel.Location = new System.Drawing.Point(311, 206);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(66, 20);
            this.regionLabel.TabIndex = 20;
            this.regionLabel.Text = "Region";
            // 
            // domainIDTextBox
            // 
            this.domainIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainIDTextBox.Location = new System.Drawing.Point(156, 200);
            this.domainIDTextBox.Name = "domainIDTextBox";
            this.domainIDTextBox.Size = new System.Drawing.Size(144, 26);
            this.domainIDTextBox.TabIndex = 19;
            // 
            // domainIDLabel
            // 
            this.domainIDLabel.AutoSize = true;
            this.domainIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainIDLabel.Location = new System.Drawing.Point(6, 206);
            this.domainIDLabel.Name = "domainIDLabel";
            this.domainIDLabel.Size = new System.Drawing.Size(94, 20);
            this.domainIDLabel.TabIndex = 18;
            this.domainIDLabel.Text = "Domain ID";
            // 
            // coordEmailTextBox
            // 
            this.coordEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordEmailTextBox.Location = new System.Drawing.Point(463, 164);
            this.coordEmailTextBox.Name = "coordEmailTextBox";
            this.coordEmailTextBox.Size = new System.Drawing.Size(144, 26);
            this.coordEmailTextBox.TabIndex = 17;
            // 
            // coordEmailLabel
            // 
            this.coordEmailLabel.AutoSize = true;
            this.coordEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordEmailLabel.Location = new System.Drawing.Point(311, 167);
            this.coordEmailLabel.Name = "coordEmailLabel";
            this.coordEmailLabel.Size = new System.Drawing.Size(158, 20);
            this.coordEmailLabel.TabIndex = 16;
            this.coordEmailLabel.Text = "Coordinator E-mail";
            // 
            // directCoordTextBox
            // 
            this.directCoordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directCoordTextBox.Location = new System.Drawing.Point(156, 164);
            this.directCoordTextBox.Name = "directCoordTextBox";
            this.directCoordTextBox.Size = new System.Drawing.Size(144, 26);
            this.directCoordTextBox.TabIndex = 15;
            // 
            // directCoordLabel
            // 
            this.directCoordLabel.AutoSize = true;
            this.directCoordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directCoordLabel.Location = new System.Drawing.Point(6, 167);
            this.directCoordLabel.Name = "directCoordLabel";
            this.directCoordLabel.Size = new System.Drawing.Size(156, 20);
            this.directCoordLabel.TabIndex = 14;
            this.directCoordLabel.Text = "Direct Coordinator";
            // 
            // stEmailTextBox
            // 
            this.stEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stEmailTextBox.Location = new System.Drawing.Point(463, 122);
            this.stEmailTextBox.Name = "stEmailTextBox";
            this.stEmailTextBox.Size = new System.Drawing.Size(144, 26);
            this.stEmailTextBox.TabIndex = 13;
            // 
            // stEmailLabel
            // 
            this.stEmailLabel.AutoSize = true;
            this.stEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stEmailLabel.Location = new System.Drawing.Point(311, 125);
            this.stEmailLabel.Name = "stEmailLabel";
            this.stEmailLabel.Size = new System.Drawing.Size(146, 20);
            this.stEmailLabel.TabIndex = 12;
            this.stEmailLabel.Text = "Storyteller E-mail";
            // 
            // directSTTextBox
            // 
            this.directSTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directSTTextBox.Location = new System.Drawing.Point(156, 122);
            this.directSTTextBox.Name = "directSTTextBox";
            this.directSTTextBox.Size = new System.Drawing.Size(144, 26);
            this.directSTTextBox.TabIndex = 11;
            // 
            // directSTLabel
            // 
            this.directSTLabel.AutoSize = true;
            this.directSTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directSTLabel.Location = new System.Drawing.Point(6, 125);
            this.directSTLabel.Name = "directSTLabel";
            this.directSTLabel.Size = new System.Drawing.Size(144, 20);
            this.directSTLabel.TabIndex = 10;
            this.directSTLabel.Text = "Direct Storyteller";
            // 
            // currentMCLabel
            // 
            this.currentMCLabel.AutoSize = true;
            this.currentMCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMCLabel.Location = new System.Drawing.Point(411, 86);
            this.currentMCLabel.Name = "currentMCLabel";
            this.currentMCLabel.Size = new System.Drawing.Size(220, 20);
            this.currentMCLabel.TabIndex = 8;
            this.currentMCLabel.Text = "Current Membership Class";
            // 
            // mcAtCreationLabel
            // 
            this.mcAtCreationLabel.AutoSize = true;
            this.mcAtCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcAtCreationLabel.Location = new System.Drawing.Point(6, 86);
            this.mcAtCreationLabel.Name = "mcAtCreationLabel";
            this.mcAtCreationLabel.Size = new System.Drawing.Size(251, 20);
            this.mcAtCreationLabel.TabIndex = 6;
            this.mcAtCreationLabel.Text = "Membership Class At Creation";
            // 
            // membershipNumberTextBox
            // 
            this.membershipNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipNumberTextBox.Location = new System.Drawing.Point(795, 48);
            this.membershipNumberTextBox.Name = "membershipNumberTextBox";
            this.membershipNumberTextBox.Size = new System.Drawing.Size(144, 26);
            this.membershipNumberTextBox.TabIndex = 5;
            // 
            // membershipNumberLabel
            // 
            this.membershipNumberLabel.AutoSize = true;
            this.membershipNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipNumberLabel.Location = new System.Drawing.Point(616, 51);
            this.membershipNumberLabel.Name = "membershipNumberLabel";
            this.membershipNumberLabel.Size = new System.Drawing.Size(173, 20);
            this.membershipNumberLabel.TabIndex = 4;
            this.membershipNumberLabel.Text = "Membership Number";
            // 
            // playerEmailTextBox
            // 
            this.playerEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEmailTextBox.Location = new System.Drawing.Point(430, 45);
            this.playerEmailTextBox.Name = "playerEmailTextBox";
            this.playerEmailTextBox.Size = new System.Drawing.Size(144, 26);
            this.playerEmailTextBox.TabIndex = 3;
            // 
            // playerEmailLabel
            // 
            this.playerEmailLabel.AutoSize = true;
            this.playerEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEmailLabel.Location = new System.Drawing.Point(311, 48);
            this.playerEmailLabel.Name = "playerEmailLabel";
            this.playerEmailLabel.Size = new System.Drawing.Size(113, 20);
            this.playerEmailLabel.TabIndex = 2;
            this.playerEmailLabel.Text = "Player E-mail";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.Location = new System.Drawing.Point(121, 42);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(144, 26);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(6, 45);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(109, 20);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player Name";
            // 
            // characterInfoTab
            // 
            this.characterInfoTab.Location = new System.Drawing.Point(4, 22);
            this.characterInfoTab.Name = "characterInfoTab";
            this.characterInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterInfoTab.Size = new System.Drawing.Size(996, 756);
            this.characterInfoTab.TabIndex = 1;
            this.characterInfoTab.Text = "Character Info";
            this.characterInfoTab.UseVisualStyleBackColor = true;
            // 
            // mcAtCreationDropDown
            // 
            this.mcAtCreationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcAtCreationDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcAtCreationDropDown.FormattingEnabled = true;
            this.mcAtCreationDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.mcAtCreationDropDown.Location = new System.Drawing.Point(263, 81);
            this.mcAtCreationDropDown.Name = "mcAtCreationDropDown";
            this.mcAtCreationDropDown.Size = new System.Drawing.Size(144, 28);
            this.mcAtCreationDropDown.TabIndex = 1;
            // 
            // currentMCDropDown
            // 
            this.currentMCDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentMCDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMCDropDown.FormattingEnabled = true;
            this.currentMCDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.currentMCDropDown.Location = new System.Drawing.Point(637, 83);
            this.currentMCDropDown.Name = "currentMCDropDown";
            this.currentMCDropDown.Size = new System.Drawing.Size(144, 28);
            this.currentMCDropDown.TabIndex = 24;
            // 
            // SheetEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 782);
            this.Controls.Add(this.sheetTabControl);
            this.MaximumSize = new System.Drawing.Size(1020, 10000);
            this.Name = "SheetEditorForm";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.SheetEditorForm_ResizeEnd);
            this.sheetTabControl.ResumeLayout(false);
            this.playerInfoTab.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.playerInfoGroupBox.ResumeLayout(false);
            this.playerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sheetTabControl;
        private System.Windows.Forms.TabPage playerInfoTab;
        private System.Windows.Forms.TabPage characterInfoTab;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.GroupBox playerInfoGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.TextBox domainIDTextBox;
        private System.Windows.Forms.Label domainIDLabel;
        private System.Windows.Forms.TextBox coordEmailTextBox;
        private System.Windows.Forms.Label coordEmailLabel;
        private System.Windows.Forms.TextBox directCoordTextBox;
        private System.Windows.Forms.Label directCoordLabel;
        private System.Windows.Forms.TextBox stEmailTextBox;
        private System.Windows.Forms.Label stEmailLabel;
        private System.Windows.Forms.TextBox directSTTextBox;
        private System.Windows.Forms.Label directSTLabel;
        private System.Windows.Forms.Label currentMCLabel;
        private System.Windows.Forms.Label mcAtCreationLabel;
        private System.Windows.Forms.TextBox membershipNumberTextBox;
        private System.Windows.Forms.Label membershipNumberLabel;
        private System.Windows.Forms.TextBox playerEmailTextBox;
        private System.Windows.Forms.Label playerEmailLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.ComboBox mcAtCreationDropDown;
        private System.Windows.Forms.ComboBox currentMCDropDown;
    }
}