namespace BuffetProject2
{
    partial class frmBuffetCollection
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCollection = new System.Windows.Forms.Label();
            this.btnControlNames = new System.Windows.Forms.Button();
            this.btnGreenButton = new System.Windows.Forms.Button();
            this.btnOrangButton = new System.Windows.Forms.Button();
            this.btnBlueButton = new System.Windows.Forms.Button();
            this.btnRedButton = new System.Windows.Forms.Button();
            this.lblColoredButtons = new System.Windows.Forms.Label();
            this.txtYellowTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.ForeColor = System.Drawing.Color.Green;
            this.btnOkay.Location = new System.Drawing.Point(221, 226);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(50, 23);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(155, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.BackColor = System.Drawing.Color.Transparent;
            this.lblCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCollection.Location = new System.Drawing.Point(96, 9);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(98, 25);
            this.lblCollection.TabIndex = 2;
            this.lblCollection.Text = "Collection";
            // 
            // btnControlNames
            // 
            this.btnControlNames.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnControlNames.Location = new System.Drawing.Point(179, 163);
            this.btnControlNames.Name = "btnControlNames";
            this.btnControlNames.Size = new System.Drawing.Size(93, 44);
            this.btnControlNames.TabIndex = 3;
            this.btnControlNames.Text = "Show Control Names";
            this.btnControlNames.UseVisualStyleBackColor = true;
            this.btnControlNames.Click += new System.EventHandler(this.btnControlNames_Click);
            // 
            // btnGreenButton
            // 
            this.btnGreenButton.ForeColor = System.Drawing.Color.Green;
            this.btnGreenButton.Location = new System.Drawing.Point(129, 117);
            this.btnGreenButton.Name = "btnGreenButton";
            this.btnGreenButton.Size = new System.Drawing.Size(65, 23);
            this.btnGreenButton.TabIndex = 4;
            this.btnGreenButton.Text = "Green";
            this.btnGreenButton.UseVisualStyleBackColor = true;
            // 
            // btnOrangButton
            // 
            this.btnOrangButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrangButton.Location = new System.Drawing.Point(206, 117);
            this.btnOrangButton.Name = "btnOrangButton";
            this.btnOrangButton.Size = new System.Drawing.Size(65, 23);
            this.btnOrangButton.TabIndex = 5;
            this.btnOrangButton.Text = "Orange";
            this.btnOrangButton.UseVisualStyleBackColor = true;
            // 
            // btnBlueButton
            // 
            this.btnBlueButton.ForeColor = System.Drawing.Color.Blue;
            this.btnBlueButton.Location = new System.Drawing.Point(129, 88);
            this.btnBlueButton.Name = "btnBlueButton";
            this.btnBlueButton.Size = new System.Drawing.Size(65, 23);
            this.btnBlueButton.TabIndex = 6;
            this.btnBlueButton.Text = "Blue";
            this.btnBlueButton.UseVisualStyleBackColor = true;
            // 
            // btnRedButton
            // 
            this.btnRedButton.ForeColor = System.Drawing.Color.Red;
            this.btnRedButton.Location = new System.Drawing.Point(206, 88);
            this.btnRedButton.Name = "btnRedButton";
            this.btnRedButton.Size = new System.Drawing.Size(65, 23);
            this.btnRedButton.TabIndex = 7;
            this.btnRedButton.Text = "Red Button";
            this.btnRedButton.UseVisualStyleBackColor = true;
            // 
            // lblColoredButtons
            // 
            this.lblColoredButtons.AutoSize = true;
            this.lblColoredButtons.BackColor = System.Drawing.Color.Transparent;
            this.lblColoredButtons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColoredButtons.Location = new System.Drawing.Point(152, 61);
            this.lblColoredButtons.Name = "lblColoredButtons";
            this.lblColoredButtons.Size = new System.Drawing.Size(85, 13);
            this.lblColoredButtons.TabIndex = 8;
            this.lblColoredButtons.Text = "Colored Buttons:";
            // 
            // txtYellowTextbox
            // 
            this.txtYellowTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYellowTextbox.Location = new System.Drawing.Point(25, 228);
            this.txtYellowTextbox.Name = "txtYellowTextbox";
            this.txtYellowTextbox.Size = new System.Drawing.Size(87, 20);
            this.txtYellowTextbox.TabIndex = 9;
            this.txtYellowTextbox.Text = "A yellow textbox";
            // 
            // frmBuffetCollection
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::BuffetProject2.Properties.Resources.thumb_1920_676506;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtYellowTextbox);
            this.Controls.Add(this.lblColoredButtons);
            this.Controls.Add(this.btnRedButton);
            this.Controls.Add(this.btnBlueButton);
            this.Controls.Add(this.btnOrangButton);
            this.Controls.Add(this.btnGreenButton);
            this.Controls.Add(this.btnControlNames);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuffetCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBuffetCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Button btnControlNames;
        private System.Windows.Forms.Button btnGreenButton;
        private System.Windows.Forms.Button btnOrangButton;
        private System.Windows.Forms.Button btnBlueButton;
        private System.Windows.Forms.Button btnRedButton;
        private System.Windows.Forms.Label lblColoredButtons;
        private System.Windows.Forms.TextBox txtYellowTextbox;
    }
}