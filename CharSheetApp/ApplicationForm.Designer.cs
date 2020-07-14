namespace CharSheetApp
{
    partial class ApplicationForm
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
            this.charNameLabel = new System.Windows.Forms.Label();
            this.charNameData = new System.Windows.Forms.Label();
            this.itemTypeDropdownLabel = new System.Windows.Forms.Label();
            this.applicationStringLabel = new System.Windows.Forms.Label();
            this.applicationStringDisplayLabel = new System.Windows.Forms.Label();
            this.applicationItemTypeDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // charNameLabel
            // 
            this.charNameLabel.AutoSize = true;
            this.charNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameLabel.Location = new System.Drawing.Point(12, 62);
            this.charNameLabel.Name = "charNameLabel";
            this.charNameLabel.Size = new System.Drawing.Size(149, 20);
            this.charNameLabel.TabIndex = 0;
            this.charNameLabel.Text = "Character Name: ";
            // 
            // charNameData
            // 
            this.charNameData.AutoSize = true;
            this.charNameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameData.Location = new System.Drawing.Point(154, 62);
            this.charNameData.MaximumSize = new System.Drawing.Size(1020, 10000);
            this.charNameData.Name = "charNameData";
            this.charNameData.Size = new System.Drawing.Size(0, 20);
            this.charNameData.TabIndex = 1;
            // 
            // itemTypeDropdownLabel
            // 
            this.itemTypeDropdownLabel.AutoSize = true;
            this.itemTypeDropdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeDropdownLabel.Location = new System.Drawing.Point(12, 94);
            this.itemTypeDropdownLabel.Name = "itemTypeDropdownLabel";
            this.itemTypeDropdownLabel.Size = new System.Drawing.Size(93, 20);
            this.itemTypeDropdownLabel.TabIndex = 2;
            this.itemTypeDropdownLabel.Text = "Item Type:";
            // 
            // applicationStringLabel
            // 
            this.applicationStringLabel.AutoSize = true;
            this.applicationStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationStringLabel.Location = new System.Drawing.Point(533, 62);
            this.applicationStringLabel.Name = "applicationStringLabel";
            this.applicationStringLabel.Size = new System.Drawing.Size(108, 20);
            this.applicationStringLabel.TabIndex = 3;
            this.applicationStringLabel.Text = "Application: ";
            // 
            // applicationStringDisplayLabel
            // 
            this.applicationStringDisplayLabel.AutoSize = true;
            this.applicationStringDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationStringDisplayLabel.Location = new System.Drawing.Point(637, 62);
            this.applicationStringDisplayLabel.Name = "applicationStringDisplayLabel";
            this.applicationStringDisplayLabel.Size = new System.Drawing.Size(0, 20);
            this.applicationStringDisplayLabel.TabIndex = 4;
            // 
            // applicationItemTypeDropDown
            // 
            this.applicationItemTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.applicationItemTypeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationItemTypeDropDown.FormattingEnabled = true;
            this.applicationItemTypeDropDown.Items.AddRange(new object[] {
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
            this.applicationItemTypeDropDown.Location = new System.Drawing.Point(111, 91);
            this.applicationItemTypeDropDown.Name = "applicationItemTypeDropDown";
            this.applicationItemTypeDropDown.Size = new System.Drawing.Size(144, 28);
            this.applicationItemTypeDropDown.TabIndex = 5;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 729);
            this.Controls.Add(this.applicationItemTypeDropDown);
            this.Controls.Add(this.applicationStringDisplayLabel);
            this.Controls.Add(this.applicationStringLabel);
            this.Controls.Add(this.itemTypeDropdownLabel);
            this.Controls.Add(this.charNameData);
            this.Controls.Add(this.charNameLabel);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charNameLabel;
        private System.Windows.Forms.Label charNameData;
        private System.Windows.Forms.Label itemTypeDropdownLabel;
        private System.Windows.Forms.Label applicationStringLabel;
        private System.Windows.Forms.Label applicationStringDisplayLabel;
        private System.Windows.Forms.ComboBox applicationItemTypeDropDown;
    }
}