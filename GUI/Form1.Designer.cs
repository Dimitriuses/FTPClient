namespace GUI
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
            this.treeViewServer = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інструментиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підключитисьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewServer = new System.Windows.Forms.ListView();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.treeViewClient = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewServer
            // 
            this.treeViewServer.Location = new System.Drawing.Point(12, 27);
            this.treeViewServer.Name = "treeViewServer";
            this.treeViewServer.Size = new System.Drawing.Size(159, 411);
            this.treeViewServer.TabIndex = 0;
            this.treeViewServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewServer_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.інструментиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // інструментиToolStripMenuItem
            // 
            this.інструментиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.підключитисьToolStripMenuItem});
            this.інструментиToolStripMenuItem.Name = "інструментиToolStripMenuItem";
            this.інструментиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.інструментиToolStripMenuItem.Text = "Інструменти";
            // 
            // підключитисьToolStripMenuItem
            // 
            this.підключитисьToolStripMenuItem.Name = "підключитисьToolStripMenuItem";
            this.підключитисьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.підключитисьToolStripMenuItem.Text = "Підключитись";
            this.підключитисьToolStripMenuItem.Click += new System.EventHandler(this.підключитисьToolStripMenuItem_Click);
            // 
            // listViewServer
            // 
            this.listViewServer.Location = new System.Drawing.Point(177, 27);
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.Size = new System.Drawing.Size(370, 411);
            this.listViewServer.TabIndex = 2;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.SelectedIndexChanged += new System.EventHandler(this.listViewServer_SelectedIndexChanged);
            // 
            // listViewClient
            // 
            this.listViewClient.Location = new System.Drawing.Point(736, 27);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(408, 411);
            this.listViewClient.TabIndex = 4;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            // 
            // treeViewClient
            // 
            this.treeViewClient.Location = new System.Drawing.Point(609, 27);
            this.treeViewClient.Name = "treeViewClient";
            this.treeViewClient.Size = new System.Drawing.Size(121, 411);
            this.treeViewClient.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.treeViewClient);
            this.Controls.Add(this.listViewServer);
            this.Controls.Add(this.treeViewServer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewServer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інструментиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підключитисьToolStripMenuItem;
        private System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.TreeView treeViewClient;
        private System.Windows.Forms.Button button1;
    }
}

