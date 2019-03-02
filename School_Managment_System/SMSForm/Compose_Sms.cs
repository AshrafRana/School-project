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
    public partial class Compose_Sms : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();
        MobileSMS sm = new MobileSMS();

        public Compose_Sms()
        {
            InitializeComponent();
        }

        private void Compose_Sms_Load(object sender, EventArgs e)
        {
            List<string> smsTitlelist = mobileSmsController.defineSMSTitleCombobox();
            foreach (var item in smsTitlelist)
            {
                titleCombo.Items.Add(item);
            }
            List<string> groupList = mobileSmsController.groupSMSNameCombobox();
            foreach (var item in groupList)
            {
                groupCombo.Items.Add(item);
            }
            foreach (var item in smsTitlelist)
            {
                singleSMSTitles.Items.Add(item);
            }
            
        }

        
        private void clearButton_Click(object sender, EventArgs e)
        {
            smsText.Text = "";
            titleCombo.Text = "";
        }
        

        private void titleCombo_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            if (titleCombo.Text != "")
            {
                List<string> listt = mobileSmsController.defineSMSTexSelect(titleCombo.Text);
                smsText.Text = listt[0];
                countCharactet.Text = smsText.Text.Count().ToString();
            }
        }

        private void contactAddList_Click_1(object sender, EventArgs e)
        {
            if (groupCombo.Text == "")
            {
                MessageBox.Show("Select Contact Group Name");
            }
            
            else
            {
                bool check = false;
                foreach (string item in listContact.Items)
                {
                    if (item == groupCombo.Text)
                    {
                        MessageBox.Show("Already Exit");
                        check = true;
                    }

                }

                if (check != true)
                {
                    listContact.Items.Add(groupCombo.Text);
                    

                }


            }
            
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (titleCombo.Text == "")
            {
                MessageBox.Show("SMS Title Text Not Empty");
            }
            else if (smsText.Text == "")
            {
                MessageBox.Show("SMS Text Not Empty");
            }
            else if (listContact.Items.Count < 1)
            {
                MessageBox.Show(listContact.Items.Count+"Contact List Should Not Empty");
            }
            else
            {
                List<string> contactList = new List<string>();
                foreach (string drv in listContact.Items)
                {
                    contactList.Add(drv);

                }

               MessageBox.Show(mobileSmsController.sendToContactList(titleCombo.Text,smsText.Text, contactList));

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            titleCombo.Text = "Select SMS Title";
            smsText.Text = "";
            groupCombo.Text = "Select Group";
            countCharactet.Text = "0";
            listContact.Items.Clear();
        }

        private void ClearContactList_Click(object sender, EventArgs e)
        {
            listContact.Items.Clear();
        }

        private void SendByCustomize_Click(object sender, EventArgs e)
        {
            string single = singleContact.Text;
            //string option = "";
            //string searchValue = "";

            if (sendGRRadio.Checked)
            {

            }
            else if (sendByStudentMobileNo.Checked)
            {

            }
            else if (sendByStaffId.Checked)
            {

            }
            else if (sendByStaffNo.Checked)
            {

            }
            else
            {
                MessageBox.Show("Select Radio Button ");
            }


            if (singleContact.Text != null && singleMessg.Text != null)
            {
                MessageBox.Show(mobileSmsController.singleSMSSend(singleContact.Text, singleMessg.Text));

            }

        }
        
        private void singleSMSTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (singleSMSTitles.Text != "")
            {
                List<string> listt = mobileSmsController.defineSMSTexSelect(singleSMSTitles.Text);
                singleMessg.Text = listt[0];
                singleSMSCount.Text = singleMessg.Text.Count().ToString();
            }
        }
    }
}
