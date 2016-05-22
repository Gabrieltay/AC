namespace Accounting.View
{
    partial class RecordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mGLCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mDescTxtbox = new System.Windows.Forms.TextBox();
            this.mAmtTxtbox = new System.Windows.Forms.TextBox();
            this.mAmountLabel = new System.Windows.Forms.Label();
            this.mOKButton = new System.Windows.Forms.Button();
            this.mDayTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mMthTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mYearTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mVoucherTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mChequeTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mRCodeDescLabel = new System.Windows.Forms.Label();
            this.mItemCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Date:\r\n(DD/MM/YY)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GL Code:";
            // 
            // mGLCodeTxtbox
            // 
            this.mGLCodeTxtbox.Location = new System.Drawing.Point(120, 113);
            this.mGLCodeTxtbox.Name = "mGLCodeTxtbox";
            this.mGLCodeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mGLCodeTxtbox.TabIndex = 5;
            this.mGLCodeTxtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mGLCodeTxtbox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // mDescTxtbox
            // 
            this.mDescTxtbox.Location = new System.Drawing.Point(120, 260);
            this.mDescTxtbox.Name = "mDescTxtbox";
            this.mDescTxtbox.Size = new System.Drawing.Size(297, 20);
            this.mDescTxtbox.TabIndex = 8;
            // 
            // mAmtTxtbox
            // 
            this.mAmtTxtbox.Location = new System.Drawing.Point(120, 316);
            this.mAmtTxtbox.Name = "mAmtTxtbox";
            this.mAmtTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mAmtTxtbox.TabIndex = 9;
            this.mAmtTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mAmtTxtbox_KeyPress);
            // 
            // mAmountLabel
            // 
            this.mAmountLabel.AutoSize = true;
            this.mAmountLabel.Location = new System.Drawing.Point(59, 319);
            this.mAmountLabel.Name = "mAmountLabel";
            this.mAmountLabel.Size = new System.Drawing.Size(55, 13);
            this.mAmountLabel.TabIndex = 11;
            this.mAmountLabel.Text = "Amount: $";
            // 
            // mOKButton
            // 
            this.mOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mOKButton.Location = new System.Drawing.Point(156, 363);
            this.mOKButton.Name = "mOKButton";
            this.mOKButton.Size = new System.Drawing.Size(123, 23);
            this.mOKButton.TabIndex = 10;
            this.mOKButton.Text = "Add";
            this.mOKButton.UseVisualStyleBackColor = true;
            this.mOKButton.Click += new System.EventHandler(this.mOKButton_Click);
            // 
            // mDayTxtbox
            // 
            this.mDayTxtbox.BeepOnError = true;
            this.mDayTxtbox.Location = new System.Drawing.Point(120, 17);
            this.mDayTxtbox.Mask = "00";
            this.mDayTxtbox.Name = "mDayTxtbox";
            this.mDayTxtbox.PromptChar = ' ';
            this.mDayTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mDayTxtbox.TabIndex = 1;
            // 
            // mMthTxtbox
            // 
            this.mMthTxtbox.BeepOnError = true;
            this.mMthTxtbox.Location = new System.Drawing.Point(170, 17);
            this.mMthTxtbox.Mask = "00";
            this.mMthTxtbox.Name = "mMthTxtbox";
            this.mMthTxtbox.PromptChar = ' ';
            this.mMthTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mMthTxtbox.TabIndex = 2;
            // 
            // mYearTxtbox
            // 
            this.mYearTxtbox.BeepOnError = true;
            this.mYearTxtbox.Location = new System.Drawing.Point(221, 17);
            this.mYearTxtbox.Mask = "00";
            this.mYearTxtbox.Name = "mYearTxtbox";
            this.mYearTxtbox.PromptChar = ' ';
            this.mYearTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mYearTxtbox.TabIndex = 3;
            // 
            // mVoucherTxtbox
            // 
            this.mVoucherTxtbox.Location = new System.Drawing.Point(120, 65);
            this.mVoucherTxtbox.Name = "mVoucherTxtbox";
            this.mVoucherTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mVoucherTxtbox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Voucher No:";
            // 
            // mChequeTxtbox
            // 
            this.mChequeTxtbox.Location = new System.Drawing.Point(120, 162);
            this.mChequeTxtbox.Name = "mChequeTxtbox";
            this.mChequeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mChequeTxtbox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cheque No:";
            // 
            // mRCodeDescLabel
            // 
            this.mRCodeDescLabel.AutoSize = true;
            this.mRCodeDescLabel.Location = new System.Drawing.Point(232, 116);
            this.mRCodeDescLabel.Name = "mRCodeDescLabel";
            this.mRCodeDescLabel.Size = new System.Drawing.Size(60, 13);
            this.mRCodeDescLabel.TabIndex = 17;
            this.mRCodeDescLabel.Text = "Description";
            // 
            // mItemCodeTxtbox
            // 
            this.mItemCodeTxtbox.Location = new System.Drawing.Point(120, 210);
            this.mItemCodeTxtbox.Name = "mItemCodeTxtbox";
            this.mItemCodeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mItemCodeTxtbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Item Code:";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 411);
            this.Controls.Add(this.mItemCodeTxtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mRCodeDescLabel);
            this.Controls.Add(this.mChequeTxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mVoucherTxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mYearTxtbox);
            this.Controls.Add(this.mMthTxtbox);
            this.Controls.Add(this.mDayTxtbox);
            this.Controls.Add(this.mOKButton);
            this.Controls.Add(this.mAmountLabel);
            this.Controls.Add(this.mAmtTxtbox);
            this.Controls.Add(this.mDescTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mGLCodeTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mGLCodeTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mDescTxtbox;
        private System.Windows.Forms.TextBox mAmtTxtbox;
        private System.Windows.Forms.Label mAmountLabel;
        private System.Windows.Forms.Button mOKButton;
        private System.Windows.Forms.MaskedTextBox mDayTxtbox;
        private System.Windows.Forms.MaskedTextBox mMthTxtbox;
        private System.Windows.Forms.MaskedTextBox mYearTxtbox;
        private System.Windows.Forms.TextBox mVoucherTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mChequeTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mRCodeDescLabel;
        private System.Windows.Forms.TextBox mItemCodeTxtbox;
        private System.Windows.Forms.Label label8;
    }
}