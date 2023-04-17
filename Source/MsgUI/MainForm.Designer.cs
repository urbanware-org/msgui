namespace MsgUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbCertainUser = new System.Windows.Forms.TextBox();
            this.rbCertainUser = new System.Windows.Forms.RadioButton();
            this.rbAllUsers = new System.Windows.Forms.RadioButton();
            this.lblSendTo = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.lnkCopyCmd = new System.Windows.Forms.LinkLabel();
            this.lnkClearMessage = new System.Windows.Forms.LinkLabel();
            this.lblCharsLeft = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.rbSeconds = new System.Windows.Forms.RadioButton();
            this.rbHitsOK = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.gpDelay = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.rbExePath = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbMsgPath = new System.Windows.Forms.TextBox();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.btnLocalhost = new System.Windows.Forms.Button();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbUser.SuspendLayout();
            this.gbMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.gpDelay.SuspendLayout();
            this.rbExePath.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.tbCertainUser);
            this.gbUser.Controls.Add(this.rbCertainUser);
            this.gbUser.Controls.Add(this.rbAllUsers);
            this.gbUser.Controls.Add(this.lblSendTo);
            this.gbUser.Location = new System.Drawing.Point(12, 12);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(355, 66);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // tbCertainUser
            // 
            this.tbCertainUser.Enabled = false;
            this.tbCertainUser.Location = new System.Drawing.Point(165, 37);
            this.tbCertainUser.Name = "tbCertainUser";
            this.tbCertainUser.Size = new System.Drawing.Size(184, 21);
            this.tbCertainUser.TabIndex = 2;
            this.tbCertainUser.TextChanged += new System.EventHandler(this.tbCertainUser_TextChanged);
            // 
            // rbCertainUser
            // 
            this.rbCertainUser.AutoSize = true;
            this.rbCertainUser.Location = new System.Drawing.Point(71, 38);
            this.rbCertainUser.Name = "rbCertainUser";
            this.rbCertainUser.Size = new System.Drawing.Size(88, 17);
            this.rbCertainUser.TabIndex = 1;
            this.rbCertainUser.Text = "Certain user:";
            this.rbCertainUser.UseVisualStyleBackColor = true;
            this.rbCertainUser.CheckedChanged += new System.EventHandler(this.rbCertainUser_CheckedChanged);
            // 
            // rbAllUsers
            // 
            this.rbAllUsers.AutoSize = true;
            this.rbAllUsers.Checked = true;
            this.rbAllUsers.Location = new System.Drawing.Point(71, 15);
            this.rbAllUsers.Name = "rbAllUsers";
            this.rbAllUsers.Size = new System.Drawing.Size(157, 17);
            this.rbAllUsers.TabIndex = 0;
            this.rbAllUsers.TabStop = true;
            this.rbAllUsers.Text = "All currently logged in users";
            this.rbAllUsers.UseVisualStyleBackColor = true;
            // 
            // lblSendTo
            // 
            this.lblSendTo.AutoSize = true;
            this.lblSendTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendTo.Location = new System.Drawing.Point(6, 17);
            this.lblSendTo.Name = "lblSendTo";
            this.lblSendTo.Size = new System.Drawing.Size(56, 13);
            this.lblSendTo.TabIndex = 4;
            this.lblSendTo.Text = "Send to...";
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.lnkCopyCmd);
            this.gbMessage.Controls.Add(this.lnkClearMessage);
            this.gbMessage.Controls.Add(this.lblCharsLeft);
            this.gbMessage.Controls.Add(this.tbMessage);
            this.gbMessage.Controls.Add(this.tbCommand);
            this.gbMessage.Location = new System.Drawing.Point(12, 269);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(355, 239);
            this.gbMessage.TabIndex = 4;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lnkCopyCmd
            // 
            this.lnkCopyCmd.AutoSize = true;
            this.lnkCopyCmd.Location = new System.Drawing.Point(3, 220);
            this.lnkCopyCmd.Name = "lnkCopyCmd";
            this.lnkCopyCmd.Size = new System.Drawing.Size(139, 13);
            this.lnkCopyCmd.TabIndex = 2;
            this.lnkCopyCmd.TabStop = true;
            this.lnkCopyCmd.Text = "Copy command to clipboard";
            this.lnkCopyCmd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyCmd_LinkClicked);
            // 
            // lnkClearMessage
            // 
            this.lnkClearMessage.AutoSize = true;
            this.lnkClearMessage.Location = new System.Drawing.Point(3, 112);
            this.lnkClearMessage.Name = "lnkClearMessage";
            this.lnkClearMessage.Size = new System.Drawing.Size(100, 13);
            this.lnkClearMessage.TabIndex = 1;
            this.lnkClearMessage.TabStop = true;
            this.lnkClearMessage.Text = "Clear message text";
            this.lnkClearMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearMessage_LinkClicked);
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.Location = new System.Drawing.Point(244, 111);
            this.lblCharsLeft.Name = "lblCharsLeft";
            this.lblCharsLeft.Size = new System.Drawing.Size(105, 15);
            this.lblCharsLeft.TabIndex = 4;
            this.lblCharsLeft.Text = "240 characters left";
            this.lblCharsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 20);
            this.tbMessage.MaxLength = 240;
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(343, 89);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbCommand
            // 
            this.tbCommand.Enabled = false;
            this.tbCommand.Location = new System.Drawing.Point(6, 128);
            this.tbCommand.MaxLength = 240;
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommand.Size = new System.Drawing.Size(343, 89);
            this.tbCommand.TabIndex = 4;
            this.tbCommand.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(238, 514);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send message now";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Enabled = false;
            this.nudSeconds.Location = new System.Drawing.Point(292, 38);
            this.nudSeconds.Maximum = new decimal(new int[] {
            10800,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(57, 21);
            this.nudSeconds.TabIndex = 2;
            this.nudSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // rbSeconds
            // 
            this.rbSeconds.AutoSize = true;
            this.rbSeconds.Location = new System.Drawing.Point(107, 38);
            this.rbSeconds.Name = "rbSeconds";
            this.rbSeconds.Size = new System.Drawing.Size(187, 17);
            this.rbSeconds.TabIndex = 1;
            this.rbSeconds.Text = "For time in seconds (default is 60)";
            this.rbSeconds.UseVisualStyleBackColor = true;
            this.rbSeconds.CheckedChanged += new System.EventHandler(this.rbSeconds_CheckedChanged);
            // 
            // rbHitsOK
            // 
            this.rbHitsOK.AutoSize = true;
            this.rbHitsOK.Checked = true;
            this.rbHitsOK.Location = new System.Drawing.Point(107, 15);
            this.rbHitsOK.Name = "rbHitsOK";
            this.rbHitsOK.Size = new System.Drawing.Size(232, 17);
            this.rbHitsOK.TabIndex = 0;
            this.rbHitsOK.TabStop = true;
            this.rbHitsOK.Text = "Without delay (until user confirms via \"OK\")";
            this.rbHitsOK.UseVisualStyleBackColor = true;
            this.rbHitsOK.CheckedChanged += new System.EventHandler(this.rbHitsOK_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(3, 17);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(98, 13);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Display message...";
            // 
            // gpDelay
            // 
            this.gpDelay.Controls.Add(this.nudSeconds);
            this.gpDelay.Controls.Add(this.lblDisplay);
            this.gpDelay.Controls.Add(this.rbSeconds);
            this.gpDelay.Controls.Add(this.rbHitsOK);
            this.gpDelay.Location = new System.Drawing.Point(12, 84);
            this.gpDelay.Name = "gpDelay";
            this.gpDelay.Size = new System.Drawing.Size(355, 67);
            this.gpDelay.TabIndex = 1;
            this.gpDelay.TabStop = false;
            this.gpDelay.Text = "Delay";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.Location = new System.Drawing.Point(12, 514);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(80, 28);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // rbExePath
            // 
            this.rbExePath.Controls.Add(this.btnCheck);
            this.rbExePath.Controls.Add(this.tbMsgPath);
            this.rbExePath.Location = new System.Drawing.Point(12, 157);
            this.rbExePath.Name = "rbExePath";
            this.rbExePath.Size = new System.Drawing.Size(355, 50);
            this.rbExePath.TabIndex = 2;
            this.rbExePath.TabStop = false;
            this.rbExePath.Text = "Path to executable";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.Location = new System.Drawing.Point(285, 16);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 27);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.TabStop = false;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbMsgPath
            // 
            this.tbMsgPath.Location = new System.Drawing.Point(6, 20);
            this.tbMsgPath.Name = "tbMsgPath";
            this.tbMsgPath.Size = new System.Drawing.Size(273, 21);
            this.tbMsgPath.TabIndex = 0;
            this.tbMsgPath.Validated += new System.EventHandler(this.tbMsgPath_Validated);
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.btnLocalhost);
            this.gbServer.Controls.Add(this.tbServer);
            this.gbServer.Location = new System.Drawing.Point(12, 213);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(355, 50);
            this.gbServer.TabIndex = 3;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Target server";
            // 
            // btnLocalhost
            // 
            this.btnLocalhost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalhost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalhost.Location = new System.Drawing.Point(285, 16);
            this.btnLocalhost.Name = "btnLocalhost";
            this.btnLocalhost.Size = new System.Drawing.Size(64, 27);
            this.btnLocalhost.TabIndex = 1;
            this.btnLocalhost.TabStop = false;
            this.btnLocalhost.Text = "Localhost";
            this.btnLocalhost.UseVisualStyleBackColor = true;
            this.btnLocalhost.Click += new System.EventHandler(this.btnLocalhost_Click);
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(6, 20);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(273, 21);
            this.tbServer.TabIndex = 0;
            this.tbServer.Validated += new System.EventHandler(this.tbServer_Validated);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(98, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.rbExePath);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.gpDelay);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbUser);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.gpDelay.ResumeLayout(false);
            this.gpDelay.PerformLayout();
            this.rbExePath.ResumeLayout(false);
            this.rbExePath.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox tbCertainUser;
        private System.Windows.Forms.RadioButton rbCertainUser;
        private System.Windows.Forms.RadioButton rbAllUsers;
        private System.Windows.Forms.Label lblSendTo;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblCharsLeft;
        private System.Windows.Forms.LinkLabel lnkClearMessage;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.RadioButton rbSeconds;
        private System.Windows.Forms.RadioButton rbHitsOK;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox gpDelay;
        private System.Windows.Forms.LinkLabel lnkCopyCmd;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox rbExePath;
        private System.Windows.Forms.TextBox tbMsgPath;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Button btnLocalhost;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btnExit;
    }
}

