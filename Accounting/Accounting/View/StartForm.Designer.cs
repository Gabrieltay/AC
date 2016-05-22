namespace Accounting.View
{
    partial class StartForm
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
            this.mNewProfileButton = new System.Windows.Forms.Button();
            this.mOpenProfileButton = new System.Windows.Forms.Button();
            this.mOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mRecentListview = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mNewProfileButton
            // 
            this.mNewProfileButton.Location = new System.Drawing.Point( 12, 12 );
            this.mNewProfileButton.Name = "mNewProfileButton";
            this.mNewProfileButton.Size = new System.Drawing.Size( 100, 100 );
            this.mNewProfileButton.TabIndex = 0;
            this.mNewProfileButton.Text = "New Profile";
            this.mNewProfileButton.UseVisualStyleBackColor = true;
            this.mNewProfileButton.Click += new System.EventHandler( this.mNewProfileButton_Click );
            // 
            // mOpenProfileButton
            // 
            this.mOpenProfileButton.Location = new System.Drawing.Point( 12, 118 );
            this.mOpenProfileButton.Name = "mOpenProfileButton";
            this.mOpenProfileButton.Size = new System.Drawing.Size( 100, 100 );
            this.mOpenProfileButton.TabIndex = 1;
            this.mOpenProfileButton.Text = "Open Profile";
            this.mOpenProfileButton.UseVisualStyleBackColor = true;
            this.mOpenProfileButton.Click += new System.EventHandler( this.mOpenProfileButton_Click );
            // 
            // mOpenFileDialog
            // 
            this.mOpenFileDialog.DefaultExt = "rtd";
            this.mOpenFileDialog.Filter = "\"rtd (*.rtd)|*.rtd|All files (*.*)|*.*\"";
            this.mOpenFileDialog.RestoreDirectory = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.mRecentListview );
            this.groupBox1.Location = new System.Drawing.Point( 129, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 318, 206 );
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Files";
            // 
            // mRecentListview
            // 
            this.mRecentListview.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.mRecentListview.BackColor = System.Drawing.SystemColors.Menu;
            this.mRecentListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mRecentListview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mRecentListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mRecentListview.ForeColor = System.Drawing.Color.Blue;
            this.mRecentListview.HideSelection = false;
            this.mRecentListview.HotTracking = true;
            this.mRecentListview.HoverSelection = true;
            this.mRecentListview.Location = new System.Drawing.Point( 3, 16 );
            this.mRecentListview.MultiSelect = false;
            this.mRecentListview.Name = "mRecentListview";
            this.mRecentListview.Size = new System.Drawing.Size( 312, 187 );
            this.mRecentListview.TabIndex = 0;
            this.mRecentListview.UseCompatibleStateImageBehavior = false;
            this.mRecentListview.View = System.Windows.Forms.View.List;
            this.mRecentListview.ItemActivate += new System.EventHandler( this.mRecentListview_ItemActivate );
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 459, 228 );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.mOpenProfileButton );
            this.Controls.Add( this.mNewProfileButton );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software";
            this.groupBox1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button mNewProfileButton;
        private System.Windows.Forms.Button mOpenProfileButton;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView mRecentListview;
    }
}