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
            CenterToParent();
        }


        public SheetEditorForm(Form Parent)
        {
            InitializeComponent();
            CenterToParent();
            MdiParent = Parent;
            this.Height = (int)(MdiParent.Height * .75);
            this.Width = (int)(MdiParent.Width * .75);
        }

        private void SheetEditorForm_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}
