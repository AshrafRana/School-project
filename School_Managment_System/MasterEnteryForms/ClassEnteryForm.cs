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
    public partial class ClassEntery : MetroFramework.Forms.MetroForm
    {

        public ClassEntery()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int DeptId = 0, class_id = 0;

        private void ClassEntery_Load(object sender, EventArgs e)
        {
            foreach (var item in mec.departmentCombobox())
            {
                departmentComb.Items.Add(item);
            }
            
            classMetroGrid.DataSource = mec.classDataGridView();
        }

        
        private void Save_Click(object sender, EventArgs e)
        {
            if (className.Text != "" && departmentComb.Text != "")
            {
                
                MessageBox.Show(mec.classInsert(className.Text.Trim(), departmentComb.Text.Trim()));
                mec.classDataGridView().Clear();
                classMetroGrid.DataSource = mec.classDataGridView();
                className.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");
           
            }

        }

        private void classMetroGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = classMetroGrid.Rows[e.RowIndex];
                className.Text = row.Cells["Class"].Value.ToString();
                departmentComb.Text  = row.Cells["Departments"].Value.ToString();
                class_id = mec.classIdSelect(row.Cells["Class"].Value.ToString());
               
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (className.Text != "" && departmentComb.Text != "")
            {
                MessageBox.Show(mec.classDelete(className.Text.Trim()));
                mec.classDataGridView().Clear();
                classMetroGrid.DataSource = mec.classDataGridView();
                className.Text = null;
                DeptId = 0;
                class_id = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

        private void className_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upate_Click(object sender, EventArgs e)
        {
           
            if (className.Text != "" && departmentComb.Text != "" && class_id > 0)
            {
                DeptId = mec.departmentIdSelect(departmentComb.Text.Trim());
                MessageBox.Show(mec.classUpdate(class_id,className.Text.Trim(), DeptId));
                mec.classDataGridView().Clear();
                classMetroGrid.DataSource = mec.classDataGridView();
                className.Text = null;
                DeptId = 0;
                class_id = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

       
    }
}
