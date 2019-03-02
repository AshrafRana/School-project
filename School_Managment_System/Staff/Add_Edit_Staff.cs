using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Resources;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace School_Managment_System
{
    public partial class Add_Edit_Staff : MetroFramework.Forms.MetroForm

    {
        MasterEnteriesController mec = new MasterEnteriesController();
        StaffController stfController = new StaffController();
        OpenFileDialog StaffImageopen = new OpenFileDialog();
        OpenFileDialog StaffFingerPrintopen = new OpenFileDialog();
        int width = 100, height = 100;
        string imagePath = null;
        string fingerprint = null;
      //  string  basicFixSalary = null;
        string willTeach = null;

        public Add_Edit_Staff()
        {
            InitializeComponent();
        }

        
        private void Add_Edit_Staff_Load(object sender, EventArgs e)
        {
          //  staffIdTextBox.Text = mec.studentLastIdSelect().ToString();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int Year = Convert.ToInt32(DateTime.Now.Year.ToString());
            dailyJoinsAtComboBox.Text = "8:00 AM";
            leaveAtComboBox.Text = "1:00 AM";
            fridayLeaveTimeComboBox.Text = "11:59 AM";
            
            foreach (var item in mec.designationCombobox())
            {
                desigantionCombobox.Items.Add(item);
            }
            foreach (var item in mec.departmentCombobox())
            {
                department.Items.Add(item);
            }
            for (int i = 1; i <= 30; i++)
            {
                day.Items.Add(i.ToString());
            }
            for (int i = Year; i >= 1985; i--)
            {
                year.Items.Add(i.ToString());
            }
            for (int i = 0; i < months.Length; i++)
            {
                month.Items.Add(months[i]);
            }

            staffIdTextBox.Text = stfController.staffLastIdSelect().ToString();
            //staffName.Text = "helo";
            //shortName.Text = "helo";
            //Gender.Text = "helo";
            //fatherName.Text = "helo";
            //phoneNo.Text = "helo";
            //email.Text = "helo";
            //cnicNo.Text = "helo";
            //maritalStatus.Text = "helo";
            //mobileNo.Text = "helo";
            //day.Text = "4";
            //month.Text = "helo";
            //year.Text = "4";
            //bloodGroup.Text = "helo";
            //address.Text = "helo";
            //imagePath = "helo";
            //fingerprint = "helo";
            //qualitification.Text = "helo";
            //personalEducation.Text = "helo";
            //personalExperience.Text = "helo";
            //appointed.Text = "helo";
            //department.Text = "helo";
            //designation.Text = "helo";
            //goodAt.Text = "helo";
            //status.Text = "helo";
            //leaveAtComboBox.Text = "helo";
            //payScaleTextBox.Text = "4";
            //basicSalaryTextBox.Text = "3";
            //allowancesTextBox.Text = "3";
            lastIncreamentTextBox.Text = "0";
            ////  onDateTimePicker.Text = "3";
            //specialBonusTextBox.Text = "3";
            //bankAccountTextBox.Text = "3";
            //scaleHLTextBox.Text = "3";
            //scaleSLTextBox.Text = "3";
            //dailyJoinsAtComboBox.Text = "3";
            //leaveAtComboBox.Text = "3";
            //fridayLeaveTimeComboBox.Text = "3";
            //annualLeaveTextBox.Text = "3";
            //monthlyAllowedTextBox.Text = "3";
            //persrntBasicSalaryTextBox.Text = "3";
            //basicFixSalary = "3";
            //fixedSalaryTextBox.Text = "helo";

            leaveDate.Text = "";
            fixedSalaryTextBox.Text = "0";
        }

        private void saveInformationButton_Click(object sender, EventArgs e)
        {
            
            if (staffName.Text == "")
            {
                MessageBox.Show("Enter Name");
            }

            else if (Gender.Text == "")
            {

                MessageBox.Show("Enter Gender");
            }

            else if (fatherName.Text == "")
            {

                MessageBox.Show("Enter Father Name");

            }

            else if (cnicNo.Text == "")
            {
                MessageBox.Show("Enter CNIC");
            }

            else if (address.Text == "")
            {

                MessageBox.Show("Enter Address");
            }

            else if (maritalStatus.Text == "")
            {

                MessageBox.Show("Enter Marital Status");
            }
            else if (mobileNo.Text == "")
            {
                MessageBox.Show("Enter Mobile No");

            }
            else if (day.Text == "")
            {

                MessageBox.Show("Enter Day");
            }
            else if (month.Text == "")
            {

                MessageBox.Show("Enter Month");
            }
            else if (year.Text == "Enter Year")
            {

                MessageBox.Show("Enter Year");
            }
            else if (bloodGroup.Text == "")
            {

                MessageBox.Show("Enter Blood Group");
            }

            else if (imagePath == null)
            {
                MessageBox.Show("Select Student Picture");
            }

            //personal education

            else if (qualitification.Text == "")
            {
                MessageBox.Show("Enter Quailification");

            }



            //Appointed Teacher



            else if (department.Text == "")
            {
                MessageBox.Show("Enter Department");

            }
            else if (desigantionCombobox.Text == "")
            {
                MessageBox.Show("Enter Designation");
            }




            //staff salary


            else if (basicSalaryTextBox.Text == "")
            {

                MessageBox.Show("Enter Basic Salary");
            }



            else if (dailyJoinsAtComboBox.Text == "")
            {

                MessageBox.Show("Daily Joins At");
            }

            else if (leaveAtComboBox.Text == "")
            {

                MessageBox.Show("Leave At");
            }

            else if (fridayLeaveTimeComboBox.Text == "")
            {

                MessageBox.Show("Friday Leave Time");
            }
            else
            {

                if (willTeachCheckBox.Checked == true)
                {

                    willTeach = "will Teach";
                }
                else
                {
                    willTeach = "Not Teach";


                }

                annualLeaveTextBox.Text = (Convert.ToInt32(monthlyAllowedTextBox.Text)*12).ToString();

                fixedSalaryTextBox.Text = (Convert.ToInt32(basicSalaryTextBox.Text) + Convert.ToInt32(allowancesTextBox.Text)).ToString();

                MessageBox.Show(stfController.staffInsert(staffName.Text, shortName.Text, Gender.Text, fatherName.Text, phoneNo.Text, email.Text, cnicNo.Text, maritalStatus.Text, mobileNo.Text, day.Text, month.Text, year.Text, bloodGroup.Text, address.Text, imagePath, fingerprint, qualitification.Text, personalEducation.Text, personalExperience.Text, goodAt.Text, appointed.Text, department.Text, desigantionCombobox.Text, shiftComboBox.Text, status.Text, leaveAtComboBox.Text, willTeach, payScaleTextBox.Text, basicSalaryTextBox.Text, allowancesTextBox.Text, lastIncreamentTextBox.Text, lastIncreamentDate.Text, specialBonusTextBox.Text, bankAccountTextBox.Text, scaleHLTextBox.Text, scaleSLTextBox.Text, dailyJoinsAtComboBox.Text, leaveAtComboBox.Text, fridayLeaveTimeComboBox.Text, annualLeaveTextBox.Text, monthlyAllowedTextBox.Text, fixedSalaryTextBox.Text));

                string StaffImage = StaffImageopen.FileName;
                File.Copy(StaffImage, Application.StartupPath + "\\StaffImage\\" + staffIdTextBox.Text + Path.GetExtension(StaffImageopen.FileName));

                string StaffFingerPrint = StaffFingerPrintopen.FileName;
                File.Copy(StaffFingerPrint, Application.StartupPath + "\\StaffFingerPrint\\" + staffIdTextBox.Text + Path.GetExtension(StaffFingerPrintopen.FileName));

            }
        }


        private void browsePictureButton_Click(object sender, EventArgs e)
        {
           
            // open file dialog   

            // image filters  
            StaffImageopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (StaffImageopen.ShowDialog() == DialogResult.OK)
            {

                Image originalImage = Image.FromFile(StaffImageopen.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);

                }

                staffImage.Image = result;

                imagePath = staffIdTextBox.Text + Path.GetExtension(StaffImageopen.FileName);
            }


            else
            {
                MessageBox.Show("Image does not selected");
            }

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
           
            // open file dialog   

            // image filters  
            StaffFingerPrintopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (StaffFingerPrintopen.ShowDialog() == DialogResult.OK)
            {

                Image originalImage = Image.FromFile(StaffFingerPrintopen.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);

                }

                fingerPrintImage.Image = result;

                fingerprint = staffIdTextBox.Text + Path.GetExtension(StaffFingerPrintopen.FileName);
            }


            else
            {
                MessageBox.Show("Image does not selected");
            }

        }

        private void staffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        private void fatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void shortName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

       
        private void mobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-@_.\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void cnicNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-/\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void staffIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void bloodGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-+/\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void goodAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }



        private void basicSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void payScaleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void specialBonusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

        }

        private void monthlyAllowedTextBox_Leave(object sender, EventArgs e)
        {
            if (monthlyAllowedTextBox.Text != "")
            {
                annualLeaveTextBox.Text = (Convert.ToInt32(monthlyAllowedTextBox.Text) * 12).ToString();

            }

        }

       

        private void bankAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

    }
}

