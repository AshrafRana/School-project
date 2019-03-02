using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace School_Managment_System
{
    class StudentController
    {

        Student student;
        Adapter adp;
        SqlCommand cmd;
        MasterEnteriesController mec;
        
        public StudentController()
        {
            student = new Student();
            adp = new Adapter();
            cmd = new SqlCommand();
            mec = new MasterEnteriesController();
           
        }

        
        /*select last GRNo of student*/
        public int studentLastIdSelect()
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTLASTSTUDENTID");
            return adp.SelectRecordID(cmd) + 1;

        }
        /* select All student from database*/
        public DataTable selectAllStudentRecordDataGridView()
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }
        /* Count all student which insert in database*/
        public int countAllStudent()
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountAllStudent");
            return adp.SelectRecordID(cmd);
        }
        /* Select Students by genders */
        public DataTable searchBytGenderRecordDataGridView(string gender)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "selectByGender");
            cmd.Parameters.AddWithValue("@Gender", gender);
            return adp.showDataGridView(cmd);
        }
        /* Count Students By Genders*/
        public int countStudentByGender(string gender)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountStudentByGender");
            cmd.Parameters.AddWithValue("@Gender", gender);
            return adp.SelectRecordID(cmd);
        }

        /* Select Students Which Present Or Left */
        public DataTable selectleftPresentStudentRecordDataGridView(string CurrentStatus)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "PresentAndLeftStudent");
            cmd.Parameters.AddWithValue("@CurrentStatus", CurrentStatus);
            return adp.showDataGridView(cmd);

        }
        /* Count Students which present or left*/
        public int CountPresentAndLeftStudent(string CurrentStatus)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountPresentAndLeft");
            cmd.Parameters.AddWithValue("@CurrentStatus", CurrentStatus);
            return adp.SelectRecordID(cmd);
        }
        /* Select Students By Group */
        public DataTable selectStudentByGroupRecordDataGridView(string group)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "searchByGroup");
            cmd.Parameters.AddWithValue("@Group", group);
            return adp.showDataGridView(cmd);
        }
        
        /* Count Students which present or left*/
        public int CountGroupStudent(string group)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountGroupStudent");
            cmd.Parameters.AddWithValue("@Group", group);
            return adp.SelectRecordID(cmd);
        }

        /* Count class Present or left Student*/
        public int CountleftPresentStudent(string CurrentStatus)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CurrentStatusCount");
            cmd.Parameters.AddWithValue("@CurrentStatus", CurrentStatus);
            return adp.SelectRecordID(cmd);

        }
        /* Select Students By Department */
        public DataTable SearchByDepartmentRecordDataGridView(string Deparment)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SearchByDeparment");
            cmd.Parameters.AddWithValue("@Departments", Deparment);
            return adp.showDataGridView(cmd);

        }
        /* Count Students Department*/
        public int countDepartmentStudent(string Deparment)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountDeparmentStudent");
            cmd.Parameters.AddWithValue("@Departments", Deparment);
            return adp.SelectRecordID(cmd);
        }

        /* Select Students By Class */
        public DataTable selectStudentByClassRecordDataGridView(string className)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTByClass");
            cmd.Parameters.AddWithValue("@Class", className);
            return adp.showDataGridView(cmd);

        }
        /* Count Students Class Student*/
        public int countClassStudent(string className)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountClassStudent");
            cmd.Parameters.AddWithValue("@Class", className);
            return adp.SelectRecordID(cmd);
        }


        /* Select Students By Class section */
        public DataTable selectStudentBySectiontRecordDataGridView(string className ,string section)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "ClassSectionStudent");
            cmd.Parameters.AddWithValue("@Class", className);
            cmd.Parameters.AddWithValue("@SectionName", section);
            return adp.showDataGridView(cmd);
        }
        /* Count class Section Student*/
        public int countClassSectionStudent(string className, string section)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "CountClassSectionStudent");
            cmd.Parameters.AddWithValue("@Class", className);
            cmd.Parameters.AddWithValue("@SectionName", section);
            return adp.SelectRecordID(cmd);
        }

        /*Search Student By check box*/
        public DataTable searchstudent(int grNo,int familyCode, string stdName, string fName, string phone, string fmobile, int day, string month, int year)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "searchstudent");
            if (grNo != 0)
            {
                cmd.Parameters.AddWithValue("@GRNo", grNo);
            }
            if (familyCode != 0)
            {
                cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
            }

            if (stdName != null)
            {
                cmd.Parameters.AddWithValue("@StudentName", stdName);
            }
            if (fName != null)
            {
                cmd.Parameters.AddWithValue("@FatherName", fName);
            }
            if (phone != null)
            {
                cmd.Parameters.AddWithValue("@HomePhoneNo", phone);
            }
            if (fmobile != null)
            {
                cmd.Parameters.AddWithValue("@FatherMobileNo", fmobile);
            }

            if (day != 0)
            {
                cmd.Parameters.AddWithValue("@Day", day);
            }
            if (month != null)
            {
                cmd.Parameters.AddWithValue("@Month", month);
            }
            if (year != 0)
            {
                cmd.Parameters.AddWithValue("@Year", year);
            }

            return adp.showDataGridView(cmd); 
        }

        /*Search Student By GR No */
        public List<string> selectStudentByGr(int GRNo)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYGRNO");
            cmd.Parameters.AddWithValue("@GRNo", GRNo);
            return adp.showDataTextbox(cmd);

        }
        /*Search Student Family Record By GRNo Code Show Add and Eidit Form */
        public List<string> selectStudentFamilyInfoByFamilyCode(int GRNo)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYGRNO");
            cmd.Parameters.AddWithValue("@GRNo", GRNo);
            return adp.showDataTextbox(cmd);

        }
        /*Delect  Student Record By GR No */
        public string deleteSingleStudent(int GRNo)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@GRNo", GRNo);
            
            if (adp.Delete(cmd))
            {
                return "Student Record Delete Successfuly";
            }
            else
            {

                return "Does Not Delete Successfuly";
            }

        }
        /*Select Student Family Record By Family Code */
        public List<string> selectStudentFamilyDataByFamilyCode(int _familyCode)
        {

            int familyCode = Convert.ToInt32(_familyCode);
            cmd = new SqlCommand("StudentfamilyInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYID");
            cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
           return adp.showFamilyDataTextbox(cmd);

        }
        /*Select Student Family Code*/
        public bool selectFamilyInfo(int FamilyCode)
        {
            cmd = new SqlCommand("StudentfamilyInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYID");
            cmd.Parameters.AddWithValue("@FamilyCode", FamilyCode);
            return adp.Select(cmd);

        }
        /*Inset Student And Family Record  */
        public string studentInsert(string studentName, string shortName, string fatherName, string guradianName, string genderComb, string dayComboBox , string monthComboBox ,string yearComboBox, string birthPlace, string bFormNo, string Religion, string motherTongue, string Nationality, string bloodGroup, string imagePath, string studentMobileNo , string kidsNo, string homePhoneNo, string homeAddress, string fatherEducation, string Caste, string monthlyIncome, string fatherOccuption, string fatherMobile, string officePhone, string fathhCnicNo, string officeAddress, string faxNo, string fatherEmail, string motherCnicNo, string motherName, string motherOccuption, string motherEducation, string motherMobile,string groupCombo, string departmentCombo, string dateOfAdmision, string classAdmittedCombo,string currentClassCombo ,string sessionComboBox, string _rollNo, string mbEnrollment, string mb9thRollNo, string mb10thRollNo, string feeTypeCombo, string feeStatusCombo, string AdmBasedComboBox, string currentStatusCombo, string lastInsitute,string nazraClass,string ikhlakiatIslamiat,string _familyCode,int classSectionId)
        {
           
            string mes = ""; int familyCode = 0;

            /*Student family information*/
            student.kidNo = Convert.ToInt32(kidsNo);
            student.homePhoneNo = homePhoneNo;
            student.homeAddress = homeAddress;


            /*Student Registeration information*/

            student.dateofAdmision = dateOfAdmision;
            student.classAdmit = classAdmittedCombo;
            student.feeStatus = feeStatusCombo;
            student.admisionBasedOn = AdmBasedComboBox;
            student.currentStatus = currentStatusCombo;
            student.lastSchool = lastInsitute;
            student.matricBoardRollNo = mb10thRollNo;
            student.boardEnrollmentNo = mbEnrollment;
            student.ninthBoardRollNo = mb9thRollNo;
            student.nazraClass = nazraClass;
            student.ethicsClassIslamiatclass = ikhlakiatIslamiat;
            student.groupId = mec.groupIdSelect(groupCombo);
            student.classSectionId = classSectionId;

            /*Student information*/
            student.Student_Name = studentName;
            student.Short_Name = shortName;
            student.Father_Name = fatherName;
            student.Guradian_Name = guradianName;
            student.Gender = genderComb;
            student.day = dayComboBox;
            student.month = monthComboBox;
            student.year = yearComboBox;
            student.Birth_Place = birthPlace;
            student.B_Form_No = bFormNo;
            student.Religion = Religion;
            student.Mother_Tongue = motherTongue;
            student.Nationality = Nationality;
            student.Blood_Group = bloodGroup;
            student.Image = imagePath;
            student.studentMobileNo = studentMobileNo;

            /*Student father information*/
            student.fatherEducation = fatherEducation;
            student.fatherCaste = Caste;
            student.fatherMonthlyIncome = monthlyIncome;
            student.fatherOccupation = fatherOccuption;
            student.fatherMobileNo = fatherMobile;
            student.fatherCNIC = fathhCnicNo;
            student.fatherFaxNo = faxNo;
            student.fatherOfficeAddress = officeAddress;
            student.fatherOfficePhoneNo = officePhone;
            student.fatherEmailAddress = fatherEmail;

            /*Student Mother information*/
            student.motherCNIC = motherCnicNo;
            student.motherName = motherName;
            student.motherOccupation = motherOccuption;
            student.motherEducation = motherEducation;
            student.motherMobileNo = motherMobile;




            if (_familyCode != null && _familyCode != "")
            {
                familyCode = Convert.ToInt32(_familyCode);
                cmd = new SqlCommand("StudentfamilyInfoSp");
                cmd.Parameters.AddWithValue("@Action", "SELECTBYID");
                cmd.Parameters.AddWithValue("@FamilyCode", familyCode);

                if (adp.Select(cmd))
                {


                    cmd = new SqlCommand("StudentRegiserationInfoSp");
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    cmd.Parameters.AddWithValue("@StudentName", student.Student_Name);
                    cmd.Parameters.AddWithValue("@ShortName", student.Short_Name);
                    cmd.Parameters.AddWithValue("@GuadianName", student.Guradian_Name);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@BFormNo", student.B_Form_No);
                    cmd.Parameters.AddWithValue("@Day", student.day);
                    cmd.Parameters.AddWithValue("@Month", student.month);
                    cmd.Parameters.AddWithValue("@Year", student.year);
                    cmd.Parameters.AddWithValue("@BirthPlace", student.Birth_Place);
                    cmd.Parameters.AddWithValue("@Religion", student.Religion);
                    cmd.Parameters.AddWithValue("@MotherTongue", student.Mother_Tongue);
                    cmd.Parameters.AddWithValue("@Nationality", student.Nationality);
                    cmd.Parameters.AddWithValue("@BloodGroup", student.Blood_Group);
                    cmd.Parameters.AddWithValue("@StudentImage", student.Image);
                    cmd.Parameters.AddWithValue("@ClassAdmit", student.classAdmit);
                    cmd.Parameters.AddWithValue("@LastSchool", student.lastSchool);
                    cmd.Parameters.AddWithValue("@CurrentStatus", student.currentStatus);
                    cmd.Parameters.AddWithValue("@AdmisionBasedOn", student.admisionBasedOn);
                    cmd.Parameters.AddWithValue("@FeeStatus", student.feeStatus);
                    cmd.Parameters.AddWithValue("@GroupId", student.groupId);
                    cmd.Parameters.AddWithValue("@EthicsClassIslamiatclass", student.ethicsClassIslamiatclass);
                    cmd.Parameters.AddWithValue("@DateofAdmision", student.dateofAdmision);
                    cmd.Parameters.AddWithValue("@NazraClass", student.nazraClass);
                    cmd.Parameters.AddWithValue("@NinthBoardRollNo", student.ninthBoardRollNo);
                    cmd.Parameters.AddWithValue("@MatricBoardRollNo", student.matricBoardRollNo);
                    cmd.Parameters.AddWithValue("@BoardEnrollmentNo", student.boardEnrollmentNo);
                    cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                    cmd.Parameters.AddWithValue("@StudentMobileNo", studentMobileNo);

                    
                    student.GRNo = adp.insertGetId(cmd);

                    cmd = new SqlCommand("StudentfamilyInfoSp");
                    cmd.Parameters.AddWithValue("@Action", "SELECTKidByID");
                    cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                    student.kidNo = adp.SelectRecordID(cmd);

                    cmd = new SqlCommand("StudentfamilyInfoSp");
                    cmd.Parameters.AddWithValue("@Action", "UPDATEKIDS");
                    cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                    cmd.Parameters.AddWithValue("@NoOfKids", student.kidNo + 1);
                    student.kidNo = adp.SelectRecordID(cmd);


                    cmd = new SqlCommand("ClassSectionSp");
                    cmd.Parameters.AddWithValue("@Action", "StudentEnRoll");
                    cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                    int enrollStudent = adp.SelectRecordID(cmd);
                    enrollStudent = enrollStudent + 1;

                    cmd = new SqlCommand("ClassSectionSp");
                    cmd.Parameters.AddWithValue("@Action", "UPDATEENRoll");
                    cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                    cmd.Parameters.AddWithValue("@StudentEnRoll", enrollStudent);
                    adp.insert(cmd);

                    cmd = new SqlCommand("ClassSectionStudentRollSp");
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    cmd.Parameters.AddWithValue("@GRNo", student.GRNo);
                    cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                    cmd.Parameters.AddWithValue("@StudentRollNo", enrollStudent);
                    

                    if (adp.insert(cmd))
                    {
                        mes = "Student Record Insert Successfuly";
                    }
                    else
                    {

                        mes = "Does Not Insert Successfuly";
                    }


                }
                else
                {

                    mes = "family code not register";
                }

            }
            else
            {

                cmd = new SqlCommand("StudentfamilyInfoSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@NoOfKids", student.kidNo);
                cmd.Parameters.AddWithValue("@HomeAddress", student.homeAddress);
                cmd.Parameters.AddWithValue("@HomePhoneNo", student.homePhoneNo);
                cmd.Parameters.AddWithValue("@FatherName", student.Father_Name);
                cmd.Parameters.AddWithValue("@FatherMobileNo", student.fatherMobileNo);
                cmd.Parameters.AddWithValue("@FatherEducation", student.fatherEducation);
                cmd.Parameters.AddWithValue("@FatherCaste", student.fatherCaste);
                cmd.Parameters.AddWithValue("@MonthlyIncome", student.fatherMonthlyIncome);
                cmd.Parameters.AddWithValue("@OfficePhoneNo", student.fatherOfficePhoneNo);
                cmd.Parameters.AddWithValue("@OfficeAddress", student.fatherOfficeAddress);
                cmd.Parameters.AddWithValue("@FatherCNICNo", student.fatherCNIC);
                cmd.Parameters.AddWithValue("@FaxNo", student.fatherFaxNo);
                cmd.Parameters.AddWithValue("@EmailAddress", student.fatherEmailAddress);
                cmd.Parameters.AddWithValue("@FatherOccupation", student.fatherOccupation);
                cmd.Parameters.AddWithValue("@MotherName", student.motherName);
                cmd.Parameters.AddWithValue("@MotherCNIC", student.motherCNIC);
                cmd.Parameters.AddWithValue("@MotherOccupation", student.motherOccupation);
                cmd.Parameters.AddWithValue("@MohterEducation", student.motherEducation);
                cmd.Parameters.AddWithValue("@MotherMobileNo", student.motherMobileNo);
                familyCode = adp.insertGetId(cmd);

                cmd = new SqlCommand("StudentRegiserationInfoSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@StudentName", student.Student_Name);
                cmd.Parameters.AddWithValue("@ShortName", student.Short_Name);
                cmd.Parameters.AddWithValue("@GuadianName", student.Guradian_Name);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@BFormNo", student.B_Form_No);
                cmd.Parameters.AddWithValue("@Day", student.day);
                cmd.Parameters.AddWithValue("@Month", student.month);
                cmd.Parameters.AddWithValue("@Year", student.year);
                cmd.Parameters.AddWithValue("@BirthPlace", student.Birth_Place);
                cmd.Parameters.AddWithValue("@Religion", student.Religion);
                cmd.Parameters.AddWithValue("@MotherTongue", student.Mother_Tongue);
                cmd.Parameters.AddWithValue("@Nationality", student.Nationality);
                cmd.Parameters.AddWithValue("@BloodGroup", student.Blood_Group);
                cmd.Parameters.AddWithValue("@StudentImage", student.Image);
                cmd.Parameters.AddWithValue("@ClassAdmit", student.classAdmit);
                cmd.Parameters.AddWithValue("@LastSchool", student.lastSchool);
                cmd.Parameters.AddWithValue("@CurrentStatus", student.currentStatus);
                cmd.Parameters.AddWithValue("@AdmisionBasedOn", student.admisionBasedOn);
                cmd.Parameters.AddWithValue("@FeeStatus", student.feeStatus);
                cmd.Parameters.AddWithValue("@GroupId", student.groupId);
                cmd.Parameters.AddWithValue("@EthicsClassIslamiatclass", student.ethicsClassIslamiatclass);
                cmd.Parameters.AddWithValue("@DateofAdmision", student.dateofAdmision);
                cmd.Parameters.AddWithValue("@NazraClass", student.nazraClass);
                cmd.Parameters.AddWithValue("@NinthBoardRollNo", student.ninthBoardRollNo);
                cmd.Parameters.AddWithValue("@MatricBoardRollNo", student.matricBoardRollNo);
                cmd.Parameters.AddWithValue("@BoardEnrollmentNo", student.boardEnrollmentNo);
                cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                student.GRNo = adp.insertGetId(cmd);

                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "StudentEnRoll");
                cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                int enrollStudent = adp.SelectRecordID(cmd);
                enrollStudent = enrollStudent + 1;

                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATEENRoll");
                cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                cmd.Parameters.AddWithValue("@StudentEnRoll", enrollStudent);
                adp.insert(cmd);

                cmd = new SqlCommand("ClassSectionStudentRollSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@GRNo", student.GRNo);
                cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
                cmd.Parameters.AddWithValue("@StudentRollNo", enrollStudent);
               
                if (adp.insert(cmd))
                {
                    mes = "Student Record Insert Successfuly";
                }
                else
                {

                    mes = "Does Not Insert Successfuly";
                }

            }

            return mes;
        }

        /*Update Student And Family Record  */
        public string studentUpdate(string studentName, string shortName, string fatherName, string guradianName, string genderComb, string dayComboBox, string monthComboBox, string yearComboBox, string birthPlace, string bFormNo, string Religion, string motherTongue, string Nationality, string bloodGroup, string imagePath, string kidsNo, string homePhoneNo, string homeAddress, string fatherEducation, string Caste, string monthlyIncome, string fatherOccuption, string fatherMobile, string officePhone, string fathhCnicNo, string officeAddress, string faxNo, string fatherEmail, string motherCnicNo, string motherName, string motherOccuption, string motherEducation, string motherMobile, string groupCombo, string departmentCombo, string dateOfAdmision, string classAdmittedCombo, string currentClassCombo, string sessionComboBox, string _rollNo, string mbEnrollment, string mb9thRollNo, string mb10thRollNo, string feeTypeCombo, string feeStatusCombo, string AdmBasedComboBox, string currentStatusCombo, string lastInsitute, string nazraClass, string ikhlakiatIslamiat, string _familyCode, int classSectionId ,string GRNo,int oldClassSectionId) 
        {

            string mes = ""; int familyCode = 0;

            /*Student family information*/
            student.kidNo = Convert.ToInt32(kidsNo);
            student.homePhoneNo = homePhoneNo;
            student.homeAddress = homeAddress;

            /*Student Registeration information*/
            student.GRNo = Convert.ToInt32(GRNo);
            student.dateofAdmision = dateOfAdmision;
            student.classAdmit = classAdmittedCombo;
            student.feeStatus = feeStatusCombo;
            student.admisionBasedOn = AdmBasedComboBox;
            student.currentStatus = currentStatusCombo;
            student.lastSchool = lastInsitute;
            student.matricBoardRollNo = mb10thRollNo;
            student.boardEnrollmentNo = mbEnrollment;
            student.ninthBoardRollNo = mb9thRollNo;
            student.nazraClass = nazraClass;
            student.ethicsClassIslamiatclass = ikhlakiatIslamiat;
            student.groupId = mec.groupIdSelect(groupCombo);
            


            /*Student information*/
            student.Student_Name = studentName;
            student.Short_Name = shortName;
            student.Father_Name = fatherName;
            student.Guradian_Name = guradianName;
            student.Gender = genderComb;
            student.day = dayComboBox;
            student.month = monthComboBox;
            student.year = yearComboBox;
            student.Birth_Place = birthPlace;
            student.B_Form_No = bFormNo;
            student.Religion = Religion;
            student.Mother_Tongue = motherTongue;
            student.Nationality = Nationality;
            student.Blood_Group = bloodGroup;
            student.Image = imagePath;


            /*Student father information*/
            student.fatherEducation = fatherEducation;
            student.fatherCaste = Caste;
            student.fatherMonthlyIncome = monthlyIncome;
            student.fatherOccupation = fatherOccuption;
            student.fatherMobileNo = fatherMobile;
            student.fatherCNIC = fathhCnicNo;
            student.fatherFaxNo = faxNo;
            student.fatherOfficeAddress = officeAddress;
            student.fatherOfficePhoneNo = officePhone;
            student.fatherEmailAddress = fatherEmail;

            /*Student Mother information*/
            student.motherCNIC = motherCnicNo;
            student.motherName = motherName;
            student.motherOccupation = motherOccuption;
            student.motherEducation = motherEducation;
            student.motherMobileNo = motherMobile;


            familyCode = Convert.ToInt32(_familyCode);
            cmd = new SqlCommand("StudentfamilyInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYID");
            cmd.Parameters.AddWithValue("@FamilyCode", familyCode);

            if (adp.Select(cmd))
            {
                
                cmd = new SqlCommand("StudentRegiserationInfoSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@GRNo", student.GRNo);
                cmd.Parameters.AddWithValue("@StudentName", student.Student_Name);
                cmd.Parameters.AddWithValue("@ShortName", student.Short_Name);
                cmd.Parameters.AddWithValue("@GuadianName", student.Guradian_Name);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@BFormNo", student.B_Form_No);
                cmd.Parameters.AddWithValue("@Day", student.day);
                cmd.Parameters.AddWithValue("@Month", student.month);
                cmd.Parameters.AddWithValue("@Year", student.year);
                cmd.Parameters.AddWithValue("@BirthPlace", student.Birth_Place);
                cmd.Parameters.AddWithValue("@Religion", student.Religion);
                cmd.Parameters.AddWithValue("@MotherTongue", student.Mother_Tongue);
                cmd.Parameters.AddWithValue("@Nationality", student.Nationality);
                cmd.Parameters.AddWithValue("@BloodGroup", student.Blood_Group);
                cmd.Parameters.AddWithValue("@StudentImage", student.Image);
                cmd.Parameters.AddWithValue("@ClassAdmit", student.classAdmit);
                cmd.Parameters.AddWithValue("@LastSchool", student.lastSchool);
                cmd.Parameters.AddWithValue("@CurrentStatus", student.currentStatus);
                cmd.Parameters.AddWithValue("@AdmisionBasedOn", student.admisionBasedOn);
                cmd.Parameters.AddWithValue("@FeeStatus", student.feeStatus);
                cmd.Parameters.AddWithValue("@GroupId", student.groupId);
                cmd.Parameters.AddWithValue("@EthicsClassIslamiatclass", student.ethicsClassIslamiatclass);
                cmd.Parameters.AddWithValue("@DateofAdmision", student.dateofAdmision);
                cmd.Parameters.AddWithValue("@NazraClass", student.nazraClass);
                cmd.Parameters.AddWithValue("@NinthBoardRollNo", student.ninthBoardRollNo);
                cmd.Parameters.AddWithValue("@MatricBoardRollNo", student.matricBoardRollNo);
                cmd.Parameters.AddWithValue("@BoardEnrollmentNo", student.boardEnrollmentNo);
                cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                adp.Update(cmd);

                cmd = new SqlCommand("StudentfamilyInfoSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@FamilyCode", familyCode);
                cmd.Parameters.AddWithValue("@NoOfKids", student.kidNo);
                cmd.Parameters.AddWithValue("@HomeAddress", student.homeAddress);
                cmd.Parameters.AddWithValue("@HomePhoneNo", student.homePhoneNo);
                cmd.Parameters.AddWithValue("@FatherName", student.Father_Name);
                cmd.Parameters.AddWithValue("@FatherMobileNo", student.fatherMobileNo);
                cmd.Parameters.AddWithValue("@FatherEducation", student.fatherEducation);
                cmd.Parameters.AddWithValue("@FatherCaste", student.fatherCaste);
                cmd.Parameters.AddWithValue("@MonthlyIncome", student.fatherMonthlyIncome);
                cmd.Parameters.AddWithValue("@OfficePhoneNo", student.fatherOfficePhoneNo);
                cmd.Parameters.AddWithValue("@OfficeAddress", student.fatherOfficeAddress);
                cmd.Parameters.AddWithValue("@FatherCNICNo", student.fatherCNIC);
                cmd.Parameters.AddWithValue("@FaxNo", student.fatherFaxNo);
                cmd.Parameters.AddWithValue("@EmailAddress", student.fatherEmailAddress);
                cmd.Parameters.AddWithValue("@FatherOccupation", student.fatherOccupation);
                cmd.Parameters.AddWithValue("@MotherName", student.motherName);
                cmd.Parameters.AddWithValue("@MotherCNIC", student.motherCNIC);
                cmd.Parameters.AddWithValue("@MotherOccupation", student.motherOccupation);
                cmd.Parameters.AddWithValue("@MohterEducation", student.motherEducation);
                cmd.Parameters.AddWithValue("@MotherMobileNo", student.motherMobileNo);
             


                if (adp.insert(cmd))
                {
                    mes = "Student Record Update Successfuly";
                }
                else
                {

                    mes = "Does Not Update Successfuly";
                }


            }
            else
            {

                mes = "family code not register";
            }


            //cmd = new SqlCommand("ClassSectionStudentRollSp");
            //cmd.Parameters.AddWithValue("@Action", "SELECTStudentRollNo");
            //cmd.Parameters.AddWithValue("@GRNo", student.GRNo);
            //cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
            //int studentGRNo = adp.SelectRecordID(cmd);
            //if (studentGRNo == Convert.ToInt32(_rollNo))
            //{
            //    mes = "match";
            //}
            //else
            //{
            //    cmd = new SqlCommand("ClassSectionSp");
            //    cmd.Parameters.AddWithValue("@Action", "StudentEnRoll");
            //    cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
            //    int enrollStudent = adp.SelectRecordID(cmd);
            //    mes += enrollStudent +"";
            //    cmd = new SqlCommand("ClassSectionSp");
            //    cmd.Parameters.AddWithValue("@Action", "UPDATEENRoll");
            //    cmd.Parameters.AddWithValue("@ClassSectionId", student.classSectionId);
            //    cmd.Parameters.AddWithValue("@StudentEnRoll", enrollStudent + 1);
            //    adp.Update(cmd);

            //    cmd = new SqlCommand("ClassSectionStudentRollSp");
            //    cmd.Parameters.AddWithValue("@Action", "INSERT");
            //    cmd.Parameters.AddWithValue("@GRNo",student.GRNo);
            //    cmd.Parameters.AddWithValue("@ClassSectionId",student.classSectionId);
            //    cmd.Parameters.AddWithValue("@StudentRollNo", enrollStudent + 1);
            //    if (adp.Update(cmd))
            //    {

            //        cmd = new SqlCommand("ClassSectionStudentRollSp");
            //        cmd.Parameters.AddWithValue("@Action", "DELETEOLDRollNo");
            //        cmd.Parameters.AddWithValue("@GRNo", student.GRNo);
            //        cmd.Parameters.AddWithValue("@ClassSectionId", oldClassSectionId);
            //        adp.Delete(cmd);


            //        mes = oldClassSectionId+"Student Record Update Successfuly";
            //    }
            //    else
            //    {

            //        mes = "Does Not Update Successfuly";
            //    }


            //}

            return mes;
        }

       
        public DataTable studentInfoReport()
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTName");
            return adp.showDataReports(cmd);

        }

    }
}
