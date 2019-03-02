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
    public partial class ClassFee : MetroFramework.Forms.MetroForm
    {
        public ClassFee()
        {
            InitializeComponent();
        }

        MasterEnteriesController mec = new MasterEnteriesController();
        int class_id=0, FeeTypeId=0, ClassFeeId=0;
        private void ClassFee_Load(object sender, EventArgs e)
        {
            foreach (var item in mec.classCombobox())
            {
                classNameComb.Items.Add(item);
            }
           
            foreach (var item in mec.feeTypeCombobox())
            {
                feeTypeComb.Items.Add(item);
            }

            classFeeGridView.DataSource = mec.classFeeDataGridView();
        }

        private void Fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && feeTypeComb.Text != "" && feeAmount.Text != "")
            {

                MessageBox.Show(mec.classFeeInsert(classNameComb.Text.Trim(), feeTypeComb.Text.Trim() ,  feeAmount.Text.Trim()));
                mec.classFeeDataGridView().Clear();
                classFeeGridView.DataSource = mec.classFeeDataGridView();
                classNameComb.Text = null;
                feeTypeComb.Text = null;
                feeAmount.Text = null;

            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (classNameComb.Text != "" && feeTypeComb.Text != "" && feeAmount.Text != "" && ClassFeeId > 0)
            {

                MessageBox.Show(mec.classFeeDelete(classNameComb.Text.Trim(), feeTypeComb.Text.Trim(), feeAmount.Text.Trim()));
                mec.classFeeDataGridView().Clear();
                classFeeGridView.DataSource = mec.classFeeDataGridView();
                classNameComb.Text = null;
                feeTypeComb.Text = null;
                feeAmount.Text = null;

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

        private void feeUpdateBtn_Click(object sender, EventArgs e)
        {
            if (classNameComb.Text != "" && feeTypeComb.Text != "" && feeAmount.Text != "" && ClassFeeId > 0)
            {
                int feeAmounts = Convert.ToInt32(feeAmount.Text.Trim());
                MessageBox.Show(mec.classFeeUpdate(feeAmounts, ClassFeeId));
                mec.classFeeDataGridView().Clear();
                classFeeGridView.DataSource = mec.classFeeDataGridView();
                classNameComb.Text = null;
                feeTypeComb.Text = null;
                feeAmount.Text = "0";
            }
            else
            {
                MessageBox.Show("Select row in sheet");
            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
           

            if (classNameComb.Text != "" && feeTypeComb.Text != "" && feeAmount.Text != "" && ClassFeeId > 0)
            {

                MessageBox.Show(mec.classFeeUpdate(classNameComb.Text.Trim(), feeTypeComb.Text.Trim(), feeAmount.Text.Trim() , ClassFeeId));
                mec.classFeeDataGridView().Clear();
                classFeeGridView.DataSource = mec.classFeeDataGridView();
                classNameComb.Text = null;
                feeTypeComb.Text = null;
                feeAmount.Text = "0";

            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void classFeeGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = classFeeGridView.Rows[e.RowIndex];
                classNameComb.Text = row.Cells["Class"].Value.ToString();
                feeTypeComb.Text = row.Cells["FeeType"].Value.ToString();
                feeAmount.Text = row.Cells["FeeAmount"].Value.ToString();
                
                class_id = mec.classIdSelect(row.Cells["Class"].Value.ToString());
                FeeTypeId = mec.feeTypeIdSelect(row.Cells["FeeType"].Value.ToString());
                ClassFeeId = mec.classFeeIdSelect(class_id, FeeTypeId);
              
            }
        }
    }
}
