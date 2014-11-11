namespace EpisodeManager_WinForms
{
    partial class LoadingIndex
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
            this.metroProgressBar.Location = new System.Drawing.Point(23, 106);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar.Size = new System.Drawing.Size(432, 35);
            this.metroProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressBar.TabIndex = 0;
            this.metroProgressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Deleting \'\'...";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // LoadingIndex
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(479, 159);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingIndex";
            this.Resizable = false;
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