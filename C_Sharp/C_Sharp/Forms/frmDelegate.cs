using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp.Forms
{
    public partial class frmDelegate : Form
    {
        NotificationCallBack? notificationCall;


        public frmDelegate()
        {
            InitializeComponent();
            MainFunction();
        }

        private void MainFunction()
        {
        }

        delegate void NotificationCallBack(string content);

        void SendJohn(string content)
        {
            txtJohn.Text = $"New notification for John: {content}";
        }

        void SendEma(string content)
        {
            txtEma.Text = $"New notification for Ema: {content}";
        }

        void SendTom(string content)
        {
            txtTom.Text = $"New notification for Tom: {content}";
        }

        void SendJane(string content)
        {
            txtJane.Text = $"New notification for Jane: {content}";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (notificationCall != null)
            {
                notificationCall("Hello, how are you");

            }
            else
            {
                MessageBox.Show("You can not send message to nobody");
            }
        }

        private void cbJohn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJohn.Checked)
            {
                notificationCall += SendJohn;
            }
            else
            {
                notificationCall -= SendJohn;
            }
        }

        private void cbEma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEma.Checked)
            {
                notificationCall += SendEma;
            }
            else
            {
                notificationCall -= SendEma;
            }
        }

        private void cbTom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTom.Checked)
            {
                notificationCall += SendTom;
            }
            else
            {
                notificationCall -= SendTom;
            }
        }

        private void cbJane_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJane.Checked)
            {
                notificationCall += SendJane;
            }
            else
            {
                notificationCall -= SendJane;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJohn.Text = "";
            txtEma.Text = "";
            txtTom.Text = "";
            txtJane.Text = "";
        }
    }
}
