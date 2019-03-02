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
    public partial class AddNewStudent : MetroFramework.Forms.MetroForm
    {
        MasterEnteriesController mec = new MasterEnteriesController();
        StudentController studentController = new StudentController();
        OpenFileDialog open = new OpenFileDialog();
        string imagePath = null;
        string nazraClass = null;
        string ikhlakiatIslamiat = null;
        int classSectionId = 0;

        public AddNewStudent()
        {
            InitializeComponent();
        }


        private void save_Click(object sender, EventArgs e)
        {
            if (studentName.Text == "")
            {
                MessageBox.Show("Enter Student Name");
            }
            else if (studentMobileNo.Text == "")
            {
                MessageBox.Show("Enter Student Student No");
            }

            else if (fatherName.Text == "")
            {
                MessageBox.Show("Enter Student Father Name");
            }

            else if (dayComboBox.Text == "")
            {
                MessageBox.Show("Select Student Birth Day ");
            }
            else if (monthComboBox.Text == "")
            {
                MessageBox.Show("Select Student Birth Month ");
            }
            else if (yearComboBox.Text == "")
            {
                MessageBox.Show("Select Student Birth Year ");
            }
            else if (Religion.Text == "")
            {
                MessageBox.Show("Select Student Religion ");
            }
            else if (motherTongue.Text == "")
            {
                MessageBox.Show("Select Student Mother Tongue ");
            }
            else if (Nationality.Text == "")
            {
                MessageBox.Show("Select Student Nationality ");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select Student blood Group ");
            }
            else if (genderComb.Text == "")
            {
                MessageBox.Show("Select Student Gender ");
            }

            else if (imagePath == null)
            {
                MessageBox.Show("Select Student Picture");
            }
            else if (homeAddress.Text == "")
            {
                MessageBox.Show("Enter Student Address ");
            }
            else if (fatherMobile.Text == "")
            {
                MessageBox.Show("Enter Student Father Mobile Number ");
            }
            else if (departmentCombo.Text == "")
            {
                MessageBox.Show("Select Student Department ");
            }
            else if (classAdmittedCombo.Text == "")
            {
                MessageBox.Show("Select Student Class Admision ");
            }
            else if (currentClassCombo.Text == "")
            {
                MessageBox.Show("Select Student Current Class Admision");
            }
            else if (sectionComboBox.Text == "")
            {
                MessageBox.Show("Select Student Current Class Session");
            }

            else if (feeTypeCombo.Text == "")
            {
                MessageBox.Show("Select Student Fee Type ");
            }

            else if (feeStatusCombo.Text == "")
            {
                MessageBox.Show("Select Student Fee Status ");
            }
            else if (AdmBasedComboBox.Text == "")
            {
                MessageBox.Show("Select Student Admision Base ");
            }
            else if (currentStatusCombo.Text == "")
            {
                MessageBox.Show("Select Student Current Status ");
            }
            
            else
            {
                if (studentName.Text != "" && fatherName.Text != "" && genderComb.Text != "" && dayComboBox.Text != "" && monthComboBox.Text != "" && yearComboBox.Text != "" && imagePath != null && homeAddress.Text != "" && dayComboBox.Text != "" && classAdmittedCombo.Text != "" && currentClassCombo.Text != "" && feeTypeCombo.Text != "" && feeStatusCombo.Text != "" && AdmBasedComboBox.Text != "" && currentStatusCombo.Text != "")
                {

                    if (kidsNo.Text == "")
                    {
                        kidsNo.Text = "0";
                    }
                    if (groupCombo.Text == "")
                    {
                        groupCombo.Text = "0";
                    }
                    if (NazraCheckBox.Checked == true)
                    {
                        nazraClass = "Attend";
                    }
                    else
                    {
                        nazraClass = "Not Attend";
                    }
                    if (ikhlakiatRadio.Checked == true)
                    {
                        ikhlakiatIslamiat = "Ethics";
                    }
                    else if (islamiatRadio.Checked == true)
                    {
                        ikhlakiatIslamiat = "Islamiat";
                    }
                    else
                    {

                    }
                    MessageBox.Show(studentController.studentInsert(studentName.Text, shortName.Text, fatherName.Text, guradianName.Text, genderComb.Text, dayComboBox.Text, monthComboBox.Text, yearComboBox.Text, birthPlace.Text, bFormNo.Text, Religion.Text, motherTongue.Text, Nationality.Text, bloodGroupComboBox.Text, imagePath, studentMobileNo.Text, kidsNo.Text, homePhoneNo.Text, homeAddress.Text, fatherEducation.Text, Caste.Text, monthlyIncome.Text, fatherOccuption.Text, fatherMobile.Text, officePhone.Text, fathhCnicNo.Text, officeAddress.Text, faxNo.Text, fatherEmail.Text, motherCnicNo.Text, motherName.Text, motherOccuption.Text, motherEducation.Text, motherMobile.Text, groupCombo.Text, departmentCombo.Text, dateOfAdmision.Text, classAdmittedCombo.Text, currentClassCombo.Text, sectionComboBox.Text, rollNo.Text, mbEnrollment.Text, mb9thRollNo.Text, mb10thRollNo.Text, feeTypeCombo.Text, feeStatusCombo.Text, AdmBasedComboBox.Text, currentStatusCombo.Text, lastInsitute.Text, nazraClass, ikhlakiatIslamiat, familyCode.Text, classSectionId));

                    string iName = open.FileName;
                    File.Copy(iName, Application.StartupPath + "\\Images\\" + GRNo.Text + Path.GetExtension(open.FileName));
                    studentImage.Invalidate(); imagePath = ""; studentName.Text = null; shortName.Text = null; fatherName.Text = null; guradianName.Text = null; genderComb.Text = null; dayComboBox.Text = null; monthComboBox.Text = null; yearComboBox.Text = null; birthPlace.Text = null; bFormNo.Text = null; Religion.Text = null; motherTongue.Text = null; Nationality.Text = null; bloodGroupComboBox.Text = null; imagePath = null; kidsNo.Text = null; homePhoneNo.Text = null; homeAddress.Text = null; fatherEducation.Text = null; Caste.Text = null; monthlyIncome.Text = null; fatherOccuption.Text = null; fatherMobile.Text = null; officePhone.Text = null; fathhCnicNo.Text = null; officeAddress.Text = null; faxNo.Text = null; fatherEmail.Text = null; motherCnicNo.Text = null; motherName.Text = null; motherOccuption.Text = null; motherEducation.Text = null; motherMobile.Text = null; groupCombo.Text = null; departmentCombo.Text = null; dateOfAdmision.Text = null; classAdmittedCombo.Text = null; currentClassCombo.Text = null; sectionComboBox.Text = null; rollNo.Text = null; mbEnrollment.Text = null; mb9thRollNo.Text = null; mb10thRollNo.Text = null; feeTypeCombo.Text = null; feeStatusCombo.Text = null; AdmBasedComboBox.Text = null; currentStatusCombo.Text = null; lastInsitute.Text = null; nazraClass = null; ikhlakiatIslamiat = null; familyCode.Text = null;
                    GRNo.Text = studentController.studentLastIdSelect().ToString();
                }
                else
                {
                    MessageBox.Show("Filed should not Empty");

                }


            }


        }

        private void selectStudentPicture_Click(object sender, EventArgs e)
        {
            int width = 100, height = 100;
            // open file dialog   
           
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
            
                Image originalImage = Image.FromFile(open.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);
                }

                studentImage.Image = result;
                
                imagePath = GRNo.Text + Path.GetExtension(open.FileName);

            }
            else
            {
                MessageBox.Show("Image does not selected");
            }
           
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int Year = Convert.ToInt32(DateTime.Now.Year.ToString());
           
            foreach (var item in mec.departmentCombobox())
            {
                departmentCombo.Items.Add(item);
            }
            
            foreach (var item in mec.feeTypeCombobox())
            {
                feeTypeCombo.Items.Add(item);
            }
            for (int i = 1; i <=30 ; i++)
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

             GRNo.Text = studentController.studentLastIdSelect().ToString();
        }
        
        
        private void shortName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void birthPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void guradianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void officeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-/\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void studentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void homePhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void fatherEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-@_.\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void fatherMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void motherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        

        private void currentClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            sectionComboBox.Items.Clear();
            if (currentClassCombo.Text != "")
            {

                
                int id = mec.classIdSelect(currentClassCombo.Text);
                foreach (var item in mec.classSectionByClassId(id))
                {
                    sectionComboBox.Items.Add(item);

                }
            }

        }

        private void selectFamilyInfoButton_Click(object sender, EventArgs e)
        {
            List<string> l;
            if (familyCode.Text != null && familyCode.Text != "")
            {
               
            
                if (studentController.selectFamilyInfo(Convert.ToInt32(familyCode.Text)))
                {
                    l = studentController.selectStudentFamilyDataByFamilyCode(Convert.ToInt32(familyCode.Text));
                    kidsNo.Text = l[1].ToString();
                    homeAddress.Text = l[2].ToString();
                    homePhoneNo.Text = l[3].ToString();
                    fatherName.Text = l[4].ToString();
                    fatherMobile.Text = l[5].ToString();
                    fatherEducation.Text = l[6].ToString();
                    Caste.Text = l[7].ToString();
                    monthlyIncome.Text = l[8].ToString();
                    officePhone.Text = l[9].ToString();
                    officeAddress.Text = l[10].ToString();
                    fathhCnicNo.Text = l[11].ToString();
                    faxNo.Text = l[12].ToString();
                    fatherEmail.Text = l[13].ToString();
                    fatherOccuption.Text = l[14].ToString();
                    motherName.Text = l[15].ToString();
                    motherCnicNo.Text = l[16].ToString();
                    motherOccuption.Text = l[17].ToString();
                    motherEducation.Text = l[18].ToString();
                    motherMobile.Text = l[19].ToString();
                    
                }
                else
                {
                    MessageBox.Show(familyCode.Text + " Not Register in Database");
                }
            }
            else
            {
                MessageBox.Show("Enter Family Code into Textbox ");
            }



        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentClassCombo.Text != null && currentClassCombo.Text != "" && sectionComboBox.Text != null && sectionComboBox.Text != "")
            {
                int classId = mec.classIdSelect(currentClassCombo.Text);
                int sectionId = mec.sectionIdSelect(sectionComboBox.Text);
                classSectionId = mec.classSectionIdSelect(classId, sectionId);
                int max = mec.classSectionMax(classSectionId);
                int roll = mec.classSectionEnRoll(classSectionId);
              
                if (roll == max && roll != 0)
                {
                    MessageBox.Show("Section Full");
                }
                else
                {

                    rollNo.Text = (roll + 1).ToString();

                }
            }
           
            
        }

        private void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            classAdmittedCombo.Items.Clear();
            currentClassCombo.Items.Clear();
            if (departmentCombo.Text != "")
            {
                int id = mec.departmentIdSelect(departmentCombo.Text);
               
                foreach (var item in mec.classCombobox(id))
                {
                    currentClassCombo.Items.Add(item);

                }

                foreach (var item in mec.classCombobox(id))
                {
                    classAdmittedCombo.Items.Add(item);

                }
            }
        }
    }
}
