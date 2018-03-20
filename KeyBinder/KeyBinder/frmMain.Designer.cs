namespace KeyBinder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pbxBinderLogo = new System.Windows.Forms.PictureBox();
            this.lblSelectGame = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKillingFloor = new System.Windows.Forms.Button();
            this.btnKillingFloor2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBinderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "KeyBinder";
            // 
            // pbxBinderLogo
            // 
            this.pbxBinderLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBinderLogo.BackgroundImage")));
            this.pbxBinderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBinderLogo.Location = new System.Drawing.Point(29, 12);
            this.pbxBinderLogo.Name = "pbxBinderLogo";
            this.pbxBinderLogo.Size = new System.Drawing.Size(84, 83);
            this.pbxBinderLogo.TabIndex = 2;
            this.pbxBinderLogo.TabStop = false;
            // 
            // lblSelectGame
            // 
            this.lblSelectGame.AutoSize = true;
            this.lblSelectGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectGame.Location = new System.Drawing.Point(27, 137);
            this.lblSelectGame.Name = "lblSelectGame";
            this.lblSelectGame.Size = new System.Drawing.Size(256, 13);
            this.lblSelectGame.TabIndex = 3;
            this.lblSelectGame.Text = "Please select a game you want to assign bindings to:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 120);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(29, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 120);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnKillingFloor
            // 
            this.btnKillingFloor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKillingFloor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKillingFloor.Location = new System.Drawing.Point(347, 216);
            this.btnKillingFloor.Name = "btnKillingFloor";
            this.btnKillingFloor.Size = new System.Drawing.Size(91, 23);
            this.btnKillingFloor.TabIndex = 8;
            this.btnKillingFloor.Text = "Killing Floor";
            this.btnKillingFloor.UseVisualStyleBackColor = false;
            this.btnKillingFloor.Click += new System.EventHandler(this.btnKillingFloor_Click);
            // 
            // btnKillingFloor2
            // 
            this.btnKillingFloor2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKillingFloor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKillingFloor2.Location = new System.Drawing.Point(347, 367);
            this.btnKillingFloor2.Name = "btnKillingFloor2";
            this.btnKillingFloor2.Size = new System.Drawing.Size(91, 23);
            this.btnKillingFloor2.TabIndex = 9;
            this.btnKillingFloor2.Text = "Killing Floor 2";
            this.btnKillingFloor2.UseVisualStyleBackColor = false;
            this.btnKillingFloor2.Click += new System.EventHandler(this.btnKillingFloor2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(383, 461);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(470, 496);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnKillingFloor2);
            this.Controls.Add(this.btnKillingFloor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelectGame);
            this.Controls.Add(this.pbxBinderLogo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "KeyBinder";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBinderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBinderLogo;
        private System.Windows.Forms.Label lblSelectGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKillingFloor;
        private System.Windows.Forms.Button btnKillingFloor2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnQuit;
    }
}

