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
            this.availEpisodesListview = new System.Windows.Forms.ListView();
            this.Episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // availEpisodesListview
            // 
            this.availEpisodesListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availEpisodesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episode});
            this.availEpisodesListview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availEpisodesListview.FullRowSelect = true;
            this.availEpisodesListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.availEpisodesListview.Location = new System.Drawing.Point(0, 0);
            this.availEpisodesListview.MultiSelect = false;
            this.availEpisodesListview.Name = "availEpisodesListview";
            this.availEpisodesListview.Size = new System.Drawing.Size(222, 481);
            this.availEpisodesListview.TabIndex = 5;
            this.availEpisodesListview.UseCompatibleStateImageBehavior = false;
            this.availEpisodesListview.View = System.Windows.Forms.View.Details;
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            this.Episode.Width = 220;
            // 
            // AvailableEpisodesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.availEpisodesListview);
            this.Name = "AvailableEpisodesControl";
            this.Size = new System.Drawing.Size(719, 481);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView availEpisodesListview;
        private System.Windows.Forms.ColumnHeader Episode;
    }
}
