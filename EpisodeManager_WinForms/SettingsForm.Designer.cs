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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.smbxversionlabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.execLocTb = new MetroFramework.Controls.MetroTextBox();
            this.worldPathTb = new MetroFramework.Controls.MetroTextBox();
            this.smbxPathTb = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.igVerCheckSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.updateIndexGen = new MetroFramework.Controls.MetroButton();
            this.availIgVerLabel = new MetroFramework.Controls.MetroLabel();
            this.indexGenVerLabel = new MetroFramework.Controls.MetroLabel();
            this.checkIndexGeneratorUpdates = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(156, 141);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(95, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 28;
            this.metroButton3.Text = "Save Settings";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // smbxversionlabel
            // 
            this.smbxversionlabel.AutoSize = true;
            this.smbxversionlabel.CustomBackground = false;
            this.smbxversionlabel.CustomForeColor = true;
            this.smbxversionlabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.smbxversionlabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.smbxversionlabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.smbxversionlabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.smbxversionlabel.Location = new System.Drawing.Point(152, 118);
            this.smbxversionlabel.Name = "smbxversionlabel";
            this.smbxversionlabel.Size = new System.Drawing.Size(95, 19);
            this.smbxversionlabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.smbxversionlabel.StyleManager = null;
            this.smbxversionlabel.TabIndex = 27;
            this.smbxversionlabel.Text = "SMBX Found: ";
            this.smbxversionlabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.smbxversionlabel.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(34, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "smbx.exe Location:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(47, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Worlds Location:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(76, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "SMBX Path: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(585, 34);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(31, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 23;
            this.metroButton2.Text = "...";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // execLocTb
            // 
            this.execLocTb.CustomBackground = false;
            this.execLocTb.CustomForeColor = false;
            this.execLocTb.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.execLocTb.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.execLocTb.Location = new System.Drawing.Point(156, 92);
            this.execLocTb.Multiline = false;
            this.execLocTb.Name = "execLocTb";
            this.execLocTb.SelectedText = "";
            this.execLocTb.Size = new System.Drawing.Size(423, 23);
            this.execLocTb.Style = MetroFramework.MetroColorStyle.Green;
            this.execLocTb.StyleManager = null;
            this.execLocTb.TabIndex = 22;
            this.execLocTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.execLocTb.UseStyleColors = true;
            this.execLocTb.TextChanged += new System.EventHandler(this.execLocTb_TextChanged);
            // 
            // worldPathTb
            // 
            this.worldPathTb.CustomBackground = false;
            this.worldPathTb.CustomForeColor = false;
            this.worldPathTb.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.worldPathTb.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.worldPathTb.Location = new System.Drawing.Point(156, 63);
            this.worldPathTb.Multiline = false;
            this.worldPathTb.Name = "worldPathTb";
            this.worldPathTb.SelectedText = "";
            this.worldPathTb.Size = new System.Drawing.Size(423, 23);
            this.worldPathTb.Style = MetroFramework.MetroColorStyle.Green;
            this.worldPathTb.StyleManager = null;
            this.worldPathTb.TabIndex = 21;
            this.worldPathTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.worldPathTb.UseStyleColors = true;
            // 
            // smbxPathTb
            // 
            this.smbxPathTb.CustomBackground = false;
            this.smbxPathTb.CustomForeColor = false;
            this.smbxPathTb.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.smbxPathTb.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.smbxPathTb.Location = new System.Drawing.Point(156, 34);
            this.smbxPathTb.Multiline = false;
            this.smbxPathTb.Name = "smbxPathTb";
            this.smbxPathTb.SelectedText = "";
            this.smbxPathTb.Size = new System.Drawing.Size(423, 23);
            this.smbxPathTb.Style = MetroFramework.MetroColorStyle.Green;
            this.smbxPathTb.StyleManager = null;
            this.smbxPathTb.TabIndex = 20;
            this.smbxPathTb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.smbxPathTb.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.smbxPathTb);
            this.groupBox1.Controls.Add(this.smbxversionlabel);
            this.groupBox1.Controls.Add(this.worldPathTb);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.execLocTb);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 187);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMBX Related Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.igVerCheckSpinner);
            this.groupBox2.Controls.Add(this.updateIndexGen);
            this.groupBox2.Controls.Add(this.availIgVerLabel);
            this.groupBox2.Controls.Add(this.indexGenVerLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 179);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Index Generator";
            // 
            // igVerCheckSpinner
            // 
            this.igVerCheckSpinner.CustomBackground = false;
            this.igVerCheckSpinner.Location = new System.Drawing.Point(158, 108);
            this.igVerCheckSpinner.Maximum = 100;
            this.igVerCheckSpinner.Name = "igVerCheckSpinner";
            this.igVerCheckSpinner.Size = new System.Drawing.Size(32, 32);
            this.igVerCheckSpinner.Speed = 3F;
            this.igVerCheckSpinner.Style = MetroFramework.MetroColorStyle.Green;
            this.igVerCheckSpinner.StyleManager = null;
            this.igVerCheckSpinner.TabIndex = 3;
            this.igVerCheckSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.igVerCheckSpinner.Visible = false;
            // 
            // updateIndexGen
            // 
            this.updateIndexGen.Enabled = false;
            this.updateIndexGen.Highlight = false;
            this.updateIndexGen.Location = new System.Drawing.Point(33, 100);
            this.updateIndexGen.Name = "updateIndexGen";
            this.updateIndexGen.Size = new System.Drawing.Size(119, 49);
            this.updateIndexGen.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateIndexGen.StyleManager = null;
            this.updateIndexGen.TabIndex = 2;
            this.updateIndexGen.Text = "UPDATE";
            this.updateIndexGen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateIndexGen.Click += new System.EventHandler(this.updateIndexGen_Click);
            // 
            // availIgVerLabel
            // 
            this.availIgVerLabel.AutoSize = true;
            this.availIgVerLabel.CustomBackground = false;
            this.availIgVerLabel.CustomForeColor = false;
            this.availIgVerLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.availIgVerLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.availIgVerLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.availIgVerLabel.Location = new System.Drawing.Point(33, 78);
            this.availIgVerLabel.Name = "availIgVerLabel";
            this.availIgVerLabel.Size = new System.Drawing.Size(0, 0);
            this.availIgVerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.availIgVerLabel.StyleManager = null;
            this.availIgVerLabel.TabIndex = 1;
            this.availIgVerLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availIgVerLabel.UseStyleColors = false;
            // 
            // indexGenVerLabel
            // 
            this.indexGenVerLabel.AutoSize = true;
            this.indexGenVerLabel.CustomBackground = false;
            this.indexGenVerLabel.CustomForeColor = false;
            this.indexGenVerLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.indexGenVerLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.indexGenVerLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.indexGenVerLabel.Location = new System.Drawing.Point(33, 41);
            this.indexGenVerLabel.Name = "indexGenVerLabel";
            this.indexGenVerLabel.Size = new System.Drawing.Size(234, 19);
            this.indexGenVerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.indexGenVerLabel.StyleManager = null;
            this.indexGenVerLabel.TabIndex = 0;
            this.indexGenVerLabel.Text = "Downloaded Index Generator Version: ";
            this.indexGenVerLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.indexGenVerLabel.UseStyleColors = false;
            // 
            // checkIndexGeneratorUpdates
            // 
            this.checkIndexGeneratorUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkIndexGeneratorUpdates_DoWork);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Settings";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        public MetroFramework.Controls.MetroLabel smbxversionlabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroTextBox execLocTb;
        public MetroFramework.Controls.MetroTextBox worldPathTb;
        public MetroFramework.Controls.MetroTextBox smbxPathTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton updateIndexGen;
        private MetroFramework.Controls.MetroLabel availIgVerLabel;
        private MetroFramework.Controls.MetroLabel indexGenVerLabel;
        private System.ComponentModel.BackgroundWorker checkIndexGeneratorUpdates;
        private MetroFramework.Controls.MetroProgressSpinner igVerCheckSpinner;
    }
}