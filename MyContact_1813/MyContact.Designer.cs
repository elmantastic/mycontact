namespace MyContact_1813
{
    partial class MyContact
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTextStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMyContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContact1 = new MyContact_1813.NewContact();
            this.myContactList1 = new MyContact_1813.MyContactList();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsTextStripMenu,
            this.toolStripMenuItem2,
            this.LogoutStripMenu,
            this.exitToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // SaveAsTextStripMenu
            // 
            this.SaveAsTextStripMenu.Name = "SaveAsTextStripMenu";
            this.SaveAsTextStripMenu.Size = new System.Drawing.Size(152, 22);
            this.SaveAsTextStripMenu.Text = "Save as Text";
            this.SaveAsTextStripMenu.Click += new System.EventHandler(this.SaveAsTextStripMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // LogoutStripMenu
            // 
            this.LogoutStripMenu.Name = "LogoutStripMenu";
            this.LogoutStripMenu.Size = new System.Drawing.Size(136, 22);
            this.LogoutStripMenu.Text = "Logout";
            this.LogoutStripMenu.Click += new System.EventHandler(this.LogoutStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContactToolStripMenuItem,
            this.listContactToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // newContactToolStripMenuItem
            // 
            this.newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
            this.newContactToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newContactToolStripMenuItem.Text = "New Contact";
            this.newContactToolStripMenuItem.Click += new System.EventHandler(this.newContactToolStripMenuItem_Click);
            // 
            // listContactToolStripMenuItem
            // 
            this.listContactToolStripMenuItem.Name = "listContactToolStripMenuItem";
            this.listContactToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listContactToolStripMenuItem.Text = "List Contact";
            this.listContactToolStripMenuItem.Click += new System.EventHandler(this.listContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMyContactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMyContactToolStripMenuItem
            // 
            this.aboutMyContactToolStripMenuItem.Name = "aboutMyContactToolStripMenuItem";
            this.aboutMyContactToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutMyContactToolStripMenuItem.Text = "About MyContact";
            this.aboutMyContactToolStripMenuItem.Click += new System.EventHandler(this.aboutMyContactToolStripMenuItem_Click);
            // 
            // newContact1
            // 
            this.newContact1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newContact1.BackColor = System.Drawing.Color.White;
            this.newContact1.Location = new System.Drawing.Point(12, 40);
            this.newContact1.MaximumSize = new System.Drawing.Size(615, 279);
            this.newContact1.MinimumSize = new System.Drawing.Size(615, 279);
            this.newContact1.Name = "newContact1";
            this.newContact1.Size = new System.Drawing.Size(615, 279);
            this.newContact1.TabIndex = 2;
            // 
            // myContactList1
            // 
            this.myContactList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myContactList1.BackColor = System.Drawing.Color.White;
            this.myContactList1.Location = new System.Drawing.Point(12, 40);
            this.myContactList1.Name = "myContactList1";
            this.myContactList1.Size = new System.Drawing.Size(615, 279);
            this.myContactList1.TabIndex = 1;
            // 
            // MyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 331);
            this.Controls.Add(this.myContactList1);
            this.Controls.Add(this.newContact1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(655, 370);
            this.Name = "MyContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyContact";
            this.SizeChanged += new System.EventHandler(this.MyContact_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTextStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem LogoutStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMyContactToolStripMenuItem;
        private NewContact newContact1;
        private MyContactList myContactList1;
    }
}

