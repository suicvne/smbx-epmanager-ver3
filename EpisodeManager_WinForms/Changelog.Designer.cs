namespace EpisodeManager_WinForms
{
    partial class Changelog
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
            this.availableVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.currentVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.updateConfirmLabel = new MetroFramework.Controls.MetroLabel();
            this.yesButton = new MetroFramework.Controls.MetroButton();
            this.noButton = new MetroFramework.Controls.MetroButton();
            this.changelogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // availableVersionLabel
            // 
            this.availableVersionLabel.AutoSize = true;
            this.availableVersionLabel.CustomBackground = false;
            this.availableVersionLabel.CustomForeColor = false;
            this.availableVersionLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.availableVersionLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.availableVersionLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.availableVersionLabel.Location = new System.Drawing.Point(24, 94);
            this.availableVersionLabel.Name = "availableVersionLabel";
            this.availableVersionLabel.Size = new System.Drawing.Size(81, 19);
            this.availableVersionLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.availableVersionLabel.TabIndex = 1;
            this.availableVersionLabel.Text = "metroLabel1";
            this.availableVersionLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableVersionLabel.UseStyleColors = false;
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.CustomBackground = false;
            this.currentVersionLabel.CustomForeColor = false;
            this.currentVersionLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.currentVersionLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.currentVersionLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.currentVersionLabel.Location = new System.Drawing.Point(24, 72);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(83, 19);
            this.currentVersionLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.currentVersionLabel.TabIndex = 2;
            this.currentVersionLabel.Text = "metroLabel2";
            this.currentVersionLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.currentVersionLabel.UseStyleColors = false;
            // 
            // updateConfirmLabel
            // 
            this.updateConfirmLabel.AutoSize = true;
            this.updateConfirmLabel.CustomBackground = false;
            this.updateConfirmLabel.CustomForeColor = false;
            this.updateConfirmLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.updateConfirmLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.updateConfirmLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.updateConfirmLabel.Location = new System.Drawing.Point(132, 428);
            this.updateConfirmLabel.Name = "updateConfirmLabel";
            this.updateConfirmLabel.Size = new System.Drawing.Size(162, 19);
            this.updateConfirmLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateConfirmLabel.TabIndex = 3;
            this.updateConfirmLabel.Text = "Would you like to update?";
            this.updateConfirmLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateConfirmLabel.UseStyleColors = false;
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Highlight = false;
            this.yesButton.Location = new System.Drawing.Point(132, 450);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 36);
            this.yesButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "YES";
            this.yesButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButton.Highlight = false;
            this.noButton.Location = new System.Drawing.Point(219, 450);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 36);
            this.noButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noButton.TabIndex = 5;
            this.noButton.Text = "NO";
            this.noButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // changelogTextBox
            // 
            this.changelogTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogTextBox.Location = new System.Drawing.Point(24, 116);
            this.changelogTextBox.Name = "changelogTextBox";
            this.changelogTextBox.Size = new System.Drawing.Size(412, 309);
            this.changelogTextBox.TabIndex = 6;
            this.changelogTextBox.Text = "";
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 509);
            this.Controls.Add(this.changelogTextBox);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.updateConfirmLabel);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.availableVersionLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Changelog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Update Available!";
            this.Load += new System.EventHandler(this.Changelog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel availableVersionLabel;
        private MetroFramework.Controls.MetroLabel currentVersionLabel;
        private MetroFramework.Controls.MetroLabel updateConfirmLabel;
        private MetroFramework.Controls.MetroButton yesButton;
        private MetroFramework.Controls.MetroButton noButton;
        private System.Windows.Forms.RichTextBox changelogTextBox;
    }
}