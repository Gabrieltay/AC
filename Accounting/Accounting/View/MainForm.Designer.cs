namespace Accounting.View
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
            this.mStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mTotalRecordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mNewButton = new System.Windows.Forms.ToolStripButton();
            this.mOpenButton = new System.Windows.Forms.ToolStripButton();
            this.mSaveButton = new System.Windows.Forms.ToolStripButton();
            this.mFilterTxtbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mCodeButton = new System.Windows.Forms.ToolStripButton();
            this.Filter = new System.Windows.Forms.ToolStripButton();
            this.mAddButton = new System.Windows.Forms.ToolStripButton();
            this.mTransactionsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mAboutButton = new System.Windows.Forms.ToolStripButton();
            this.mOLVMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mMainPanel = new System.Windows.Forms.Panel();
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.mTransactionTabPage = new System.Windows.Forms.TabPage();
            this.mLogPage = new System.Windows.Forms.TabPage();
            this.mGenericTab = new System.Windows.Forms.TabPage();
            this.mHotItemStyle = new BrightIdeasSoftware.HotItemStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mImportCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mExportCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveCSVFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mOpenCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mBalancesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mTransactionOLV = new Accounting.Controls.TransactionOLV();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mStatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mOLVMenuStrip.SuspendLayout();
            this.mMainPanel.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.mTransactionTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTransactionOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // mStatusStrip
            // 
            this.mStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStatusLabel,
            this.toolStripStatusLabel1,
            this.mTotalRecordsLabel,
            this.mBalancesLabel});
            this.mStatusStrip.Location = new System.Drawing.Point(0, 658);
            this.mStatusStrip.Name = "mStatusStrip";
            this.mStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mStatusStrip.Size = new System.Drawing.Size(1632, 25);
            this.mStatusStrip.SizingGrip = false;
            this.mStatusStrip.TabIndex = 0;
            this.mStatusStrip.Text = "statusStrip1";
            // 
            // mStatusLabel
            // 
            this.mStatusLabel.Name = "mStatusLabel";
            this.mStatusLabel.Size = new System.Drawing.Size(50, 20);
            this.mStatusLabel.Text = "Ready";
            // 
            // mTotalRecordsLabel
            // 
            this.mTotalRecordsLabel.Name = "mTotalRecordsLabel";
            this.mTotalRecordsLabel.Size = new System.Drawing.Size(110, 20);
            this.mTotalRecordsLabel.Text = "Total Records : ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNewButton,
            this.mOpenButton,
            this.mSaveButton,
            this.mFilterTxtbox,
            this.toolStripSeparator4,
            this.mCodeButton,
            this.Filter,
            this.mAddButton,
            this.mTransactionsButton,
            this.toolStripButton1,
            this.mAboutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1632, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mNewButton
            // 
            this.mNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mNewButton.Image = global::Accounting.Properties.Resources._new;
            this.mNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mNewButton.Name = "mNewButton";
            this.mNewButton.Size = new System.Drawing.Size(24, 34);
            this.mNewButton.Text = "New Profile";
            this.mNewButton.Click += new System.EventHandler(this.mNewButton_Click);
            // 
            // mOpenButton
            // 
            this.mOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mOpenButton.Image = global::Accounting.Properties.Resources.openHS;
            this.mOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mOpenButton.Name = "mOpenButton";
            this.mOpenButton.Size = new System.Drawing.Size(24, 34);
            this.mOpenButton.Text = "Open Profile";
            this.mOpenButton.Click += new System.EventHandler(this.mOpenButton_Click);
            // 
            // mSaveButton
            // 
            this.mSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mSaveButton.Image = global::Accounting.Properties.Resources.saveHS;
            this.mSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSaveButton.Name = "mSaveButton";
            this.mSaveButton.Size = new System.Drawing.Size(24, 34);
            this.mSaveButton.Text = "Save File";
            this.mSaveButton.Click += new System.EventHandler(this.mSaveButton_Click);
            // 
            // mFilterTxtbox
            // 
            this.mFilterTxtbox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mFilterTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mFilterTxtbox.Margin = new System.Windows.Forms.Padding(1, 10, 15, 0);
            this.mFilterTxtbox.Name = "mFilterTxtbox";
            this.mFilterTxtbox.Size = new System.Drawing.Size(199, 27);
            this.mFilterTxtbox.TextChanged += new System.EventHandler(this.mFilterTxtbox_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // mCodeButton
            // 
            this.mCodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mCodeButton.Image = ((System.Drawing.Image)(resources.GetObject("mCodeButton.Image")));
            this.mCodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mCodeButton.Name = "mCodeButton";
            this.mCodeButton.Size = new System.Drawing.Size(24, 34);
            this.mCodeButton.Text = "GL Code Maintenance";
            this.mCodeButton.Click += new System.EventHandler(this.mCodeButton_Click);
            // 
            // Filter
            // 
            this.Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Filter.Image = global::Accounting.Properties.Resources.Filter2HS;
            this.Filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(24, 34);
            this.Filter.Text = "Filter";
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // mAddButton
            // 
            this.mAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAddButton.Image = global::Accounting.Properties.Resources.add;
            this.mAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mAddButton.Name = "mAddButton";
            this.mAddButton.Size = new System.Drawing.Size(24, 34);
            this.mAddButton.Text = "Add Record";
            this.mAddButton.Click += new System.EventHandler(this.mAddButton_Click);
            // 
            // mTransactionsButton
            // 
            this.mTransactionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mTransactionsButton.Image = global::Accounting.Properties.Resources.adds;
            this.mTransactionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mTransactionsButton.Name = "mTransactionsButton";
            this.mTransactionsButton.Size = new System.Drawing.Size(24, 34);
            this.mTransactionsButton.Text = "Add Transactions";
            this.mTransactionsButton.Click += new System.EventHandler(this.mTransactionsButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // mAboutButton
            // 
            this.mAboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAboutButton.Image = global::Accounting.Properties.Resources.About;
            this.mAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mAboutButton.Name = "mAboutButton";
            this.mAboutButton.Size = new System.Drawing.Size(24, 34);
            this.mAboutButton.Text = "About";
            this.mAboutButton.ToolTipText = "About";
            this.mAboutButton.Click += new System.EventHandler(this.mAboutButton_Click);
            // 
            // mOLVMenuStrip
            // 
            this.mOLVMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mOLVMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.mOLVMenuStrip.Name = "mOLVMenuStrip";
            this.mOLVMenuStrip.Size = new System.Drawing.Size(129, 88);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mSaveFileDialog
            // 
            this.mSaveFileDialog.DefaultExt = "rtd";
            this.mSaveFileDialog.Filter = "\"rtd files (*.rtd)|*.rtd|All files (*.*)|*.*\"";
            this.mSaveFileDialog.RestoreDirectory = true;
            this.mSaveFileDialog.Title = "Save Profile";
            // 
            // mOpenFileDialog
            // 
            this.mOpenFileDialog.DefaultExt = "rtd";
            this.mOpenFileDialog.Filter = "\"rtd (*.rtd)|*.rtd|csv (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.mOpenFileDialog.RestoreDirectory = true;
            // 
            // mMainPanel
            // 
            this.mMainPanel.Controls.Add(this.mTabControl);
            this.mMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mMainPanel.Location = new System.Drawing.Point(0, 65);
            this.mMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mMainPanel.Name = "mMainPanel";
            this.mMainPanel.Size = new System.Drawing.Size(1632, 593);
            this.mMainPanel.TabIndex = 5;
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.mTransactionTabPage);
            this.mTabControl.Controls.Add(this.mLogPage);
            this.mTabControl.Controls.Add(this.mGenericTab);
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControl.Location = new System.Drawing.Point(0, 0);
            this.mTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(1632, 593);
            this.mTabControl.TabIndex = 0;
            // 
            // mTransactionTabPage
            // 
            this.mTransactionTabPage.Controls.Add(this.mTransactionOLV);
            this.mTransactionTabPage.Location = new System.Drawing.Point(4, 25);
            this.mTransactionTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.mTransactionTabPage.Name = "mTransactionTabPage";
            this.mTransactionTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.mTransactionTabPage.Size = new System.Drawing.Size(1624, 564);
            this.mTransactionTabPage.TabIndex = 0;
            this.mTransactionTabPage.Text = "Transactions";
            this.mTransactionTabPage.UseVisualStyleBackColor = true;
            // 
            // mLogPage
            // 
            this.mLogPage.Location = new System.Drawing.Point(4, 25);
            this.mLogPage.Margin = new System.Windows.Forms.Padding(4);
            this.mLogPage.Name = "mLogPage";
            this.mLogPage.Padding = new System.Windows.Forms.Padding(4);
            this.mLogPage.Size = new System.Drawing.Size(1624, 564);
            this.mLogPage.TabIndex = 1;
            this.mLogPage.Text = "Log";
            this.mLogPage.UseVisualStyleBackColor = true;
            // 
            // mGenericTab
            // 
            this.mGenericTab.Location = new System.Drawing.Point(4, 25);
            this.mGenericTab.Margin = new System.Windows.Forms.Padding(4);
            this.mGenericTab.Name = "mGenericTab";
            this.mGenericTab.Padding = new System.Windows.Forms.Padding(4);
            this.mGenericTab.Size = new System.Drawing.Size(1624, 564);
            this.mGenericTab.TabIndex = 2;
            this.mGenericTab.Text = "Generic";
            this.mGenericTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1632, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.mOpenMenuItem,
            this.mSaveMenuItem,
            this.mSaveAsMenuItem,
            this.toolStripSeparator1,
            this.mImportCSVMenuItem,
            this.mExportCSVMenuItem,
            this.toolStripSeparator3,
            this.mExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mProfileMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // mProfileMenuItem
            // 
            this.mProfileMenuItem.Name = "mProfileMenuItem";
            this.mProfileMenuItem.Size = new System.Drawing.Size(127, 26);
            this.mProfileMenuItem.Text = "Profile";
            this.mProfileMenuItem.Click += new System.EventHandler(this.mProfileMenuItem_Click);
            // 
            // mOpenMenuItem
            // 
            this.mOpenMenuItem.Name = "mOpenMenuItem";
            this.mOpenMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mOpenMenuItem.Text = "Open";
            this.mOpenMenuItem.Click += new System.EventHandler(this.mOpenMenuItem_Click);
            // 
            // mSaveMenuItem
            // 
            this.mSaveMenuItem.Name = "mSaveMenuItem";
            this.mSaveMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mSaveMenuItem.Text = "Save";
            this.mSaveMenuItem.Click += new System.EventHandler(this.mSaveMenuItem_Click);
            // 
            // mSaveAsMenuItem
            // 
            this.mSaveAsMenuItem.Name = "mSaveAsMenuItem";
            this.mSaveAsMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mSaveAsMenuItem.Text = "Save As...";
            this.mSaveAsMenuItem.Click += new System.EventHandler(this.mSaveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // mImportCSVMenuItem
            // 
            this.mImportCSVMenuItem.Name = "mImportCSVMenuItem";
            this.mImportCSVMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mImportCSVMenuItem.Text = "Import CSV";
            this.mImportCSVMenuItem.Click += new System.EventHandler(this.mImportCSVMenuItem_Click);
            // 
            // mExportCSVMenuItem
            // 
            this.mExportCSVMenuItem.Name = "mExportCSVMenuItem";
            this.mExportCSVMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mExportCSVMenuItem.Text = "Export CSV";
            this.mExportCSVMenuItem.Click += new System.EventHandler(this.mExportCSVMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // mExitMenuItem
            // 
            this.mExitMenuItem.Name = "mExitMenuItem";
            this.mExitMenuItem.Size = new System.Drawing.Size(159, 26);
            this.mExitMenuItem.Text = "Exit";
            this.mExitMenuItem.Click += new System.EventHandler(this.mExitMenuItem_Click);
            // 
            // mSaveCSVFileDialog
            // 
            this.mSaveCSVFileDialog.CheckPathExists = false;
            this.mSaveCSVFileDialog.DefaultExt = "csv";
            this.mSaveCSVFileDialog.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.mSaveCSVFileDialog.RestoreDirectory = true;
            this.mSaveCSVFileDialog.Title = "Export to CSV";
            // 
            // mOpenCSVFileDialog
            // 
            this.mOpenCSVFileDialog.DefaultExt = "csv";
            this.mOpenCSVFileDialog.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.mOpenCSVFileDialog.Title = "Import From CSV";
            // 
            // mBalancesLabel
            // 
            this.mBalancesLabel.Name = "mBalancesLabel";
            this.mBalancesLabel.Size = new System.Drawing.Size(68, 20);
            this.mBalancesLabel.Text = "Balance :";
            // 
            // mTransactionOLV
            // 
            this.mTransactionOLV.AllowDrop = true;
            this.mTransactionOLV.ContextMenuStrip = this.mOLVMenuStrip;
            this.mTransactionOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTransactionOLV.Location = new System.Drawing.Point(4, 4);
            this.mTransactionOLV.Margin = new System.Windows.Forms.Padding(4);
            this.mTransactionOLV.Name = "mTransactionOLV";
            this.mTransactionOLV.Size = new System.Drawing.Size(1616, 556);
            this.mTransactionOLV.TabIndex = 0;
            this.mTransactionOLV.UseCompatibleStateImageBehavior = false;
            this.mTransactionOLV.View = System.Windows.Forms.View.Details;
            this.mTransactionOLV.DragDrop += new System.Windows.Forms.DragEventHandler(this.mTransactionOLV_DragDrop);
            this.mTransactionOLV.DragEnter += new System.Windows.Forms.DragEventHandler(this.mTransactionOLV_DragEnter);
            this.mTransactionOLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTransactionOLV_KeyDown);
            this.mTransactionOLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mTransactionOLV_MouseDoubleClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1384, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 683);
            this.Controls.Add(this.mMainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.mStatusStrip.ResumeLayout(false);
            this.mStatusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mOLVMenuStrip.ResumeLayout(false);
            this.mMainPanel.ResumeLayout(false);
            this.mTabControl.ResumeLayout(false);
            this.mTransactionTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTransactionOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mStatusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mAddButton;
        private System.Windows.Forms.ToolStripButton mSaveButton;
        private System.Windows.Forms.SaveFileDialog mSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialog;
        private System.Windows.Forms.ToolStripButton mOpenButton;
        private System.Windows.Forms.ContextMenuStrip mOLVMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel mMainPanel;
        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.TabPage mTransactionTabPage;
        private System.Windows.Forms.TabPage mLogPage;
        private BrightIdeasSoftware.HotItemStyle mHotItemStyle;
        private System.Windows.Forms.TabPage mGenericTab;
        private Accounting.Controls.TransactionOLV mTransactionOLV;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel mStatusLabel;
        private System.Windows.Forms.ToolStripTextBox mFilterTxtbox;
        private System.Windows.Forms.ToolStripButton mCodeButton;
        private System.Windows.Forms.ToolStripButton mTransactionsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mImportCSVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mExportCSVMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mExitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog mSaveCSVFileDialog;
        private System.Windows.Forms.OpenFileDialog mOpenCSVFileDialog;
        private System.Windows.Forms.ToolStripButton mAboutButton;
        private System.Windows.Forms.ToolStripButton Filter;
        private System.Windows.Forms.ToolStripButton mNewButton;
        private System.Windows.Forms.ToolStripStatusLabel mTotalRecordsLabel;
        private System.Windows.Forms.ToolStripStatusLabel mBalancesLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

