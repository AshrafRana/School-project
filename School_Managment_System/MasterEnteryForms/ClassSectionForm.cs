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
    public partial class ClassSectionForm : MetroFramework.Forms.MetroForm
    {
        MasterEnteriesController mec = new MasterEnteriesController();
        int sectionId = 0, class_id = 0 , classSessionId = 0;

        public ClassSectionForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && sectionNameCombo.Text != "" && maxStudentText.Text != "")
            {
                int maxStudent = Convert.ToInt32(maxStudentText.Text.Trim());
                int enRollStudent = 0;
                MessageBox.Show(mec.classSectionInsert(classNameComb.Text.Trim(), sectionNameCombo.Text.Trim(), maxStudent, enRollStudent));
                mec.classSectionDataGridView().Clear();
                classSectiondataGrid.DataSource = mec.classSectionDataGridView();
                classNameComb.Text = null;
                sectionNameCombo.Text = null;
                maxStudent = 0;

            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && sectionNameCombo.Text != "" && maxStudentText.Text != "" && classSessionId > 0)
            {
                int maxStudent = Convert.ToInt32(maxStudentText.Text.Trim());
                MessageBox.Show(mec.classSectionUpdate(classNameComb.Text.Trim(), sectionNameCombo.Text.Trim(), maxStudent, classSessionId));
                mec.classSectionDataGridView().Clear();
                classSectiondataGrid.DataSource = mec.classSectionDataGridView();
                classNameComb.Text = null;
                sectionNameCombo.Text = null;
                maxStudentText.Text = "0";
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && sectionNameCombo.Text != "" && classSessionId > 0)
            {

                MessageBox.Show(mec.classSectionDelete(classNameComb.Text.Trim(), sectionNameCombo.Text.Trim()));
                mec.classSectionDataGridView().Clear();
                classSectiondataGrid.DataSource = mec.classSectionDataGridView();
                classNameComb.Text = null;
                sectionNameCombo.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateMaxStudentBtn_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && sectionNameCombo.Text != "" && maxStudentText.Text != "" && classSessionId > 0)
            {
                int maxStudent = Convert.ToInt32(maxStudentText.Text.Trim());
                MessageBox.Show(mec.classSectionExdentStudent(maxStudent, classSessionId));
                mec.classSectionDataGridView().Clear();
                classSectiondataGrid.DataSource = mec.classSectionDataGridView();
                classNameComb.Text = null;
                sectionNameCombo.Text = null;
                maxStudentText.Text = "0";
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

        private void maxStudentText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void ClassSectionForm_Load(object sender, EventArgs e)
        {
            foreach (var item in mec.classCombobox())
            {
                classNameComb.Items.Add(item);
            }
            foreach (var item in mec.sectionCombobox())
            {
                sectionNameCombo.Items.Add(item);
            }

            classSectiondataGrid.DataSource = mec.classSectionDataGridView();
        }

        private void classSectiondataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = classSectiondataGrid.Rows[e.RowIndex];
                classNameComb.Text = row.Cells["Class"].Value.ToString();
                sectionNameCombo.Text = row.Cells["SectionName"].Value.ToString();
                maxStudentText.Text = row.Cells["MaxStudent"].Value.ToString();
                
                class_id = mec.classIdSelect(row.Cells["Class"].Value.ToString());
                sectionId = mec.sectionIdSelect(row.Cells["SectionName"].Value.ToString());
                classSessionId = mec.classSectionIdSelect(class_id, sectionId);
            }
        }
    }
}
