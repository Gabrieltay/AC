namespace Accounting.View
{
    partial class DisplayTBForm
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
            this.mCreditLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mDebitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mBalanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mTrialBalanceOLV = new Accounting.Controls.TrialBalanceOLV();
            this.mTotalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrialBalanceOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTotalLabel,
            this.mCreditLabel,
            this.mDebitLabel,
            this.mBalanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mCreditLabel
            // 
            this.mCreditLabel.Name = "mCreditLabel";
            this.mCreditLabel.Size = new System.Drawing.Size(45, 17);
            this.mCreditLabel.Text = "Credit :";
            // 
            // mDebitLabel
            // 
            this.mDebitLabel.Name = "mDebitLabel";
            this.mDebitLabel.Size = new System.Drawing.Size(41, 17);
            this.mDebitLabel.Text = "Debit :";
            // 
            // mBalanceLabel
            // 
            this.mBalanceLabel.Name = "mBalanceLabel";
            this.mBalanceLabel.Size = new System.Drawing.Size(54, 17);
            this.mBalanceLabel.Text = "Balance :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mTrialBalanceOLV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 563);
            this.panel1.TabIndex = 2;
            // 
            // mTrialBalanceOLV
            // 
            this.mTrialBalanceOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrialBalanceOLV.Location = new System.Drawing.Point(0, 0);
            this.mTrialBalanceOLV.Name = "mTrialBalanceOLV";
            this.mTrialBalanceOLV.Size = new System.Drawing.Size(730, 563);
            this.mTrialBalanceOLV.TabIndex = 0;
            this.mTrialBalanceOLV.UseCompatibleStateImageBehavior = false;
            this.mTrialBalanceOLV.View = System.Windows.Forms.View.Details;
            // 
            // mTotalLabel
            // 
            this.mTotalLabel.Name = "mTotalLabel";
            this.mTotalLabel.Size = new System.Drawing.Size(79, 17);
            this.mTotalLabel.Text = "Total Codes : ";
            // 
            // DisplayTBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DisplayTBForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DisplayTBForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mTrialBalanceOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controls.TrialBalanceOLV mTrialBalanceOLV;
        private System.Windows.Forms.ToolStripStatusLabel mCreditLabel;
        private System.Windows.Forms.ToolStripStatusLabel mDebitLabel;
        private System.Windows.Forms.ToolStripStatusLabel mBalanceLabel;
        private System.Windows.Forms.ToolStripStatusLabel mTotalLabel;
    }
}