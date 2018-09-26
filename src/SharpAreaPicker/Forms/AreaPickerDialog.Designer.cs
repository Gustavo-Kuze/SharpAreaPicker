namespace SharpAreaPicker.Forms
{
    partial class AreaPickerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cntxMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntxMenuOptions
            // 
            this.cntxMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxCapture,
            this.cntxCancel});
            this.cntxMenuOptions.Name = "cntxMenuOptions";
            this.cntxMenuOptions.Size = new System.Drawing.Size(181, 70);
            // 
            // cntxCapture
            // 
            this.cntxCapture.Name = "cntxCapture";
            this.cntxCapture.Size = new System.Drawing.Size(180, 22);
            this.cntxCapture.Text = "Capture";
            this.cntxCapture.Click += new System.EventHandler(this.cntxCapture_Click);
            // 
            // cntxCancel
            // 
            this.cntxCancel.Name = "cntxCancel";
            this.cntxCancel.Size = new System.Drawing.Size(180, 22);
            this.cntxCancel.Text = "Cancel";
            this.cntxCancel.Click += new System.EventHandler(this.cntxCancel_Click);
            // 
            // AreaPickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(764, 516);
            this.ContextMenuStrip = this.cntxMenuOptions;
            this.ControlBox = false;
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "AreaPickerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaPickerDialog_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaPickerDialog_MouseDown);
            this.cntxMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cntxMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem cntxCapture;
        private System.Windows.Forms.ToolStripMenuItem cntxCancel;
    }
}