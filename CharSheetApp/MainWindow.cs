using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharSheetApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width > 1020 ? (int)(Screen.PrimaryScreen.Bounds.Width * .75) : 1020;
            this.Height =Screen.PrimaryScreen.Bounds.Height > 768 ? (int)(Screen.PrimaryScreen.Bounds.Height * .75) : 768;
            this.Text = "BNS System Character Sheet Builder";
            this.IsMdiContainer = true;
            this.CenterToScreen();

            SheetEditorForm Sheet = new SheetEditorForm();
            Sheet.MdiParent = this;
            Sheet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
