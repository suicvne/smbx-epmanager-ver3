namespace EpisodeManager_WinForms
{
    partial class Main_NEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_NEW));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.episodesMoreButton = new System.Windows.Forms.Button();
            this.localEpisodes = new EpisodeManager_WinForms.LocalEpisodesControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.AvailableEpisodes = new EpisodeManager_WinForms.AvailableEpisodesControl();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.episodeContext = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.deleteSave1Menu = new System.Windows.Forms.MenuItem();
            this.deleteSave2Menu = new System.Windows.Forms.MenuItem();
            this.deleteSave3Menu = new System.Windows.Forms.MenuItem();
            this.launchSMBXMenu = new System.Windows.Forms.MenuItem();
            this.updatedLabel = new MetroFramework.Controls.MetroLabel();
            this.availEpisodesOverflow = new System.Windows.Forms.Button();
            this.availContext = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(731, 506);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.episodeInfoControlsbgo;
            this.metroTabPage1.Controls.Add(this.episodesMoreButton);
            this.metroTabPage1.Controls.Add(this.localEpisodes);
            this.metroTabPage1.CustomBackground = false;
            this.metroTabPage1.HorizontalScrollbar = false;
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(723, 467);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Local Episodes";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = false;
            this.metroTabPage1.VerticalScrollbarBarColor = false;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // episodesMoreButton
            // 
            this.episodesMoreButton.AutoSize = true;
            this.episodesMoreButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.episodesMoreButton.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.more_32;
            this.episodesMoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.episodesMoreButton.FlatAppearance.BorderSize = 0;
            this.episodesMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.episodesMoreButton.ForeColor = System.Drawing.Color.White;
            this.episodesMoreButton.Location = new System.Drawing.Point(672, 3);
            this.episodesMoreButton.Name = "episodesMoreButton";
            this.episodesMoreButton.Size = new System.Drawing.Size(41, 37);
            this.episodesMoreButton.TabIndex = 5;
            this.episodesMoreButton.UseVisualStyleBackColor = false;
            this.episodesMoreButton.Click += new System.EventHandler(this.episodesMoreButton_Click_1);
            // 
            // localEpisodes
            // 
            this.localEpisodes.Location = new System.Drawing.Point(0, 0);
            this.localEpisodes.Name = "localEpisodes";
            this.localEpisodes.Size = new System.Drawing.Size(718, 466);
            this.localEpisodes.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.availEpisodesOverflow);
            this.metroTabPage2.Controls.Add(this.AvailableEpisodes);
            this.metroTabPage2.CustomBackground = false;
            this.metroTabPage2.HorizontalScrollbar = false;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(723, 467);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.StyleManager = null;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Available Episodes";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = false;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // AvailableEpisodes
            // 
            this.AvailableEpisodes.BackColor = System.Drawing.SystemColors.Control;
            this.AvailableEpisodes.Location = new System.Drawing.Point(0, 0);
            this.AvailableEpisodes.Name = "AvailableEpisodes";
            this.AvailableEpisodes.parentForm = null;
            this.AvailableEpisodes.Size = new System.Drawing.Size(720, 472);
            this.AvailableEpisodes.TabIndex = 2;
            this.AvailableEpisodes.Load += new System.EventHandler(this.AvailableEpisodes_Load);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = true;
            this.aboutButton.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.info_32;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.Transparent;
            this.aboutButton.Location = new System.Drawing.Point(659, 46);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(41, 43);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.settings_filled_32;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.settingsButton.Location = new System.Drawing.Point(700, 46);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(41, 43);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.Icon_Gray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(274, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // episodeContext
            // 
            this.episodeContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem2,
            this.launchSMBXMenu});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Delete Episode";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItem3.Text = "Refresh Directory";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.deleteSave1Menu,
            this.deleteSave2Menu,
            this.deleteSave3Menu});
            this.menuItem2.Text = "Delete Saves";
            // 
            // deleteSave1Menu
            // 
            this.deleteSave1Menu.Enabled = false;
            this.deleteSave1Menu.Index = 0;
            this.deleteSave1Menu.Text = "Delete Save 1";
            this.deleteSave1Menu.Click += new System.EventHandler(this.deleteSave1Menu_Click);
            // 
            // deleteSave2Menu
            // 
            this.deleteSave2Menu.Enabled = false;
            this.deleteSave2Menu.Index = 1;
            this.deleteSave2Menu.Text = "Delete Save 2";
            this.deleteSave2Menu.Click += new System.EventHandler(this.deleteSave2Menu_Click);
            // 
            // deleteSave3Menu
            // 
            this.deleteSave3Menu.Enabled = false;
            this.deleteSave3Menu.Index = 2;
            this.deleteSave3Menu.Text = "Delete Save 3";
            this.deleteSave3Menu.Click += new System.EventHandler(this.deleteSave3Menu_Click);
            // 
            // launchSMBXMenu
            // 
            this.launchSMBXMenu.Enabled = false;
            this.launchSMBXMenu.Index = 3;
            this.launchSMBXMenu.Text = "Launch SMBX";
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.CustomBackground = false;
            this.updatedLabel.CustomForeColor = false;
            this.updatedLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.updatedLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.updatedLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.updatedLabel.Location = new System.Drawing.Point(313, 27);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(80, 19);
            this.updatedLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.updatedLabel.StyleManager = null;
            this.updatedLabel.TabIndex = 5;
            this.updatedLabel.Text = "Up to Date: ";
            this.updatedLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updatedLabel.UseStyleColors = false;
            // 
            // availEpisodesOverflow
            // 
            this.availEpisodesOverflow.AutoSize = true;
            this.availEpisodesOverflow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.availEpisodesOverflow.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.more_32;
            this.availEpisodesOverflow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.availEpisodesOverflow.FlatAppearance.BorderSize = 0;
            this.availEpisodesOverflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availEpisodesOverflow.ForeColor = System.Drawing.Color.White;
            this.availEpisodesOverflow.Location = new System.Drawing.Point(672, 3);
            this.availEpisodesOverflow.Name = "availEpisodesOverflow";
            this.availEpisodesOverflow.Size = new System.Drawing.Size(41, 37);
            this.availEpisodesOverflow.TabIndex = 6;
            this.availEpisodesOverflow.UseVisualStyleBackColor = false;
            this.availEpisodesOverflow.Click += new System.EventHandler(this.availEpisodesOverflow_Click);
            // 
            // availContext
            // 
            this.availContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Refresh Index";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Download Index + Image Files Only";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // Main_NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 586);
            this.Controls.Add(this.updatedLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Main_NEW";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "SMBX Episode Manager";
            this.Load += new System.EventHandler(this.Main_NEW_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingsButton;
        public LocalEpisodesControl localEpisodes;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button episodesMoreButton;
        private System.Windows.Forms.ContextMenu episodeContext;
        private System.Windows.Forms.MenuItem menuItem1;
        public AvailableEpisodesControl AvailableEpisodes;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem deleteSave1Menu;
        private System.Windows.Forms.MenuItem deleteSave2Menu;
        private System.Windows.Forms.MenuItem deleteSave3Menu;
        private System.Windows.Forms.MenuItem launchSMBXMenu;
        private MetroFramework.Controls.MetroLabel updatedLabel;
        private System.Windows.Forms.Button availEpisodesOverflow;
        private System.Windows.Forms.ContextMenu availContext;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        
        
        
       
        
    }
}