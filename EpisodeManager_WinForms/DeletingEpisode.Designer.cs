namespace EpisodeManager_WinForms
{
    partial class DeletingEpisode
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
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.metroProgressBar.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.metroProgressBar.HideProgressText = true;
            this.metroProgressBar.Location = new System.Drawing.Point(23, 106);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar.Size = new System.Drawing.Size(432, 35);
            this.metroProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressBar.StyleManager = null;
            this.metroProgressBar.TabIndex = 0;
            this.metroProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroProgressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Deleting \'\'...";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // DeletingEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 159);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DeletingEpisode";
            this.Opacity = 0.75D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Deleting...";
            this.Load += new System.EventHandler(this.DeletingEpisode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}