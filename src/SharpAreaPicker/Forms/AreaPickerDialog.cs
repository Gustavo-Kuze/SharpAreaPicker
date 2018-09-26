using System;
using System.Windows.Forms;
using SharpAreaPicker.Utils;

namespace SharpAreaPicker.Forms
{
    public partial class AreaPickerDialog : Form
    {
        public AreaPickerDialog()
        {
            InitializeComponent();
        }
        
        private void AreaPickerDialog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, Win32.WM_NCLBUTTONDOWN, Win32.HT_CAPTION, 0);
            }
        }
        
        private void AreaPickerDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okSelected();
            }
            if (e.KeyCode == Keys.Escape)
            {
                cancelSelected();
            }
        }

        void okSelected()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
        void cancelSelected()
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cntxCapture_Click(object sender, EventArgs e)
        {
            okSelected();
        }

        private void cntxCancel_Click(object sender, EventArgs e)
        {
            cancelSelected();
        }
    }
}
