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
    public partial class SectionEntry : MetroFramework.Forms.MetroForm
    {
        public SectionEntry()
        {
            InitializeComponent();
        }

        MasterEnteriesController mec = new MasterEnteriesController();
        int sectionId = 0;

        private void SectionEntry_Load(object sender, EventArgs e)
        {
            sectionGridView.DataSource = mec.sectionDataGridView();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (sectionName.Text != "")
            {

                MessageBox.Show(mec.sectionInsert(sectionName.Text.Trim()));
                mec.sectionDataGridView().Clear();
                sectionGridView.DataSource = mec.sectionDataGridView();
                sectionName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (sectionName.Text != "" && sectionId > 0)
            {

                MessageBox.Show(mec.sectionUpdate(sectionId,sectionName.Text.Trim()));
                mec.sectionDataGridView().Clear();
                sectionGridView.DataSource = mec.sectionDataGridView();
                sectionName.Text = null;
                sectionId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (sectionName.Text != "")
            {

                MessageBox.Show(mec.sectionDelete(sectionName.Text.Trim()));
                mec.sectionDataGridView().Clear();
                sectionGridView.DataSource = mec.sectionDataGridView();
                sectionName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void sectionGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sectionGridView.Rows[e.RowIndex];
                sectionId = Convert.ToInt32(row.Cells["sectionId"].Value.ToString());
                sectionName.Text = row.Cells["SectionName"].Value.ToString();

            }
        }

        private void sectionName_KeyPress(object sender, KeyPressEventArgs e)
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
