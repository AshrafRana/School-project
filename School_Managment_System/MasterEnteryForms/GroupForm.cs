using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace School_Managment_System
{
    public partial class GroupForm : MetroFramework.Forms.MetroForm
        
    {
        public GroupForm()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int GroupId = 0;
        private void Save_Click(object sender, EventArgs e)
        {
            if (groupName.Text != "")
            {

                MessageBox.Show(mec.groupInsert(groupName.Text.Trim()));
                mec.groupDataGridView().Clear();
                groupGridView.DataSource = mec.groupDataGridView();
                groupName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            groupGridView.DataSource = mec.groupDataGridView();
        }

        private void groupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (groupName.Text != "" && GroupId > 0)
            {

                MessageBox.Show(mec.groupUpdate(GroupId, groupName.Text.Trim()));
                mec.groupDataGridView().Clear();
                groupGridView.DataSource = mec.groupDataGridView();
                groupName.Text = null;
                GroupId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void groupGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = groupGridView.Rows[e.RowIndex];
                groupName.Text = row.Cells["Group"].Value.ToString();
                GroupId = Convert.ToInt32(row.Cells["GroupId"].Value.ToString());

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (groupName.Text != "" && GroupId > 0)
            {

                MessageBox.Show(mec.groupDelete(groupName.Text.Trim()));
                mec.groupDataGridView().Clear();
                groupGridView.DataSource = mec.groupDataGridView();
                groupName.Text = null;
                GroupId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }

        }
    }
}
