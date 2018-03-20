namespace BuffetProject2
{
    partial class frmBuffetMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuffetMain));
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnQuitApplication = new System.Windows.Forms.Button();
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnEnlargePicture = new System.Windows.Forms.Button();
            this.btnShrinkPicture = new System.Windows.Forms.Button();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            this.lblXPosn = new System.Windows.Forms.Label();
            this.lblYPosn = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkPromptExit = new System.Windows.Forms.CheckBox();
            this.lblWindowSize = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.cboPenColor = new System.Windows.Forms.ComboBox();
            this.chkDrawBorder = new System.Windows.Forms.CheckBox();
            this.btnCollection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPicture.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectPicture.Location = new System.Drawing.Point(320, 6);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(85, 23);
            this.btnSelectPicture.TabIndex = 0;
            this.btnSelectPicture.Text = "Select Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnQuitApplication
            // 
            this.btnQuitApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitApplication.ForeColor = System.Drawing.Color.Tomato;
            this.btnQuitApplication.Location = new System.Drawing.Point(481, 6);
            this.btnQuitApplication.Name = "btnQuitApplication";
            this.btnQuitApplication.Size = new System.Drawing.Size(52, 23);
            this.btnQuitApplication.TabIndex = 1;
            this.btnQuitApplication.Text = "Quit";
            this.btnQuitApplication.UseVisualStyleBackColor = true;
            this.btnQuitApplication.Click += new System.EventHandler(this.btnQuitApplication_Click);
            // 
            // picShowPicture
            // 
            this.picShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picShowPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowPicture.Location = new System.Drawing.Point(6, 6);
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.Size = new System.Drawing.Size(300, 300);
            this.picShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowPicture.TabIndex = 2;
            this.picShowPicture.TabStop = false;
            this.picShowPicture.SizeChanged += new System.EventHandler(this.picShowPicture_SizeChanged);
            this.picShowPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseClick);
            this.picShowPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseDown);
            this.picShowPicture.MouseLeave += new System.EventHandler(this.picShowPicture_MouseLeave);
            this.picShowPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseMove);
            this.picShowPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseUp);
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|JPEG|*.JPG";
            this.ofdSelectPicture.Title = "Select Picture";
            // 
            // btnEnlargePicture
            // 
            this.btnEnlargePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlargePicture.Location = new System.Drawing.Point(513, 268);
            this.btnEnlargePicture.Name = "btnEnlargePicture";
            this.btnEnlargePicture.Size = new System.Drawing.Size(21, 23);
            this.btnEnlargePicture.TabIndex = 3;
            this.btnEnlargePicture.Text = "↑";
            this.btnEnlargePicture.UseVisualStyleBackColor = true;
            this.btnEnlargePicture.Click += new System.EventHandler(this.btnEnlargeWindow_Click);
            // 
            // btnShrinkPicture
            // 
            this.btnShrinkPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShrinkPicture.Location = new System.Drawing.Point(513, 293);
            this.btnShrinkPicture.Name = "btnShrinkPicture";
            this.btnShrinkPicture.Size = new System.Drawing.Size(21, 23);
            this.btnShrinkPicture.TabIndex = 4;
            this.btnShrinkPicture.Text = "↓";
            this.btnShrinkPicture.UseVisualStyleBackColor = true;
            this.btnShrinkPicture.Click += new System.EventHandler(this.btnShrinkWindow_Click);
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrawBorder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDrawBorder.Location = new System.Drawing.Point(320, 35);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(85, 23);
            this.btnDrawBorder.TabIndex = 5;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = true;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // lblXPosn
            // 
            this.lblXPosn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXPosn.AutoSize = true;
            this.lblXPosn.BackColor = System.Drawing.Color.Transparent;
            this.lblXPosn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblXPosn.Location = new System.Drawing.Point(317, 268);
            this.lblXPosn.Name = "lblXPosn";
            this.lblXPosn.Size = new System.Drawing.Size(17, 13);
            this.lblXPosn.TabIndex = 6;
            this.lblXPosn.Text = "X:";
            // 
            // lblYPosn
            // 
            this.lblYPosn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYPosn.AutoSize = true;
            this.lblYPosn.BackColor = System.Drawing.Color.Transparent;
            this.lblYPosn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYPosn.Location = new System.Drawing.Point(317, 283);
            this.lblYPosn.Name = "lblYPosn";
            this.lblYPosn.Size = new System.Drawing.Size(17, 13);
            this.lblYPosn.TabIndex = 7;
            this.lblYPosn.Text = "Y:";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOptions.Location = new System.Drawing.Point(320, 204);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(67, 23);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkPromptExit
            // 
            this.chkPromptExit.AutoSize = true;
            this.chkPromptExit.Location = new System.Drawing.Point(403, 173);
            this.chkPromptExit.Name = "chkPromptExit";
            this.chkPromptExit.Size = new System.Drawing.Size(89, 17);
            this.chkPromptExit.TabIndex = 9;
            this.chkPromptExit.Text = "Exit (invisible)";
            this.chkPromptExit.UseVisualStyleBackColor = true;
            this.chkPromptExit.Visible = false;
            this.chkPromptExit.CheckedChanged += new System.EventHandler(this.chkPromptExit_CheckedChanged);
            // 
            // lblWindowSize
            // 
            this.lblWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowSize.AutoSize = true;
            this.lblWindowSize.BackColor = System.Drawing.Color.Transparent;
            this.lblWindowSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindowSize.Location = new System.Drawing.Point(441, 283);
            this.lblWindowSize.Name = "lblWindowSize";
            this.lblWindowSize.Size = new System.Drawing.Size(72, 13);
            this.lblWindowSize.TabIndex = 10;
            this.lblWindowSize.Text = "Window Size:";
            // 
            // lblPenColor
            // 
            this.lblPenColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.BackColor = System.Drawing.Color.Transparent;
            this.lblPenColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPenColor.Location = new System.Drawing.Point(317, 88);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(56, 13);
            this.lblPenColor.TabIndex = 11;
            this.lblPenColor.Text = "Pen Color:";
            this.lblPenColor.Click += new System.EventHandler(this.lblPenColor_Click);
            // 
            // cboPenColor
            // 
            this.cboPenColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPenColor.FormattingEnabled = true;
            this.cboPenColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black"});
            this.cboPenColor.Location = new System.Drawing.Point(320, 104);
            this.cboPenColor.Name = "cboPenColor";
            this.cboPenColor.Size = new System.Drawing.Size(61, 21);
            this.cboPenColor.TabIndex = 12;
            this.cboPenColor.SelectedIndexChanged += new System.EventHandler(this.cboPenColor_SelectedIndexChanged);
            // 
            // chkDrawBorder
            // 
            this.chkDrawBorder.AutoSize = true;
            this.chkDrawBorder.Location = new System.Drawing.Point(403, 150);
            this.chkDrawBorder.Name = "chkDrawBorder";
            this.chkDrawBorder.Size = new System.Drawing.Size(131, 17);
            this.chkDrawBorder.TabIndex = 13;
            this.chkDrawBorder.Text = "Draw Border (invisible)";
            this.chkDrawBorder.UseVisualStyleBackColor = true;
            this.chkDrawBorder.Visible = false;
            this.chkDrawBorder.CheckedChanged += new System.EventHandler(this.chkDrawBorder_CheckedChanged);
            // 
            // btnCollection
            // 
            this.btnCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollection.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCollection.Location = new System.Drawing.Point(320, 233);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(67, 23);
            this.btnCollection.TabIndex = 14;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // frmBuffetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::BuffetProject2.Properties.Resources.thumb_1920_521477;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 321);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.chkDrawBorder);
            this.Controls.Add(this.cboPenColor);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.lblWindowSize);
            this.Controls.Add(this.chkPromptExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblYPosn);
            this.Controls.Add(this.lblXPosn);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.btnShrinkPicture);
            this.Controls.Add(this.btnEnlargePicture);
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.btnQuitApplication);
            this.Controls.Add(this.btnSelectPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(505, 360);
            this.Name = "frmBuffetMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Buffet Project";
            this.Load += new System.EventHandler(this.frmBuffetMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnQuitApplication;
        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
        private System.Windows.Forms.Button btnEnlargePicture;
        private System.Windows.Forms.Button btnShrinkPicture;
        private System.Windows.Forms.Button btnDrawBorder;
        private System.Windows.Forms.Label lblXPosn;
        private System.Windows.Forms.Label lblYPosn;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkPromptExit;
        private System.Windows.Forms.Label lblWindowSize;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.ComboBox cboPenColor;
        private System.Windows.Forms.CheckBox chkDrawBorder;
        private System.Windows.Forms.Button btnCollection;
    }
}

