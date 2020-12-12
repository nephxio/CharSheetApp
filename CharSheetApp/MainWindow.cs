using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CharSheetApp
{
    public partial class MainWindow : Form
    {
        private List<SheetEditorForm> sheets;
        private List<CharSheetData> chars;
        private List<ApplicationForm> appForms;

        public MainWindow()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width > 1020 ? (int)(Screen.PrimaryScreen.Bounds.Width * .75) : (int)(Screen.PrimaryScreen.Bounds.Width);
            this.Height = Screen.PrimaryScreen.Bounds.Height > 768 ? (int)(Screen.PrimaryScreen.Bounds.Height * .75) : (int)(Screen.PrimaryScreen.Bounds.Height);
            this.Text = "BNS System Character Sheet Builder";
            this.IsMdiContainer = true;
            this.CenterToScreen();

            sheets = new List<SheetEditorForm>();
            chars = new List<CharSheetData>();
            appForms = new List<ApplicationForm>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sheets.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ".sheet files (*.sheet)|*.sheet";
                sfd.DefaultExt = "sheet";
                sfd.InitialDirectory = Path.Combine(Application.StartupPath, @"..\Sheets\");
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    SheetEditorForm sef = new SheetEditorForm();
                    sef = (SheetEditorForm)ActiveMdiChild;
                    StaticGameData.SerializeCharacterSheet(sfd.FileName, sef.PackCharacterDataForSave());
                }
            }
            else
            {
                return;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".sheet files (*.sheet)|*.sheet";
            ofd.DefaultExt = "sheet";
            ofd.InitialDirectory = Path.Combine(Application.StartupPath, @"..\Sheets\");
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                sheets.Add(new SheetEditorForm(this));
                sheets[sheets.Count - 1].sheet = StaticGameData.DeserializeCharacterSheet(ofd.FileName);
                sheets[sheets.Count - 1].Show();
            }
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sheets.Add(new SheetEditorForm(this));
            sheets[sheets.Count - 1].Show();
        }

        private void newToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach(Form child in this.MdiChildren)
                {
                    SheetEditorForm sheetData = child as SheetEditorForm;
                    if (sheetData != null)
                    {
                        ToolStripMenuItem characterSheetItem = new ToolStripMenuItem(sheetData.Text, null, CreateNewApplication);
                        applicationForToolStripMenuItem.DropDownItems.Add(characterSheetItem);
                        chars.Add(sheetData.sheet);
                    }
                }
            }
        }

        private void CreateNewApplication(object sender, System.EventArgs e)
        {
            appForms.Add(new ApplicationForm(this, chars[0]));            
            appForms[appForms.Count - 1].Show();
        }

        private void newToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            applicationForToolStripMenuItem.DropDownItems.Clear();
        }
        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> tableData = new List<string>();

            tableData = StaticGameData.FixTable("static_data_foci");

            tableData.Remove("None");
            tableData.Insert(0, "None");

            StaticGameData.WriteFixToTable("static_data_foci", "focus_id", "focus_name", tableData, tableData.Count);
        }

        private void disciplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> tableData = StaticGameData.FixTableInt("static_data_disciplines", 9);
            for(int x = 0; x < tableData.Count; x++)
            {
                if(tableData[x] == 10)
                {
                    tableData[x] = 1;
                }
                else
                {
                    tableData[x]++;
                }
            }

            StaticGameData.WriteFixToTableInt("static_data_disciplines", "discipline_id", "level_five_focus_id", tableData, tableData.Count);
        }
    }
}
