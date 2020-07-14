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
            this.currentMCDropDown = new System.Windows.Forms.ComboBox();
            this.mcAtCreationDropDown = new System.Windows.Forms.ComboBox();
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
            this.charInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.embraceDateTimePicker = new System.Windows.Forms.TextBox();
            this.embraceDateLabel = new System.Windows.Forms.Label();
            this.moralityLevelDropDown = new System.Windows.Forms.ComboBox();
            this.moralityLevelLabel = new System.Windows.Forms.Label();
            this.moralityDropDown = new System.Windows.Forms.ComboBox();
            this.moralityLabel = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nativeLanguageTextBox = new System.Windows.Forms.TextBox();
            this.nativeLanguageLabel = new System.Windows.Forms.Label();
            this.archetypeTextBox = new System.Windows.Forms.TextBox();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.sectDropBox = new System.Windows.Forms.ComboBox();
            this.sectLabel = new System.Windows.Forms.Label();
            this.isNPCCheckBox = new System.Windows.Forms.CheckBox();
            this.clanDropBox = new System.Windows.Forms.ComboBox();
            this.clanLabel = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.attributeGroupBox = new System.Windows.Forms.GroupBox();
            this.attributePhysicalFocus3ComboBox = new System.Windows.Forms.ComboBox();
            this.attributePhysicalFocus2ComboBox = new System.Windows.Forms.ComboBox();
            this.attributePhysicalFocus1ComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.attributePhysicalLabel = new System.Windows.Forms.Label();
            this.sheetTabControl.SuspendLayout();
            this.playerInfoTab.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.playerInfoGroupBox.SuspendLayout();
            this.characterInfoTab.SuspendLayout();
            this.charInfoGroupBox.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.attributeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheetTabControl
            // 
            this.sheetTabControl.Controls.Add(this.playerInfoTab);
            this.sheetTabControl.Controls.Add(this.characterInfoTab);
            this.sheetTabControl.Controls.Add(this.statsTab);
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
            this.playerInfoTab.Enter += new System.EventHandler(this.playerInfoTab_Enter);
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
            this.playerInfoGroupBox.Location = new System.Drawing.Point(3, 204);
            this.playerInfoGroupBox.Name = "playerInfoGroupBox";
            this.playerInfoGroupBox.Size = new System.Drawing.Size(982, 326);
            this.playerInfoGroupBox.TabIndex = 0;
            this.playerInfoGroupBox.TabStop = false;
            this.playerInfoGroupBox.Text = "Player Info";
            // 
            // currentMCDropDown
            // 
            this.currentMCDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentMCDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMCDropDown.FormattingEnabled = true;
            this.currentMCDropDown.Location = new System.Drawing.Point(637, 83);
            this.currentMCDropDown.Name = "currentMCDropDown";
            this.currentMCDropDown.Size = new System.Drawing.Size(144, 28);
            this.currentMCDropDown.TabIndex = 24;
            // 
            // mcAtCreationDropDown
            // 
            this.mcAtCreationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcAtCreationDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcAtCreationDropDown.FormattingEnabled = true;
            this.mcAtCreationDropDown.Items.AddRange(new object[] {
            "N/A",
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
            this.mcAtCreationDropDown.SelectedIndexChanged += new System.EventHandler(this.mcAtCreationDropDown_SelectedIndexChanged);
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
            this.characterInfoTab.Controls.Add(this.charInfoGroupBox);
            this.characterInfoTab.Location = new System.Drawing.Point(4, 22);
            this.characterInfoTab.Name = "characterInfoTab";
            this.characterInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterInfoTab.Size = new System.Drawing.Size(996, 756);
            this.characterInfoTab.TabIndex = 1;
            this.characterInfoTab.Text = "Character Info";
            this.characterInfoTab.UseVisualStyleBackColor = true;
            // 
            // charInfoGroupBox
            // 
            this.charInfoGroupBox.Controls.Add(this.embraceDateTimePicker);
            this.charInfoGroupBox.Controls.Add(this.embraceDateLabel);
            this.charInfoGroupBox.Controls.Add(this.moralityLevelDropDown);
            this.charInfoGroupBox.Controls.Add(this.moralityLevelLabel);
            this.charInfoGroupBox.Controls.Add(this.moralityDropDown);
            this.charInfoGroupBox.Controls.Add(this.moralityLabel);
            this.charInfoGroupBox.Controls.Add(this.genderTextBox);
            this.charInfoGroupBox.Controls.Add(this.genderLabel);
            this.charInfoGroupBox.Controls.Add(this.nativeLanguageTextBox);
            this.charInfoGroupBox.Controls.Add(this.nativeLanguageLabel);
            this.charInfoGroupBox.Controls.Add(this.archetypeTextBox);
            this.charInfoGroupBox.Controls.Add(this.archetypeLabel);
            this.charInfoGroupBox.Controls.Add(this.creationDateTimePicker);
            this.charInfoGroupBox.Controls.Add(this.creationDateLabel);
            this.charInfoGroupBox.Controls.Add(this.sectDropBox);
            this.charInfoGroupBox.Controls.Add(this.sectLabel);
            this.charInfoGroupBox.Controls.Add(this.isNPCCheckBox);
            this.charInfoGroupBox.Controls.Add(this.clanDropBox);
            this.charInfoGroupBox.Controls.Add(this.clanLabel);
            this.charInfoGroupBox.Controls.Add(this.characterNameTextBox);
            this.charInfoGroupBox.Controls.Add(this.characterNameLabel);
            this.charInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInfoGroupBox.Location = new System.Drawing.Point(8, 195);
            this.charInfoGroupBox.Name = "charInfoGroupBox";
            this.charInfoGroupBox.Size = new System.Drawing.Size(982, 341);
            this.charInfoGroupBox.TabIndex = 0;
            this.charInfoGroupBox.TabStop = false;
            this.charInfoGroupBox.Text = "Character Info";
            // 
            // embraceDateTimePicker
            // 
            this.embraceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embraceDateTimePicker.Location = new System.Drawing.Point(153, 233);
            this.embraceDateTimePicker.Name = "embraceDateTimePicker";
            this.embraceDateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.embraceDateTimePicker.TabIndex = 22;
            // 
            // embraceDateLabel
            // 
            this.embraceDateLabel.AutoSize = true;
            this.embraceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embraceDateLabel.Location = new System.Drawing.Point(8, 233);
            this.embraceDateLabel.Name = "embraceDateLabel";
            this.embraceDateLabel.Size = new System.Drawing.Size(124, 20);
            this.embraceDateLabel.TabIndex = 21;
            this.embraceDateLabel.Text = "Embrace Date";
            // 
            // moralityLevelDropDown
            // 
            this.moralityLevelDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moralityLevelDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityLevelDropDown.FormattingEnabled = true;
            this.moralityLevelDropDown.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.moralityLevelDropDown.Location = new System.Drawing.Point(469, 182);
            this.moralityLevelDropDown.Name = "moralityLevelDropDown";
            this.moralityLevelDropDown.Size = new System.Drawing.Size(50, 28);
            this.moralityLevelDropDown.TabIndex = 20;
            // 
            // moralityLevelLabel
            // 
            this.moralityLevelLabel.AutoSize = true;
            this.moralityLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityLevelLabel.Location = new System.Drawing.Point(412, 187);
            this.moralityLevelLabel.Name = "moralityLevelLabel";
            this.moralityLevelLabel.Size = new System.Drawing.Size(51, 20);
            this.moralityLevelLabel.TabIndex = 19;
            this.moralityLevelLabel.Text = "Level";
            // 
            // moralityDropDown
            // 
            this.moralityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moralityDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityDropDown.FormattingEnabled = true;
            this.moralityDropDown.Location = new System.Drawing.Point(153, 184);
            this.moralityDropDown.Name = "moralityDropDown";
            this.moralityDropDown.Size = new System.Drawing.Size(235, 28);
            this.moralityDropDown.TabIndex = 18;
            // 
            // moralityLabel
            // 
            this.moralityLabel.AutoSize = true;
            this.moralityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityLabel.Location = new System.Drawing.Point(8, 187);
            this.moralityLabel.Name = "moralityLabel";
            this.moralityLabel.Size = new System.Drawing.Size(134, 20);
            this.moralityLabel.TabIndex = 17;
            this.moralityLabel.Text = "Path of Morality";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTextBox.Location = new System.Drawing.Point(699, 144);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(144, 26);
            this.genderTextBox.TabIndex = 16;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(633, 147);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(69, 20);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Gender";
            // 
            // nativeLanguageTextBox
            // 
            this.nativeLanguageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nativeLanguageTextBox.Location = new System.Drawing.Point(469, 144);
            this.nativeLanguageTextBox.Name = "nativeLanguageTextBox";
            this.nativeLanguageTextBox.Size = new System.Drawing.Size(144, 26);
            this.nativeLanguageTextBox.TabIndex = 14;
            // 
            // nativeLanguageLabel
            // 
            this.nativeLanguageLabel.AutoSize = true;
            this.nativeLanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nativeLanguageLabel.Location = new System.Drawing.Point(324, 147);
            this.nativeLanguageLabel.Name = "nativeLanguageLabel";
            this.nativeLanguageLabel.Size = new System.Drawing.Size(144, 20);
            this.nativeLanguageLabel.TabIndex = 13;
            this.nativeLanguageLabel.Text = "Native Language";
            // 
            // archetypeTextBox
            // 
            this.archetypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeTextBox.Location = new System.Drawing.Point(153, 141);
            this.archetypeTextBox.Name = "archetypeTextBox";
            this.archetypeTextBox.Size = new System.Drawing.Size(144, 26);
            this.archetypeTextBox.TabIndex = 12;
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(8, 144);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(90, 20);
            this.archetypeLabel.TabIndex = 11;
            this.archetypeLabel.Text = "Archetype";
            // 
            // creationDateTimePicker
            // 
            this.creationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creationDateTimePicker.Location = new System.Drawing.Point(153, 46);
            this.creationDateTimePicker.Name = "creationDateTimePicker";
            this.creationDateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.creationDateTimePicker.TabIndex = 10;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.Location = new System.Drawing.Point(8, 51);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(121, 20);
            this.creationDateLabel.TabIndex = 9;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // sectDropBox
            // 
            this.sectDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectDropBox.FormattingEnabled = true;
            this.sectDropBox.Items.AddRange(new object[] {
            "Anarch",
            "Camarilla",
            "Independent Alliance",
            "Sabbat",
            "Unaligned"});
            this.sectDropBox.Location = new System.Drawing.Point(643, 94);
            this.sectDropBox.Name = "sectDropBox";
            this.sectDropBox.Size = new System.Drawing.Size(200, 28);
            this.sectDropBox.TabIndex = 8;
            // 
            // sectLabel
            // 
            this.sectLabel.AutoSize = true;
            this.sectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectLabel.Location = new System.Drawing.Point(592, 97);
            this.sectLabel.Name = "sectLabel";
            this.sectLabel.Size = new System.Drawing.Size(46, 20);
            this.sectLabel.TabIndex = 7;
            this.sectLabel.Text = "Sect";
            // 
            // isNPCCheckBox
            // 
            this.isNPCCheckBox.AutoSize = true;
            this.isNPCCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNPCCheckBox.Location = new System.Drawing.Point(869, 98);
            this.isNPCCheckBox.Name = "isNPCCheckBox";
            this.isNPCCheckBox.Size = new System.Drawing.Size(83, 24);
            this.isNPCCheckBox.TabIndex = 6;
            this.isNPCCheckBox.Text = "Is NPC";
            this.isNPCCheckBox.UseVisualStyleBackColor = true;
            // 
            // clanDropBox
            // 
            this.clanDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clanDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clanDropBox.FormattingEnabled = true;
            this.clanDropBox.Location = new System.Drawing.Point(375, 94);
            this.clanDropBox.Name = "clanDropBox";
            this.clanDropBox.Size = new System.Drawing.Size(200, 28);
            this.clanDropBox.TabIndex = 5;
            this.clanDropBox.SelectedIndexChanged += new System.EventHandler(this.clanDropBox_SelectedIndexChanged);
            // 
            // clanLabel
            // 
            this.clanLabel.AutoSize = true;
            this.clanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clanLabel.Location = new System.Drawing.Point(324, 97);
            this.clanLabel.Name = "clanLabel";
            this.clanLabel.Size = new System.Drawing.Size(45, 20);
            this.clanLabel.TabIndex = 4;
            this.clanLabel.Text = "Clan";
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameTextBox.Location = new System.Drawing.Point(153, 94);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(144, 26);
            this.characterNameTextBox.TabIndex = 3;
            this.characterNameTextBox.TextChanged += new System.EventHandler(this.characterNameTextBox_TextChanged);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameLabel.Location = new System.Drawing.Point(8, 97);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(139, 20);
            this.characterNameLabel.TabIndex = 2;
            this.characterNameLabel.Text = "Character Name";
            // 
            // statsTab
            // 
            this.statsTab.Controls.Add(this.attributeGroupBox);
            this.statsTab.Location = new System.Drawing.Point(4, 22);
            this.statsTab.Name = "statsTab";
            this.statsTab.Size = new System.Drawing.Size(996, 756);
            this.statsTab.TabIndex = 2;
            this.statsTab.Text = "Attributes/Abilities/Backgrounds";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // attributeGroupBox
            // 
            this.attributeGroupBox.Controls.Add(this.attributePhysicalFocus3ComboBox);
            this.attributeGroupBox.Controls.Add(this.attributePhysicalFocus2ComboBox);
            this.attributeGroupBox.Controls.Add(this.attributePhysicalFocus1ComboBox);
            this.attributeGroupBox.Controls.Add(this.textBox1);
            this.attributeGroupBox.Controls.Add(this.attributePhysicalLabel);
            this.attributeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeGroupBox.Location = new System.Drawing.Point(8, 3);
            this.attributeGroupBox.Name = "attributeGroupBox";
            this.attributeGroupBox.Size = new System.Drawing.Size(980, 218);
            this.attributeGroupBox.TabIndex = 0;
            this.attributeGroupBox.TabStop = false;
            this.attributeGroupBox.Text = "Attributes";
            // 
            // attributePhysicalFocus3ComboBox
            // 
            this.attributePhysicalFocus3ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributePhysicalFocus3ComboBox.FormattingEnabled = true;
            this.attributePhysicalFocus3ComboBox.Location = new System.Drawing.Point(10, 168);
            this.attributePhysicalFocus3ComboBox.Name = "attributePhysicalFocus3ComboBox";
            this.attributePhysicalFocus3ComboBox.Size = new System.Drawing.Size(121, 28);
            this.attributePhysicalFocus3ComboBox.TabIndex = 8;
            this.attributePhysicalFocus3ComboBox.Visible = false;
            // 
            // attributePhysicalFocus2ComboBox
            // 
            this.attributePhysicalFocus2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributePhysicalFocus2ComboBox.FormattingEnabled = true;
            this.attributePhysicalFocus2ComboBox.Location = new System.Drawing.Point(10, 134);
            this.attributePhysicalFocus2ComboBox.Name = "attributePhysicalFocus2ComboBox";
            this.attributePhysicalFocus2ComboBox.Size = new System.Drawing.Size(121, 28);
            this.attributePhysicalFocus2ComboBox.TabIndex = 7;
            this.attributePhysicalFocus2ComboBox.Visible = false;
            // 
            // attributePhysicalFocus1ComboBox
            // 
            this.attributePhysicalFocus1ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributePhysicalFocus1ComboBox.FormattingEnabled = true;
            this.attributePhysicalFocus1ComboBox.Location = new System.Drawing.Point(10, 100);
            this.attributePhysicalFocus1ComboBox.Name = "attributePhysicalFocus1ComboBox";
            this.attributePhysicalFocus1ComboBox.Size = new System.Drawing.Size(121, 28);
            this.attributePhysicalFocus1ComboBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 26);
            this.textBox1.TabIndex = 5;
            // 
            // attributePhysicalLabel
            // 
            this.attributePhysicalLabel.AutoSize = true;
            this.attributePhysicalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributePhysicalLabel.Location = new System.Drawing.Point(6, 71);
            this.attributePhysicalLabel.Name = "attributePhysicalLabel";
            this.attributePhysicalLabel.Size = new System.Drawing.Size(74, 20);
            this.attributePhysicalLabel.TabIndex = 4;
            this.attributePhysicalLabel.Text = "Physical";
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
            this.sheetTabControl.ResumeLayout(false);
            this.playerInfoTab.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.playerInfoGroupBox.ResumeLayout(false);
            this.playerInfoGroupBox.PerformLayout();
            this.characterInfoTab.ResumeLayout(false);
            this.charInfoGroupBox.ResumeLayout(false);
            this.charInfoGroupBox.PerformLayout();
            this.statsTab.ResumeLayout(false);
            this.attributeGroupBox.ResumeLayout(false);
            this.attributeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sheetTabControl;
        private System.Windows.Forms.TabPage playerInfoTab;
        private System.Windows.Forms.TabPage characterInfoTab;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.GroupBox playerInfoGroupBox;
        private System.Windows.Forms.ComboBox currentMCDropDown;
        private System.Windows.Forms.ComboBox mcAtCreationDropDown;
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
        private System.Windows.Forms.GroupBox charInfoGroupBox;
        private System.Windows.Forms.ComboBox clanDropBox;
        private System.Windows.Forms.Label clanLabel;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.ComboBox sectDropBox;
        private System.Windows.Forms.Label sectLabel;
        private System.Windows.Forms.CheckBox isNPCCheckBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nativeLanguageTextBox;
        private System.Windows.Forms.Label nativeLanguageLabel;
        private System.Windows.Forms.TextBox archetypeTextBox;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.DateTimePicker creationDateTimePicker;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.ComboBox moralityDropDown;
        private System.Windows.Forms.Label moralityLabel;
        private System.Windows.Forms.ComboBox moralityLevelDropDown;
        private System.Windows.Forms.Label moralityLevelLabel;
        private System.Windows.Forms.Label embraceDateLabel;
        private System.Windows.Forms.GroupBox attributeGroupBox;
        private System.Windows.Forms.TextBox embraceDateTimePicker;
        private System.Windows.Forms.ComboBox attributePhysicalFocus3ComboBox;
        private System.Windows.Forms.ComboBox attributePhysicalFocus2ComboBox;
        private System.Windows.Forms.ComboBox attributePhysicalFocus1ComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label attributePhysicalLabel;
    }
}