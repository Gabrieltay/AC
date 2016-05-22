using System.Windows.Forms;
using Accounting.Model;

namespace Accounting.View
{
    partial class CodeForm
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
            this.DataModel.Unsubscribe( this.Observer );
            this.DataModel.Unsubscribe( this.FormObserver );
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mCImportButton = new System.Windows.Forms.ToolStripButton();
            this.mCExportButton = new System.Windows.Forms.ToolStripButton();
            this.mCTopPanel = new System.Windows.Forms.Panel();
            this.mCodeOLV = new Accounting.Controls.CodeOLV();
            this.mContextMenuStrp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCBotPanel = new System.Windows.Forms.Panel();
            this.mCAddBButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mCBalRButton = new System.Windows.Forms.RadioButton();
            this.mCIncomeRbutton = new System.Windows.Forms.RadioButton();
            this.mCDescTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mCCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mCClearButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.mCTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCodeOLV)).BeginInit();
            this.mContextMenuStrp.SuspendLayout();
            this.mCBotPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCImportButton,
            this.mCExportButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mCImportButton
            // 
            this.mCImportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mCImportButton.Image = global::Accounting.Properties.Resources.openHS;
            this.mCImportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mCImportButton.Name = "mCImportButton";
            this.mCImportButton.Size = new System.Drawing.Size(23, 22);
            this.mCImportButton.Text = "toolStripButton1";
            this.mCImportButton.ToolTipText = "Import";
            this.mCImportButton.Click += new System.EventHandler(this.mCImportButton_Click);
            // 
            // mCExportButton
            // 
            this.mCExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mCExportButton.Image = global::Accounting.Properties.Resources.saveHS;
            this.mCExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mCExportButton.Name = "mCExportButton";
            this.mCExportButton.Size = new System.Drawing.Size(23, 22);
            this.mCExportButton.Text = "Save";
            this.mCExportButton.ToolTipText = "Export";
            this.mCExportButton.Click += new System.EventHandler(this.mCExportButton_Click);
            // 
            // mCTopPanel
            // 
            this.mCTopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mCTopPanel.Controls.Add(this.mCodeOLV);
            this.mCTopPanel.Location = new System.Drawing.Point(13, 29);
            this.mCTopPanel.Name = "mCTopPanel";
            this.mCTopPanel.Size = new System.Drawing.Size(451, 379);
            this.mCTopPanel.TabIndex = 1;
            // 
            // mCodeOLV
            // 
            this.mCodeOLV.ContextMenuStrip = this.mContextMenuStrp;
            this.mCodeOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCodeOLV.Location = new System.Drawing.Point(0, 0);
            this.mCodeOLV.Name = "mCodeOLV";
            this.mCodeOLV.Size = new System.Drawing.Size(451, 379);
            this.mCodeOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mCodeOLV.TabIndex = 0;
            this.mCodeOLV.UseCompatibleStateImageBehavior = false;
            this.mCodeOLV.View = System.Windows.Forms.View.Details;
            this.mCodeOLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mCodeOLV_KeyDown);
            this.mCodeOLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mCodeOLV_MouseDoubleClick);
            // 
            // mContextMenuStrp
            // 
            this.mContextMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.mContextMenuStrp.Name = "mContextMenuStrp";
            this.mContextMenuStrp.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mCBotPanel
            // 
            this.mCBotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mCBotPanel.Controls.Add(this.mCClearButton);
            this.mCBotPanel.Controls.Add(this.mCAddBButton);
            this.mCBotPanel.Controls.Add(this.groupBox1);
            this.mCBotPanel.Controls.Add(this.mCDescTxtbox);
            this.mCBotPanel.Controls.Add(this.label2);
            this.mCBotPanel.Controls.Add(this.mCCodeTxtbox);
            this.mCBotPanel.Controls.Add(this.label1);
            this.mCBotPanel.Location = new System.Drawing.Point(13, 416);
            this.mCBotPanel.Name = "mCBotPanel";
            this.mCBotPanel.Size = new System.Drawing.Size(451, 146);
            this.mCBotPanel.TabIndex = 2;
            // 
            // mCAddBButton
            // 
            this.mCAddBButton.Location = new System.Drawing.Point(373, 110);
            this.mCAddBButton.Name = "mCAddBButton";
            this.mCAddBButton.Size = new System.Drawing.Size(75, 23);
            this.mCAddBButton.TabIndex = 5;
            this.mCAddBButton.Text = "Add";
            this.mCAddBButton.UseVisualStyleBackColor = true;
            this.mCAddBButton.Click += new System.EventHandler(this.mCAddBButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mCBalRButton);
            this.groupBox1.Controls.Add(this.mCIncomeRbutton);
            this.groupBox1.Location = new System.Drawing.Point(200, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type:";
            // 
            // mCBalRButton
            // 
            this.mCBalRButton.AutoSize = true;
            this.mCBalRButton.Location = new System.Drawing.Point(80, 42);
            this.mCBalRButton.Name = "mCBalRButton";
            this.mCBalRButton.Size = new System.Drawing.Size(95, 17);
            this.mCBalRButton.TabIndex = 1;
            this.mCBalRButton.Text = "Balance Sheet";
            this.mCBalRButton.UseVisualStyleBackColor = true;
            // 
            // mCIncomeRbutton
            // 
            this.mCIncomeRbutton.AutoSize = true;
            this.mCIncomeRbutton.Checked = true;
            this.mCIncomeRbutton.Location = new System.Drawing.Point(80, 19);
            this.mCIncomeRbutton.Name = "mCIncomeRbutton";
            this.mCIncomeRbutton.Size = new System.Drawing.Size(121, 17);
            this.mCIncomeRbutton.TabIndex = 0;
            this.mCIncomeRbutton.TabStop = true;
            this.mCIncomeRbutton.Text = "Income/Expenditure";
            this.mCIncomeRbutton.UseVisualStyleBackColor = true;
            // 
            // mCDescTxtbox
            // 
            this.mCDescTxtbox.Location = new System.Drawing.Point(84, 84);
            this.mCDescTxtbox.Name = "mCDescTxtbox";
            this.mCDescTxtbox.Size = new System.Drawing.Size(364, 20);
            this.mCDescTxtbox.TabIndex = 3;
            this.mCDescTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mCDescTxtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // mCCodeTxtbox
            // 
            this.mCCodeTxtbox.Location = new System.Drawing.Point(84, 38);
            this.mCCodeTxtbox.Name = "mCCodeTxtbox";
            this.mCCodeTxtbox.Size = new System.Drawing.Size(100, 20);
            this.mCCodeTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // mSaveFileDialog
            // 
            this.mSaveFileDialog.DefaultExt = "csv";
            this.mSaveFileDialog.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            // 
            // mOpenFileDialog
            // 
            this.mOpenFileDialog.DefaultExt = "csv";
            this.mOpenFileDialog.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.mOpenFileDialog.RestoreDirectory = true;
            // 
            // mCClearButton
            // 
            this.mCClearButton.Location = new System.Drawing.Point(292, 110);
            this.mCClearButton.Name = "mCClearButton";
            this.mCClearButton.Size = new System.Drawing.Size(75, 23);
            this.mCClearButton.TabIndex = 6;
            this.mCClearButton.Text = "Clear";
            this.mCClearButton.UseVisualStyleBackColor = true;
            this.mCClearButton.Click += new System.EventHandler(this.mCClearButton_Click);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 573);
            this.Controls.Add(this.mCBotPanel);
            this.Controls.Add(this.mCTopPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GL Code Maintenance";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mCTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mCodeOLV)).EndInit();
            this.mContextMenuStrp.ResumeLayout(false);
            this.mCBotPanel.ResumeLayout(false);
            this.mCBotPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mCExportButton;
        private System.Windows.Forms.Panel mCTopPanel;
        private System.Windows.Forms.Panel mCBotPanel;
        private Accounting.Controls.CodeOLV mCodeOLV;
        private GroupBox groupBox1;
        private RadioButton mCBalRButton;
        private RadioButton mCIncomeRbutton;
        private TextBox mCDescTxtbox;
        private Label label2;
        private TextBox mCCodeTxtbox;
        private Label label1;
        private Button mCAddBButton;
        private SaveFileDialog mSaveFileDialog;
        private ToolStripButton mCImportButton;
        private OpenFileDialog mOpenFileDialog;
        private ContextMenuStrip mContextMenuStrp;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button mCClearButton;
    }
}