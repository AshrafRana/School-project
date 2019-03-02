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
    public partial class Department : MetroFramework.Forms.MetroForm
    {
        public Department()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int DeptId = 0;
        private void Department_Load(object sender, EventArgs e)
        {
            departmentGridView.DataSource = mec.departmentDataGridView();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (departmentName.Text != "")
            {

                MessageBox.Show(mec.departmentInsert(departmentName.Text.Trim()));
                mec.departmentDataGridView().Clear();
                departmentGridView.DataSource = mec.departmentDataGridView();
                departmentName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
           
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            
            if (departmentName.Text != "" && DeptId > 0)
            {

                MessageBox.Show(mec.departmentUpdate(DeptId, departmentName.Text.Trim()));
                mec.departmentDataGridView().Clear();
                departmentGridView.DataSource = mec.departmentDataGridView();
                departmentName.Text = null;
                DeptId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void departmentGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = departmentGridView.Rows[e.RowIndex];
                DeptId = Convert.ToInt32((row.Cells["DeptId"].Value.ToString()));
                departmentName.Text = row.Cells["Departments"].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (departmentName.Text != "")
            {

                MessageBox.Show(mec.departmentDelete(departmentName.Text.Trim()));
                mec.departmentDataGridView().Clear();
                departmentGridView.DataSource = mec.departmentDataGridView();
                departmentName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void departmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
