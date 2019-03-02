using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class SMS : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        private static Phone_Setting phoneSetting = null;
        private static GroupSMS groupSMS = null;
        private static GroupContactNo groupContactNo = null;
        private static Compose_Sms compose_Sms = null;
        private static StudnetSentBox studentSentBox = null;
        private static StudentUnsentBox studentUnsentBox = null;
        private static DefineSMS defineSMS = null;
        
        public SMS()
        {
            InitializeComponent();
        }
        
        private void SMS_Load(object sender, EventArgs e)
        {}
        private void SMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            mobileSMSController.disconnectProt();
        }

        private void gsmsetting_Click(object sender, EventArgs e)
        {
            if (phoneSetting == null || phoneSetting.IsDisposed)
            {
                phoneSetting = new Phone_Setting();
                phoneSetting.Show();
            }
            else
            {
                phoneSetting.WindowState = FormWindowState.Normal;
                phoneSetting.Show();
                phoneSetting.Focus();

            }
        }

        private void createGroup_Click(object sender, EventArgs e)
        {
            if (groupSMS == null || groupSMS.IsDisposed)
            {
                groupSMS = new GroupSMS();
                groupSMS.Show();
            }
            else
            {
                groupSMS.WindowState = FormWindowState.Normal;
                groupSMS.Show();
                groupSMS.Focus();

            }
        }

        private void groupContacts_Click(object sender, EventArgs e)
        {
            if (groupContactNo == null || groupContactNo.IsDisposed)
            {
                groupContactNo = new GroupContactNo();
                groupContactNo.Show();
            }
            else
            {
                groupContactNo.WindowState = FormWindowState.Normal;
                groupContactNo.Show();
                groupContactNo.Focus();

            }
        }

        private void composesms_Click(object sender, EventArgs e)
        {
            if (compose_Sms == null || compose_Sms.IsDisposed)
            {
                compose_Sms = new Compose_Sms();
                compose_Sms.Show();
            }
            else
            {
                compose_Sms.WindowState = FormWindowState.Normal;
                compose_Sms.Show();
                compose_Sms.Focus();

            }
        }

        private void outbox_Click(object sender, EventArgs e)
        {
            if (defineSMS == null || defineSMS.IsDisposed)
            {
                defineSMS = new DefineSMS();
                defineSMS.Show();
            }
            else
            {
                defineSMS.WindowState = FormWindowState.Normal;
                defineSMS.Show();
                defineSMS.Focus();

            }
        }

        private void sentbox_Click(object sender, EventArgs e)
        {
            if (studentSentBox == null || studentSentBox.IsDisposed)
            {
                studentSentBox = new StudnetSentBox();
                studentSentBox.Show();
            }
            else
            {
                studentSentBox.WindowState = FormWindowState.Normal;
                studentSentBox.Show();
                studentSentBox.Focus();

            }
        }

        private void unsentbox_Click(object sender, EventArgs e)
        {
            if (studentUnsentBox == null || studentUnsentBox.IsDisposed)
            {
                studentUnsentBox = new StudentUnsentBox();
                studentUnsentBox.Show();
            }
            else
            {
                studentUnsentBox.WindowState = FormWindowState.Normal;
                studentUnsentBox.Show();
                studentUnsentBox.Focus();

            }
        }
        

        private void closeform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inbox_Click(object sender, EventArgs e)
        {

        }
    }
}
