/*
    MsgUI - Simple graphical front end for sending messages via 'msg.exe'
    Main form
    Copyright (c) 2023 by Ralf Kilian
    Distributed under the MIT License (https://opensource.org/licenses/MIT)

    GitHub: https://github.com/urbanware-org/msgui
    GitLab: https://gitlab.com/urbanware-org/msgui
*/

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MsgUI
{
    public partial class MainForm : Form
    {

        #region Variable declarations

        private string server = "/SERVER:" + System.Net.Dns.GetHostEntry(Environment.MachineName).HostName;
        private string delay = "0";
        private string user = "*";
        private string msg = "C:\\Windows\\System32\\msg.exe";

        #endregion

        #region Main form constructor and load event handler

        public MainForm()
        {
            InitializeComponent();

            tbMsgPath.Text = msg;
            tbServer.Text = server;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadLoggedInUsers();
            buildCommand();
        }

        #endregion

        #region Command related

        private void buildCommand()
        {
            tbCommand.Text = msg + " " + server + " /TIME:" + delay + " " + user + " \"" + tbMessage.Text + "\"";
        }

        private bool checkExecutable(string path, bool confirm)
        {
            if (!msg.EndsWith("\\msg.exe"))
            {
                MessageBox.Show("The path to the \"msg.exe\" executable must end with its filename.", "Path to executable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (File.Exists(msg))
                {
                    if (confirm)
                        MessageBox.Show("Check successful.\n\nThe \"msg.exe\" executable was found at the given path.", "Path to executable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("The given path to the \"msg.exe\" executable does not exist.\n\nNotice that it has to be an absolute path without any variables such as \"%WINDIR%\", as they are not supported here.", "Path to executable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return false;
        }

        private void loadLoggedInUsers()
        {
            cbCertainUser.Text = "";
            cbCertainUser.Items.Clear();

            var users = Wtsapi32.GetLoggedInUsers().OrderBy(user => user);

            foreach (var user in users)
            {
                cbCertainUser.Items.Add(user);
            }

            cbCertainUser.SelectedIndex = -1;
        }

        #endregion

        #region Send message event handler

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rbCertainUser.Checked)
            {
                if (cbCertainUser.Text == "")
                {
                    MessageBox.Show("User name must not be empty.", "User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                user = "\"" + cbCertainUser.Text + "\"";
            }
            else
            {
                user = "*";
            }

            if (rbSeconds.Checked)
            {
                delay = nudSeconds.Value.ToString();
            }
            else
            {
                delay = "0";
            }

            if (!checkExecutable(msg, false))
                return;

            if (tbMessage.Text == "")
            {
                MessageBox.Show("Message text must not be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = msg;
            startInfo.Arguments = server + " /TIME:" + delay + " " + user + " \"" + tbMessage.Text + "\"";
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            try
            {
                Process.Start(startInfo);
                MessageBox.Show("Message has been sent.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Not really a clean solution to process every execption that way
                MessageBox.Show("Failed to send the message.\n\nPlease check your settings and retry.\n\nFurthermore, you can copy the command to the clipboard and execute it on the command-line to get a detailed error message.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Various event handlers

        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkExecutable(msg, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLocalhost_Click(object sender, EventArgs e)
        {
            server = "/SERVER:" + System.Net.Dns.GetHostEntry(Environment.MachineName).HostName;
            tbServer.Text = server;
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            loadLoggedInUsers();
            cbCertainUser.Focus();
        }

        private void cbCertainUser_DropDown(object sender, EventArgs e)
        {
            if (chkAutoRefresh.Checked)
            {
                loadLoggedInUsers();
            }
        }

        private void cbCertainUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = "\"" + cbCertainUser.Text + "\"";
            buildCommand();
        }

        private void cbCertainUser_TextChanged(object sender, EventArgs e)
        {
            user = "\"" + cbCertainUser.Text + "\"";
            buildCommand();
        }

        private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            btnRefreshUsers.Enabled = !chkAutoRefresh.Checked;
            loadLoggedInUsers();
            cbCertainUser.Focus();
        }

        private void lnkClearMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbMessage.Text = "";
            tbMessage.Focus();
            buildCommand();
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            delay = nudSeconds.Value.ToString();
            buildCommand();
        }

        private void rbAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllUsers.Checked)
            {
                cbCertainUser.Enabled = false;
                chkAutoRefresh.Enabled = false;
                btnRefreshUsers.Enabled = false;
                cbCertainUser.Text = "";
                user = "*";
            }
            buildCommand();
        }

        private void rbCertainUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCertainUser.Checked)
            {
                cbCertainUser.Enabled = true;
                chkAutoRefresh.Enabled = true;
                btnRefreshUsers.Enabled = !chkAutoRefresh.Checked;
                cbCertainUser.Focus();
                user = "\"\"";
            }
            buildCommand();
        }

        private void rbHitsOK_CheckedChanged(object sender, EventArgs e)
        {
            delay = "0";
            buildCommand();
        }

        private void rbSeconds_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeconds.Checked)
            {
                nudSeconds.Enabled = true;
                nudSeconds.Focus();
            }
            else
            {
                nudSeconds.Enabled = false;
                nudSeconds.Value = 60;
            }

            delay = nudSeconds.Value.ToString();
            buildCommand();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            int charsLeft = 240 - tbMessage.TextLength;
            lblCharsLeft.Text = charsLeft.ToString() + " characters left";
            buildCommand();
        }
        
        private void tbMsgPath_Validated(object sender, EventArgs e)
        {
            msg = tbMsgPath.Text;
            buildCommand();
        }

        private void tbServer_Validated(object sender, EventArgs e)
        {
            server = tbServer.Text;
            buildCommand();
        }

        #endregion

        #region Clipboard related

        private void lnkCopyCmd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(tbCommand.Text);
            MessageBox.Show("Command has been copied to the clipboard.", "Copy to clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region About form

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        #endregion

    }
}
