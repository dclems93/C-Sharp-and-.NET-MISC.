namespace BuffetProject2
{
    partial class frmBuffetOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuffetOptions));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpDefauldBackgroundColor = new System.Windows.Forms.GroupBox();
            this.optBackgroundYellow = new System.Windows.Forms.RadioButton();
            this.optBackgroundGrey = new System.Windows.Forms.RadioButton();
            this.optBackgroundRed = new System.Windows.Forms.RadioButton();
            this.optBackgroundBlue = new System.Windows.Forms.RadioButton();
            this.cboBorderColors = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpDefauldBackgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(211, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(144, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(69, 9);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserName.Size = new System.Drawing.Size(120, 39);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "Enter Username...";
            // 
            // grpDefauldBackgroundColor
            // 
            this.grpDefauldBackgroundColor.BackColor = System.Drawing.Color.Transparent;
            this.grpDefauldBackgroundColor.Controls.Add(this.optBackgroundYellow);
            this.grpDefauldBackgroundColor.Controls.Add(this.optBackgroundGrey);
            this.grpDefauldBackgroundColor.Controls.Add(this.optBackgroundRed);
            this.grpDefauldBackgroundColor.Controls.Add(this.optBackgroundBlue);
            this.grpDefauldBackgroundColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpDefauldBackgroundColor.Location = new System.Drawing.Point(34, 80);
            this.grpDefauldBackgroundColor.Name = "grpDefauldBackgroundColor";
            this.grpDefauldBackgroundColor.Size = new System.Drawing.Size(187, 74);
            this.grpDefauldBackgroundColor.TabIndex = 4;
            this.grpDefauldBackgroundColor.TabStop = false;
            this.grpDefauldBackgroundColor.Text = "Options Default Background Color";
            // 
            // optBackgroundYellow
            // 
            this.optBackgroundYellow.Appearance = System.Windows.Forms.Appearance.Button;
            this.optBackgroundYellow.AutoSize = true;
            this.optBackgroundYellow.ForeColor = System.Drawing.Color.Yellow;
            this.optBackgroundYellow.Location = new System.Drawing.Point(98, 45);
            this.optBackgroundYellow.Name = "optBackgroundYellow";
            this.optBackgroundYellow.Size = new System.Drawing.Size(48, 23);
            this.optBackgroundYellow.TabIndex = 3;
            this.optBackgroundYellow.TabStop = true;
            this.optBackgroundYellow.Text = "Yellow";
            this.optBackgroundYellow.UseVisualStyleBackColor = true;
            this.optBackgroundYellow.CheckedChanged += new System.EventHandler(this.optBackgroundYellow_CheckedChanged);
            // 
            // optBackgroundGrey
            // 
            this.optBackgroundGrey.Appearance = System.Windows.Forms.Appearance.Button;
            this.optBackgroundGrey.AutoSize = true;
            this.optBackgroundGrey.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.optBackgroundGrey.Location = new System.Drawing.Point(98, 19);
            this.optBackgroundGrey.Name = "optBackgroundGrey";
            this.optBackgroundGrey.Size = new System.Drawing.Size(48, 23);
            this.optBackgroundGrey.TabIndex = 2;
            this.optBackgroundGrey.TabStop = true;
            this.optBackgroundGrey.Text = "  Grey ";
            this.optBackgroundGrey.UseVisualStyleBackColor = true;
            this.optBackgroundGrey.CheckedChanged += new System.EventHandler(this.optBackgroundGrey_CheckedChanged);
            // 
            // optBackgroundRed
            // 
            this.optBackgroundRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.optBackgroundRed.AutoSize = true;
            this.optBackgroundRed.ForeColor = System.Drawing.Color.Red;
            this.optBackgroundRed.Location = new System.Drawing.Point(44, 45);
            this.optBackgroundRed.Name = "optBackgroundRed";
            this.optBackgroundRed.Size = new System.Drawing.Size(49, 23);
            this.optBackgroundRed.TabIndex = 1;
            this.optBackgroundRed.TabStop = true;
            this.optBackgroundRed.Text = "  Red  ";
            this.optBackgroundRed.UseVisualStyleBackColor = true;
            this.optBackgroundRed.CheckedChanged += new System.EventHandler(this.optBackgroundRed_CheckedChanged);
            // 
            // optBackgroundBlue
            // 
            this.optBackgroundBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.optBackgroundBlue.AutoSize = true;
            this.optBackgroundBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.optBackgroundBlue.Location = new System.Drawing.Point(45, 19);
            this.optBackgroundBlue.Name = "optBackgroundBlue";
            this.optBackgroundBlue.Size = new System.Drawing.Size(47, 23);
            this.optBackgroundBlue.TabIndex = 0;
            this.optBackgroundBlue.TabStop = true;
            this.optBackgroundBlue.Text = "  Blue ";
            this.optBackgroundBlue.UseVisualStyleBackColor = true;
            this.optBackgroundBlue.CheckedChanged += new System.EventHandler(this.optBackgroundBlue_CheckedChanged);
            // 
            // cboBorderColors
            // 
            this.cboBorderColors.FormattingEnabled = true;
            this.cboBorderColors.Items.AddRange(new object[] {
            "Default",
            "Cyan",
            "Red",
            "Green",
            "Yellow",
            "Orange"});
            this.cboBorderColors.Location = new System.Drawing.Point(74, 174);
            this.cboBorderColors.Name = "cboBorderColors";
            this.cboBorderColors.Size = new System.Drawing.Size(121, 21);
            this.cboBorderColors.TabIndex = 0;
            this.cboBorderColors.Text = "Border Colors";
            this.cboBorderColors.SelectedIndexChanged += new System.EventHandler(this.cboBorderColors_SelectedIndexChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(69, 54);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxPassword.Size = new System.Drawing.Size(120, 20);
            this.tbxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(11, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // frmBuffetOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::BuffetProject2.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.cboBorderColors);
            this.Controls.Add(this.grpDefauldBackgroundColor);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmBuffetOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buffet Options";
            this.Load += new System.EventHandler(this.frmBuffetOptions_Load);
            this.grpDefauldBackgroundColor.ResumeLayout(false);
            this.grpDefauldBackgroundColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpDefauldBackgroundColor;
        private System.Windows.Forms.RadioButton optBackgroundYellow;
        private System.Windows.Forms.RadioButton optBackgroundGrey;
        private System.Windows.Forms.RadioButton optBackgroundRed;
        private System.Windows.Forms.RadioButton optBackgroundBlue;
        private System.Windows.Forms.ComboBox cboBorderColors;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}