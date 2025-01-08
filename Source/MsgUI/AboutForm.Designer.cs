namespace MsgUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblGitHub = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lnkLicense = new System.Windows.Forms.LinkLabel();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkGitLab = new System.Windows.Forms.LinkLabel();
            this.lblSpecialThanks = new System.Windows.Forms.Label();
            this.lblIcons = new System.Windows.Forms.Label();
            this.lnkIcons8 = new System.Windows.Forms.LinkLabel();
            this.lnkIconAbout = new System.Windows.Forms.LinkLabel();
            this.lnkIconMessage = new System.Windows.Forms.LinkLabel();
            this.lnkIconComputer = new System.Windows.Forms.LinkLabel();
            this.lnkIconRefresh = new System.Windows.Forms.LinkLabel();
            this.lnkIconCommand = new System.Windows.Forms.LinkLabel();
            this.lnkIconExit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApplication.Location = new System.Drawing.Point(82, 12);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(43, 13);
            this.lblApplication.TabIndex = 11;
            this.lblApplication.Text = "MsgUI";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCopyright.Location = new System.Drawing.Point(82, 56);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(54, 13);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(82, 34);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "Version";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MsgUI.Properties.Resources.MsgUI_64x64;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 64);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitHub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGitHub.Location = new System.Drawing.Point(82, 123);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(181, 13);
            this.lblGitHub.TabIndex = 13;
            this.lblGitHub.Text = "This project is hosted on             and";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLicense.Location = new System.Drawing.Point(82, 79);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(109, 13);
            this.lblLicense.TabIndex = 14;
            this.lblLicense.Text = "Distributed under the";
            // 
            // lnkLicense
            // 
            this.lnkLicense.AutoSize = true;
            this.lnkLicense.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLicense.Location = new System.Drawing.Point(187, 79);
            this.lnkLicense.Name = "lnkLicense";
            this.lnkLicense.Size = new System.Drawing.Size(63, 13);
            this.lnkLicense.TabIndex = 1;
            this.lnkLicense.TabStop = true;
            this.lnkLicense.Text = "MIT License";
            this.lnkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicense_LinkClicked);
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.BackColor = System.Drawing.SystemColors.Control;
            this.lnkGitHub.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitHub.Location = new System.Drawing.Point(202, 123);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(39, 13);
            this.lnkGitHub.TabIndex = 2;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "GitHub";
            this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(435, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkGitLab
            // 
            this.lnkGitLab.AutoSize = true;
            this.lnkGitLab.BackColor = System.Drawing.SystemColors.Control;
            this.lnkGitLab.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitLab.Location = new System.Drawing.Point(259, 123);
            this.lnkGitLab.Name = "lnkGitLab";
            this.lnkGitLab.Size = new System.Drawing.Size(37, 13);
            this.lnkGitLab.TabIndex = 15;
            this.lnkGitLab.TabStop = true;
            this.lnkGitLab.Text = "GitLab";
            this.lnkGitLab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitLab_LinkClicked);
            // 
            // lblSpecialThanks
            // 
            this.lblSpecialThanks.AutoSize = true;
            this.lblSpecialThanks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialThanks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpecialThanks.Location = new System.Drawing.Point(82, 101);
            this.lblSpecialThanks.Name = "lblSpecialThanks";
            this.lblSpecialThanks.Size = new System.Drawing.Size(340, 13);
            this.lblSpecialThanks.TabIndex = 16;
            this.lblSpecialThanks.Text = "Special thanks to Matthias Schwarz for his support developing MsgUI.";
            // 
            // lblIcons
            // 
            this.lblIcons.AutoSize = true;
            this.lblIcons.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIcons.Location = new System.Drawing.Point(82, 149);
            this.lblIcons.Name = "lblIcons";
            this.lblIcons.Size = new System.Drawing.Size(234, 13);
            this.lblIcons.TabIndex = 17;
            this.lblIcons.Text = "The icons used on the buttons are provided by ";
            // 
            // lnkIcons8
            // 
            this.lnkIcons8.AutoSize = true;
            this.lnkIcons8.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIcons8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIcons8.Location = new System.Drawing.Point(309, 149);
            this.lnkIcons8.Name = "lnkIcons8";
            this.lnkIcons8.Size = new System.Drawing.Size(39, 13);
            this.lnkIcons8.TabIndex = 18;
            this.lnkIcons8.TabStop = true;
            this.lnkIcons8.Text = "Icons8";
            this.lnkIcons8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIcons8_LinkClicked);
            // 
            // lnkIconAbout
            // 
            this.lnkIconAbout.AutoSize = true;
            this.lnkIconAbout.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconAbout.Location = new System.Drawing.Point(82, 184);
            this.lnkIconAbout.Name = "lnkIconAbout";
            this.lnkIconAbout.Size = new System.Drawing.Size(58, 13);
            this.lnkIconAbout.TabIndex = 19;
            this.lnkIconAbout.TabStop = true;
            this.lnkIconAbout.Text = "About icon";
            this.lnkIconAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconAbout_LinkClicked);
            // 
            // lnkIconMessage
            // 
            this.lnkIconMessage.AutoSize = true;
            this.lnkIconMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconMessage.Location = new System.Drawing.Point(82, 236);
            this.lnkIconMessage.Name = "lnkIconMessage";
            this.lnkIconMessage.Size = new System.Drawing.Size(71, 13);
            this.lnkIconMessage.TabIndex = 20;
            this.lnkIconMessage.TabStop = true;
            this.lnkIconMessage.Text = "Message icon";
            this.lnkIconMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconMessage_LinkClicked);
            // 
            // lnkIconComputer
            // 
            this.lnkIconComputer.AutoSize = true;
            this.lnkIconComputer.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconComputer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconComputer.Location = new System.Drawing.Point(82, 210);
            this.lnkIconComputer.Name = "lnkIconComputer";
            this.lnkIconComputer.Size = new System.Drawing.Size(76, 13);
            this.lnkIconComputer.TabIndex = 21;
            this.lnkIconComputer.TabStop = true;
            this.lnkIconComputer.Text = "Computer icon";
            this.lnkIconComputer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconComputer_LinkClicked);
            // 
            // lnkIconRefresh
            // 
            this.lnkIconRefresh.AutoSize = true;
            this.lnkIconRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconRefresh.Location = new System.Drawing.Point(82, 249);
            this.lnkIconRefresh.Name = "lnkIconRefresh";
            this.lnkIconRefresh.Size = new System.Drawing.Size(67, 13);
            this.lnkIconRefresh.TabIndex = 22;
            this.lnkIconRefresh.TabStop = true;
            this.lnkIconRefresh.Text = "Refresh icon";
            this.lnkIconRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconRefresh_LinkClicked);
            // 
            // lnkIconCommand
            // 
            this.lnkIconCommand.AutoSize = true;
            this.lnkIconCommand.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconCommand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconCommand.Location = new System.Drawing.Point(82, 197);
            this.lnkIconCommand.Name = "lnkIconCommand";
            this.lnkIconCommand.Size = new System.Drawing.Size(76, 13);
            this.lnkIconCommand.TabIndex = 23;
            this.lnkIconCommand.TabStop = true;
            this.lnkIconCommand.Text = "Command icon";
            this.lnkIconCommand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconCommand_LinkClicked);
            // 
            // lnkIconExit
            // 
            this.lnkIconExit.AutoSize = true;
            this.lnkIconExit.BackColor = System.Drawing.SystemColors.Control;
            this.lnkIconExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIconExit.Location = new System.Drawing.Point(82, 223);
            this.lnkIconExit.Name = "lnkIconExit";
            this.lnkIconExit.Size = new System.Drawing.Size(47, 13);
            this.lnkIconExit.TabIndex = 24;
            this.lnkIconExit.TabStop = true;
            this.lnkIconExit.Text = "Exit icon";
            this.lnkIconExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIconExit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(82, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "As requested per license, the direct links to each of them:";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 293);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkIconExit);
            this.Controls.Add(this.lnkIconCommand);
            this.Controls.Add(this.lnkIconRefresh);
            this.Controls.Add(this.lnkIconComputer);
            this.Controls.Add(this.lnkIconMessage);
            this.Controls.Add(this.lnkIconAbout);
            this.Controls.Add(this.lnkIcons8);
            this.Controls.Add(this.lblIcons);
            this.Controls.Add(this.lblSpecialThanks);
            this.Controls.Add(this.lnkGitLab);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.lnkLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGitHub;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.LinkLabel lnkLicense;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkGitLab;
        private System.Windows.Forms.Label lblSpecialThanks;
        private System.Windows.Forms.Label lblIcons;
        private System.Windows.Forms.LinkLabel lnkIcons8;
        private System.Windows.Forms.LinkLabel lnkIconAbout;
        private System.Windows.Forms.LinkLabel lnkIconMessage;
        private System.Windows.Forms.LinkLabel lnkIconComputer;
        private System.Windows.Forms.LinkLabel lnkIconRefresh;
        private System.Windows.Forms.LinkLabel lnkIconCommand;
        private System.Windows.Forms.LinkLabel lnkIconExit;
        private System.Windows.Forms.Label label1;
    }
}