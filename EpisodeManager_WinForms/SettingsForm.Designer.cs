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
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(186, 208);
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
            this.smbxversionlabel.Location = new System.Drawing.Point(182, 185);
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
            this.metroLabel3.Location = new System.Drawing.Point(64, 163);
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
            this.metroLabel2.Location = new System.Drawing.Point(77, 134);
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
            this.metroLabel1.Location = new System.Drawing.Point(106, 105);
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
            this.metroButton2.Location = new System.Drawing.Point(615, 101);
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
            this.execLocTb.Location = new System.Drawing.Point(186, 159);
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
            this.worldPathTb.Location = new System.Drawing.Point(186, 130);
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
            this.smbxPathTb.Location = new System.Drawing.Point(186, 101);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 287);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.smbxversionlabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.execLocTb);
            this.Controls.Add(this.worldPathTb);
            this.Controls.Add(this.smbxPathTb);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Settings";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}