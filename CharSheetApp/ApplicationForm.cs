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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        public ApplicationForm(Form Parent, CharSheetData data)
        {
            InitializeComponent();

            CenterToParent();
            MdiParent = Parent;

            PrepopulateFields(data);

            this.Height = (int)(MdiParent.Height * .75);
            this.Width = (int)(MdiParent.Width * .75);
        }

        private void PrepopulateFields(CharSheetData data)
        {
            this.Text = "Application For: " + data.headers.charName;
            this.charNameData.Text = data.headers.charName;

            applicationStringDisplayLabel.Text = GenerateAppString(4,"USA","SE","VS");            
        }

        private void FillApprovalItemsDropDown(List<ApprovalItems> appItems)
        {

        }

        private string GenerateAppString(int appID, string countryCode, string regionCode, string venueCode)
        {
            return countryCode + "-" + regionCode + "-" + venueCode + "-" + GenerateAppID(appID);
        }

        private string GenerateAppID(int appID)
        {
            string tempID = (new Random().Next(100000,999999)).ToString().Trim('0');
            tempID = tempID.Substring(new Random().Next(0, tempID.Length - 6), 6);

            return tempID;
        }
    }
}
