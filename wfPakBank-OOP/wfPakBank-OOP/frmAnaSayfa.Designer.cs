namespace wfPakBank_OOP
{
    partial class frmAnaSayfa
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
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIYeniHesapAc = new System.Windows.Forms.ToolStripMenuItem();
            this.mIHesapDokumu = new System.Windows.Forms.ToolStripMenuItem();
            this.mICikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(667, 24);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIYeniHesapAc,
            this.mIHesapDokumu,
            this.mICikis});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem.Text = "&Hesap İşlemleri";
            // 
            // mIYeniHesapAc
            // 
            this.mIYeniHesapAc.Name = "mIYeniHesapAc";
            this.mIYeniHesapAc.Size = new System.Drawing.Size(190, 22);
            this.mIYeniHesapAc.Text = "&Yeni Hesap Aç";
            this.mIYeniHesapAc.Click += new System.EventHandler(this.mIYeniHesapAc_Click);
            // 
            // mIHesapDokumu
            // 
            this.mIHesapDokumu.Name = "mIHesapDokumu";
            this.mIHesapDokumu.Size = new System.Drawing.Size(190, 22);
            this.mIHesapDokumu.Text = "Hesap &Dökümü İncele";
            this.mIHesapDokumu.Click += new System.EventHandler(this.mIHesapDokumu_Click);
            // 
            // mICikis
            // 
            this.mICikis.Name = "mICikis";
            this.mICikis.Size = new System.Drawing.Size(190, 22);
            this.mICikis.Text = "&Çıkış";
            this.mICikis.Click += new System.EventHandler(this.mICikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 393);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "PakBank AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIYeniHesapAc;
        private System.Windows.Forms.ToolStripMenuItem mIHesapDokumu;
        private System.Windows.Forms.ToolStripMenuItem mICikis;
    }
}