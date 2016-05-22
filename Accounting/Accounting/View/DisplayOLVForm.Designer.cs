namespace Accounting.View
{
    partial class DisplayOLVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mDateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mTotalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mCreditLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mDebitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mBalanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mTransactionOLV = new Accounting.Controls.TransactionOLV();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTransactionOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1493, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDateStatusLabel,
            this.toolStripStatusLabel1,
            this.mTotalLabel,
            this.mCreditLabel,
            this.mDebitLabel,
            this.mBalanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 969);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1493, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mDateStatusLabel
            // 
            this.mDateStatusLabel.Name = "mDateStatusLabel";
            this.mDateStatusLabel.Size = new System.Drawing.Size(52, 20);
            this.mDateStatusLabel.Text = "Date : ";
            // 
            // mTotalLabel
            // 
            this.mTotalLabel.Name = "mTotalLabel";
            this.mTotalLabel.Size = new System.Drawing.Size(110, 20);
            this.mTotalLabel.Text = "Total Records : ";
            // 
            // mCreditLabel
            // 
            this.mCreditLabel.Name = "mCreditLabel";
            this.mCreditLabel.Size = new System.Drawing.Size(60, 20);
            this.mCreditLabel.Text = "Credit : ";
            // 
            // mDebitLabel
            // 
            this.mDebitLabel.Name = "mDebitLabel";
            this.mDebitLabel.Size = new System.Drawing.Size(57, 20);
            this.mDebitLabel.Text = "Debit : ";
            // 
            // mBalanceLabel
            // 
            this.mBalanceLabel.Name = "mBalanceLabel";
            this.mBalanceLabel.Size = new System.Drawing.Size(72, 20);
            this.mBalanceLabel.Text = "Balance : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mTransactionOLV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 944);
            this.panel1.TabIndex = 2;
            // 
            // mTransactionOLV
            // 
            this.mTransactionOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTransactionOLV.Location = new System.Drawing.Point(0, 0);
            this.mTransactionOLV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTransactionOLV.Name = "mTransactionOLV";
            this.mTransactionOLV.Size = new System.Drawing.Size(1493, 944);
            this.mTransactionOLV.TabIndex = 0;
            this.mTransactionOLV.UseCompatibleStateImageBehavior = false;
            this.mTransactionOLV.View = System.Windows.Forms.View.Details;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1083, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // DisplayOLVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 994);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisplayOLVForm";
            this.Text = "Display";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mTransactionOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controls.TransactionOLV mTransactionOLV;
        private System.Windows.Forms.ToolStripStatusLabel mDateStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mTotalLabel;
        private System.Windows.Forms.ToolStripStatusLabel mBalanceLabel;
        private System.Windows.Forms.ToolStripStatusLabel mCreditLabel;
        private System.Windows.Forms.ToolStripStatusLabel mDebitLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}