namespace KeyBinder
{
    partial class frmKillingFloor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKillingFloor2));
            this.btnApplyBindings = new System.Windows.Forms.Button();
            this.lblSelectFile3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.ofdSelectConfigFileKFloor2 = new System.Windows.Forms.OpenFileDialog();
            this.pbxKillingFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKillingFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApplyBindings
            // 
            this.btnApplyBindings.AutoSize = true;
            this.btnApplyBindings.Location = new System.Drawing.Point(135, 211);
            this.btnApplyBindings.Name = "btnApplyBindings";
            this.btnApplyBindings.Size = new System.Drawing.Size(86, 23);
            this.btnApplyBindings.TabIndex = 11;
            this.btnApplyBindings.Text = "Apply Bindings";
            this.btnApplyBindings.UseVisualStyleBackColor = true;
            this.btnApplyBindings.Visible = false;
            this.btnApplyBindings.Click += new System.EventHandler(this.btnApplyBindings_Click);
            // 
            // lblSelectFile3
            // 
            this.lblSelectFile3.AutoSize = true;
            this.lblSelectFile3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectFile3.Location = new System.Drawing.Point(25, 185);
            this.lblSelectFile3.Name = "lblSelectFile3";
            this.lblSelectFile3.Size = new System.Drawing.Size(389, 13);
            this.lblSelectFile3.TabIndex = 9;
            this.lblSelectFile3.Text = "If no file exists, boot into the game and assign at least one value to generate o" +
    "ne.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "This is typically found in C:// Documents/My Games/KillingFloor2/KFGame/Config";
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelectFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectFile.Location = new System.Drawing.Point(25, 151);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(295, 17);
            this.lblSelectFile.TabIndex = 7;
            this.lblSelectFile.Text = "Please select the location of your User.ini file.";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(29, 211);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(74, 23);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Open";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // ofdSelectConfigFileKFloor2
            // 
            this.ofdSelectConfigFileKFloor2.FileName = "openFileDialog1";
            // 
            // pbxKillingFloor
            // 
            this.pbxKillingFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxKillingFloor.BackgroundImage")));
            this.pbxKillingFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKillingFloor.Location = new System.Drawing.Point(94, 11);
            this.pbxKillingFloor.Name = "pbxKillingFloor";
            this.pbxKillingFloor.Size = new System.Drawing.Size(334, 137);
            this.pbxKillingFloor.TabIndex = 12;
            this.pbxKillingFloor.TabStop = false;
            // 
            // frmKillingFloor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 801);
            this.Controls.Add(this.pbxKillingFloor);
            this.Controls.Add(this.btnApplyBindings);
            this.Controls.Add(this.lblSelectFile3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKillingFloor2";
            this.Text = "Killing Floor 2";
            ((System.ComponentModel.ISupportInitialize)(this.pbxKillingFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApplyBindings;
        private System.Windows.Forms.Label lblSelectFile3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog ofdSelectConfigFileKFloor2;
        private System.Windows.Forms.PictureBox pbxKillingFloor;
    }
}