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
            this.chkAutoRefresh = new System.Windows.Forms.CheckBox();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.cbCertainUser = new System.Windows.Forms.ComboBox();
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
            this.gbUser.Controls.Add(this.chkAutoRefresh);
            this.gbUser.Controls.Add(this.btnRefreshUsers);
            this.gbUser.Controls.Add(this.cbCertainUser);
            this.gbUser.Controls.Add(this.rbCertainUser);
            this.gbUser.Controls.Add(this.rbAllUsers);
            this.gbUser.Controls.Add(this.lblSendTo);
            this.gbUser.Location = new System.Drawing.Point(12, 12);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(420, 94);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.AutoSize = true;
            this.chkAutoRefresh.Enabled = false;
            this.chkAutoRefresh.Location = new System.Drawing.Point(90, 66);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Size = new System.Drawing.Size(297, 17);
            this.chkAutoRefresh.TabIndex = 4;
            this.chkAutoRefresh.Text = "Refresh automatically on drop-down (not recommended)";
            this.chkAutoRefresh.UseVisualStyleBackColor = true;
            this.chkAutoRefresh.CheckedChanged += new System.EventHandler(this.chkAutoRefresh_CheckedChanged);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshUsers.Enabled = false;
            this.btnRefreshUsers.Image = global::MsgUI.Properties.Resources.refresh_24x24;
            this.btnRefreshUsers.Location = new System.Drawing.Point(384, 31);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(30, 30);
            this.btnRefreshUsers.TabIndex = 3;
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // cbCertainUser
            // 
            this.cbCertainUser.Enabled = false;
            this.cbCertainUser.FormattingEnabled = true;
            this.cbCertainUser.Location = new System.Drawing.Point(165, 37);
            this.cbCertainUser.Name = "cbCertainUser";
            this.cbCertainUser.Size = new System.Drawing.Size(213, 21);
            this.cbCertainUser.TabIndex = 2;
            this.cbCertainUser.DropDown += new System.EventHandler(this.cbCertainUser_DropDown);
            this.cbCertainUser.SelectedIndexChanged += new System.EventHandler(this.cbCertainUser_SelectedIndexChanged);
            this.cbCertainUser.TextChanged += new System.EventHandler(this.cbCertainUser_TextChanged);
            // 
            // rbCertainUser
            // 
            this.rbCertainUser.AutoSize = true;
            this.rbCertainUser.Location = new System.Drawing.Point(71, 38);
            this.rbCertainUser.Name = "rbCertainUser";
            this.rbCertainUser.Size = new System.Drawing.Size(88, 17);
            this.rbCertainUser.TabIndex = 1;
            this.rbCertainUser.TabStop = true;
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
            this.rbAllUsers.CheckedChanged += new System.EventHandler(this.rbAllUsers_CheckedChanged);
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
            this.gbMessage.Location = new System.Drawing.Point(12, 297);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(415, 245);
            this.gbMessage.TabIndex = 4;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lnkCopyCmd
            // 
            this.lnkCopyCmd.AutoSize = true;
            this.lnkCopyCmd.Location = new System.Drawing.Point(6, 222);
            this.lnkCopyCmd.Name = "lnkCopyCmd";
            this.lnkCopyCmd.Size = new System.Drawing.Size(139, 13);
            this.lnkCopyCmd.TabIndex = 15;
            this.lnkCopyCmd.TabStop = true;
            this.lnkCopyCmd.Text = "Copy command to clipboard";
            this.lnkCopyCmd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyCmd_LinkClicked);
            // 
            // lnkClearMessage
            // 
            this.lnkClearMessage.AutoSize = true;
            this.lnkClearMessage.Location = new System.Drawing.Point(6, 114);
            this.lnkClearMessage.Name = "lnkClearMessage";
            this.lnkClearMessage.Size = new System.Drawing.Size(100, 13);
            this.lnkClearMessage.TabIndex = 13;
            this.lnkClearMessage.TabStop = true;
            this.lnkClearMessage.Text = "Clear message text";
            this.lnkClearMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearMessage_LinkClicked);
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.Location = new System.Drawing.Point(304, 112);
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
            this.tbMessage.Size = new System.Drawing.Size(403, 89);
            this.tbMessage.TabIndex = 12;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbCommand
            // 
            this.tbCommand.Enabled = false;
            this.tbCommand.Location = new System.Drawing.Point(6, 130);
            this.tbCommand.MaxLength = 240;
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommand.Size = new System.Drawing.Size(403, 89);
            this.tbCommand.TabIndex = 14;
            this.tbCommand.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = global::MsgUI.Properties.Resources.send_24x24;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(296, 548);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(132, 30);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send message now";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Enabled = false;
            this.nudSeconds.Location = new System.Drawing.Point(352, 38);
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
            this.nudSeconds.TabIndex = 7;
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
            this.rbSeconds.TabIndex = 6;
            this.rbSeconds.TabStop = true;
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
            this.rbHitsOK.TabIndex = 5;
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
            this.gpDelay.Location = new System.Drawing.Point(12, 112);
            this.gpDelay.Name = "gpDelay";
            this.gpDelay.Size = new System.Drawing.Size(415, 67);
            this.gpDelay.TabIndex = 1;
            this.gpDelay.TabStop = false;
            this.gpDelay.Text = "Delay";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::MsgUI.Properties.Resources.about_24x24;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(12, 548);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(80, 30);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "About...";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // rbExePath
            // 
            this.rbExePath.Controls.Add(this.btnCheck);
            this.rbExePath.Controls.Add(this.tbMsgPath);
            this.rbExePath.Location = new System.Drawing.Point(12, 185);
            this.rbExePath.Name = "rbExePath";
            this.rbExePath.Size = new System.Drawing.Size(415, 50);
            this.rbExePath.TabIndex = 2;
            this.rbExePath.TabStop = false;
            this.rbExePath.Text = "Path to executable";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Image = global::MsgUI.Properties.Resources.command_24x24;
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(341, 14);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(68, 30);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbMsgPath
            // 
            this.tbMsgPath.Location = new System.Drawing.Point(6, 20);
            this.tbMsgPath.Name = "tbMsgPath";
            this.tbMsgPath.Size = new System.Drawing.Size(329, 21);
            this.tbMsgPath.TabIndex = 8;
            this.tbMsgPath.Validated += new System.EventHandler(this.tbMsgPath_Validated);
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.btnLocalhost);
            this.gbServer.Controls.Add(this.tbServer);
            this.gbServer.Location = new System.Drawing.Point(12, 241);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(415, 50);
            this.gbServer.TabIndex = 3;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Target server";
            // 
            // btnLocalhost
            // 
            this.btnLocalhost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalhost.Image = global::MsgUI.Properties.Resources.computer_24x24;
            this.btnLocalhost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalhost.Location = new System.Drawing.Point(323, 14);
            this.btnLocalhost.Name = "btnLocalhost";
            this.btnLocalhost.Size = new System.Drawing.Size(86, 30);
            this.btnLocalhost.TabIndex = 11;
            this.btnLocalhost.Text = "Localhost";
            this.btnLocalhost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalhost.UseVisualStyleBackColor = true;
            this.btnLocalhost.Click += new System.EventHandler(this.btnLocalhost_Click);
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(6, 20);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(311, 21);
            this.tbServer.TabIndex = 10;
            this.tbServer.Validated += new System.EventHandler(this.tbServer_Validated);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::MsgUI.Properties.Resources.exit_24x24;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(102, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 593);
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
        private System.Windows.Forms.ComboBox cbCertainUser;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.CheckBox chkAutoRefresh;
    }
}

