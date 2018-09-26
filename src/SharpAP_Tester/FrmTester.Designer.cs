namespace SharpAP_Tester
{
    partial class FrmTester
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbMain = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // picbMain
            // 
            this.picbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbMain.Location = new System.Drawing.Point(0, 56);
            this.picbMain.Name = "picbMain";
            this.picbMain.Size = new System.Drawing.Size(604, 471);
            this.picbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbMain.TabIndex = 3;
            this.picbMain.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(604, 56);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Capture";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FrmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 527);
            this.Controls.Add(this.picbMain);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmTester";
            this.Text = "Click the capture button to test the dialog";
            ((System.ComponentModel.ISupportInitialize)(this.picbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbMain;
        private System.Windows.Forms.Button btnOpen;
    }
}

