namespace EpisodeManager_WinForms
{
    partial class AvailableEpisodesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableEpisodesControl));
            this.availEpisodesListview = new System.Windows.Forms.ListView();
            this.Episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadingInfoBgWorker = new System.ComponentModel.BackgroundWorker();
            this.authorName = new MetroFramework.Controls.MetroLabel();
            this.episodeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.descLabel = new System.Windows.Forms.TextBox();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconFrame = new System.Windows.Forms.PictureBox();
            this.ss4 = new System.Windows.Forms.PictureBox();
            this.ss3 = new System.Windows.Forms.PictureBox();
            this.ss2 = new System.Windows.Forms.PictureBox();
            this.ss1 = new System.Windows.Forms.PictureBox();
            this.loadingProg = new MetroFramework.Controls.MetroProgressBar();
            this.installEpisodeButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            this.SuspendLayout();
            // 
            // availEpisodesListview
            // 
            this.availEpisodesListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availEpisodesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episode,
            this.columnHeader1,
            this.columnHeader2});
            this.availEpisodesListview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availEpisodesListview.FullRowSelect = true;
            this.availEpisodesListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.availEpisodesListview.Location = new System.Drawing.Point(0, 0);
            this.availEpisodesListview.MultiSelect = false;
            this.availEpisodesListview.Name = "availEpisodesListview";
            this.availEpisodesListview.Size = new System.Drawing.Size(222, 472);
            this.availEpisodesListview.TabIndex = 5;
            this.availEpisodesListview.UseCompatibleStateImageBehavior = false;
            this.availEpisodesListview.View = System.Windows.Forms.View.Details;
            this.availEpisodesListview.SelectedIndexChanged += new System.EventHandler(this.availEpisodesListview_SelectedIndexChanged);
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            this.Episode.Width = 219;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Download URL";
            this.columnHeader2.Width = 0;
            // 
            // authorName
            // 
            this.authorName.CustomBackground = false;
            this.authorName.CustomForeColor = false;
            this.authorName.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.authorName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.authorName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.authorName.Location = new System.Drawing.Point(235, 50);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(466, 20);
            this.authorName.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorName.StyleManager = null;
            this.authorName.TabIndex = 20;
            this.authorName.Text = "by: ";
            this.authorName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorName.UseStyleColors = false;
            // 
            // episodeNameLabel
            // 
            this.episodeNameLabel.CustomBackground = false;
            this.episodeNameLabel.CustomForeColor = false;
            this.episodeNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.episodeNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.episodeNameLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.episodeNameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.episodeNameLabel.Location = new System.Drawing.Point(235, 16);
            this.episodeNameLabel.Name = "episodeNameLabel";
            this.episodeNameLabel.Size = new System.Drawing.Size(469, 25);
            this.episodeNameLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.episodeNameLabel.StyleManager = null;
            this.episodeNameLabel.TabIndex = 19;
            this.episodeNameLabel.Text = "episodeName";
            this.episodeNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.episodeNameLabel.UseStyleColors = false;
            // 
            // descLabel
            // 
            this.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.Location = new System.Drawing.Point(235, 76);
            this.descLabel.Multiline = true;
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(469, 87);
            this.descLabel.TabIndex = 27;
            this.descLabel.Text = "desc";
            // 
            // iconPicture
            // 
            this.iconPicture.Location = new System.Drawing.Point(413, 195);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(112, 100);
            this.iconPicture.TabIndex = 26;
            this.iconPicture.TabStop = false;
            // 
            // iconFrame
            // 
            this.iconFrame.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.Frame;
            this.iconFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconFrame.Location = new System.Drawing.Point(405, 187);
            this.iconFrame.Name = "iconFrame";
            this.iconFrame.Size = new System.Drawing.Size(128, 116);
            this.iconFrame.TabIndex = 25;
            this.iconFrame.TabStop = false;
            // 
            // ss4
            // 
            this.ss4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ss4.BackgroundImage")));
            this.ss4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ss4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss4.InitialImage = null;
            this.ss4.Location = new System.Drawing.Point(592, 310);
            this.ss4.Name = "ss4";
            this.ss4.Size = new System.Drawing.Size(112, 90);
            this.ss4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ss4.TabIndex = 24;
            this.ss4.TabStop = false;
            this.ss4.Click += new System.EventHandler(this.ss4_Click);
            // 
            // ss3
            // 
            this.ss3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ss3.BackgroundImage")));
            this.ss3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ss3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss3.InitialImage = null;
            this.ss3.Location = new System.Drawing.Point(474, 310);
            this.ss3.Name = "ss3";
            this.ss3.Size = new System.Drawing.Size(112, 90);
            this.ss3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ss3.TabIndex = 23;
            this.ss3.TabStop = false;
            this.ss3.Click += new System.EventHandler(this.ss3_Click);
            // 
            // ss2
            // 
            this.ss2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ss2.BackgroundImage")));
            this.ss2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ss2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss2.InitialImage = null;
            this.ss2.Location = new System.Drawing.Point(356, 310);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(112, 90);
            this.ss2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ss2.TabIndex = 22;
            this.ss2.TabStop = false;
            this.ss2.Click += new System.EventHandler(this.ss2_Click);
            // 
            // ss1
            // 
            this.ss1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ss1.BackgroundImage")));
            this.ss1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ss1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss1.InitialImage = null;
            this.ss1.Location = new System.Drawing.Point(238, 310);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(112, 90);
            this.ss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ss1.TabIndex = 21;
            this.ss1.TabStop = false;
            this.ss1.Click += new System.EventHandler(this.ss1_Click);
            // 
            // loadingProg
            // 
            this.loadingProg.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.loadingProg.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.loadingProg.HideProgressText = true;
            this.loadingProg.Location = new System.Drawing.Point(238, 226);
            this.loadingProg.Name = "loadingProg";
            this.loadingProg.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingProg.Size = new System.Drawing.Size(466, 32);
            this.loadingProg.Style = MetroFramework.MetroColorStyle.Purple;
            this.loadingProg.StyleManager = null;
            this.loadingProg.TabIndex = 28;
            this.loadingProg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadingProg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loadingProg.Visible = false;
            // 
            // installEpisodeButton
            // 
            this.installEpisodeButton.Highlight = false;
            this.installEpisodeButton.Location = new System.Drawing.Point(413, 406);
            this.installEpisodeButton.Name = "installEpisodeButton";
            this.installEpisodeButton.Size = new System.Drawing.Size(120, 46);
            this.installEpisodeButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.installEpisodeButton.StyleManager = null;
            this.installEpisodeButton.TabIndex = 29;
            this.installEpisodeButton.Text = "INSTALL EPISODE";
            this.installEpisodeButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.installEpisodeButton.Click += new System.EventHandler(this.installEpisodeButton_Click);
            // 
            // AvailableEpisodesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.installEpisodeButton);
            this.Controls.Add(this.loadingProg);
            this.Controls.Add(this.iconPicture);
            this.Controls.Add(this.iconFrame);
            this.Controls.Add(this.ss4);
            this.Controls.Add(this.ss3);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.episodeNameLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.availEpisodesListview);
            this.Name = "AvailableEpisodesControl";
            this.Size = new System.Drawing.Size(719, 472);
            this.Load += new System.EventHandler(this.AvailableEpisodesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView availEpisodesListview;
        public System.Windows.Forms.PictureBox iconPicture;
        public System.Windows.Forms.PictureBox iconFrame;
        public System.Windows.Forms.PictureBox ss4;
        public System.Windows.Forms.PictureBox ss3;
        public System.Windows.Forms.PictureBox ss2;
        public System.Windows.Forms.PictureBox ss1;
        public MetroFramework.Controls.MetroLabel authorName;
        public MetroFramework.Controls.MetroLabel episodeNameLabel;
        public System.Windows.Forms.TextBox descLabel;
        public System.Windows.Forms.ColumnHeader Episode;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.ComponentModel.BackgroundWorker loadingInfoBgWorker;
        public MetroFramework.Controls.MetroProgressBar loadingProg;
        public MetroFramework.Controls.MetroButton installEpisodeButton;
        public System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
