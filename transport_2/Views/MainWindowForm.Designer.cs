﻿namespace transport_2.Views
{
    partial class MainWindowForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bejelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépélsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csomagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevemenLévőCsomagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyféltőlFelvehetőCsomagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóInaktiválásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statusbarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.csomagToolStripMenuItem,
            this.felhasználókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bejelentkezésToolStripMenuItem,
            this.kijelentkezésToolStripMenuItem,
            this.kilépélsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // bejelentkezésToolStripMenuItem
            // 
            this.bejelentkezésToolStripMenuItem.Name = "bejelentkezésToolStripMenuItem";
            this.bejelentkezésToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bejelentkezésToolStripMenuItem.Text = "Bejelentkezés";
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            // 
            // kilépélsToolStripMenuItem
            // 
            this.kilépélsToolStripMenuItem.Name = "kilépélsToolStripMenuItem";
            this.kilépélsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kilépélsToolStripMenuItem.Text = "Kilépés";
            this.kilépélsToolStripMenuItem.Click += new System.EventHandler(this.kilépélsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // csomagToolStripMenuItem
            // 
            this.csomagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nevemenLévőCsomagokToolStripMenuItem,
            this.ügyféltőlFelvehetőCsomagokToolStripMenuItem});
            this.csomagToolStripMenuItem.Name = "csomagToolStripMenuItem";
            this.csomagToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.csomagToolStripMenuItem.Text = "Csomagok";
            this.csomagToolStripMenuItem.Click += new System.EventHandler(this.csomagToolStripMenuItem_Click);
            // 
            // nevemenLévőCsomagokToolStripMenuItem
            // 
            this.nevemenLévőCsomagokToolStripMenuItem.Name = "nevemenLévőCsomagokToolStripMenuItem";
            this.nevemenLévőCsomagokToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.nevemenLévőCsomagokToolStripMenuItem.Text = "Nevemen lévő csomagok";
            // 
            // ügyféltőlFelvehetőCsomagokToolStripMenuItem
            // 
            this.ügyféltőlFelvehetőCsomagokToolStripMenuItem.Name = "ügyféltőlFelvehetőCsomagokToolStripMenuItem";
            this.ügyféltőlFelvehetőCsomagokToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ügyféltőlFelvehetőCsomagokToolStripMenuItem.Text = "Ügyféltől felvehető csomagok";
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználóListaToolStripMenuItem,
            this.felhasználóInaktiválásaToolStripMenuItem});
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // felhasználóListaToolStripMenuItem
            // 
            this.felhasználóListaToolStripMenuItem.Name = "felhasználóListaToolStripMenuItem";
            this.felhasználóListaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.felhasználóListaToolStripMenuItem.Text = "Felhasználó Lista";
            this.felhasználóListaToolStripMenuItem.Click += new System.EventHandler(this.felhasználóListaToolStripMenuItem_Click);
            // 
            // felhasználóInaktiválásaToolStripMenuItem
            // 
            this.felhasználóInaktiválásaToolStripMenuItem.Name = "felhasználóInaktiválásaToolStripMenuItem";
            this.felhasználóInaktiválásaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.felhasználóInaktiválásaToolStripMenuItem.Text = "Felhasználó Inaktiválása";
            // 
            // toolbar
            // 
            this.toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(600, 27);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::transport_2.Properties.Resources.icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusbar
            // 
            this.statusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbarLabel});
            this.statusbar.Location = new System.Drawing.Point(0, 344);
            this.statusbar.Name = "statusbar";
            this.statusbar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusbar.Size = new System.Drawing.Size(600, 22);
            this.statusbar.TabIndex = 2;
            // 
            // statusbarLabel
            // 
            this.statusbarLabel.Name = "statusbarLabel";
            this.statusbarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 298);
            this.panel1.TabIndex = 3;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bejelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépélsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripMenuItem csomagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevemenLévőCsomagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyféltőlFelvehetőCsomagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóInaktiválásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel statusbarLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
    }
}