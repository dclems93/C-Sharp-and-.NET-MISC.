namespace KeyBinder
{
    partial class frmKillingFloor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKillingFloor));
            this.ofdSelectConfigFileKFloor = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.lblSelectFile2 = new System.Windows.Forms.Label();
            this.lblSelectFile3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnApplyBindings = new System.Windows.Forms.Button();
            this.pbxKillingFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKillingFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdSelectConfigFileKFloor
            // 
            this.ofdSelectConfigFileKFloor.FileName = "openFileDialog1";
            this.ofdSelectConfigFileKFloor.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelectConfigFileKFloor_FileOk);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(29, 211);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(74, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Open";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelectFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectFile.Location = new System.Drawing.Point(26, 150);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(313, 17);
            this.lblSelectFile.TabIndex = 1;
            this.lblSelectFile.Text = "Please select the location of your KFInput.ini file.";
            // 
            // lblSelectFile2
            // 
            this.lblSelectFile2.AutoSize = true;
            this.lblSelectFile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectFile2.Location = new System.Drawing.Point(25, 171);
            this.lblSelectFile2.Name = "lblSelectFile2";
            this.lblSelectFile2.Size = new System.Drawing.Size(434, 13);
            this.lblSelectFile2.TabIndex = 2;
            this.lblSelectFile2.Text = "This is typically found in C:// ProgramFiles/Steam/steamapps/common/KillingFloor/" +
    "System";
            // 
            // lblSelectFile3
            // 
            this.lblSelectFile3.AutoSize = true;
            this.lblSelectFile3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectFile3.Location = new System.Drawing.Point(26, 184);
            this.lblSelectFile3.Name = "lblSelectFile3";
            this.lblSelectFile3.Size = new System.Drawing.Size(389, 13);
            this.lblSelectFile3.TabIndex = 3;
            this.lblSelectFile3.Text = "If no file exists, boot into the game and assign at least one value to generate o" +
    "ne.";
            // 
            // btnApplyBindings
            // 
            this.btnApplyBindings.AutoSize = true;
            this.btnApplyBindings.Location = new System.Drawing.Point(135, 211);
            this.btnApplyBindings.Name = "btnApplyBindings";
            this.btnApplyBindings.Size = new System.Drawing.Size(86, 23);
            this.btnApplyBindings.TabIndex = 5;
            this.btnApplyBindings.Text = "Apply Bindings";
            this.btnApplyBindings.UseVisualStyleBackColor = true;
            this.btnApplyBindings.Visible = false;
            this.btnApplyBindings.Click += new System.EventHandler(this.btnApplyBindings_Click);
            // 
            // pbxKillingFloor
            // 
            this.pbxKillingFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxKillingFloor.BackgroundImage")));
            this.pbxKillingFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKillingFloor.Location = new System.Drawing.Point(109, 12);
            this.pbxKillingFloor.Name = "pbxKillingFloor";
            this.pbxKillingFloor.Size = new System.Drawing.Size(277, 135);
            this.pbxKillingFloor.TabIndex = 6;
            this.pbxKillingFloor.TabStop = false;
            // 
            // frmKillingFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 801);
            this.Controls.Add(this.pbxKillingFloor);
            this.Controls.Add(this.btnApplyBindings);
            this.Controls.Add(this.lblSelectFile3);
            this.Controls.Add(this.lblSelectFile2);
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKillingFloor";
            this.Text = "Killing Floor";
            ((System.ComponentModel.ISupportInitialize)(this.pbxKillingFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectConfigFileKFloor;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Label lblSelectFile2;
        private System.Windows.Forms.Label lblSelectFile3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnApplyBindings;
        private System.Windows.Forms.PictureBox pbxKillingFloor;
    }
}