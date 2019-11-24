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
            InCharacter.headers.PlayerName = playerNameTextBox.Text;
            InCharacter.headers.PlayerEmail = playerEmailTextBox.Text;
            InCharacter.headers.MembershipID = membershipNumberTextBox.Text;

            if (mcAtCreationDropDown.Text == "N/A" || mcAtCreationDropDown.Text == "")
            {
                InCharacter.headers.CreationMC = -1;
            }
            else
            {
                InCharacter.headers.CreationMC = Convert.ToInt32(mcAtCreationDropDown.Text);
            }

            if (currentMCDropDown.Text == "N/A" || currentMCDropDown.Text == "")
            {
                InCharacter.headers.CurrentMC = -1;
            }
            else
            {
                InCharacter.headers.CurrentMC = Convert.ToInt32(currentMCDropDown.Text);
            }

            InCharacter.headers.DirectST = directSTTextBox.Text;
            InCharacter.headers.DirectSTEmail = stEmailTextBox.Text;
            InCharacter.headers.DirectCoord = directCoordTextBox.Text;
            InCharacter.headers.DirectCoordEmail = coordEmailTextBox.Text;
            InCharacter.headers.DomainID = domainIDTextBox.Text;
            InCharacter.headers.RegionID = regionTextBox.Text;
            InCharacter.headers.CountryID = countryTextBox.Text;
        }

        private void FillPlayerInfo()
        {
            playerNameTextBox.Text = sheet.headers.PlayerName;
            playerEmailTextBox.Text = sheet.headers.PlayerEmail;
            membershipNumberTextBox.Text = sheet.headers.MembershipID;
            mcAtCreationDropDown.Text = sheet.headers.CreationMC.ToString();

            if (mcAtCreationDropDown.Text != "")
            {
                mcAtCreationDropDown.Enabled = false;
            }

            currentMCDropDown.Text = sheet.headers.CurrentMC.ToString();
            directSTTextBox.Text = sheet.headers.DirectST;
            stEmailTextBox.Text = sheet.headers.DirectSTEmail;
            directCoordTextBox.Text = sheet.headers.DirectCoord;
            coordEmailTextBox.Text = sheet.headers.DirectCoordEmail;
            domainIDTextBox.Text = sheet.headers.DomainID;
            regionTextBox.Text = sheet.headers.RegionID;
            countryTextBox.Text = sheet.headers.CountryID;
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
    }
}
