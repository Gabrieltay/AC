namespace Accounting.View
{
    partial class FilterForm
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
            this.mFilterListbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mAllRButton = new System.Windows.Forms.RadioButton();
            this.mMonthRButton = new System.Windows.Forms.RadioButton();
            this.mMonthComboBox = new System.Windows.Forms.ComboBox();
            this.mYearComboBox = new System.Windows.Forms.ComboBox();
            this.mRangeRButton = new System.Windows.Forms.RadioButton();
            this.mToLabel = new System.Windows.Forms.Label();
            this.mFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.mToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.mFilterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mCodeOLV = new Accounting.Controls.CodeOLV();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mAllButton = new System.Windows.Forms.Button();
            this.mClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCodeOLV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFilterListbox
            // 
            this.mFilterListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mFilterListbox.FormattingEnabled = true;
            this.mFilterListbox.Items.AddRange(new object[] {
            "Transactions",
            "Trial Balance",
            "PL"});
            this.mFilterListbox.Location = new System.Drawing.Point(13, 13);
            this.mFilterListbox.Name = "mFilterListbox";
            this.mFilterListbox.Size = new System.Drawing.Size(192, 537);
            this.mFilterListbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.mFilterButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(213, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 537);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mToDatePicker);
            this.groupBox1.Controls.Add(this.mFromDatePicker);
            this.groupBox1.Controls.Add(this.mToLabel);
            this.groupBox1.Controls.Add(this.mRangeRButton);
            this.groupBox1.Controls.Add(this.mYearComboBox);
            this.groupBox1.Controls.Add(this.mMonthComboBox);
            this.groupBox1.Controls.Add(this.mMonthRButton);
            this.groupBox1.Controls.Add(this.mAllRButton);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Selection";
            // 
            // mAllRButton
            // 
            this.mAllRButton.AutoSize = true;
            this.mAllRButton.Checked = true;
            this.mAllRButton.Location = new System.Drawing.Point(7, 20);
            this.mAllRButton.Name = "mAllRButton";
            this.mAllRButton.Size = new System.Drawing.Size(36, 17);
            this.mAllRButton.TabIndex = 0;
            this.mAllRButton.TabStop = true;
            this.mAllRButton.Text = "All";
            this.mAllRButton.UseVisualStyleBackColor = true;
            this.mAllRButton.CheckedChanged += new System.EventHandler(this.mAllRButton_CheckedChanged);
            // 
            // mMonthRButton
            // 
            this.mMonthRButton.AutoSize = true;
            this.mMonthRButton.Location = new System.Drawing.Point(7, 58);
            this.mMonthRButton.Name = "mMonthRButton";
            this.mMonthRButton.Size = new System.Drawing.Size(102, 17);
            this.mMonthRButton.TabIndex = 1;
            this.mMonthRButton.TabStop = true;
            this.mMonthRButton.Text = "Specified Month";
            this.mMonthRButton.UseVisualStyleBackColor = true;
            this.mMonthRButton.CheckedChanged += new System.EventHandler(this.mMonthRButton_CheckedChanged);
            // 
            // mMonthComboBox
            // 
            this.mMonthComboBox.Enabled = false;
            this.mMonthComboBox.FormattingEnabled = true;
            this.mMonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.mMonthComboBox.Location = new System.Drawing.Point(125, 57);
            this.mMonthComboBox.Name = "mMonthComboBox";
            this.mMonthComboBox.Size = new System.Drawing.Size(81, 21);
            this.mMonthComboBox.TabIndex = 2;
            this.mMonthComboBox.Text = "December";
            // 
            // mYearComboBox
            // 
            this.mYearComboBox.Enabled = false;
            this.mYearComboBox.FormattingEnabled = true;
            this.mYearComboBox.Location = new System.Drawing.Point(212, 57);
            this.mYearComboBox.Name = "mYearComboBox";
            this.mYearComboBox.Size = new System.Drawing.Size(56, 21);
            this.mYearComboBox.TabIndex = 3;
            this.mYearComboBox.Text = "2014";
            // 
            // mRangeRButton
            // 
            this.mRangeRButton.AutoSize = true;
            this.mRangeRButton.Location = new System.Drawing.Point(7, 102);
            this.mRangeRButton.Name = "mRangeRButton";
            this.mRangeRButton.Size = new System.Drawing.Size(57, 17);
            this.mRangeRButton.TabIndex = 4;
            this.mRangeRButton.TabStop = true;
            this.mRangeRButton.Text = "Range";
            this.mRangeRButton.UseVisualStyleBackColor = true;
            this.mRangeRButton.CheckedChanged += new System.EventHandler(this.mRangeRButton_CheckedChanged);
            // 
            // mToLabel
            // 
            this.mToLabel.AutoSize = true;
            this.mToLabel.Enabled = false;
            this.mToLabel.Location = new System.Drawing.Point(286, 102);
            this.mToLabel.Name = "mToLabel";
            this.mToLabel.Size = new System.Drawing.Size(20, 13);
            this.mToLabel.TabIndex = 2;
            this.mToLabel.Text = "To";
            // 
            // mFromDatePicker
            // 
            this.mFromDatePicker.Enabled = false;
            this.mFromDatePicker.Location = new System.Drawing.Point(80, 98);
            this.mFromDatePicker.Name = "mFromDatePicker";
            this.mFromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.mFromDatePicker.TabIndex = 1;
            // 
            // mToDatePicker
            // 
            this.mToDatePicker.Enabled = false;
            this.mToDatePicker.Location = new System.Drawing.Point(312, 98);
            this.mToDatePicker.Name = "mToDatePicker";
            this.mToDatePicker.Size = new System.Drawing.Size(200, 20);
            this.mToDatePicker.TabIndex = 5;
            // 
            // mFilterButton
            // 
            this.mFilterButton.Location = new System.Drawing.Point(479, 511);
            this.mFilterButton.Name = "mFilterButton";
            this.mFilterButton.Size = new System.Drawing.Size(75, 23);
            this.mFilterButton.TabIndex = 1;
            this.mFilterButton.Text = "Filter";
            this.mFilterButton.UseVisualStyleBackColor = true;
            this.mFilterButton.Click += new System.EventHandler(this.mFilterButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mClearButton);
            this.groupBox2.Controls.Add(this.mAllButton);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(4, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GL Code";
            // 
            // mCodeOLV
            // 
            this.mCodeOLV.CheckBoxes = true;
            this.mCodeOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCodeOLV.Location = new System.Drawing.Point(0, 0);
            this.mCodeOLV.Name = "mCodeOLV";
            this.mCodeOLV.Size = new System.Drawing.Size(537, 161);
            this.mCodeOLV.TabIndex = 0;
            this.mCodeOLV.UseCompatibleStateImageBehavior = false;
            this.mCodeOLV.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mCodeOLV);
            this.panel2.Location = new System.Drawing.Point(7, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 161);
            this.panel2.TabIndex = 0;
            // 
            // mAllButton
            // 
            this.mAllButton.Location = new System.Drawing.Point(6, 187);
            this.mAllButton.Name = "mAllButton";
            this.mAllButton.Size = new System.Drawing.Size(75, 23);
            this.mAllButton.TabIndex = 1;
            this.mAllButton.Text = "All";
            this.mAllButton.UseVisualStyleBackColor = true;
            this.mAllButton.Click += new System.EventHandler(this.mAllButton_Click);
            // 
            // mClearButton
            // 
            this.mClearButton.Location = new System.Drawing.Point(87, 187);
            this.mClearButton.Name = "mClearButton";
            this.mClearButton.Size = new System.Drawing.Size(75, 23);
            this.mClearButton.TabIndex = 3;
            this.mClearButton.Text = "Clear";
            this.mClearButton.UseVisualStyleBackColor = true;
            this.mClearButton.Click += new System.EventHandler(this.mClearButton_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mFilterListbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mCodeOLV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mFilterListbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mYearComboBox;
        private System.Windows.Forms.ComboBox mMonthComboBox;
        private System.Windows.Forms.RadioButton mMonthRButton;
        private System.Windows.Forms.RadioButton mAllRButton;
        private System.Windows.Forms.Label mToLabel;
        private System.Windows.Forms.RadioButton mRangeRButton;
        private System.Windows.Forms.DateTimePicker mFromDatePicker;
        private System.Windows.Forms.DateTimePicker mToDatePicker;
        private System.Windows.Forms.Button mFilterButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.CodeOLV mCodeOLV;
        private System.Windows.Forms.Button mClearButton;
        private System.Windows.Forms.Button mAllButton;
        private System.Windows.Forms.Panel panel2;
    }
}