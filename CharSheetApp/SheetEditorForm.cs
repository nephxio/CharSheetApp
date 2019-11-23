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
        public SheetEditorForm()
        {
            InitializeComponent();
            TabControl TabList = new TabControl();
            TabPage MainSheetTab = new TabPage("Sheet");
            CenterToParent();
            MainSheetTab.Dock = DockStyle.Fill;
            TabList.TabPages.Add(MainSheetTab);
            

        }
    }
}
