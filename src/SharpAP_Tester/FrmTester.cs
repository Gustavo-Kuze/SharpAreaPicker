using SharpAreaPicker;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpAP_Tester
{
    public partial class FrmTester : Form
    {
        public FrmTester()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Image img = AreaPicker.screenshot(this);
            if (img != null)
            {
                picbMain.Image = null;
                picbMain.Image = img;
            }

        }
    }
}
