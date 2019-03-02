using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Schoolinfo : MetroFramework.Forms.MetroForm
    {
        public Schoolinfo()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        OpenFileDialog schoolLogoImage = new OpenFileDialog();
        OpenFileDialog bankLogoImage = new OpenFileDialog();
        int width = 150, height = 150;
        string oldSchoolLogo = null;
        string oldbBankLogo = null;

        string schoolLogo = null;
        string bankLogo = null;

        int schoolId = 0;

        private void Save_Click(object sender, EventArgs e)
        {
        
            if (schoolName.Text == "")
            {
                MessageBox.Show("Enter School Name");
            }
            else if (schoolAddress.Text == "")
            {
                MessageBox.Show("Enter School Address");
            }

            else if (l.Text == "")
            {
                MessageBox.Show("Enter School phone No ");
            }
            else if (emailAddress.Text == "")
            {
                MessageBox.Show("Enter School Email Address ");
            }
            else if (Website.Text == "")
            {
                MessageBox.Show("Enter School Website url ");
            }
            else if (faxNo.Text == "")
            {
                MessageBox.Show("Enter School FAX No ");
            }
            else if (oldSchoolLogo == "")
            {
                MessageBox.Show("Select School Logo  ");
            }
            else if (priodsInDay.Text == "")
            {
                MessageBox.Show("Enter Priod Day ");
            }
            else if (schoolStatrAt.Text == "")
            {
                MessageBox.Show("Enter School Start Timing ");
            }
            else if (breakStatrAt.Text == "")
            {
                MessageBox.Show("Enter School Break Time  ");
            }
          
            else if (oldbBankLogo == null)
            {
                MessageBox.Show("Select Bank Logo ");
            }
            else if (smsTitle.Text == "")
            {
                MessageBox.Show("Enter School SMS Tile ");
            }
            else if (bankName.Text == "")
            {
                MessageBox.Show("Enter School Bank Name  ");
            }
            else if (bankAddress.Text == "")
            {
                MessageBox.Show("Enter School Bank Address ");
            }
            else if (softwareLocation.Text == "")
            {
                MessageBox.Show("Enter School Software Location ");
            }
            else if (workingDays.Text == "")
            {
                MessageBox.Show("Enter School Working Days ");
            }
            else if (schoolCloseAt.Text == "")
            {
                MessageBox.Show("Enter School close Time ");
            }

            else if (priodsDuration.Text == "")
            {
                MessageBox.Show("Enter School Priod Duration Time ");
            }

            else if (breakDuration.Text == "")
            {
                MessageBox.Show("Enter School Break Duration ");
            }
            else if (bankAccountNo.Text == "")
            {
                MessageBox.Show("Enter School Bank Account ");
            }
            else
            {
                MessageBox.Show(mec.schoolInfoInsert(schoolName.Text, schoolAddress.Text, phoneNoText.Text, cellNumber.Text , Website.Text, emailAddress.Text, faxNo.Text, schoolLogo, priodsInDay.Text, schoolStatrAt.Text, breakStatrAt.Text, smsTitle.Text, bankName.Text, bankAddress.Text, softwareLocation.Text, workingDays.Text, schoolCloseAt.Text, priodsDuration.Text, breakDuration.Text, bankAccountNo.Text, bankLogo));

                if (schoolLogo !=  null && bankLogo != null)
                {
                    string school = schoolLogoImage.FileName;
                    File.Copy(school, Application.StartupPath + "\\Images\\" + schoolLogo);
                    string bank = schoolLogoImage.FileName;
                    File.Copy(bank, Application.StartupPath + "\\Images\\" + bankLogo);
                }
                
                
            }

        }

        private void Schoolinfo_Load(object sender, EventArgs e)
        {
            List<string> l = mec.selectSchoolInfo();
            if (l.Count() > 0)
            {
                schoolId = Convert.ToInt32(l[0]);
                schoolName.Text = l[1];
                schoolAddress.Text = l[2];
                phoneNoText.Text = l[3];
                cellNumber.Text = l[4];
                Website.Text = l[5];
                emailAddress.Text = l[6];
                faxNo.Text = l[7];
                
                
                priodsInDay.Text = l[9];
                schoolStatrAt.Text = l[10];
                breakStatrAt.Text = l[11];
                workingDays.Text = l[12];
                schoolCloseAt.Text = l[13];
                priodsDuration.Text = l[14];
                smsTitle.Text = l[15];
                breakDuration.Text = l[16];
                bankName.Text = l[17];
                bankAccountNo.Text = l[18];
                bankAddress.Text = l[19];
                softwareLocation.Text = l[20];
                 
                //school logo
                string pic = l[8];
                string filePath = Application.StartupPath + "\\Images\\" + pic;
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {

                    Image originalImage = Image.FromStream(stream);

                    Bitmap result = new Bitmap(width, height);

                    using (Graphics g = Graphics.FromImage(result))
                    {
                        // Draw the originam image in a new size.
                        g.DrawImage(originalImage, 0, 0, width, height);
                    }
                    schoolImage.Image = result;
                    oldSchoolLogo = pic;
                     stream.Dispose();
                }

                //bank logo
                pic = l[21];
                string filePaths = Application.StartupPath + "\\Images\\" + pic;
                using (FileStream stream = new FileStream(filePaths, FileMode.Open, FileAccess.Read))
                {

                    
                    Image originalImages = Image.FromStream(stream);
                    Bitmap results = new Bitmap(width, height);

                    using (Graphics g = Graphics.FromImage(results))
                    {
                        // Draw the originam image in a new size.
                        g.DrawImage(originalImages, 0, 0, width, height);
                    }
                    backLogo.Image = results;
                    oldbBankLogo = pic;
                    stream.Dispose();
                }
                
            }


        }

        private void selectSchoolLogo_Click(object sender, EventArgs e)
        {
           
            // open file dialog   

            // image filters  
            schoolLogoImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (schoolLogoImage.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Application.StartupPath + "\\Images\\" + oldSchoolLogo))
                {
                    File.Delete(Application.StartupPath + "\\Images\\" + oldSchoolLogo);
                }
                Image originalImage = Image.FromFile(schoolLogoImage.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);
                }

                schoolImage.Image = result;

                schoolLogo = "schoollogo" + Path.GetExtension(schoolLogoImage.FileName);

            }
            else
            {
                MessageBox.Show("Image does not selected");
            }
        }

        private void selectBreakLogo_Click(object sender, EventArgs e)
        {
           
            // open file dialog   

            // image filters  
            bankLogoImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (bankLogoImage.ShowDialog() == DialogResult.OK)
            {
                
                if (File.Exists(Application.StartupPath + "\\Images\\" + oldbBankLogo))
                {
                    File.Delete(Application.StartupPath + "\\Images\\" + oldbBankLogo);
                }
                Image originalImage = Image.FromFile(bankLogoImage.FileName);

                Bitmap result = new Bitmap(width, height);

                using (Graphics g = Graphics.FromImage(result))
                {
                    // Draw the originam image in a new size.
                    g.DrawImage(originalImage, 0, 0, width, height);
                }

                backLogo.Image = result;

                bankLogo = "banklogo" + Path.GetExtension(bankLogoImage.FileName);

            }
            else
            {
                MessageBox.Show("Image does not selected");
            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (schoolName.Text == "")
            {
                MessageBox.Show("Enter School Name");
            }
            else if (schoolAddress.Text == "")
            {
                MessageBox.Show("Enter School Address");
            }

            else if (l.Text == "")
            {
                MessageBox.Show("Enter School phone No ");
            }
            else if (emailAddress.Text == "")
            {
                MessageBox.Show("Enter School Email Address ");
            }
            else if (Website.Text == "")
            {
                MessageBox.Show("Enter School Website url ");
            }
            else if (faxNo.Text == "")
            {
                MessageBox.Show("Enter School FAX No ");
            }
            else if (schoolLogo == "")
            {
                MessageBox.Show("Select School Logo  ");
            }
            else if (priodsInDay.Text == "")
            {
                MessageBox.Show("Enter Priod Day ");
            }
            else if (schoolStatrAt.Text == "")
            {
                MessageBox.Show("Enter School Start Timing ");
            }
            else if (breakStatrAt.Text == "")
            {
                MessageBox.Show("Enter School Break Time  ");
            }
           
            else if (smsTitle.Text == "")
            {
                MessageBox.Show("Enter School SMS Tile ");
            }
            else if (bankName.Text == "")
            {
                MessageBox.Show("Enter School Bank Name  ");
            }
            else if (bankAddress.Text == "")
            {
                MessageBox.Show("Enter School Bank Address ");
            }
            else if (softwareLocation.Text == "")
            {
                MessageBox.Show("Enter School Software Location ");
            }
            else if (workingDays.Text == "")
            {
                MessageBox.Show("Enter School Working Days ");
            }
            else if (schoolCloseAt.Text == "")
            {
                MessageBox.Show("Enter School close Time ");
            }

            else if (priodsDuration.Text == "")
            {
                MessageBox.Show("Enter School Priod Duration Time ");
            }

            else if (breakDuration.Text == "")
            {
                MessageBox.Show("Enter School Break Duration ");
            }
            else if (bankAccountNo.Text == "")
            {
                MessageBox.Show("Enter School Bank Account ");
            }
            else
            {
                if (schoolLogo != null)
                {
                    string school = schoolLogoImage.FileName;
                    File.Copy(school, Application.StartupPath + "\\Images\\" + schoolLogo);
                    oldSchoolLogo = schoolLogo;
                }
                if (bankLogo != null)
                {
                    string bank = bankLogoImage.FileName;
                    File.Copy(bank, Application.StartupPath + "\\Images\\" + bankLogo);
                    oldbBankLogo = bankLogo;
                }

                MessageBox.Show(mec.schoolInfoUpdate(schoolId,schoolName.Text, schoolAddress.Text, phoneNoText.Text, cellNumber.Text, Website.Text, emailAddress.Text, faxNo.Text, oldSchoolLogo, priodsInDay.Text, schoolStatrAt.Text, breakStatrAt.Text, smsTitle.Text, bankName.Text, bankAddress.Text, softwareLocation.Text, workingDays.Text, schoolCloseAt.Text, priodsDuration.Text, breakDuration.Text, bankAccountNo.Text, oldbBankLogo));
                
                Schoolinfo f = new Schoolinfo();
                this.Hide();
                f.Show();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mec.schoolInfoDelete(schoolId));
            schoolName.Text = "";
            schoolAddress.Text = "";
            phoneNoText.Text = "";
            cellNumber.Text = "";
            Website.Text = "";
            emailAddress.Text = "";
            faxNo.Text = "";
            schoolLogo = "";
            priodsInDay.Text = "";
            schoolStatrAt.Text = "";
            breakStatrAt.Text = "";
            workingDays.Text = "";
            schoolCloseAt.Text = "";
            priodsDuration.Text = "";
            smsTitle.Text = "";
            breakDuration.Text = "";
            bankName.Text = "";
            bankAccountNo.Text = "";
            bankAddress.Text = "";
            softwareLocation.Text = "";
            bankLogo = "";
            schoolLogo = null;
            bankLogo = null;
        }

        private void cellNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9-:\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void bankAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-/\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void schoolName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void emailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-@_.\b]");
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
