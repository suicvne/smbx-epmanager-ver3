namespace EpisodeManager_WinForms
{
    partial class UpdateEpisode
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
            this.InitialCheckGroup = new System.Windows.Forms.GroupBox();
            this.isOkGroup = new System.Windows.Forms.GroupBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconFrame = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.updatingToLabel = new MetroFramework.Controls.MetroLabel();
            this.changesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadFilesBgWorker = new System.ComponentModel.BackgroundWorker();
            this.InitialCheckGroup.SuspendLayout();
            this.isOkGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // InitialCheckGroup
            // 
            this.InitialCheckGroup.Controls.Add(this.isOkGroup);
            this.InitialCheckGroup.Controls.Add(this.iconPicture);
            this.InitialCheckGroup.Controls.Add(this.iconFrame);
            this.InitialCheckGroup.Controls.Add(this.metroLabel2);
            this.InitialCheckGroup.Controls.Add(this.updatingToLabel);
            this.InitialCheckGroup.Controls.Add(this.changesListView);
            this.InitialCheckGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialCheckGroup.ForeColor = System.Drawing.Color.DarkGreen;
            this.InitialCheckGroup.Location = new System.Drawing.Point(24, 64);
            this.InitialCheckGroup.Name = "InitialCheckGroup";
            this.InitialCheckGroup.Size = new System.Drawing.Size(568, 554);
            this.InitialCheckGroup.TabIndex = 0;
            this.InitialCheckGroup.TabStop = false;
            // 
            // isOkGroup
            // 
            this.isOkGroup.Controls.Add(this.yesButton);
            this.isOkGroup.Controls.Add(this.noButton);
            this.isOkGroup.Controls.Add(this.metroLabel1);
            this.isOkGroup.Location = new System.Drawing.Point(362, 56);
            this.isOkGroup.Name = "isOkGroup";
            this.isOkGroup.Size = new System.Drawing.Size(200, 100);
            this.isOkGroup.TabIndex = 17;
            this.isOkGroup.TabStop = false;
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.ok_32;
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.ForeColor = System.Drawing.Color.Transparent;
            this.yesButton.Location = new System.Drawing.Point(114, 41);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(41, 43);
            this.yesButton.TabIndex = 15;
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.cancel_32;
            this.noButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noButton.FlatAppearance.BorderSize = 0;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.ForeColor = System.Drawing.Color.Transparent;
            this.noButton.Location = new System.Drawing.Point(43, 41);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(41, 43);
            this.noButton.TabIndex = 16;
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(61, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Is this okay?";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // iconPicture
            // 
            this.iconPicture.Location = new System.Drawing.Point(217, 51);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(112, 100);
            this.iconPicture.TabIndex = 13;
            this.iconPicture.TabStop = false;
            // 
            // iconFrame
            // 
            this.iconFrame.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.Frame;
            this.iconFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconFrame.Location = new System.Drawing.Point(209, 43);
            this.iconFrame.Name = "iconFrame";
            this.iconFrame.Size = new System.Drawing.Size(128, 116);
            this.iconFrame.TabIndex = 12;
            this.iconFrame.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(6, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(205, 44);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "The following changes will be \r\ndownloaded:\r\n";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // updatingToLabel
            // 
            this.updatingToLabel.AutoSize = true;
            this.updatingToLabel.CustomBackground = false;
            this.updatingToLabel.CustomForeColor = false;
            this.updatingToLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.updatingToLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.updatingToLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.updatingToLabel.Location = new System.Drawing.Point(193, 19);
            this.updatingToLabel.Name = "updatingToLabel";
            this.updatingToLabel.Size = new System.Drawing.Size(155, 19);
            this.updatingToLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.updatingToLabel.TabIndex = 6;
            this.updatingToLabel.Text = "Updating to Version 1000";
            this.updatingToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatingToLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updatingToLabel.UseStyleColors = false;
            // 
            // changesListView
            // 
            this.changesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.changesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.changesListView.ForeColor = System.Drawing.Color.DarkGreen;
            this.changesListView.FullRowSelect = true;
            this.changesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.changesListView.Location = new System.Drawing.Point(6, 162);
            this.changesListView.MultiSelect = false;
            this.changesListView.Name = "changesListView";
            this.changesListView.Size = new System.Drawing.Size(556, 386);
            this.changesListView.TabIndex = 5;
            this.changesListView.UseCompatibleStateImageBehavior = false;
            this.changesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 345;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Type";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Completed";
            this.columnHeader3.Width = 83;
            // 
            // downloadFilesBgWorker
            // 
            this.downloadFilesBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadFilesBgWorker_DoWork);
            // 
            // UpdateEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 641);
            this.Controls.Add(this.InitialCheckGroup);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateEpisode";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Update Episode";
            this.Load += new System.EventHandler(this.UpdateEpisode_Load);
            this.InitialCheckGroup.ResumeLayout(false);
            this.InitialCheckGroup.PerformLayout();
            this.isOkGroup.ResumeLayout(false);
            this.isOkGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InitialCheckGroup;
        private System.Windows.Forms.ListView changesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel updatingToLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.PictureBox iconPicture;
        public System.Windows.Forms.PictureBox iconFrame;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.ComponentModel.BackgroundWorker downloadFilesBgWorker;
        private System.Windows.Forms.GroupBox isOkGroup;
    }
}