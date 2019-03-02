using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace School_Managment_System
{
    public partial class GroupSMS : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        int SmsGroupId = 0;
        
        public GroupSMS()
        {
            InitializeComponent();
        }

        
        private void Save_Click(object sender, EventArgs e)
        {
            if (SMSGroupTextBox.Text != "")
            {
                MessageBox.Show(mobileSMSController.groupSMSNameInsert(SMSGroupTextBox.Text));
                SMSGroupTextBox.Text = "";
                mobileSMSController.groupSMSDataGridView().Clear();
                groupSMSNamedataGridView.DataSource = mobileSMSController.groupSMSDataGridView();
            }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }
            
        }

        private void SMSGroupTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void GroupSMS_Load(object sender, EventArgs e)
        {
            mobileSMSController.groupSMSDataGridView().Clear();
            groupSMSNamedataGridView.DataSource = mobileSMSController.groupSMSDataGridView();
       
        }

        private void groupSMSNamedataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = groupSMSNamedataGridView.Rows[e.RowIndex];
                SMSGroupTextBox.Text = row.Cells["SmsGroupName"].Value.ToString();
                SmsGroupId = Convert.ToInt32(row.Cells["SmsGroupId"].Value.ToString());
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (SMSGroupTextBox.Text != "" && SmsGroupId > 0)
            {
                MessageBox.Show(mobileSMSController.groupSMSNameDelete(SMSGroupTextBox.Text));
                SMSGroupTextBox.Text = "";
                mobileSMSController.groupSMSDataGridView().Clear();
                groupSMSNamedataGridView.DataSource = mobileSMSController.groupSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }


            
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (SMSGroupTextBox.Text != "" && SmsGroupId > 0)
            {

                MessageBox.Show(mobileSMSController.groupSMSNameUpdate(SmsGroupId, SMSGroupTextBox.Text));
                SMSGroupTextBox.Text = "";
                mobileSMSController.groupSMSDataGridView().Clear();
                groupSMSNamedataGridView.DataSource = mobileSMSController.groupSMSDataGridView();

                SmsGroupId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }
    }
}
