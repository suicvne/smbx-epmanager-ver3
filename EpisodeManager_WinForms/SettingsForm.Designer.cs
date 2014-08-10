namespace EpisodeManager_WinForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkIndexGeneratorUpdates = new System.ComponentModel.BackgroundWorker();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.smbxSettingsGb = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.smbxPathTb = new MetroFramework.Controls.MetroTextBox();
            this.smbxversionlabel = new MetroFramework.Controls.MetroLabel();
            this.worldPathTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.execLocTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.indexGeneratorGb = new System.Windows.Forms.GroupBox();
            this.igVerCheckSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.updateIndexGen = new MetroFramework.Controls.MetroButton();
            this.availIgVerLabel = new MetroFramework.Controls.MetroLabel();
            this.indexGenVerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.cacheManagerGb = new System.Windows.Forms.GroupBox();
            this.cacheTreeView = new System.Windows.Forms.TreeView();
            this.showCacheButton = new MetroFramework.Controls.MetroButton();
            this.clearCacheButton = new MetroFramework.Controls.MetroButton();
            this.aboutCacheLabel = new MetroFramework.Controls.MetroLabel();
            this.totalCacheLabel = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.smbxSettingsGb.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.indexGeneratorGb.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.cacheManagerGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkIndexGeneratorUpdates
            // 
            this.checkIndexGeneratorUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkIndexGeneratorUpdates_DoWork);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(688, 270);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.smbxSettingsGb);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(680, 231);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // smbxSettingsGb
            // 
            this.smbxSettingsGb.Controls.Add(this.metroLabel1);
            this.smbxSettingsGb.Controls.Add(this.smbxPathTb);
            this.smbxSettingsGb.Controls.Add(this.smbxversionlabel);
            this.smbxSettingsGb.Controls.Add(this.worldPathTb);
            this.smbxSettingsGb.Controls.Add(this.metroLabel3);
            this.smbxSettingsGb.Controls.Add(this.execLocTb);
            this.smbxSettingsGb.Controls.Add(this.metroLabel2);
            this.smbxSettingsGb.Controls.Add(this.metroButton2);
            this.smbxSettingsGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smbxSettingsGb.Location = new System.Drawing.Point(3, 3);
            this.smbxSettingsGb.Name = "smbxSettingsGb";
            this.smbxSettingsGb.Size = new System.Drawing.Size(677, 225);
            this.smbxSettingsGb.TabIndex = 31;
            this.smbxSettingsGb.TabStop = false;
            this.smbxSettingsGb.Text = "SMBX Related Settings";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(79, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "SMBX Path: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // smbxPathTb
            // 
            this.smbxPathTb.Location = new System.Drawing.Point(167, 62);
            this.smbxPathTb.Name = "smbxPathTb";
            this.smbxPathTb.Size = new System.Drawing.Size(423, 23);
            this.smbxPathTb.Style = MetroFramework.MetroColorStyle.Purple;
            this.smbxPathTb.TabIndex = 20;
            this.smbxPathTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.smbxPathTb.UseStyleColors = true;
            // 
            // smbxversionlabel
            // 
            this.smbxversionlabel.AutoSize = true;
            this.smbxversionlabel.CustomForeColor = true;
            this.smbxversionlabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.smbxversionlabel.Location = new System.Drawing.Point(167, 149);
            this.smbxversionlabel.Name = "smbxversionlabel";
            this.smbxversionlabel.Size = new System.Drawing.Size(14, 19);
            this.smbxversionlabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.smbxversionlabel.TabIndex = 27;
            this.smbxversionlabel.Text = "s";
            this.smbxversionlabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // worldPathTb
            // 
            this.worldPathTb.Location = new System.Drawing.Point(167, 91);
            this.worldPathTb.Name = "worldPathTb";
            this.worldPathTb.Size = new System.Drawing.Size(423, 23);
            this.worldPathTb.Style = MetroFramework.MetroColorStyle.Purple;
            this.worldPathTb.TabIndex = 21;
            this.worldPathTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.worldPathTb.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "smbx.exe Location:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // execLocTb
            // 
            this.execLocTb.Location = new System.Drawing.Point(167, 120);
            this.execLocTb.Name = "execLocTb";
            this.execLocTb.Size = new System.Drawing.Size(423, 23);
            this.execLocTb.Style = MetroFramework.MetroColorStyle.Purple;
            this.execLocTb.TabIndex = 22;
            this.execLocTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.execLocTb.UseStyleColors = true;
            this.execLocTb.TextChanged += new System.EventHandler(this.execLocTb_TextChanged);
            this.execLocTb.Click += new System.EventHandler(this.execLocTb_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Worlds Location:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(596, 62);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(31, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton2.TabIndex = 23;
            this.metroButton2.Text = "...";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.indexGeneratorGb);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(680, 231);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Index Generator";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // indexGeneratorGb
            // 
            this.indexGeneratorGb.Controls.Add(this.igVerCheckSpinner);
            this.indexGeneratorGb.Controls.Add(this.updateIndexGen);
            this.indexGeneratorGb.Controls.Add(this.availIgVerLabel);
            this.indexGeneratorGb.Controls.Add(this.indexGenVerLabel);
            this.indexGeneratorGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexGeneratorGb.Location = new System.Drawing.Point(3, 3);
            this.indexGeneratorGb.Name = "indexGeneratorGb";
            this.indexGeneratorGb.Size = new System.Drawing.Size(678, 225);
            this.indexGeneratorGb.TabIndex = 33;
            this.indexGeneratorGb.TabStop = false;
            this.indexGeneratorGb.Text = "Index Generator";
            this.indexGeneratorGb.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // igVerCheckSpinner
            // 
            this.igVerCheckSpinner.Location = new System.Drawing.Point(158, 108);
            this.igVerCheckSpinner.Maximum = 100;
            this.igVerCheckSpinner.Name = "igVerCheckSpinner";
            this.igVerCheckSpinner.Size = new System.Drawing.Size(32, 32);
            this.igVerCheckSpinner.Speed = 3F;
            this.igVerCheckSpinner.Style = MetroFramework.MetroColorStyle.Green;
            this.igVerCheckSpinner.TabIndex = 3;
            this.igVerCheckSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.igVerCheckSpinner.Visible = false;
            // 
            // updateIndexGen
            // 
            this.updateIndexGen.Enabled = false;
            this.updateIndexGen.Location = new System.Drawing.Point(33, 100);
            this.updateIndexGen.Name = "updateIndexGen";
            this.updateIndexGen.Size = new System.Drawing.Size(119, 49);
            this.updateIndexGen.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateIndexGen.TabIndex = 2;
            this.updateIndexGen.Text = "UPDATE";
            this.updateIndexGen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateIndexGen.Click += new System.EventHandler(this.updateIndexGen_Click);
            // 
            // availIgVerLabel
            // 
            this.availIgVerLabel.AutoSize = true;
            this.availIgVerLabel.Location = new System.Drawing.Point(33, 78);
            this.availIgVerLabel.Name = "availIgVerLabel";
            this.availIgVerLabel.Size = new System.Drawing.Size(0, 0);
            this.availIgVerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.availIgVerLabel.TabIndex = 1;
            this.availIgVerLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // indexGenVerLabel
            // 
            this.indexGenVerLabel.AutoSize = true;
            this.indexGenVerLabel.Location = new System.Drawing.Point(33, 41);
            this.indexGenVerLabel.Name = "indexGenVerLabel";
            this.indexGenVerLabel.Size = new System.Drawing.Size(234, 19);
            this.indexGenVerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.indexGenVerLabel.TabIndex = 0;
            this.indexGenVerLabel.Text = "Downloaded Index Generator Version: ";
            this.indexGenVerLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.cacheManagerGb);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(680, 231);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Cache";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // cacheManagerGb
            // 
            this.cacheManagerGb.Controls.Add(this.cacheTreeView);
            this.cacheManagerGb.Controls.Add(this.showCacheButton);
            this.cacheManagerGb.Controls.Add(this.clearCacheButton);
            this.cacheManagerGb.Controls.Add(this.aboutCacheLabel);
            this.cacheManagerGb.Controls.Add(this.totalCacheLabel);
            this.cacheManagerGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheManagerGb.Location = new System.Drawing.Point(3, 3);
            this.cacheManagerGb.Name = "cacheManagerGb";
            this.cacheManagerGb.Size = new System.Drawing.Size(676, 225);
            this.cacheManagerGb.TabIndex = 2;
            this.cacheManagerGb.TabStop = false;
            this.cacheManagerGb.Text = "Cache Manager";
            // 
            // cacheTreeView
            // 
            this.cacheTreeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheTreeView.HotTracking = true;
            this.cacheTreeView.Location = new System.Drawing.Point(426, 16);
            this.cacheTreeView.Name = "cacheTreeView";
            this.cacheTreeView.Size = new System.Drawing.Size(244, 203);
            this.cacheTreeView.TabIndex = 4;
            // 
            // showCacheButton
            // 
            this.showCacheButton.Location = new System.Drawing.Point(325, 41);
            this.showCacheButton.Name = "showCacheButton";
            this.showCacheButton.Size = new System.Drawing.Size(95, 23);
            this.showCacheButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.showCacheButton.TabIndex = 3;
            this.showCacheButton.Text = "SHOW CACHE";
            this.showCacheButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showCacheButton.Click += new System.EventHandler(this.showCacheButton_Click);
            // 
            // clearCacheButton
            // 
            this.clearCacheButton.Location = new System.Drawing.Point(227, 41);
            this.clearCacheButton.Name = "clearCacheButton";
            this.clearCacheButton.Size = new System.Drawing.Size(92, 23);
            this.clearCacheButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clearCacheButton.TabIndex = 2;
            this.clearCacheButton.Text = "CLEAR CACHE";
            this.clearCacheButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clearCacheButton.Click += new System.EventHandler(this.clearCacheButton_Click);
            // 
            // aboutCacheLabel
            // 
            this.aboutCacheLabel.AutoSize = true;
            this.aboutCacheLabel.Location = new System.Drawing.Point(6, 80);
            this.aboutCacheLabel.Name = "aboutCacheLabel";
            this.aboutCacheLabel.Size = new System.Drawing.Size(414, 133);
            this.aboutCacheLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.aboutCacheLabel.TabIndex = 1;
            this.aboutCacheLabel.Text = resources.GetString("aboutCacheLabel.Text");
            this.aboutCacheLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // totalCacheLabel
            // 
            this.totalCacheLabel.AutoSize = true;
            this.totalCacheLabel.Location = new System.Drawing.Point(6, 43);
            this.totalCacheLabel.Name = "totalCacheLabel";
            this.totalCacheLabel.Size = new System.Drawing.Size(125, 19);
            this.totalCacheLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalCacheLabel.TabIndex = 0;
            this.totalCacheLabel.Text = "Total Cache Size: {0}";
            this.totalCacheLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(608, 62);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(95, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 28;
            this.metroButton3.Text = "SAVE SETTINGS";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 350);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.smbxSettingsGb.ResumeLayout(false);
            this.smbxSettingsGb.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.indexGeneratorGb.ResumeLayout(false);
            this.indexGeneratorGb.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.cacheManagerGb.ResumeLayout(false);
            this.cacheManagerGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker checkIndexGeneratorUpdates;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox smbxSettingsGb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        public MetroFramework.Controls.MetroTextBox smbxPathTb;
        public MetroFramework.Controls.MetroLabel smbxversionlabel;
        public MetroFramework.Controls.MetroTextBox worldPathTb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox execLocTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox indexGeneratorGb;
        private MetroFramework.Controls.MetroProgressSpinner igVerCheckSpinner;
        private MetroFramework.Controls.MetroButton updateIndexGen;
        private MetroFramework.Controls.MetroLabel availIgVerLabel;
        private MetroFramework.Controls.MetroLabel indexGenVerLabel;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.GroupBox cacheManagerGb;
        private MetroFramework.Controls.MetroButton showCacheButton;
        private MetroFramework.Controls.MetroButton clearCacheButton;
        private MetroFramework.Controls.MetroLabel aboutCacheLabel;
        private MetroFramework.Controls.MetroLabel totalCacheLabel;
        private System.Windows.Forms.TreeView cacheTreeView;
    }
}