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
    public partial class StaffDetails : MetroFramework.Forms.MetroForm

    {
        StaffController staffController = new StaffController();
        int StafID = 0;
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            
            staffGridView.DataSource = staffController.selectAllStaffRecordDataGridView();
        }

        
        private void staffGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffGridView.Rows[e.RowIndex];
                StafID = Convert.ToInt32((row.Cells["staffId"].Value.ToString()));
                Edit_Staff es = new Edit_Staff(StafID);
                es.Show();
            }
        }

        private void staffGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffGridView.Rows[e.RowIndex];
                StafID = Convert.ToInt32((row.Cells["staffId"].Value.ToString()));
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(staffController.deleteSingleStaff(StafID));
            staffController.selectAllStaffRecordDataGridView().Clear();
            staffGridView.DataSource = staffController.selectAllStaffRecordDataGridView();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (StafID > 0)
            {
                Edit_Staff es = new Edit_Staff(StafID);
                es.Show();
            }
            else
            {
                MessageBox.Show("Select Row from Table");
            }
        }

        private void allRadio_CheckedChanged(object sender, EventArgs e)
        {

            staffGridView.DataSource = staffController.selectAllStaffRecordDataGridView();
        }

        private void Sreach_Click(object sender, EventArgs e)
        {
            int stId = 0;
            string staffName = null;
            string staffFather = null;
            string phone = null;
            string staffMobile = null;
            int day = 0;
            string month = null;
            int year = 0;



            staffController.searchStaff(stId, staffName, staffFather, phone, staffMobile, day, month, year).Clear();

            // staffController.searchstudent(grNo, familyCode, stdName, fName, phone, fmobile, day, month, year).Clear();

            if (staffIdcheck.Checked == true && staffId.Text != null)
            {
                stId = Convert.ToInt32(staffId.Text);
            }
           
            if (staffNameCheck.Checked == true && nameTextBox.Text != null)
            {
                staffName = nameTextBox.Text;
            }
            if (staffFatherCheck.Checked == true && fatherTextBox.Text != null)
            {
                staffFather = fatherTextBox.Text;
            }
            if (staffPhoneCheck.Checked == true && phoneNoTextBox.Text != null)
            {
                phone = phoneNoTextBox.Text;
            }
            if (staffMobileCheck.Checked == true && mobileNoTextBox.Text != null)
            {
                staffMobile = mobileNoTextBox.Text;
            }
            if (staffDOBCheck.Checked == true && dayComboBox.Text != null && monthComboBox.Text != null && yearComboBox.Text != null)
            {
                day = Convert.ToInt32(dayComboBox.Text);
                month = monthComboBox.Text;
                year = Convert.ToInt32(yearComboBox.Text);
            }
            staffGridView.DataSource = staffController.searchStaff(stId, staffName, staffFather, phone, staffMobile, day, month, year);

        }

        private void editLeft_Click(object sender, EventArgs e)
        {
            staffController.searchStaff().Clear();
            staffGridView.DataSource = staffController.searchStaff();


        }
    }
}
