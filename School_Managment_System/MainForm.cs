using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*Master Entery */
        private static ClassEntery classEntery = null;
        private static ClassFee classFee = null;
        private static ClassSectionForm classSection = null;
        private static Department department = null;
        private static Designation designation = null;
        private static FeesType feeType = null;
        private static GroupForm group = null;
        private static Schoolinfo schoolInfo = null;
        private static SectionEntry sectionEntry = null;
        private static Session session = null;
        private static SubjectEntry subject = null;
        private static ClassSessionSubject classSession = null;

        private static AddNewStudent addStudent = null;
        private static EditStudent editStudent = null;
        private static studentDetails studentDetail = null;
        private static SMS sms;

      private static  StaffDetails staffDetail = null;
        //Class objects
        BackupRestoreController backupRestore = new BackupRestoreController();

        private void classFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classFee == null || classFee.IsDisposed)
            {
                classFee = new ClassFee();
                classFee.Show();
            }
            else
            {
                classFee.WindowState = FormWindowState.Normal;
                classFee.Show();
                classFee.Focus();

            }
        }

        private void classTpyeToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void classEnteryToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            if (classEntery == null || classEntery.IsDisposed)
            {
                classEntery = new ClassEntery();
                classEntery.Show();
            }
            else
            {
                classEntery.WindowState = FormWindowState.Normal;
                classEntery.Show();
                classEntery.Focus();

            }


        }

        private void sectionEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (sectionEntry == null)
            {
                sectionEntry = new SectionEntry();
                sectionEntry.Show();
            }
            else
            {
                sectionEntry.WindowState = FormWindowState.Normal;
              //  sectionEntry.Show();
                sectionEntry.Focus();

            }
        }

        private void classSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 if (classSection == null || classSection.IsDisposed)
                {
                    classSection = new ClassSectionForm();
                    classSection.Show();
                }
                else
                {
                    classSection.WindowState = FormWindowState.Normal;
                    classSection.Show();
                    classSection.Focus();

                }
           
        }

        private void sessionEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session == null || session.IsDisposed)
            {
                session = new Session();
                session.Show();
            }
            else
            {
                session.WindowState = FormWindowState.Normal;
                session.Show();
                session.Focus();

            }
        }

        private void employeeDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (department == null)
            {
                department = new Department();
                department.Show();
            }
            else
            {
                department = new Department();
                department.WindowState = FormWindowState.Normal;
                department.Show();
                department.Focus();

            }
        }

        private void employeeDesiganationToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (designation == null)
            {
                designation = new Designation();
                designation.Show();
            }
            else
            {
                designation.WindowState = FormWindowState.Normal;
                designation.Show();
                designation.Focus();

            }

        }

        private void feesTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (feeType == null)
            {
                feeType = new FeesType();
                feeType.Show();
            }
            else
            {
                feeType.WindowState = FormWindowState.Normal;
                feeType.Show();
                feeType.Focus();

            }

        }

        private void subjectEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (subject == null)
            {
                subject = new SubjectEntry();
                subject.Show();
            }
            else
            {
                subject.WindowState = FormWindowState.Normal;
                subject.Show();
                subject.Focus();

            }
        }

       

        private void schoolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SchoolTypeForm s = new SchoolTypeForm();
            //s.Show();
            
        }

      

        private void schoolFeesEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SchoolFeeEntry SF = new SchoolFeeEntry();
            //SF.Show();
        }

       

        private void gregingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GradingLevel gl = new GradingLevel();
            //gl.Show();
        }

        private void examsGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExamEntry exm = new ExamEntry();
            //exm.Show();
        }

        private void bookSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BookSuppliers BS = new BookSuppliers();
           
            //BS.Show();
        }

        private void studentDocoumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StudentDocument SD = new StudentDocument();
            //SD.Show();
        }

        private void StudentRegistration_Click(object sender, EventArgs e)
        {
            if (addStudent == null)
            {
                addStudent = new AddNewStudent();
                addStudent.Show();
            }
            else
            {
                addStudent.WindowState = FormWindowState.Normal;
                addStudent.Show();
                addStudent.Focus();

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            if (studentDetail == null)
            {
                studentDetail = new studentDetails();
                studentDetail.Show();
            }
            else
            {
                studentDetail.WindowState = FormWindowState.Normal;
                studentDetail.Show();
                studentDetail.Focus();

            }
        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
            
        //    //if (editStudent == null)
        //    //{
        //    //    editStudent = new StaffD();
        //    //    editStudent.Show();
        //    //}
        //    //else
        //    //{
        //    //    editStudent.WindowState = FormWindowState.Normal;
        //    //    editStudent.Show();
        //    //    editStudent.Focus();

        //    //}
        //}

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            
            if (sms == null)
            {
                sms = new SMS();
                sms.Show();
            }
            else
            {
                sms.WindowState = FormWindowState.Normal;
                sms.Show();
                sms.Focus();

            }
        }

        

        private void schoolEnteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (schoolInfo == null || schoolInfo.IsDisposed)
            {
                schoolInfo = new Schoolinfo();
                schoolInfo.Show();
            }
            else
            {
                schoolInfo.WindowState = FormWindowState.Normal;
                schoolInfo.Show();
                schoolInfo.Focus();

            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (group == null || group.IsDisposed)
            {
                group = new GroupForm();
                group.Show();
            }
            else
            {
                group.WindowState = FormWindowState.Normal;
                //group.Show();
                group.Focus();

            }
        }

        private void classSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classSession == null || classSection.IsDisposed)
            {
                classSession = new ClassSessionSubject();
                classSession.Show();
            }
            else
            {
                classSession.WindowState = FormWindowState.Normal;
                classSession.Show();
                classSession.Focus();

            }
        }

        private void studentRegisterationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addStudent == null || addStudent.IsDisposed)
            {
                addStudent = new AddNewStudent();
                addStudent.Show();
            }
            else
            {
                addStudent.WindowState = FormWindowState.Normal;
                addStudent.Show();
                addStudent.Focus();

            }
        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentDetail == null)
            {
                studentDetail = new studentDetails();
                studentDetail.Show();
            }
            else
            {
                studentDetail.WindowState = FormWindowState.Normal;
                studentDetail.Show();
                studentDetail.Focus();

            }
        }

        private void backupFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            try
            {
                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //textBox1.Text = fbd.SelectedPath;
                    //Properties.Settings.Default.BackupPath = fbd.SelectedPath;
                    // Properties.Settings.Default.Save();
                    string databaseName = "sms";
                    //string path = "D:\\back\\";
                    string path = fbd.SelectedPath + "\\";
                    string date = DateTime.Now.ToString("dd-MM-yyyy");

                    MessageBox.Show(backupRestore.backupfile(databaseName, path, date));


                }
                else
                {
                    MessageBox.Show("Backup File Directory Not selected!");

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Access Denied for Backup Directory Use another Directory ");
                //    MessageBox.Show(x.Message);
            }
        }

        private void StaffDetail_Click(object sender, EventArgs e)
        {
            if (staffDetail == null)
            {
                staffDetail = new StaffDetails();
                staffDetail.Show();
            }
            else {

                staffDetail.WindowState = FormWindowState.Normal;
                staffDetail.Show();
                staffDetail.Focus();

            }

        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restoreBackupfiel_Click(object sender, EventArgs e)
        {
            
            //OpenFileDialog open = new OpenFileDialog();
            //// image filters  
            //// open.Filter = "Files(*.bak)";
            //open.Filter = "Backup File |*.bak";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    string backupFilePath = open.FileName;
            //   // MessageBox.Show(backupFilePath);
            //   //   MessageBox.Show(backupRestore.restoreBackupfile(backupFilePath));

               

            //    // MessageBox.Show(fileName);
            //}
            //else
            //{
            //    MessageBox.Show("Backup file does not selected");
            //}
        }









        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Adapter adp = new Adapter();
        //    string stdInfo, stdFather, stdMother;

        //    int stdfamilyCode = adp.insterGetId("INSERT INTO Student_family_Info(no_of_kid,home_address,phone_no) OUTPUT INSERTED.family_code VALUES(5,'home_address','phone_no')");

        //    stdFather = "INSERT INTO Student_Father_Info(family_code,father_name,father_mobile_no,father_education,caste,monthly_income,office_phone_no,office_address,father_cnic_no,fax_no,email_address,father_occupation)VALUES(" + stdfamilyCode + ",'father_name','father_mobile_no','father_education','caste','monthly_income','office_phone_no','office_address','father_cnic_no','fax_no','email_address','father_occupation')";

        //    stdInfo = "INSERT INTO Student_Info(family_code ,student_name,short_name,guadian_name,gender,b_form_no,date_of_birth,birth_place,religion,mother_tongue,nationality,blood_group,image_path)VALUES(" + stdfamilyCode + ",'student_name','short_name','guadian_name','gender','b_form_no','date_of_birth','birth_place','religion','mother_tongue','nationality','blood_group','image_path')";

        //    stdMother = "INSERT INTO Student_Mother_Info(family_code,mother_name,mother_cnic,mother_occupation,mohter_education,mother_mobile_no)VALUES(" + stdfamilyCode + ",'mother_name','mother_cnic','mother_occupation','mohter_education','mother_mobile_no')";

        //    if (adp.insert(stdFather) && adp.insert(stdInfo) && adp.insert(stdMother))
        //    {
        //        MessageBox.Show("Student Record Insert Successfuly");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Does Not Insert Successfuly");
        //    }
        //}



        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    Adapter adp = new Adapter();
        //    string stdFamily, stdInfo, stdFather, stdMother;

        //    stdFamily = "UPDATE Student_family_Info SET no_of_kid = 55, home_address = 'shome_address',phone_no = 'phone_no' WHERE family_code = 1013";

        //    stdFather = "UPDATE Student_Father_Info SET father_name = 'ashraffather_name',father_mobile_no = 'father_mobile_no',father_education = 'father_education',caste = 'caste',monthly_income = 'monthly_income',office_phone_no = 'office_phone_no',office_address = 'office_address',father_cnic_no = 'father_cnic_no',fax_no = 'fax_no',email_address = 'email_address',father_occupation = 'father_occupation' WHERE  family_code = 1013";

        //    stdInfo = "UPDATE Student_Info SET student_name = 'Ashraf student_name',short_name = 'short_name',guadian_name = 'guadian_name',gender = 'gender',b_form_no = 'b_form_no',date_of_birth = 'date_of_birth',birth_place = 'birth_place',religion = 'religion',mother_tongue = 'mother_tongue',nationality = 'nationality',blood_group = 'blood_group',image_path = 'image_path' WHERE stud_id = 8";

        //    stdMother = "UPDATE Student_Mother_Info SET mother_name = 'MM  mother_name',mother_cnic = 'mother_cnic',mother_occupation = 'mother_occupation',mohter_education = 'mohter_education',mother_mobile_no = 'mother_mobile_no' WHERE family_code = 1013";

        //    if (adp.Update(stdFamily) && adp.Update(stdFather) && adp.Update(stdInfo) && adp.Update(stdMother))
        //    {
        //        MessageBox.Show("Student Record Update Successfuly");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Does Not Update Successfuly");
        //    }
        //}




    }
}
