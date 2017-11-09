/******************************************************************************
 * MsgUI - Simple graphical front end for sending messages via 'msg.exe'      *
 * Main form                                                                  *
 * Copyright (C) 2017 by Ralf Kilian                                          *
 * Distributed under the MIT License (https://opensource.org/licenses/MIT)    *
 *                                                                            *
 * GitHub: https://github.com/urbanware-org/msgui                             *
 ******************************************************************************/

using System;
using System.Diagnostics;
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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            buildCommand();
        }

        #endregion

        #region Command-line related

        private void buildCommand()
        {
            tbCommand.Text = msg + " " + server + " /TIME:" + delay + " " + user + " \"" + tbMessage.Text + "\"";
        }

        private void tbCertainUser_TextChanged(object sender, EventArgs e)
        {
            user = "\"" + tbCertainUser.Text + "\"";
            buildCommand();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            int charsLeft = 240 - tbMessage.TextLength;
            lblCharsLeft.Text = charsLeft.ToString() + " characters left";
            buildCommand();
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

        #endregion

        #region Option related

        private void rbCertainUser_CheckedChanged(object sender, EventArgs e)
        {

            if (rbCertainUser.Checked)
            {
                tbCertainUser.Enabled = true;
                tbCertainUser.Focus();
                user = "\"\"";
            }
            else
            {
                tbCertainUser.Enabled = false;
                tbCertainUser.Text = "";
                user = "*";
            }

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
                nudSeconds.Value = 10;
                nudSeconds.Value = 60;
            }

            delay = nudSeconds.Value.ToString();
            buildCommand();
        }

        #endregion

        #region Send message event handler

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rbCertainUser.Checked)
            {
                if (tbCertainUser.Text == "")
                {
                    MessageBox.Show("User name must not be empty.", "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user = "\"" + tbCertainUser.Text + "\"";
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

            if (tbMessage.Text == "")
            {
                MessageBox.Show("Message text must not be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = msg;
            startInfo.Arguments = server + " /TIME:" + delay + " " + user + " \"" + tbMessage.Text + "\"";
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(startInfo);

            MessageBox.Show("Message has been sent.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        #endregion
    }
}
