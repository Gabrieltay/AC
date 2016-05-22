namespace Accounting.View
{
    partial class ProfileForm
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
            this.mCreatePButton = new System.Windows.Forms.Button();
            this.mCancelPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mCoyNameTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mCreatePButton
            // 
            this.mCreatePButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mCreatePButton.Location = new System.Drawing.Point( 100, 76 );
            this.mCreatePButton.Name = "mCreatePButton";
            this.mCreatePButton.Size = new System.Drawing.Size( 75, 23 );
            this.mCreatePButton.TabIndex = 0;
            this.mCreatePButton.Text = "Create";
            this.mCreatePButton.UseVisualStyleBackColor = true;
            // 
            // mCancelPButton
            // 
            this.mCancelPButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mCancelPButton.Location = new System.Drawing.Point( 213, 76 );
            this.mCancelPButton.Name = "mCancelPButton";
            this.mCancelPButton.Size = new System.Drawing.Size( 75, 23 );
            this.mCancelPButton.TabIndex = 1;
            this.mCancelPButton.Text = "Cancel";
            this.mCancelPButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 9, 29 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 85, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name:";
            // 
            // mCoyNameTxtbox
            // 
            this.mCoyNameTxtbox.Location = new System.Drawing.Point( 100, 26 );
            this.mCoyNameTxtbox.Name = "mCoyNameTxtbox";
            this.mCoyNameTxtbox.Size = new System.Drawing.Size( 273, 20 );
            this.mCoyNameTxtbox.TabIndex = 3;
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.mCreatePButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mCancelPButton;
            this.ClientSize = new System.Drawing.Size( 385, 116 );
            this.Controls.Add( this.mCoyNameTxtbox );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.mCancelPButton );
            this.Controls.Add( this.mCreatePButton );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.ProfileForm_FormClosed );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mCreatePButton;
        private System.Windows.Forms.Button mCancelPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mCoyNameTxtbox;
    }
}