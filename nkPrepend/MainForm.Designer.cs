
namespace nkPrepend
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel loadedFilesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fileCountToolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.ToolStripMenuItem padWithZerosToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ColumnHeader fileColumnHeader;
        private System.Windows.Forms.ContextMenuStrip fileListViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.padWithZerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.loadedFilesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.fileCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.browseButton = new System.Windows.Forms.Button();
        	this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.renameButton = new System.Windows.Forms.Button();
        	this.copyButton = new System.Windows.Forms.Button();
        	this.moveButton = new System.Windows.Forms.Button();
        	this.fileListView = new System.Windows.Forms.ListView();
        	this.fileColumnHeader = new System.Windows.Forms.ColumnHeader();
        	this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.fileListViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.buttonTableLayoutPanel.SuspendLayout();
        	this.fileListViewContextMenuStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.optionsToolStripMenuItem,
			this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
        	this.mainMenuStrip.TabIndex = 45;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newToolStripMenuItem,
			this.toolStripSeparator,
			this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.alwaysOnTopToolStripMenuItem,
			this.padWithZerosToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// padWithZerosToolStripMenuItem
        	// 
        	this.padWithZerosToolStripMenuItem.Name = "padWithZerosToolStripMenuItem";
        	this.padWithZerosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
        	this.padWithZerosToolStripMenuItem.Text = "&Pad with zeros";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.freeReleasesPublicDomainisToolStripMenuItem,
			this.originalThreadDonationCodercomToolStripMenuItem,
			this.sourceCodeGithubcomToolStripMenuItem,
			this.toolStripSeparator2,
			this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// freeReleasesPublicDomainisToolStripMenuItem
        	// 
        	this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnOnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.loadedFilesToolStripStatusLabel,
			this.fileCountToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 324);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 44;
        	// 
        	// loadedFilesToolStripStatusLabel
        	// 
        	this.loadedFilesToolStripStatusLabel.Name = "loadedFilesToolStripStatusLabel";
        	this.loadedFilesToolStripStatusLabel.Size = new System.Drawing.Size(73, 17);
        	this.loadedFilesToolStripStatusLabel.Text = "Loaded files:";
        	// 
        	// fileCountToolStripStatusLabel
        	// 
        	this.fileCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.fileCountToolStripStatusLabel.Name = "fileCountToolStripStatusLabel";
        	this.fileCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.fileCountToolStripStatusLabel.Text = "0";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 1;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.Controls.Add(this.browseButton, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.fileListView, 0, 1);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 3;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 300);
        	this.mainTableLayoutPanel.TabIndex = 46;
        	// 
        	// browseButton
        	// 
        	this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.browseButton.Location = new System.Drawing.Point(3, 3);
        	this.browseButton.Name = "browseButton";
        	this.browseButton.Size = new System.Drawing.Size(278, 29);
        	this.browseButton.TabIndex = 0;
        	this.browseButton.Text = "&Browse for directory";
        	this.browseButton.UseVisualStyleBackColor = true;
        	this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
        	// 
        	// buttonTableLayoutPanel
        	// 
        	this.buttonTableLayoutPanel.ColumnCount = 3;
        	this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        	this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        	this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        	this.buttonTableLayoutPanel.Controls.Add(this.renameButton, 0, 0);
        	this.buttonTableLayoutPanel.Controls.Add(this.copyButton, 1, 0);
        	this.buttonTableLayoutPanel.Controls.Add(this.moveButton, 2, 0);
        	this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.buttonTableLayoutPanel.Location = new System.Drawing.Point(0, 265);
        	this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
        	this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
        	this.buttonTableLayoutPanel.RowCount = 1;
        	this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.buttonTableLayoutPanel.Size = new System.Drawing.Size(284, 35);
        	this.buttonTableLayoutPanel.TabIndex = 2;
        	// 
        	// renameButton
        	// 
        	this.renameButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.renameButton.Enabled = false;
        	this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.renameButton.Location = new System.Drawing.Point(3, 3);
        	this.renameButton.Name = "renameButton";
        	this.renameButton.Size = new System.Drawing.Size(88, 29);
        	this.renameButton.TabIndex = 2;
        	this.renameButton.Text = "&Rename";
        	this.renameButton.UseVisualStyleBackColor = true;
        	this.renameButton.Click += new System.EventHandler(this.OnRenameButtonClick);
        	// 
        	// copyButton
        	// 
        	this.copyButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyButton.Enabled = false;
        	this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyButton.Location = new System.Drawing.Point(97, 3);
        	this.copyButton.Name = "copyButton";
        	this.copyButton.Size = new System.Drawing.Size(88, 29);
        	this.copyButton.TabIndex = 3;
        	this.copyButton.Text = "&Copy";
        	this.copyButton.UseVisualStyleBackColor = true;
        	this.copyButton.Click += new System.EventHandler(this.OnCopyButtonClick);
        	// 
        	// moveButton
        	// 
        	this.moveButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.moveButton.Enabled = false;
        	this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.moveButton.Location = new System.Drawing.Point(191, 3);
        	this.moveButton.Name = "moveButton";
        	this.moveButton.Size = new System.Drawing.Size(90, 29);
        	this.moveButton.TabIndex = 4;
        	this.moveButton.Text = "&Move";
        	this.moveButton.UseVisualStyleBackColor = true;
        	this.moveButton.Click += new System.EventHandler(this.OnMoveButtonClick);
        	// 
        	// fileListView
        	// 
        	this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.fileColumnHeader});
        	this.fileListView.ContextMenuStrip = this.fileListViewContextMenuStrip;
        	this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fileListView.Location = new System.Drawing.Point(3, 38);
        	this.fileListView.Name = "fileListView";
        	this.fileListView.Size = new System.Drawing.Size(278, 224);
        	this.fileListView.TabIndex = 3;
        	this.fileListView.UseCompatibleStateImageBehavior = false;
        	this.fileListView.View = System.Windows.Forms.View.Details;
        	this.fileListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFileListViewMouseDown);
        	this.fileListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnFileListViewMouseMove);
        	this.fileListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFileListViewMouseUp);
        	// 
        	// fileColumnHeader
        	// 
        	this.fileColumnHeader.Text = "Files";
        	this.fileColumnHeader.Width = 250;
        	// 
        	// fileListViewContextMenuStrip
        	// 
        	this.fileListViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deleteToolStripMenuItem});
        	this.fileListViewContextMenuStrip.Name = "fileListViewContextMenuStrip";
        	this.fileListViewContextMenuStrip.Size = new System.Drawing.Size(153, 48);
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.deleteToolStripMenuItem.Text = "&Delete";
        	this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteToolStripMenuItemClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 346);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "nkPrepend";
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.buttonTableLayoutPanel.ResumeLayout(false);
        	this.fileListViewContextMenuStrip.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}
