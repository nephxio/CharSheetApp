using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharSheetApp
{
    public partial class SheetEditorForm : Form
    {
        public CharSheetData sheet;

        public SheetEditorForm()
        {
            InitializeComponent();
            sheet = new CharSheetData();
            CenterToParent();
        }


        public SheetEditorForm(Form Parent)
        {
            InitializeComponent();
            sheet = new CharSheetData();
            StaticGameData.LoadBloodlineData();
            FillClanBox(clanDropBox);
            FillPathBox(moralityDropDown);

            this.Text = "New Character";

            CenterToParent();
            MdiParent = Parent;

            this.Height = (int)(MdiParent.Height * .75);
            this.Width = (int)(MdiParent.Width * .75);
        }

        public CharSheetData PackCharacterDataForSave()
        {
            CharSheetData charData = new CharSheetData();

            PackPlayerInfo(ref charData);
            PackCharacterInfo(ref charData);

            return charData;
        }

        private void PackPlayerInfo(ref CharSheetData InCharacter)
        {
            InCharacter.headers.playerName = playerNameTextBox.Text;
            InCharacter.headers.playerEmail = playerEmailTextBox.Text;
            InCharacter.headers.membershipID = membershipNumberTextBox.Text;

            if (mcAtCreationDropDown.Text == "N/A" || mcAtCreationDropDown.Text == "")
            {
                InCharacter.headers.creationMC = -1;
            }
            else
            {
                InCharacter.headers.creationMC = Convert.ToInt32(mcAtCreationDropDown.Text);
            }

            if (currentMCDropDown.Text == "N/A" || currentMCDropDown.Text == "")
            {
                InCharacter.headers.currentMC = -1;
            }
            else
            {
                InCharacter.headers.currentMC = Convert.ToInt32(currentMCDropDown.Text);
            }

            InCharacter.headers.directST = directSTTextBox.Text;
            InCharacter.headers.directSTEmail = stEmailTextBox.Text;
            InCharacter.headers.directCoord = directCoordTextBox.Text;
            InCharacter.headers.directCoordEmail = coordEmailTextBox.Text;
            InCharacter.headers.domainID = domainIDTextBox.Text;
            InCharacter.headers.regionID = regionTextBox.Text;
            InCharacter.headers.countryID = countryTextBox.Text;
        }

        private void FillPlayerInfo()
        {
            playerNameTextBox.Text = sheet.headers.playerName;
            playerEmailTextBox.Text = sheet.headers.playerEmail;
            membershipNumberTextBox.Text = sheet.headers.membershipID;
            mcAtCreationDropDown.Text = sheet.headers.creationMC.ToString();

            if (mcAtCreationDropDown.Text != "")
            {
                mcAtCreationDropDown.Enabled = false;
            }

            currentMCDropDown.Text = sheet.headers.currentMC.ToString();
            directSTTextBox.Text = sheet.headers.directST;
            stEmailTextBox.Text = sheet.headers.directSTEmail;
            directCoordTextBox.Text = sheet.headers.directCoord;
            coordEmailTextBox.Text = sheet.headers.directCoordEmail;
            domainIDTextBox.Text = sheet.headers.domainID;
            regionTextBox.Text = sheet.headers.regionID;
            countryTextBox.Text = sheet.headers.countryID;
        }

        private void PackCharacterInfo(ref CharSheetData InCharacter)
        {
            InCharacter.headers.isNPC = isNPCCheckBox.Checked;
            InCharacter.headers.creationDate = creationDateTimePicker.Value;
            InCharacter.headers.charName = characterNameTextBox.Text;
            InCharacter.headers.charClan = clanDropBox.Text;
            InCharacter.headers.charSect = sectDropBox.Text;
            InCharacter.headers.charPronouns = genderTextBox.Text;
            InCharacter.headers.charArchetype = archetypeTextBox.Text;
            InCharacter.headers.nativeLanguage = nativeLanguageTextBox.Text;
            List<MoralityPath> pathInfo = StaticGameData.LoadMoralityData();
            foreach (MoralityPath path in pathInfo)
            {
                if(path.moralityInfo.fieldName == moralityDropDown.Text)
                {
                    InCharacter.headers.moralityPathInfo.moralityInfo.fieldID = path.moralityInfo.fieldID;
                    InCharacter.headers.moralityPathInfo.moralityInfo.fieldName = path.moralityInfo.fieldName;
                    InCharacter.headers.moralityPathInfo.baseCost = path.baseCost;
                    InCharacter.headers.moralityPathInfo.sabbatCost = path.sabbatCost;
                    InCharacter.headers.moralityPathInfo.level = Convert.ToInt32(moralityLevelDropDown.Text);
                    break;
                }
            }

            InCharacter.headers.embraceDate = embraceDateTimePicker.Text;
        }

        private void FillCharacterInfo()
        {
            isNPCCheckBox.Checked = sheet.headers.isNPC;
            creationDateTimePicker.Value = sheet.headers.creationDate;
            creationDateTimePicker.Enabled = false;
            characterNameTextBox.Text = sheet.headers.charName;
            clanDropBox.Text = sheet.headers.charClan;
            sectDropBox.Text = sheet.headers.charSect;
            genderTextBox.Text = sheet.headers.charPronouns;
            archetypeTextBox.Text = sheet.headers.charArchetype;
            nativeLanguageTextBox.Text = sheet.headers.nativeLanguage;
            moralityDropDown.Text = sheet.headers.moralityPathInfo.moralityInfo.fieldName;
            moralityLevelDropDown.Text = sheet.headers.moralityPathInfo.level.ToString();
            embraceDateTimePicker.Text = sheet.headers.embraceDate;
        }

        private void FillClanBox(ComboBox control)
        {
            List<Clan> clanList = StaticGameData.LoadClanData();

            foreach (Clan c in clanList)
            {
                if (c.clanInfo.fieldName != "None")
                {
                    control.Items.Add(c.clanInfo.fieldName);
                }
            }
        }

        private void FillPathBox(ComboBox control)
        {
            List<MoralityPath> pathList = StaticGameData.LoadMoralityData();

            foreach (MoralityPath c in pathList)
            {
                if (c.moralityInfo.fieldName != "None")
                {
                    control.Items.Add(c.moralityInfo.fieldName);
                }
            }
        }

        private void playerInfoTab_Enter(object sender, EventArgs e)
        {
            FillPlayerInfo();
        }

        private void mcAtCreationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMCDropDown.Items.Clear();
            if (mcAtCreationDropDown.Text == "N/A")
            {
                currentMCDropDown.Items.Add("N/A");
                currentMCDropDown.Text = "N/A";
            }
            else
            {
                for (int i = Convert.ToInt32(mcAtCreationDropDown.Text); i <= 15; i++)
                {
                    currentMCDropDown.Items.Add(i.ToString());
                }
            }
        }

        private void embraceDateTimePicker_ProcessCmdKey(ref System.Windows.Forms.Message m, System.Windows.Forms.Keys keyData)
        {
            //TODO: Put in Validation for date in text box
        }

        private void characterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = characterNameTextBox.Text;
            sheet.headers.charName = characterNameTextBox.Text;
        }

        private void clanDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text += " - " + clanDropBox.Text;
            sheet.headers.charClan = clanDropBox.Text;
        }
    }
}
