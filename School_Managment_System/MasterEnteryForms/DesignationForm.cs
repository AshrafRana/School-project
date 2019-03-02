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
    public partial class Designation : MetroFramework.Forms.MetroForm
    {
        MasterEnteriesController mec = new MasterEnteriesController();

        public Designation()
        {
            InitializeComponent();
        }
        int Desig_id = 0;

        private void Designation_Load(object sender, EventArgs e)
        {
            designationGridView.DataSource = mec.designationDataGridView();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           

            if (designationName.Text != "")
            {

                MessageBox.Show(mec.desiganationInsert(designationName.Text.Trim()));
                mec.designationDataGridView().Clear();
                designationGridView.DataSource = mec.designationDataGridView();
                designationName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void designationGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = designationGridView.Rows[e.RowIndex];
                designationName.Text = row.Cells["Designation"].Value.ToString();
                Desig_id = Convert.ToInt32(row.Cells["DesignationId"].Value.ToString());
               
            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
          

            if (designationName.Text != "" && Desig_id > 0)
            {

                MessageBox.Show(mec.desiganationtUpdate(Desig_id, designationName.Text.Trim()));
                mec.designationDataGridView().Clear();
                designationGridView.DataSource = mec.designationDataGridView();
                designationName.Text = null;
                Desig_id = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
            if (designationName.Text != "")
            {

                MessageBox.Show(mec.desiganationtDelete(designationName.Text.Trim()));
                mec.designationDataGridView().Clear();
                designationGridView.DataSource = mec.designationDataGridView();
                designationName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void designationName_KeyPress(object sender, KeyPressEventArgs e)
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
