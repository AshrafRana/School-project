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
    public partial class SubjectEntry : MetroFramework.Forms.MetroForm
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int subjectId = 0;
        private void SubjectEntry_Load(object sender, EventArgs e)
        {
            subjectEntryGridView.DataSource = mec.subjectDataGridView();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (subjectName.Text != "" )
            {

                MessageBox.Show(mec.subjectInsert(subjectName.Text.Trim()));
                mec.subjectDataGridView().Clear();
                subjectEntryGridView.DataSource = mec.subjectDataGridView();
                subjectName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (subjectName.Text != "" && subjectId > 0)
            {

                MessageBox.Show(mec.subjectUpdate(subjectId, subjectName.Text.Trim()));
                mec.subjectDataGridView().Clear();
                subjectEntryGridView.DataSource = mec.subjectDataGridView();
                subjectId = 0;
                subjectName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void subjectEntryGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = subjectEntryGridView.Rows[e.RowIndex];
                subjectName.Text = row.Cells["SubjectName"].Value.ToString();
                subjectId =Convert.ToInt32(row.Cells["subjectId"].Value.ToString());
               
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (subjectName.Text != "")
            {

                MessageBox.Show(mec.subjectDelete(subjectName.Text.Trim()));
                mec.subjectDataGridView().Clear();
                subjectEntryGridView.DataSource = mec.subjectDataGridView();
                subjectName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void subjectName_KeyPress(object sender, KeyPressEventArgs e)
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
