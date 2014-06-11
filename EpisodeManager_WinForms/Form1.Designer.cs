namespace EpisodeManager_WinForms
{
    partial class Form1
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.epInfoPanel = new System.Windows.Forms.Panel();
            this.ss1 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.authorName = new MetroFramework.Controls.MetroLabel();
            this.episodeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.listViewPanel = new System.Windows.Forms.Panel();
            this.localEpisodesListview = new System.Windows.Forms.ListView();
            this.Episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ss2 = new System.Windows.Forms.PictureBox();
            this.ss3 = new System.Windows.Forms.PictureBox();
            this.ss4 = new System.Windows.Forms.PictureBox();
            this.forumTopicButton = new MetroFramework.Controls.MetroButton();
            this.checkServer = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.epInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            this.listViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(723, 505);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.StyleManager = this.metroStyleManager1;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.panel3);
            this.metroTabPage2.CustomBackground = false;
            this.metroTabPage2.HorizontalScrollbar = false;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(715, 466);
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
            // metroTabPage3
            // 
            this.metroTabPage3.CustomBackground = false;
            this.metroTabPage3.HorizontalScrollbar = false;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(715, 466);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.StyleManager = null;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Settings";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage3.VerticalScrollbar = false;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroTabPage1.Controls.Add(this.epInfoPanel);
            this.metroTabPage1.Controls.Add(this.listViewPanel);
            this.metroTabPage1.CustomBackground = false;
            this.metroTabPage1.HorizontalScrollbar = false;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(715, 466);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Local Episodes";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = false;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // epInfoPanel
            // 
            this.epInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.epInfoPanel.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.episodeInfoControlsbgo;
            this.epInfoPanel.Controls.Add(this.metroButton1);
            this.epInfoPanel.Controls.Add(this.checkServer);
            this.epInfoPanel.Controls.Add(this.forumTopicButton);
            this.epInfoPanel.Controls.Add(this.ss4);
            this.epInfoPanel.Controls.Add(this.ss3);
            this.epInfoPanel.Controls.Add(this.ss2);
            this.epInfoPanel.Controls.Add(this.ss1);
            this.epInfoPanel.Controls.Add(this.descriptionLabel);
            this.epInfoPanel.Controls.Add(this.authorName);
            this.epInfoPanel.Controls.Add(this.episodeNameLabel);
            this.epInfoPanel.Location = new System.Drawing.Point(230, 0);
            this.epInfoPanel.Name = "epInfoPanel";
            this.epInfoPanel.Size = new System.Drawing.Size(562, 466);
            this.epInfoPanel.TabIndex = 3;
            // 
            // ss1
            // 
            this.ss1.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss1.Location = new System.Drawing.Point(6, 304);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(112, 90);
            this.ss1.TabIndex = 3;
            this.ss1.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.CustomBackground = false;
            this.descriptionLabel.CustomForeColor = false;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.descriptionLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.descriptionLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 73);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 19);
            this.descriptionLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionLabel.StyleManager = null;
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "desc";
            this.descriptionLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionLabel.UseStyleColors = false;
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.CustomBackground = false;
            this.authorName.CustomForeColor = false;
            this.authorName.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.authorName.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.authorName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.authorName.Location = new System.Drawing.Point(6, 44);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(30, 19);
            this.authorName.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorName.StyleManager = null;
            this.authorName.TabIndex = 1;
            this.authorName.Text = "by: ";
            this.authorName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorName.UseStyleColors = false;
            // 
            // episodeNameLabel
            // 
            this.episodeNameLabel.AutoSize = true;
            this.episodeNameLabel.CustomBackground = false;
            this.episodeNameLabel.CustomForeColor = false;
            this.episodeNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.episodeNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.episodeNameLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.episodeNameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.episodeNameLabel.Location = new System.Drawing.Point(6, 9);
            this.episodeNameLabel.Name = "episodeNameLabel";
            this.episodeNameLabel.Size = new System.Drawing.Size(117, 25);
            this.episodeNameLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.episodeNameLabel.StyleManager = null;
            this.episodeNameLabel.TabIndex = 0;
            this.episodeNameLabel.Text = "episodeName";
            this.episodeNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.episodeNameLabel.UseStyleColors = false;
            this.episodeNameLabel.UseWaitCursor = true;
            // 
            // listViewPanel
            // 
            this.listViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.listViewPanel.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.listviewbgo;
            this.listViewPanel.Controls.Add(this.localEpisodesListview);
            this.listViewPanel.Location = new System.Drawing.Point(0, 0);
            this.listViewPanel.Name = "listViewPanel";
            this.listViewPanel.Size = new System.Drawing.Size(230, 466);
            this.listViewPanel.TabIndex = 2;
            // 
            // localEpisodesListview
            // 
            this.localEpisodesListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localEpisodesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episode});
            this.localEpisodesListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localEpisodesListview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localEpisodesListview.Location = new System.Drawing.Point(0, 0);
            this.localEpisodesListview.Name = "localEpisodesListview";
            this.localEpisodesListview.Size = new System.Drawing.Size(230, 466);
            this.localEpisodesListview.TabIndex = 0;
            this.localEpisodesListview.UseCompatibleStateImageBehavior = false;
            this.localEpisodesListview.View = System.Windows.Forms.View.Details;
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            this.Episode.Width = 224;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.episodeInfoControlsbgo;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 466);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.listviewbgo;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 466);
            this.panel3.TabIndex = 4;
            // 
            // ss2
            // 
            this.ss2.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss2.Location = new System.Drawing.Point(124, 304);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(112, 90);
            this.ss2.TabIndex = 4;
            this.ss2.TabStop = false;
            // 
            // ss3
            // 
            this.ss3.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss3.Location = new System.Drawing.Point(242, 304);
            this.ss3.Name = "ss3";
            this.ss3.Size = new System.Drawing.Size(112, 90);
            this.ss3.TabIndex = 5;
            this.ss3.TabStop = false;
            // 
            // ss4
            // 
            this.ss4.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss4.Location = new System.Drawing.Point(360, 304);
            this.ss4.Name = "ss4";
            this.ss4.Size = new System.Drawing.Size(112, 90);
            this.ss4.TabIndex = 6;
            this.ss4.TabStop = false;
            // 
            // forumTopicButton
            // 
            this.forumTopicButton.Highlight = false;
            this.forumTopicButton.Location = new System.Drawing.Point(6, 400);
            this.forumTopicButton.Name = "forumTopicButton";
            this.forumTopicButton.Size = new System.Drawing.Size(112, 23);
            this.forumTopicButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.forumTopicButton.StyleManager = null;
            this.forumTopicButton.TabIndex = 7;
            this.forumTopicButton.Text = "VISIT FORUM TOPIC";
            this.forumTopicButton.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // checkServer
            // 
            this.checkServer.Highlight = false;
            this.checkServer.Location = new System.Drawing.Point(6, 429);
            this.checkServer.Name = "checkServer";
            this.checkServer.Size = new System.Drawing.Size(112, 23);
            this.checkServer.Style = MetroFramework.MetroColorStyle.Purple;
            this.checkServer.StyleManager = null;
            this.checkServer.TabIndex = 8;
            this.checkServer.Text = "CHECK SERVER";
            this.checkServer.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(124, 400);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 585);
            this.Controls.Add(this.metroTabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.StyleManager = this.metroStyleManager1;
            this.Text = "smbx episode manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.epInfoPanel.ResumeLayout(false);
            this.epInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            this.listViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Panel listViewPanel;
        private System.Windows.Forms.Panel epInfoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView localEpisodesListview;
        private System.Windows.Forms.ColumnHeader Episode;
        private MetroFramework.Controls.MetroLabel episodeNameLabel;
        private System.Windows.Forms.PictureBox ss1;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroLabel authorName;
        private MetroFramework.Controls.MetroButton checkServer;
        private MetroFramework.Controls.MetroButton forumTopicButton;
        private System.Windows.Forms.PictureBox ss4;
        private System.Windows.Forms.PictureBox ss3;
        private System.Windows.Forms.PictureBox ss2;
        private MetroFramework.Controls.MetroButton metroButton1;

    }
}

