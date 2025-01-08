/*
    MsgUI - Simple graphical front end for sending messages via 'msg.exe'
    About form
    Copyright (c) 2023 by Ralf Kilian
    Distributed under the MIT License (https://opensource.org/licenses/MIT)

    GitHub: https://github.com/urbanware-org/msgui
    GitLab: https://gitlab.com/urbanware-org/msgui
*/

using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace MsgUI
{
    public partial class AboutForm : Form
    {

        #region Constructor of this form

        public AboutForm()
        {
            InitializeComponent();

            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            var copyright = versionInfo.LegalCopyright;

            lblVersion.Text = "Version " + Application.ProductVersion.ToString();
            lblCopyright.Text = copyright;
        }

        #endregion

        #region Event handler for the links

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/urbanware-org/msgui");
        }

        private void lnkGitLab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gitlab.com/urbanware-org/msgui");
        }

        private void lnkIconAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/82742/info");
        }

        private void lnkIconCommand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/120387/console");
        }

        private void lnkIconComputer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/85457/monitor");
        }

        private void lnkIconExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/110344/emergency-exit");
        }

        private void lnkIconMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/87019/chat-bubble");
        }

        private void lnkIconRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/icon/123373/update-left-rotation");
        }

        private void lnkIcons8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com");
        }

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://opensource.org/licenses/MIT");
        }

        #endregion

        #region Command button event handler

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
