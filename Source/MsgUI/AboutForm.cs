/*
    MsgUI - Simple graphical front end for sending messages via 'msg.exe'
    About form
    Copyright (C) 2018 by Ralf Kilian
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

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://opensource.org/licenses/MIT");
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/urbanware-org/msgui");
        }

        private void lnkGitLab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gitlab.com/urbanware-org/msgui");
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
