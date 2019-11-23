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
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * .75);
            this.Height =(int)(Screen.PrimaryScreen.Bounds.Height * .75);
            this.IsMdiContainer = true;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
