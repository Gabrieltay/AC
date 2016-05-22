namespace Accounting.View
{
    partial class TransactionsForm
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
            this.mRCodeDescLabel = new System.Windows.Forms.Label();
            this.mChequeTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mVoucherTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mYearTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mMthTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mDayTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.mOKButton = new System.Windows.Forms.Button();
            this.mAmountLabel = new System.Windows.Forms.Label();
            this.mAmtTxtbox = new System.Windows.Forms.TextBox();
            this.mGLCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mDescTxtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.mBalTxtbox = new System.Windows.Forms.TextBox();
            this.mAutoRButton = new System.Windows.Forms.RadioButton();
            this.mSingleRButton = new System.Windows.Forms.RadioButton();
            this.mItemCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mOLV = new Accounting.Controls.TransactionOLV();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // mRCodeDescLabel
            // 
            this.mRCodeDescLabel.AutoSize = true;
            this.mRCodeDescLabel.Location = new System.Drawing.Point(201, 113);
            this.mRCodeDescLabel.Name = "mRCodeDescLabel";
            this.mRCodeDescLabel.Size = new System.Drawing.Size(60, 13);
            this.mRCodeDescLabel.TabIndex = 35;
            this.mRCodeDescLabel.Text = "Description";
            // 
            // mChequeTxtbox
            // 
            this.mChequeTxtbox.Location = new System.Drawing.Point(91, 62);
            this.mChequeTxtbox.Name = "mChequeTxtbox";
            this.mChequeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mChequeTxtbox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cheque No:";
            // 
            // mVoucherTxtbox
            // 
            this.mVoucherTxtbox.Location = new System.Drawing.Point(419, 13);
            this.mVoucherTxtbox.Name = "mVoucherTxtbox";
            this.mVoucherTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mVoucherTxtbox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Voucher No:";
            // 
            // mYearTxtbox
            // 
            this.mYearTxtbox.BeepOnError = true;
            this.mYearTxtbox.Location = new System.Drawing.Point(220, 13);
            this.mYearTxtbox.Mask = "00";
            this.mYearTxtbox.Name = "mYearTxtbox";
            this.mYearTxtbox.PromptChar = ' ';
            this.mYearTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mYearTxtbox.TabIndex = 21;
            // 
            // mMthTxtbox
            // 
            this.mMthTxtbox.BeepOnError = true;
            this.mMthTxtbox.Location = new System.Drawing.Point(169, 13);
            this.mMthTxtbox.Mask = "00";
            this.mMthTxtbox.Name = "mMthTxtbox";
            this.mMthTxtbox.PromptChar = ' ';
            this.mMthTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mMthTxtbox.TabIndex = 20;
            // 
            // mDayTxtbox
            // 
            this.mDayTxtbox.BeepOnError = true;
            this.mDayTxtbox.Location = new System.Drawing.Point(119, 13);
            this.mDayTxtbox.Mask = "00";
            this.mDayTxtbox.Name = "mDayTxtbox";
            this.mDayTxtbox.PromptChar = ' ';
            this.mDayTxtbox.Size = new System.Drawing.Size(28, 20);
            this.mDayTxtbox.TabIndex = 19;
            // 
            // mOKButton
            // 
            this.mOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mOKButton.Location = new System.Drawing.Point(392, 570);
            this.mOKButton.Name = "mOKButton";
            this.mOKButton.Size = new System.Drawing.Size(123, 23);
            this.mOKButton.TabIndex = 30;
            this.mOKButton.Text = "Add";
            this.mOKButton.UseVisualStyleBackColor = true;
            // 
            // mAmountLabel
            // 
            this.mAmountLabel.AutoSize = true;
            this.mAmountLabel.Location = new System.Drawing.Point(22, 341);
            this.mAmountLabel.Name = "mAmountLabel";
            this.mAmountLabel.Size = new System.Drawing.Size(55, 13);
            this.mAmountLabel.TabIndex = 32;
            this.mAmountLabel.Text = "Amount: $";
            // 
            // mAmtTxtbox
            // 
            this.mAmtTxtbox.Location = new System.Drawing.Point(89, 338);
            this.mAmtTxtbox.Name = "mAmtTxtbox";
            this.mAmtTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mAmtTxtbox.TabIndex = 28;
            this.mAmtTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mAmtTxtbox_KeyPress);
            // 
            // mGLCodeTxtbox
            // 
            this.mGLCodeTxtbox.Location = new System.Drawing.Point(89, 110);
            this.mGLCodeTxtbox.Name = "mGLCodeTxtbox";
            this.mGLCodeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mGLCodeTxtbox.TabIndex = 25;
            this.mGLCodeTxtbox.TextChanged += new System.EventHandler(this.mGLCodeTxtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "GL Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Transaction Date:\r\n(DD/MM/YY)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Description:";
            // 
            // mDescTxtbox
            // 
            this.mDescTxtbox.Location = new System.Drawing.Point(89, 215);
            this.mDescTxtbox.Multiline = true;
            this.mDescTxtbox.Name = "mDescTxtbox";
            this.mDescTxtbox.Size = new System.Drawing.Size(426, 98);
            this.mDescTxtbox.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mOLV);
            this.panel1.Location = new System.Drawing.Point(15, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 174);
            this.panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Balance: $";
            // 
            // mBalTxtbox
            // 
            this.mBalTxtbox.Location = new System.Drawing.Point(407, 338);
            this.mBalTxtbox.Name = "mBalTxtbox";
            this.mBalTxtbox.ReadOnly = true;
            this.mBalTxtbox.Size = new System.Drawing.Size(100, 20);
            this.mBalTxtbox.TabIndex = 38;
            this.mBalTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mAutoRButton
            // 
            this.mAutoRButton.AutoSize = true;
            this.mAutoRButton.Checked = true;
            this.mAutoRButton.Location = new System.Drawing.Point(220, 63);
            this.mAutoRButton.Name = "mAutoRButton";
            this.mAutoRButton.Size = new System.Drawing.Size(47, 17);
            this.mAutoRButton.TabIndex = 39;
            this.mAutoRButton.TabStop = true;
            this.mAutoRButton.Text = "Auto";
            this.mAutoRButton.UseVisualStyleBackColor = true;
            // 
            // mSingleRButton
            // 
            this.mSingleRButton.AutoSize = true;
            this.mSingleRButton.Location = new System.Drawing.Point(298, 63);
            this.mSingleRButton.Name = "mSingleRButton";
            this.mSingleRButton.Size = new System.Drawing.Size(54, 17);
            this.mSingleRButton.TabIndex = 40;
            this.mSingleRButton.TabStop = true;
            this.mSingleRButton.Text = "Single";
            this.mSingleRButton.UseVisualStyleBackColor = true;
            // 
            // mItemCodeTxtbox
            // 
            this.mItemCodeTxtbox.Location = new System.Drawing.Point(89, 162);
            this.mItemCodeTxtbox.Name = "mItemCodeTxtbox";
            this.mItemCodeTxtbox.Size = new System.Drawing.Size(96, 20);
            this.mItemCodeTxtbox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Item Code:";
            // 
            // mOLV
            // 
            this.mOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mOLV.Location = new System.Drawing.Point(0, 0);
            this.mOLV.Name = "mOLV";
            this.mOLV.Size = new System.Drawing.Size(501, 174);
            this.mOLV.TabIndex = 0;
            this.mOLV.UseCompatibleStateImageBehavior = false;
            this.mOLV.View = System.Windows.Forms.View.Details;
            this.mOLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mOLV_KeyDown);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 605);
            this.Controls.Add(this.mItemCodeTxtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mSingleRButton);
            this.Controls.Add(this.mAutoRButton);
            this.Controls.Add(this.mBalTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mGLCodeTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Transactions";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mRCodeDescLabel;
        private System.Windows.Forms.TextBox mChequeTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mVoucherTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mYearTxtbox;
        private System.Windows.Forms.MaskedTextBox mMthTxtbox;
        private System.Windows.Forms.MaskedTextBox mDayTxtbox;
        private System.Windows.Forms.Button mOKButton;
        private System.Windows.Forms.Label mAmountLabel;
        private System.Windows.Forms.TextBox mAmtTxtbox;
        private System.Windows.Forms.TextBox mGLCodeTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mDescTxtbox;
        private System.Windows.Forms.Panel panel1;
        private Accounting.Controls.TransactionOLV mOLV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mBalTxtbox;
        private System.Windows.Forms.RadioButton mAutoRButton;
        private System.Windows.Forms.RadioButton mSingleRButton;
        private System.Windows.Forms.TextBox mItemCodeTxtbox;
        private System.Windows.Forms.Label label9;
    }
}