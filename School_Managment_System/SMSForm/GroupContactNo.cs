using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class GroupContactNo : MetroFramework.Forms.MetroForm
    {

        MobileSMSController mobileSmsController = new MobileSMSController();
        MasterEnteriesController mec = new MasterEnteriesController();
        public GroupContactNo()
        {
            InitializeComponent();
        }


        private void GroupContactNo_Load(object sender, EventArgs e)
        {
            List<string> groupList = mobileSmsController.groupSMSNameCombobox();
            foreach (var item in groupList)
            {
                groupCombo.Items.Add(item);
            }


            foreach (var item in mec.classCombobox())
            {
                classNameComb.Items.Add(item);
            }
        }

        private void contactAddList_Click(object sender, EventArgs e)
        {
            if (groupCombo.Text == "")
            {
                MessageBox.Show("Select Group Name");
            }
            else if (classNameComb.Text == "")
            {
                MessageBox.Show("Select Class Name");
            }
            
            else
            {
                bool check = false;
                foreach (string item in listContact.Items)
                {
                    if (item == classNameComb.Text)
                    {
                        MessageBox.Show("Already Exit");
                        check = true;
                    }

                }

                if (check != true)
                {
                        listContact.Items.Add(classNameComb.Text);
                        groupContactsdataGridview.DataSource = mobileSmsController.groupSMSContacts(classNameComb.Text);
                    

                }


            }
        }

        private void ClearContactList_Click(object sender, EventArgs e)
        {
            listContact.Items.Clear();
            mobileSmsController.groupSMSContacts(classNameComb.Text).Clear();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool status = false;
            int SmsGroupId =  mobileSmsController.groupSMSNameIdSelect(groupCombo.Text);
            for (int i = 0; i < groupContactsdataGridview.RowCount; i++)
            {

                int GRNo = Convert.ToInt32(groupContactsdataGridview.Rows[i].Cells[0].Value.ToString());
                status = mobileSmsController.groupSMSContactsInsert(GRNo, SmsGroupId);
    
            }
            if (status)
            {
                MessageBox.Show("Contacts Insert in Group Successfuly!");
            }
            
        }
    }
}
