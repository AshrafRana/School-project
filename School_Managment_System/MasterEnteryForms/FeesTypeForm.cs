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
    public partial class FeesType : MetroFramework.Forms.MetroForm
    {
        public FeesType()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int FeeTypeId = 0;

       

        private void FeesType_Load(object sender, EventArgs e)
        {
            feeTypeDataGridView.DataSource = mec.feeTypeDataGridView();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (feeName.Text != "")
            {

                MessageBox.Show(mec.feeTypeInsert(feeName.Text.Trim()));
                mec.feeTypeDataGridView().Clear();
                feeTypeDataGridView.DataSource = mec.feeTypeDataGridView();
                feeName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (feeName.Text != "" && FeeTypeId > 0)
            {
              
                MessageBox.Show(mec.feeTypeUpdate(FeeTypeId ,feeName.Text.Trim() ));
                mec.feeTypeDataGridView().Clear();
                feeTypeDataGridView.DataSource = mec.feeTypeDataGridView();
                FeeTypeId = 0;
                feeName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (feeName.Text != "")
            {

                MessageBox.Show(mec.feeTypeDelete(feeName.Text.Trim()));
                mec.feeTypeDataGridView().Clear();
                feeTypeDataGridView.DataSource = mec.feeTypeDataGridView();
                feeName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void feeTypeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = feeTypeDataGridView.Rows[e.RowIndex];
                FeeTypeId = Convert.ToInt32(row.Cells["FeeTypeId"].Value.ToString());
                feeName.Text = row.Cells["FeeType"].Value.ToString();

            }
        }

        private void feeName_KeyPress(object sender, KeyPressEventArgs e)
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
