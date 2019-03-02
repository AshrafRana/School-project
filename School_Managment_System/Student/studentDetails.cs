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
    public partial class studentDetails : MetroFramework.Forms.MetroForm
    {
        public studentDetails()
        {
            InitializeComponent();
        }

        StudentController studentController = new StudentController();
        MasterEnteriesController mec = new MasterEnteriesController();
        int grNo = 0;
        string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int Year = Convert.ToInt32(DateTime.Now.Year.ToString());

        private void studentDetails_Load(object sender, EventArgs e)
        {
            studentGridView.DataSource = studentController.selectAllStudentRecordDataGridView();
            allCountTextBox.Text = studentController.countAllStudent().ToString();

            foreach (var item in mec.departmentCombobox())
            {
                DepartComboBox.Items.Add(item);
            }
            foreach (var item in mec.classCombobox())
            {
                classComboBox.Items.Add(item);
            }


            for (int i = 1; i <= 30; i++)
            {
                dayComboBox.Items.Add(i.ToString());
            }
            for (int i = Year; i >= 1985; i--)
            {
                yearComboBox.Items.Add(i.ToString());
            }
            for (int i = 0; i < month.Length; i++)
            {
                monthComboBox.Items.Add(month[i]);
            }
            foreach (var item in mec.groupNameCombobox())
            {
                groupCombo.Items.Add(item);
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddNewStudent studentAdd = new AddNewStudent();

            studentAdd.Show();


        }

        private void studentGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentGridView.Rows[e.RowIndex];
                grNo = Convert.ToInt32((row.Cells["GRNo"].Value.ToString()));
             }
        }

        private void studentGridView_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (grNo > 0)
            {
                EditStudent es = new EditStudent(grNo);
                es.Show();
            }
            else
            {
                MessageBox.Show("Select Row which you Delete");
            }
        }

        private void studentGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentGridView.Rows[e.RowIndex];
                grNo = Convert.ToInt32((row.Cells["GRNo"].Value.ToString()));
                EditStudent es = new EditStudent(grNo);
                es.Show();
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (grNo > 0)
            {
                MessageBox.Show(studentController.deleteSingleStudent(grNo));
                studentController.selectAllStudentRecordDataGridView().Clear();
                studentGridView.DataSource = studentController.selectAllStudentRecordDataGridView();
            }
            else
            {
                MessageBox.Show("Select Row which you Delete");
            }

        }

        private void hasLeft_Click(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.selectleftPresentStudentRecordDataGridView("Left");
        }

        private void presentBtn_Click(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.selectleftPresentStudentRecordDataGridView("Present");

        }

        private void allRadio_Click(object sender, EventArgs e)
        {
            
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.selectAllStudentRecordDataGridView();
            allCountTextBox.Text = studentController.countAllStudent().ToString();
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.searchBytGenderRecordDataGridView("Male");
             allCountTextBox.Text = studentController.countStudentByGender("Male").ToString();

        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.searchBytGenderRecordDataGridView("Female");
             allCountTextBox.Text = studentController.countStudentByGender("Female").ToString();

        }

        private void presentRadio_Click(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.selectleftPresentStudentRecordDataGridView("Present");
            allCountTextBox.Text = studentController.CountPresentAndLeftStudent("Present").ToString();
        }

        private void leftRadio_Click(object sender, EventArgs e)
        {
            studentController.selectAllStudentRecordDataGridView().Clear();
            studentGridView.DataSource = studentController.selectleftPresentStudentRecordDataGridView("Left");
            allCountTextBox.Text = studentController.CountPresentAndLeftStudent("Left").ToString();
        }

        private void DepartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartComboBox.Text != "")
            {
                studentController.SearchByDepartmentRecordDataGridView(DepartComboBox.Text).Clear();
                studentGridView.DataSource = studentController.SearchByDepartmentRecordDataGridView(DepartComboBox.Text);
                allCountTextBox.Text = studentController.countDepartmentStudent(DepartComboBox.Text).ToString();
            }

        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentController.selectStudentByClassRecordDataGridView(classComboBox.Text).Clear();
            studentGridView.DataSource = studentController.selectStudentByClassRecordDataGridView(classComboBox.Text);
            allCountTextBox.Text = studentController.countClassStudent(classComboBox.Text).ToString();
            sectionCombobox.Items.Clear();
            if (classComboBox.Text != "")
            {


                int id = mec.classIdSelect(classComboBox.Text);
                foreach (var item in mec.classSectionByClassId(id))
                {
                    sectionCombobox.Items.Add(item);

                }
            }
        }

        private void sectionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentController.selectStudentBySectiontRecordDataGridView(classComboBox.Text, sectionCombobox.Text).Clear();
            studentGridView.DataSource = studentController.selectStudentBySectiontRecordDataGridView(classComboBox.Text , sectionCombobox.Text);
            allCountTextBox.Text = studentController.countClassSectionStudent(classComboBox.Text, sectionCombobox.Text).ToString();
        }

        private void Sreach_Click(object sender, EventArgs e)
        {
            int grNo = 0, familyCode = 0;
            string stdName = null;
            string fName = null;
            string phone = null;
            string fmobile = null;
            int day = 0;
            string month = null;
            int year = 0;

            studentController.searchstudent(grNo, familyCode, stdName, fName, phone, fmobile, day, month, year).Clear();

            if (GRNOCheckBox.Checked == true && GRNoText.Text != null)
            {
                grNo =Convert.ToInt32(GRNoText.Text);
            }
           if (familCodeCheckBox.Checked == true && familyCodeText.Text != null)
            {
                familyCode = Convert.ToInt32(familyCodeText.Text);
            }
            if (StudentNameCheckBox.Checked == true && studentNameTextBox.Text != null)
            {
                stdName = studentNameTextBox.Text;
            }
             if (FatherCheckBox.Checked == true && fatherNameTextBox.Text != null)
            {
                fName = fatherNameTextBox.Text;
            }
             if (phoneCheckBox.Checked == true && phoneNoTextBox.Text != null)
            {
                phone = phoneNoTextBox.Text;
            }
             if (fatherMobileCheckBox.Checked == true && fatherMobileTextBox.Text != null)
            {
                fmobile = fatherMobileTextBox.Text;
            }
             if (dateofBirthCheckBox.Checked == true && dayComboBox.Text != null && monthComboBox.Text != null && yearComboBox.Text != null)
            {
                day = Convert.ToInt32(dayComboBox.Text);
                month = monthComboBox.Text;
                year = Convert.ToInt32(yearComboBox.Text);
            }
            studentGridView.DataSource = studentController.searchstudent( grNo,  familyCode,  stdName,  fName,  phone,  fmobile,  day,  month,  year);
           
        }

        private void groupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentController.selectStudentByGroupRecordDataGridView(groupCombo.Text).Clear();
            studentGridView.DataSource = studentController.selectStudentByGroupRecordDataGridView(groupCombo.Text);
            allCountTextBox.Text = studentController.CountGroupStudent(groupCombo.Text).ToString();
        }

        private void phoneNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void familyCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

        }

        private void studentNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void editLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
