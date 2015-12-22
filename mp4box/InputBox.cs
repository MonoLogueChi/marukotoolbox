using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mp4box
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void qqButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        internal static string Show(string message, string title, string text)
        {
            using (InputBox inbox = new InputBox())
            {
                inbox.lblMessage.Text = message;
                inbox.text.Text = text;
                inbox.Text = title;
                if (inbox.ShowDialog() == DialogResult.OK)
                    return inbox.text.Text;
                return null;
            }
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                qqButton1_Click(null, null);
            }
            else if (e.KeyChar == 27)
            {
                btnCancel_Click(null, null);
            }
        }
    }
}
