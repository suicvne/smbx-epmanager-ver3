namespace IndexGenerator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.directoryText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epNameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.verText = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.serverLinkText = new System.Windows.Forms.TextBox();
            this.forumLinkText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.screenshot1 = new IndexGenerator.Screenshot();
            this.screenshot2 = new IndexGenerator.Screenshot();
            this.screenshot3 = new IndexGenerator.Screenshot();
            this.screenshot4 = new IndexGenerator.Screenshot();
            this.iconPic1 = new IndexGenerator.IconPic();
            this.vLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryText
            // 
            this.directoryText.Location = new System.Drawing.Point(12, 28);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(393, 20);
            this.directoryText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Episode Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Episode Name: ";
            // 
            // epNameText
            // 
            this.epNameText.Location = new System.Drawing.Point(101, 300);
            this.epNameText.Name = "epNameText";
            this.epNameText.Size = new System.Drawing.Size(389, 20);
            this.epNameText.TabIndex = 5;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(101, 326);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(389, 20);
            this.authorText.TabIndex = 7;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(54, 329);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(41, 13);
            this.Author.TabIndex = 6;
            this.Author.Text = "Author:";
            // 
            // descText
            // 
            this.descText.Location = new System.Drawing.Point(101, 352);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(389, 20);
            this.descText.TabIndex = 9;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(32, 355);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 13);
            this.Description.TabIndex = 8;
            this.Description.Text = "Description:";
            // 
            // verText
            // 
            this.verText.Location = new System.Drawing.Point(101, 378);
            this.verText.Name = "verText";
            this.verText.Size = new System.Drawing.Size(389, 20);
            this.verText.TabIndex = 11;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(50, 381);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(45, 13);
            this.Version.TabIndex = 10;
            this.Version.Text = "Version:";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 55);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 239);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 468;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 20);
            this.button4.TabIndex = 15;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(497, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Save Project";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Load from Index";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Refresh Dir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(496, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 22);
            this.button8.TabIndex = 23;
            this.button8.Text = "Generate Changes";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Server: ";
            // 
            // serverLinkText
            // 
            this.serverLinkText.Location = new System.Drawing.Point(101, 405);
            this.serverLinkText.Name = "serverLinkText";
            this.serverLinkText.Size = new System.Drawing.Size(389, 20);
            this.serverLinkText.TabIndex = 12;
            this.toolTip.SetToolTip(this.serverLinkText, "Be sure to end the URL with a \"/\"!");
            // 
            // forumLinkText
            // 
            this.forumLinkText.Location = new System.Drawing.Point(101, 431);
            this.forumLinkText.Name = "forumLinkText";
            this.forumLinkText.Size = new System.Drawing.Size(389, 20);
            this.forumLinkText.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Forum URL: ";
            // 
            // screenshot1
            // 
            this.screenshot1.Location = new System.Drawing.Point(632, 28);
            this.screenshot1.Name = "screenshot1";
            this.screenshot1.Size = new System.Drawing.Size(134, 186);
            this.screenshot1.TabIndex = 27;
            // 
            // screenshot2
            // 
            this.screenshot2.Location = new System.Drawing.Point(772, 28);
            this.screenshot2.Name = "screenshot2";
            this.screenshot2.Size = new System.Drawing.Size(134, 186);
            this.screenshot2.TabIndex = 28;
            // 
            // screenshot3
            // 
            this.screenshot3.Location = new System.Drawing.Point(632, 220);
            this.screenshot3.Name = "screenshot3";
            this.screenshot3.Size = new System.Drawing.Size(134, 186);
            this.screenshot3.TabIndex = 29;
            // 
            // screenshot4
            // 
            this.screenshot4.Location = new System.Drawing.Point(772, 220);
            this.screenshot4.Name = "screenshot4";
            this.screenshot4.Size = new System.Drawing.Size(134, 186);
            this.screenshot4.TabIndex = 30;
            // 
            // iconPic1
            // 
            this.iconPic1.Location = new System.Drawing.Point(497, 177);
            this.iconPic1.Name = "iconPic1";
            this.iconPic1.Size = new System.Drawing.Size(129, 182);
            this.iconPic1.TabIndex = 31;
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Location = new System.Drawing.Point(497, 439);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(45, 13);
            this.vLabel.TabIndex = 32;
            this.vLabel.Text = "Version ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 464);
            this.Controls.Add(this.vLabel);
            this.Controls.Add(this.iconPic1);
            this.Controls.Add(this.screenshot4);
            this.Controls.Add(this.screenshot3);
            this.Controls.Add(this.screenshot2);
            this.Controls.Add(this.screenshot1);
            this.Controls.Add(this.forumLinkText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverLinkText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.verText);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.epNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.directoryText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Episode Index Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epNameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox verText;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        
        public System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverLinkText;
        private System.Windows.Forms.TextBox forumLinkText;
        private System.Windows.Forms.Label label4;
        
        private System.Windows.Forms.ToolTip toolTip;
        private IndexGenerator.Screenshot screenshot1;
        private IndexGenerator.Screenshot screenshot2;
        private IndexGenerator.Screenshot screenshot3;
        private IndexGenerator.Screenshot screenshot4;
        private IndexGenerator.IconPic iconPic1;
        private System.Windows.Forms.Label vLabel;
        
    }
}

