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
            FillClanBox(clanDropBox);
            FillPathBox(moralityDropDown);

            CenterToParent();
            MdiParent = Parent;

            this.Height = (int)(MdiParent.Height * .75);
            this.Width = (int)(MdiParent.Width * .75);
        }

        public CharSheetData PackCharacterDataForSave()
        {
            CharSheetData charData = new CharSheetData();

            PackPlayerInfo(ref charData);

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

        private void FillClanBox(ComboBox control)
        {
            List<Clan> clanList = StaticGameData.LoadClanData();

            foreach(Clan c in clanList)
            {
                control.Items.Add(c.clanName);
            }
        }

        private void FillPathBox(ComboBox control)
        {
            List<MoralityPath> pathList = StaticGameData.LoadMoralityData();

            foreach (MoralityPath c in pathList)
            {
                control.Items.Add(c.pathName);
            }
        }
    }
}
