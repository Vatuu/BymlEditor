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
            this.labelId = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxType = new System.Windows.Forms.TextBox();
            this.boxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
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
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.controlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.linksPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.masterTable.SuspendLayout();
            this.controlsTable.SuspendLayout();
            this.linksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(39, 3);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(651, 527);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 10);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(64, 13);
            this.boxId.Name = "boxId";
            this.boxId.ReadOnly = true;
            this.boxId.Size = new System.Drawing.Size(458, 20);
            this.boxId.TabIndex = 4;
            // 
            // boxType
            // 
            this.boxType.Location = new System.Drawing.Point(64, 38);
            this.boxType.Name = "boxType";
            this.boxType.ReadOnly = true;
            this.boxType.Size = new System.Drawing.Size(458, 20);
            this.boxType.TabIndex = 5;
            // 
            // boxValue
            // 
            this.boxValue.Location = new System.Drawing.Point(64, 64);
            this.boxValue.Name = "boxValue";
            this.boxValue.Size = new System.Drawing.Size(458, 20);
            this.boxValue.TabIndex = 6;
            this.boxValue.TextChanged += new System.EventHandler(this.boxValue_TextChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(13, 61);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 7;
            this.labelValue.Text = "Value";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkGithub.Location = new System.Drawing.Point(0, 0);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(115, 13);
            this.linkGithub.TabIndex = 8;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "BYML Editor on Github\r\n";
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            this.versionLabel.Location = new System.Drawing.Point(656, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(69, 13);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Version 0.1.1";
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // toXMLToolStripMenuItem
            // 
            this.toXMLToolStripMenuItem.Name = "toXMLToolStripMenuItem";
            this.toXMLToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.toXMLToolStripMenuItem.Text = "To XML";
            this.toXMLToolStripMenuItem.Click += new System.EventHandler(this.toXMLToolStripMenuItem_Click);
            // 
            // toJSONToolStripMenuItem
            // 
            this.toJSONToolStripMenuItem.Name = "toJSONToolStripMenuItem";
            this.toJSONToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
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
            this.linkByml.Size = new System.Drawing.Size(180, 22);
            this.linkByml.Text = "BYAML File Format";
            this.linkByml.Click += new System.EventHandler(this.bYMLFileFormatToolStripMenuItem_Click);
            // 
            // discordInvitesToolStripMenuItem
            // 
            this.discordInvitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordMarioInvite,
            this.zeldaDiscordInvite});
            this.discordInvitesToolStripMenuItem.Name = "discordInvitesToolStripMenuItem";
            this.discordInvitesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expandAllToolStripMenuItem.Text = "Expand all";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // masterTable
            // 
            this.masterTable.ColumnCount = 3;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.masterTable.Controls.Add(this.controlsTable, 1, 1);
            this.masterTable.Controls.Add(this.tree, 1, 0);
            this.masterTable.Controls.Add(this.linksPanel, 0, 2);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 24);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 3;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.masterTable.Size = new System.Drawing.Size(731, 657);
            this.masterTable.TabIndex = 10;
            this.masterTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // controlsTable
            // 
            this.controlsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlsTable.AutoSize = true;
            this.controlsTable.ColumnCount = 2;
            this.controlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.controlsTable.Controls.Add(this.labelType, 0, 1);
            this.controlsTable.Controls.Add(this.labelId, 0, 0);
            this.controlsTable.Controls.Add(this.boxId, 1, 0);
            this.controlsTable.Controls.Add(this.boxType, 1, 1);
            this.controlsTable.Controls.Add(this.labelValue, 0, 2);
            this.controlsTable.Controls.Add(this.boxValue, 1, 2);
            this.controlsTable.Location = new System.Drawing.Point(96, 536);
            this.controlsTable.Name = "controlsTable";
            this.controlsTable.Padding = new System.Windows.Forms.Padding(10);
            this.controlsTable.RowCount = 3;
            this.controlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.controlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.controlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.controlsTable.Size = new System.Drawing.Size(536, 98);
            this.controlsTable.TabIndex = 11;
            // 
            // linksPanel
            // 
            this.masterTable.SetColumnSpan(this.linksPanel, 3);
            this.linksPanel.Controls.Add(this.linkGithub);
            this.linksPanel.Controls.Add(this.versionLabel);
            this.linksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linksPanel.Location = new System.Drawing.Point(3, 640);
            this.linksPanel.Name = "linksPanel";
            this.linksPanel.Size = new System.Drawing.Size(725, 14);
            this.linksPanel.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 681);
            this.Controls.Add(this.masterTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Binary YAML Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.masterTable.ResumeLayout(false);
            this.masterTable.PerformLayout();
            this.controlsTable.ResumeLayout(false);
            this.controlsTable.PerformLayout();
            this.linksPanel.ResumeLayout(false);
            this.linksPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxType;
        private System.Windows.Forms.TextBox boxValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label versionLabel;
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
        private System.Windows.Forms.TableLayoutPanel masterTable;
        private System.Windows.Forms.TableLayoutPanel controlsTable;
        private System.Windows.Forms.Panel linksPanel;
    }
}

