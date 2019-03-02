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
    public partial class ClassSessionSubject : MetroFramework.Forms.MetroForm
    {
        public ClassSessionSubject()
        {
            InitializeComponent();
        }

        MasterEnteriesController mec = new MasterEnteriesController();
        int ClassSubjId = 0, ClassId = 0, subjectId = 0;
        private void ClassSessionSubject_Load(object sender, EventArgs e)
        {
            classSubjectGridView.DataSource = mec.classSubjectDataGridView();
            foreach (var item in mec.classCombobox())
            {
                classNameComb.Items.Add(item);
            }

            foreach (var item in mec.subjectCombobox())
            {
                subjectNameCombo.Items.Add(item);
            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && subjectNameCombo.Text != "" && ClassSubjId > 0)
            {

                MessageBox.Show(mec.classSubjectUpdate(classNameComb.Text.Trim(), subjectNameCombo.Text.Trim(), ClassSubjId));
                mec.classSubjectDataGridView().Clear();
                classSubjectGridView.DataSource = mec.classSubjectDataGridView();
                classNameComb.Text = null;
                subjectNameCombo.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && subjectNameCombo.Text != "" && ClassSubjId > 0)
            {

                MessageBox.Show(mec.classSubjectDelete(classNameComb.Text.Trim(), subjectNameCombo.Text.Trim()));
                mec.classSubjectDataGridView().Clear();
                classSubjectGridView.DataSource = mec.classSubjectDataGridView();
                classNameComb.Text = null;
                subjectNameCombo.Text = null;
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && subjectNameCombo.Text != "")
            {

                MessageBox.Show(mec.classSubjectInsert(classNameComb.Text.Trim(), subjectNameCombo.Text.Trim()));
                mec.classSubjectDataGridView().Clear();
                classSubjectGridView.DataSource = mec.classSubjectDataGridView();
                classNameComb.Text = null;
                subjectNameCombo.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void classSubjectGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = classSubjectGridView.Rows[e.RowIndex];
                classNameComb.Text = row.Cells["Class"].Value.ToString();
                subjectNameCombo.Text = row.Cells["SubjectName"].Value.ToString();
                ClassId = mec.classIdSelect(row.Cells["Class"].Value.ToString());
                subjectId = mec.subjectIdSelect(row.Cells["SubjectName"].Value.ToString());
                ClassSubjId = mec.selectClassSubjectIdUpdate(ClassId, subjectId);
                
            }
        }
    }
}
