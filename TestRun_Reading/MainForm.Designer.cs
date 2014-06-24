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
            this.changeDirButton = new System.Windows.Forms.Button();
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
            this.loadDirButton = new System.Windows.Forms.Button();
            this.refreshDirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.serverLinkText = new System.Windows.Forms.TextBox();
            this.forumLinkText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.vLabel = new System.Windows.Forms.Label();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectLanguageButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.uncheckAllButton = new System.Windows.Forms.Button();
            this.iconPic1 = new IndexGenerator.IconPic();
            this.screenshot4 = new IndexGenerator.Screenshot();
            this.screenshot3 = new IndexGenerator.Screenshot();
            this.screenshot2 = new IndexGenerator.Screenshot();
            this.screenshot1 = new IndexGenerator.Screenshot();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoryText
            // 
            resources.ApplyResources(this.directoryText, "directoryText");
            this.directoryText.Name = "directoryText";
            // 
            // changeDirButton
            // 
            resources.ApplyResources(this.changeDirButton, "changeDirButton");
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.UseVisualStyleBackColor = true;
            this.changeDirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // epNameText
            // 
            resources.ApplyResources(this.epNameText, "epNameText");
            this.epNameText.Name = "epNameText";
            // 
            // authorText
            // 
            resources.ApplyResources(this.authorText, "authorText");
            this.authorText.Name = "authorText";
            // 
            // Author
            // 
            resources.ApplyResources(this.Author, "Author");
            this.Author.Name = "Author";
            // 
            // descText
            // 
            resources.ApplyResources(this.descText, "descText");
            this.descText.Name = "descText";
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            // 
            // verText
            // 
            resources.ApplyResources(this.verText, "verText");
            this.verText.Name = "verText";
            // 
            // Version
            // 
            resources.ApplyResources(this.Version, "Version");
            this.Version.Name = "Version";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // loadDirButton
            // 
            resources.ApplyResources(this.loadDirButton, "loadDirButton");
            this.loadDirButton.Name = "loadDirButton";
            this.loadDirButton.UseVisualStyleBackColor = true;
            this.loadDirButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // refreshDirButton
            // 
            resources.ApplyResources(this.refreshDirButton, "refreshDirButton");
            this.refreshDirButton.Name = "refreshDirButton";
            this.refreshDirButton.UseVisualStyleBackColor = true;
            this.refreshDirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // serverLinkText
            // 
            resources.ApplyResources(this.serverLinkText, "serverLinkText");
            this.serverLinkText.Name = "serverLinkText";
            this.toolTip.SetToolTip(this.serverLinkText, resources.GetString("serverLinkText.ToolTip"));
            // 
            // forumLinkText
            // 
            resources.ApplyResources(this.forumLinkText, "forumLinkText");
            this.forumLinkText.Name = "forumLinkText";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // vLabel
            // 
            resources.ApplyResources(this.vLabel, "vLabel");
            this.vLabel.Name = "vLabel";
            // 
            // checkAllButton
            // 
            resources.ApplyResources(this.checkAllButton, "checkAllButton");
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.UseVisualStyleBackColor = true;
            this.checkAllButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.selectLanguageButton);
            this.groupBox1.Controls.Add(this.languageComboBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // selectLanguageButton
            // 
            resources.ApplyResources(this.selectLanguageButton, "selectLanguageButton");
            this.selectLanguageButton.Name = "selectLanguageButton";
            this.selectLanguageButton.UseVisualStyleBackColor = true;
            this.selectLanguageButton.Click += new System.EventHandler(this.selectLanguageButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8});
            resources.ApplyResources(this.menuItem6, "menuItem6");
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            resources.ApplyResources(this.menuItem8, "menuItem8");
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // uncheckAllButton
            // 
            resources.ApplyResources(this.uncheckAllButton, "uncheckAllButton");
            this.uncheckAllButton.Name = "uncheckAllButton";
            this.uncheckAllButton.UseVisualStyleBackColor = true;
            this.uncheckAllButton.Click += new System.EventHandler(this.uncheckAllButton_Click);
            // 
            // iconPic1
            // 
            resources.ApplyResources(this.iconPic1, "iconPic1");
            this.iconPic1.Name = "iconPic1";
            // 
            // screenshot4
            // 
            resources.ApplyResources(this.screenshot4, "screenshot4");
            this.screenshot4.Name = "screenshot4";
            // 
            // screenshot3
            // 
            resources.ApplyResources(this.screenshot3, "screenshot3");
            this.screenshot3.Name = "screenshot3";
            // 
            // screenshot2
            // 
            resources.ApplyResources(this.screenshot2, "screenshot2");
            this.screenshot2.Name = "screenshot2";
            // 
            // screenshot1
            // 
            resources.ApplyResources(this.screenshot1, "screenshot1");
            this.screenshot1.Name = "screenshot1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uncheckAllButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkAllButton);
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
            this.Controls.Add(this.loadDirButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.refreshDirButton);
            this.Controls.Add(this.verText);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.epNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeDirButton);
            this.Controls.Add(this.directoryText);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Button changeDirButton;
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
        private System.Windows.Forms.Button loadDirButton;
        
        public System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Button refreshDirButton;
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
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectLanguageButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.Button uncheckAllButton;
        
    }
}

