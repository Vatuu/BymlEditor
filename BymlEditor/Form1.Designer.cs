namespace BymlEditor
{
    partial class mainForm
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
            this.tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxType = new System.Windows.Forms.TextBox();
            this.boxValue = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soonTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkByml = new System.Windows.Forms.ToolStripMenuItem();
            this.discordInvitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordMarioInvite = new System.Windows.Forms.ToolStripMenuItem();
            this.zeldaDiscordInvite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileNormal = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(12, 27);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(707, 522);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(135, 563);
            this.boxId.Name = "boxId";
            this.boxId.ReadOnly = true;
            this.boxId.Size = new System.Drawing.Size(458, 20);
            this.boxId.TabIndex = 4;
            // 
            // boxType
            // 
            this.boxType.Location = new System.Drawing.Point(135, 589);
            this.boxType.Name = "boxType";
            this.boxType.ReadOnly = true;
            this.boxType.Size = new System.Drawing.Size(458, 20);
            this.boxType.TabIndex = 5;
            // 
            // boxValue
            // 
            this.boxValue.Location = new System.Drawing.Point(135, 615);
            this.boxValue.Name = "boxValue";
            this.boxValue.Size = new System.Drawing.Size(458, 20);
            this.boxValue.TabIndex = 6;
            this.boxValue.TextChanged += new System.EventHandler(this.boxValue_TextChanged);
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(96, 618);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(34, 13);
            this.Value.TabIndex = 7;
            this.Value.Text = "Value";
            this.Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(604, 658);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(115, 13);
            this.linkGithub.TabIndex = 8;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "BYML Editor on Github\r\n";
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(9, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Version 0.1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soonTMToolStripMenuItem});
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // soonTMToolStripMenuItem
            // 
            this.soonTMToolStripMenuItem.Name = "soonTMToolStripMenuItem";
            this.soonTMToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.soonTMToolStripMenuItem.Text = "SoonTM";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromXMLToolStripMenuItem,
            this.fromJSONToolStripMenuItem});
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // fromXMLToolStripMenuItem
            // 
            this.fromXMLToolStripMenuItem.Name = "fromXMLToolStripMenuItem";
            this.fromXMLToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fromXMLToolStripMenuItem.Text = "From XML";
            // 
            // fromJSONToolStripMenuItem
            // 
            this.fromJSONToolStripMenuItem.Name = "fromJSONToolStripMenuItem";
            this.fromJSONToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fromJSONToolStripMenuItem.Text = "From JSON";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toXMLToolStripMenuItem,
            this.toJSONToolStripMenuItem});
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // toXMLToolStripMenuItem
            // 
            this.toXMLToolStripMenuItem.Name = "toXMLToolStripMenuItem";
            this.toXMLToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.toXMLToolStripMenuItem.Text = "To XML";
            this.toXMLToolStripMenuItem.Click += new System.EventHandler(this.toXMLToolStripMenuItem_Click);
            // 
            // toJSONToolStripMenuItem
            // 
            this.toJSONToolStripMenuItem.Name = "toJSONToolStripMenuItem";
            this.toJSONToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.toJSONToolStripMenuItem.Text = "To JSON";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkByml,
            this.discordInvitesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Links";
            // 
            // linkByml
            // 
            this.linkByml.Name = "linkByml";
            this.linkByml.Size = new System.Drawing.Size(175, 22);
            this.linkByml.Text = "BYAML File Format";
            this.linkByml.Click += new System.EventHandler(this.bYMLFileFormatToolStripMenuItem_Click);
            // 
            // discordInvitesToolStripMenuItem
            // 
            this.discordInvitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordMarioInvite,
            this.zeldaDiscordInvite});
            this.discordInvitesToolStripMenuItem.Name = "discordInvitesToolStripMenuItem";
            this.discordInvitesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.discordInvitesToolStripMenuItem.Text = "Discord Invites";
            // 
            // discordMarioInvite
            // 
            this.discordMarioInvite.Name = "discordMarioInvite";
            this.discordMarioInvite.Size = new System.Drawing.Size(213, 22);
            this.discordMarioInvite.Text = "SMO Modding Hub";
            this.discordMarioInvite.Click += new System.EventHandler(this.sMOModdingHubToolStripMenuItem_Click);
            // 
            // zeldaDiscordInvite
            // 
            this.zeldaDiscordInvite.Name = "zeldaDiscordInvite";
            this.zeldaDiscordInvite.Size = new System.Drawing.Size(213, 22);
            this.zeldaDiscordInvite.Text = "Zelda BotW Modding Hub";
            this.zeldaDiscordInvite.Click += new System.EventHandler(this.zeldaBotWModdingHubToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expandAllToolStripMenuItem.Text = "Expand all";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse all";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // openFileNormal
            // 
            this.openFileNormal.DefaultExt = "byml";
            this.openFileNormal.Filter = "Binary YAML Files|*.byml";
            this.openFileNormal.Title = "Open BYML...";
            this.openFileNormal.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileNormal_FileOk);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.boxValue);
            this.Controls.Add(this.boxType);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Binary YAML Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxType;
        private System.Windows.Forms.TextBox boxValue;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soonTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordInvitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordMarioInvite;
        private System.Windows.Forms.ToolStripMenuItem zeldaDiscordInvite;
        private System.Windows.Forms.ToolStripMenuItem linkByml;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileNormal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
    }
}

