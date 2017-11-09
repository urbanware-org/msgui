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
            this.gbUser.SuspendLayout();
            this.gbMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.gpDelay.SuspendLayout();
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
            this.gbUser.Size = new System.Drawing.Size(355, 85);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // tbCertainUser
            // 
            this.tbCertainUser.Enabled = false;
            this.tbCertainUser.Location = new System.Drawing.Point(183, 45);
            this.tbCertainUser.Name = "tbCertainUser";
            this.tbCertainUser.Size = new System.Drawing.Size(157, 21);
            this.tbCertainUser.TabIndex = 2;
            this.tbCertainUser.TextChanged += new System.EventHandler(this.tbCertainUser_TextChanged);
            // 
            // rbCertainUser
            // 
            this.rbCertainUser.AutoSize = true;
            this.rbCertainUser.Location = new System.Drawing.Point(89, 46);
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
            this.rbAllUsers.Location = new System.Drawing.Point(89, 23);
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
            this.lblSendTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendTo.Location = new System.Drawing.Point(15, 25);
            this.lblSendTo.Name = "lblSendTo";
            this.lblSendTo.Size = new System.Drawing.Size(59, 13);
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
            this.gbMessage.Location = new System.Drawing.Point(12, 194);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(355, 264);
            this.gbMessage.TabIndex = 2;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lnkCopyCmd
            // 
            this.lnkCopyCmd.AutoSize = true;
            this.lnkCopyCmd.Location = new System.Drawing.Point(6, 242);
            this.lnkCopyCmd.Name = "lnkCopyCmd";
            this.lnkCopyCmd.Size = new System.Drawing.Size(139, 13);
            this.lnkCopyCmd.TabIndex = 7;
            this.lnkCopyCmd.TabStop = true;
            this.lnkCopyCmd.Text = "Copy command to clipboard";
            this.lnkCopyCmd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyCmd_LinkClicked);
            // 
            // lnkClearMessage
            // 
            this.lnkClearMessage.AutoSize = true;
            this.lnkClearMessage.Location = new System.Drawing.Point(6, 123);
            this.lnkClearMessage.Name = "lnkClearMessage";
            this.lnkClearMessage.Size = new System.Drawing.Size(100, 13);
            this.lnkClearMessage.TabIndex = 6;
            this.lnkClearMessage.TabStop = true;
            this.lnkClearMessage.Text = "Clear message text";
            this.lnkClearMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearMessage_LinkClicked);
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.Location = new System.Drawing.Point(244, 122);
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
            this.tbMessage.Size = new System.Drawing.Size(343, 99);
            this.tbMessage.TabIndex = 5;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbCommand
            // 
            this.tbCommand.Enabled = false;
            this.tbCommand.Location = new System.Drawing.Point(6, 140);
            this.tbCommand.MaxLength = 240;
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommand.Size = new System.Drawing.Size(343, 99);
            this.tbCommand.TabIndex = 4;
            this.tbCommand.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(238, 474);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 28);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Enabled = false;
            this.nudSeconds.Location = new System.Drawing.Point(276, 46);
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
            this.nudSeconds.Size = new System.Drawing.Size(64, 21);
            this.nudSeconds.TabIndex = 5;
            this.nudSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // rbSeconds
            // 
            this.rbSeconds.AutoSize = true;
            this.rbSeconds.Location = new System.Drawing.Point(89, 46);
            this.rbSeconds.Name = "rbSeconds";
            this.rbSeconds.Size = new System.Drawing.Size(171, 17);
            this.rbSeconds.TabIndex = 4;
            this.rbSeconds.Text = "Time in seconds (60 = default)";
            this.rbSeconds.UseVisualStyleBackColor = true;
            // 
            // rbHitsOK
            // 
            this.rbHitsOK.AutoSize = true;
            this.rbHitsOK.Checked = true;
            this.rbHitsOK.Location = new System.Drawing.Point(89, 23);
            this.rbHitsOK.Name = "rbHitsOK";
            this.rbHitsOK.Size = new System.Drawing.Size(115, 17);
            this.rbHitsOK.TabIndex = 3;
            this.rbHitsOK.TabStop = true;
            this.rbHitsOK.Text = "Until user hits \"OK\"";
            this.rbHitsOK.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(15, 25);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(57, 13);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Display...";
            // 
            // gpDelay
            // 
            this.gpDelay.Controls.Add(this.nudSeconds);
            this.gpDelay.Controls.Add(this.lblDisplay);
            this.gpDelay.Controls.Add(this.rbSeconds);
            this.gpDelay.Controls.Add(this.rbHitsOK);
            this.gpDelay.Location = new System.Drawing.Point(12, 103);
            this.gpDelay.Name = "gpDelay";
            this.gpDelay.Size = new System.Drawing.Size(355, 85);
            this.gpDelay.TabIndex = 1;
            this.gpDelay.TabStop = false;
            this.gpDelay.Text = "Delay";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.Location = new System.Drawing.Point(12, 474);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(95, 28);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About ...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 515);
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
    }
}

