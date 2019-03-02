using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace School_Managment_System
{
    public partial class Edit_Staff : MetroFramework.Forms.MetroForm
    {
        string imagePath = null;
        string fingerprint = null;
        string newImagePath = null;
        string newFingerprint = null;



        //  string basicFixSalary = null;

        MasterEnteriesController mec = new MasterEnteriesController();
        StaffController stfController = new StaffController();
        OpenFileDialog StaffImageopen = new OpenFileDialog();
        OpenFileDialog StaffFingerPrintopen = new OpenFileDialog();
        int StaffId = 0;
        int width = 100, height = 100;
        string willTeach = null;



        public Edit_Staff(int stafId)
        {
            InitializeComponent();
            this.StaffId = stafId;
        }

        private void Edit_Staff_Load(object sender, EventArgs e)
        {

            List<string> l = stfController.selectStaffById(StaffId);
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int Year = Convert.ToInt32(DateTime.Now.Year.ToString());


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
            

            staffIdTextBox.Text = l[0];
            staffName.Text = l[1];
            shortName.Text = l[2];
            Gender.Text = l[3];
            maritalStatus.Text = l[4];

            fatherName.Text = l[5];
            day.Text = l[6];
            month.Text = l[7];
            year.Text = l[8];
            phoneNo.Text = l[9];
            mobileNo.Text = l[10];
            email.Text = l[11];
            cnicNo.Text = l[12];
            bloodGroup.Text = l[13];
            address.Text = l[14];
           
            string pic = l[15];
            string filePath = Application.StartupPath + "\\StaffImage\\" + pic;
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {

                Image originalImage = Image.FromStream(stream);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);
                }
                staffImage.Image = result;
                imagePath = pic;
                stream.Dispose();
            }

            
             pic = l[16];
             filePath = Application.StartupPath + "\\StaffImage\\" + pic;
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {

                Image originalImage = Image.FromStream(stream);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);
                }
                fingerPrintImage.Image = result;
                fingerprint = pic;
                stream.Dispose();
            }


            qualitification.Text = l[17];
            personalEducation.Text = l[18];
            personalExperience.Text = l[19];
            goodAt.Text = l[20];


            appointed.Text = l[21];
            if (l[22] == "will Teach")
            {
                willTeachCheckBox.Checked = true;
            }

            desigantionCombobox.Text = l[23];
            department.Text =  l[24];
            shiftComboBox.Text = l[25];
            status.Text = l[26];
            leaveDate.Text = l[27];

            payScaleTextBox.Text = l[28];
            basicSalaryTextBox.Text = l[29];
            allowancesTextBox.Text = l[30];
            lastIncreamentTextBox.Text = l[31];
            lastIncreamentDate.Text = l[32];
            specialBonusTextBox.Text = l[33];
           
            scaleHLTextBox.Text = l[34];
            scaleSLTextBox.Text = l[35];
            bankAccountTextBox.Text = l[36];

            dailyJoinsAtComboBox.Text = l[37];
            leaveAtComboBox.Text = l[38];
            fridayLeaveTimeComboBox.Text = l[39];
            annualLeaveTextBox.Text = l[40];
            monthlyAllowedTextBox.Text = l[41];
            fixedSalaryTextBox.Text = l[42];

        }

        private void updateInformationButton_Click(object sender, EventArgs e)
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

                annualLeaveTextBox.Text = (Convert.ToInt32(monthlyAllowedTextBox.Text) * 12).ToString();

                fixedSalaryTextBox.Text = (Convert.ToInt32(basicSalaryTextBox.Text) + Convert.ToInt32(allowancesTextBox.Text)).ToString();

                MessageBox.Show(stfController.staffUpdate(staffIdTextBox.Text, staffName.Text, shortName.Text, Gender.Text, fatherName.Text, phoneNo.Text, email.Text, cnicNo.Text, maritalStatus.Text, mobileNo.Text, day.Text, month.Text, year.Text, bloodGroup.Text, address.Text, imagePath, fingerprint, qualitification.Text, personalEducation.Text, personalExperience.Text, goodAt.Text, appointed.Text, department.Text, desigantionCombobox.Text, shiftComboBox.Text, status.Text, leaveAtComboBox.Text, willTeach, payScaleTextBox.Text, basicSalaryTextBox.Text, allowancesTextBox.Text, lastIncreamentTextBox.Text, lastIncreamentDate.Text, specialBonusTextBox.Text, bankAccountTextBox.Text, scaleHLTextBox.Text, scaleSLTextBox.Text, dailyJoinsAtComboBox.Text, leaveAtComboBox.Text, fridayLeaveTimeComboBox.Text, annualLeaveTextBox.Text, monthlyAllowedTextBox.Text, fixedSalaryTextBox.Text));
               
                if (newImagePath != null)
                {
                    string StaffImage = StaffImageopen.FileName;
                    File.Copy(StaffImage, Application.StartupPath + "\\StaffImage\\" + staffIdTextBox.Text + Path.GetExtension(StaffImageopen.FileName));

                }
                if (newFingerprint != null)
                {
                    string StaffFingerPrint = StaffFingerPrintopen.FileName;
                    File.Copy(StaffFingerPrint, Application.StartupPath + "\\StaffFingerPrint\\" + staffIdTextBox.Text + Path.GetExtension(StaffFingerPrintopen.FileName));

                }
                StaffId = 0;
                newImagePath = "";
                newFingerprint = "";
                imagePath = "";
                fingerprint = "";
                this.Close();
            }
        }

        private void browsePictureButton_Click(object sender, EventArgs e)
        {
            // open file dialog   

            // image filters  
            StaffImageopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (StaffImageopen.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Application.StartupPath + "\\StaffImage\\" + imagePath))
                {
                    File.Delete(Application.StartupPath + "\\StaffImage\\" + imagePath);
                }

                Image originalImage = Image.FromFile(StaffImageopen.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);

                }

                staffImage.Image = result;

                imagePath = staffIdTextBox.Text + Path.GetExtension(StaffImageopen.FileName);
                newImagePath = imagePath;
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
                if (File.Exists(Application.StartupPath + "\\StaffFingerPrint\\" + fingerprint))
                {
                    File.Delete(Application.StartupPath + "\\StaffFingerPrint\\" + fingerprint);
                }

                Image originalImage = Image.FromFile(StaffFingerPrintopen.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);

                }

                fingerPrintImage.Image = result;

                fingerprint = staffIdTextBox.Text + Path.GetExtension(StaffFingerPrintopen.FileName);

                    newFingerprint = fingerprint;
            }


            else
            {
                MessageBox.Show("Image does not selected");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (nameTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter Name");
            //}

            //else if (GenderCmbo.Text == "")
            //{

            //    MessageBox.Show("Enter Gender");
            //}

            //else if (fatherNameTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Father Name");

            //}

            //else if (phoneNoTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Phone No");
            //}

            //else if (emailTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Email");

            //}
            //else if (cnicNoTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter CNIC");
            //}

            //else if (addressRichTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Address");
            //}
            //else if (shortName.Text == "")
            //{

            //    MessageBox.Show("Enter Short Name");
            //}

            //else if (maritalStatuscomboBox.Text == "")
            //{

            //    MessageBox.Show("Enter Marital Status");
            //}
            //else if (mobileNoTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter Mobile No");

            //}
            //else if (dayComboBox.Text == "")
            //{

            //    MessageBox.Show("Enter No");
            //}
            //else if (monthComboBox.Text == "")
            //{

            //    MessageBox.Show("Enter Month");
            //}
            //else if (yearComboBox.Text == "Enter Year")
            //{

            //    MessageBox.Show("Enter Year");
            //}
            //else if (bloodGroupComboBox.Text == "")
            //{

            //    MessageBox.Show("Enter Blood Group");
            //}

            //else if (imagePath == null)
            //{
            //    MessageBox.Show("Select Student Picture");
            //}

            ////personal education

            //else if (comboBoxQualitification.Text == "")
            //{
            //    MessageBox.Show("Enter Quailification");

            //}

            //else if (educationrichTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Personal Education Detail");
            //}
            //else if (experienceRischBox.Text == "")
            //{
            //    MessageBox.Show("Enter Personal Experience Detail");
            //}

            ////Appointed Teacher

            //else if (appointedComboBox.Text == "")
            //{

            //    MessageBox.Show("Enter Appointed On");
            //}

            //else if (DepartcomboBox.Text == "")
            //{
            //    MessageBox.Show("Enter Department");

            //}
            //else if (designationTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter Designation");
            //}

            //else if (goodAtTextBox.Text == "")
            //{

            //    MessageBox.Show("Enter Good At");
            //}

            //else if (statusComboBox.Text == "")
            //{

            //    MessageBox.Show("Enter Status");
            //}

            //else if (LeaveDate.Text == "")
            //{

            //    MessageBox.Show("Enter Leave Date");
            //}
            ////staff salary

            //else if (paySacle.Text == "")
            //{

            //    MessageBox.Show("Enter Pay Scale");
            //}
            //else if (basicSalary.Text == "")
            //{

            //    MessageBox.Show("Enter Basic Salary");
            //}

            //else if (allowancess.Text == "")
            //{

            //    MessageBox.Show("Enter Allowances");
            //}
            //else if (scaleHL.Text == "")
            //{

            //    MessageBox.Show("Scale H.L");
            //}
            //else if (scaleSL.Text == "")
            //{

            //    MessageBox.Show("Scale S.L");
            //}

            //else if (dailyJons.Text == "")
            //{

            //    MessageBox.Show("Daily Joins At");
            //}

            //else if (leaveAt.Text == "")
            //{

            //    MessageBox.Show("Leave At");
            //}

            //else if (fridayLeaveTime.Text == "")
            //{

            //    MessageBox.Show("Friday Leave Time");
            //}
            //else { }


            //if (presentBasicSalary== true)
            //{

            //    basicFixSalary = persrntBasicSalaryTextBox.Text;
            //}

            //else if (fixedRadioButton.Checked == true)
            //{
            //    basicFixSalary = fixedSalaryTextBox.Text;
            //}

            //else { }


            //if (willTeachCheckBox.Checked == true)
            //{

            //    willTeach = "will Teach";
            //}
            //else
            //{
            //    willTeach = "Not Teach";


            //}


         //   MessageBox.Show(stf.staffUpdate(staffIdTextBox.Text, nameTextBox.Text, shortName.Text, GenderCmbo.Text, fatherNameTextBox.Text, phoneNoTextBox.Text, emailTextBox.Text, cnicNoTextBox.Text, maritalStatuscomboBox.Text, mobileNoTextBox.Text, dayComboBox.Text, monthComboBox.Text, yearComboBox.Text, bloodGroupComboBox.Text, addressRichTextBox.Text, imagePath, fingerprint, comboBoxQualitification.Text, educationrichTextBox.Text, experienceRischBox.Text, appointedComboBox.Text, DepartcomboBox.Text, designationTextBox.Text, goodAtTextBox.Text, statusComboBox.Text, LeaveDate.Text,

           //    paySacle.Text, basicSalary.Text, allowancess.Text,lastIncreament.Text, dateTimePicker.Text, specialBonus.Text, bankAcc.Text, scaleHL.Text, scaleSL.Text, dailyJons.Text, leaveAt.Text,fridayLeaveTime.Text, annualLeaves.Text, monthlyAllowed.Text, presentBasicSalary.Text,basicFixSalary,fixedSalaey.Text, willTeachCheckBox.Text));

            //string StaffImage = StaffImageopen.FileName;
            //File.Copy(StaffImage, Application.StartupPath + "\\Images\\" + GRNo.Text + Path.GetExtension(open.FileName));

            //string StaffFingerPrint = StaffFingerPrintopen.FileName;
            //File.Copy(StaffFingerPrint, Application.StartupPath + "\\Images\\" + GRNo.Text + Path.GetExtension(open.FileName));



        }
    }
}
