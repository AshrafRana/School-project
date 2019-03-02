using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace School_Managment_System
{
    class StaffController
    {
        StaffInfo StaffInfo;
        Adapter adp;
        SqlCommand cmd;
        MasterEnteriesController mec;
        public StaffController() 
        {

            StaffInfo = new StaffInfo();
            adp = new Adapter();
            cmd = new SqlCommand();
            mec = new MasterEnteriesController();


        }
        


        /*select last GRNo of student*/
        public int staffLastIdSelect()
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTLASTSTUDENTID");
            return adp.SelectRecordID(cmd) + 1;

        }
        //  public string staffInsert(string _staffName, string _shortName, string _gender, string _fatherName, string _phoneNo, string _email, string _cnic, string __maritalStatus, string _mobileNo, string _day,string _month,string _year, string _bloodGroup, string _address, string _image, string _fingerPrint, string _qualification, string _personalEducation, string _personalExperiance, string _oppointed, string _department, string _desiganation, string _goodAt, string _Status, string _leaveStatus, string _payScale, string _basicSalary, string _totalAllowances, string _lastIncreament, string _lastIncreamentDate, string _anySpecialBonus, string _bankAccNo, string _scaleHL, string _scaleSL, string _daliyJoinsAt, string _leavesAt, string _fridayLeaves, string _annualLeaves,string _monthlyAllowed, string _basicSalaryAmount, string _salaryType, string _fixedSalaryAmount,string willTeach)
        public string staffInsert(string _staffName, string _shortName, string _gender, string _fatherName, string _phoneNo, string _email, string _cnic, string __maritalStatus, string _mobileNo, string _day, string _month, string _year, string _bloodGroup, string _address, string _image, string _fingerPrint, string _qualification, string _personalEducation, string _personalExperiance, string _goodAt, string _oppointed, string _department, string _desiganation, string _shift, string _Status, string _leftDate, string willTeach, string _payScale, string _basicSalary, string _totalAllowances, string _lastIncreament, string _lastIncreamentDate, string _anySpecialBonus, string _bankAccNo, string _scaleHL, string _scaleSL, string _daliyJoinsAt, string _leavesAt, string _fridayLeaves, string _annualLeaves, string _monthlyAllowed, string _fixedSalaryAmount)
       {
            string mes ="";
            //staff infomation

            StaffInfo.staffName = _staffName;
            StaffInfo.shortName = _shortName;
            StaffInfo.Gender = _gender;
            StaffInfo.fatherName = _fatherName;
            StaffInfo.phoneNo = _phoneNo;
            StaffInfo.Email = _email;
            StaffInfo.Cnic = _cnic;
            StaffInfo.maritalStatus = __maritalStatus;
            StaffInfo.mobileNo = _mobileNo;
            StaffInfo.days = Convert.ToInt32(_day);
            StaffInfo.months = _month;
            StaffInfo.year = Convert.ToInt32(_year);
            StaffInfo.bloodGroup = _bloodGroup;
            StaffInfo.Address = _address;
            StaffInfo.Image = _image;
            StaffInfo.fingerPrint = _fingerPrint;

            //staff education information

            StaffInfo.qualification = _qualification;
            StaffInfo.personalEducation = _personalEducation;
            StaffInfo.personalExperiance = _personalExperiance;
            StaffInfo.goodAt = _goodAt;

            StaffInfo.oppointed = _oppointed;
            StaffInfo.departmentId = mec.departmentIdSelect(_department);
            StaffInfo.desiganationId = mec.designationIdSelect(_desiganation);
            StaffInfo.shift = _shift;
            StaffInfo.status = _Status;
            StaffInfo.leaveStatus = _leftDate;
            StaffInfo.willTeach = willTeach;
            //staff salry information

            StaffInfo.payScale = _payScale.ToUpper();
            StaffInfo.basicSalary = Convert.ToInt32(_basicSalary);
            StaffInfo.totalAlloance = Convert.ToInt32(_totalAllowances);
            StaffInfo.lastIncreament = Convert.ToInt32(_lastIncreament);
            StaffInfo.lastIncreamentDate = _lastIncreamentDate;
            StaffInfo.anySpecialBonus = Convert.ToInt32(_anySpecialBonus);
            StaffInfo.bankAcNo = _bankAccNo;
            StaffInfo.scaleHL = _scaleHL;
            StaffInfo.scaleSL = _scaleSL;
            StaffInfo.dailyJoinsAt = _daliyJoinsAt;
            StaffInfo.leavesAt = _leavesAt;
            StaffInfo.fridayLeavesTime = _fridayLeaves;
            StaffInfo.annualLeaves = Convert.ToInt32(_annualLeaves);
            StaffInfo.monthlyAllowed = Convert.ToInt32(_monthlyAllowed);
            StaffInfo.fixedSalaryAmount = _fixedSalaryAmount;

            //StaffInfo.basicSalaryAmount = Convert.ToInt32(_basicSalaryAmount);
            //StaffInfo.salaryType = _salaryType;


            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@StaffName", StaffInfo.staffName);
            cmd.Parameters.AddWithValue("@ShortName", StaffInfo.shortName);
            cmd.Parameters.AddWithValue("@Gender", StaffInfo.Gender);
            cmd.Parameters.AddWithValue("@FatherName", StaffInfo.fatherName);
            cmd.Parameters.AddWithValue("@PhoneNo", StaffInfo.phoneNo);
            cmd.Parameters.AddWithValue("@EmailAddress", StaffInfo.Email);
            cmd.Parameters.AddWithValue("@CNICNo", StaffInfo.Cnic);
            cmd.Parameters.AddWithValue("@HomeAddress", StaffInfo.Address);
            cmd.Parameters.AddWithValue("@MaritalStatus", StaffInfo.maritalStatus);
            cmd.Parameters.AddWithValue("@MobileNo", StaffInfo.mobileNo);
            cmd.Parameters.AddWithValue("@Day", StaffInfo.days);
            cmd.Parameters.AddWithValue("@Month", StaffInfo.months);
            cmd.Parameters.AddWithValue("@Year", StaffInfo.year);
            cmd.Parameters.AddWithValue("@BloodGroup", StaffInfo.bloodGroup);
            cmd.Parameters.AddWithValue("@StaffImage", StaffInfo.Image);
            cmd.Parameters.AddWithValue("@StaffFingerPrint", StaffInfo.fingerPrint);
            
            cmd.Parameters.AddWithValue("@Qualification", StaffInfo.qualification);
            cmd.Parameters.AddWithValue("@EducationDetial", StaffInfo.personalEducation);
            cmd.Parameters.AddWithValue("@ExperianceDetail", StaffInfo.personalExperiance);
            cmd.Parameters.AddWithValue("@AppointedDate", StaffInfo.oppointed);
            cmd.Parameters.AddWithValue("@WillTeach", StaffInfo.willTeach);
            cmd.Parameters.AddWithValue("@DesignationId", StaffInfo.desiganationId);
            cmd.Parameters.AddWithValue("@DeptId", StaffInfo.departmentId);
            cmd.Parameters.AddWithValue("@GoodAt", StaffInfo.goodAt);
            cmd.Parameters.AddWithValue("@Status", StaffInfo.status);
            cmd.Parameters.AddWithValue("@LeavedDate", StaffInfo.leavesAt);

            cmd.Parameters.AddWithValue("@pay_scale", StaffInfo.payScale);
            cmd.Parameters.AddWithValue("@basic_salary", StaffInfo.basicSalary);
            cmd.Parameters.AddWithValue("@totall_of_allowance", StaffInfo.totalAlloance);
            cmd.Parameters.AddWithValue("@last_increament_salary", StaffInfo.lastIncreament);
            cmd.Parameters.AddWithValue("@increament_date", StaffInfo.lastIncreamentDate);
            cmd.Parameters.AddWithValue("@special_bonus", StaffInfo.anySpecialBonus);
            cmd.Parameters.AddWithValue("@bank_account_no", StaffInfo.bankAcNo);
            cmd.Parameters.AddWithValue("@ScaleHL", StaffInfo.scaleHL);
            cmd.Parameters.AddWithValue("@ScaleSL", StaffInfo.scaleSL);
            cmd.Parameters.AddWithValue("@DailyJointAt", StaffInfo.dailyJoinsAt);
            cmd.Parameters.AddWithValue("@DailyLeaveAt", StaffInfo.leavesAt);
            cmd.Parameters.AddWithValue("@FridayLeave", StaffInfo.fridayLeavesTime);
            cmd.Parameters.AddWithValue("@AnnualLeave", StaffInfo.annualLeaves);
            cmd.Parameters.AddWithValue("@MontlyAllowed", StaffInfo.monthlyAllowed);
            cmd.Parameters.AddWithValue("@SalaryAmount", StaffInfo.fixedSalaryAmount);
            cmd.Parameters.AddWithValue("@Shift", StaffInfo.shift);
            //cmd.Parameters.AddWithValue("@SalaryType", StaffInfo.salaryType);



            if (adp.insert(cmd))
                {
                    mes = "Staff Record Insert Successfuly ";
                }
                else
                {

                    mes = "Does Not Insert Successfuly ";
                }
            

            return mes;
            

        }

        public string staffUpdate(string staffId, string _staffName, string _shortName, string _gender, string _fatherName, string _phoneNo, string _email, string _cnic, string __maritalStatus, string _mobileNo, string _day, string _month, string _year, string _bloodGroup, string _address, string _image, string _fingerPrint, string _qualification, string _personalEducation, string _personalExperiance, string _goodAt, string _oppointed, string _department, string _desiganation, string _shift, string _Status, string _leftDate, string willTeach, string _payScale, string _basicSalary, string _totalAllowances, string _lastIncreament, string _lastIncreamentDate, string _anySpecialBonus, string _bankAccNo, string _scaleHL, string _scaleSL, string _daliyJoinsAt, string _leavesAt, string _fridayLeaves, string _annualLeaves, string _monthlyAllowed, string _fixedSalaryAmount)
        {
            string mes = "";
            //staff infomation
            StaffInfo.staffId = Convert.ToInt32(staffId);
            StaffInfo.staffName = _staffName;
            StaffInfo.shortName = _shortName;
            StaffInfo.Gender = _gender;
            StaffInfo.fatherName = _fatherName;
            StaffInfo.phoneNo = _phoneNo;
            StaffInfo.Email = _email;
            StaffInfo.Cnic = _cnic;
            StaffInfo.maritalStatus = __maritalStatus;
            StaffInfo.mobileNo = _mobileNo;
            StaffInfo.days = Convert.ToInt32(_day);
            StaffInfo.months = _month;
            StaffInfo.year = Convert.ToInt32(_year);
            StaffInfo.bloodGroup = _bloodGroup;
            StaffInfo.Address = _address;
            StaffInfo.Image = _image;
            StaffInfo.fingerPrint = _fingerPrint;

            //staff education information

            StaffInfo.qualification = _qualification;
            StaffInfo.personalEducation = _personalEducation;
            StaffInfo.personalExperiance = _personalExperiance;
            StaffInfo.goodAt = _goodAt;

            StaffInfo.oppointed = _oppointed;
            StaffInfo.departmentId = mec.departmentIdSelect(_department);
            StaffInfo.desiganationId = mec.designationIdSelect(_desiganation);
            StaffInfo.shift = _shift;
            StaffInfo.status = _Status;
            StaffInfo.leaveStatus = _leftDate;
            StaffInfo.willTeach = willTeach;
            //staff salry information

            StaffInfo.payScale = _payScale.ToUpper();
            StaffInfo.basicSalary = Convert.ToInt32(_basicSalary);
            StaffInfo.totalAlloance = Convert.ToInt32(_totalAllowances);
            StaffInfo.lastIncreament = Convert.ToInt32(_lastIncreament);
            StaffInfo.lastIncreamentDate = _lastIncreamentDate;
            StaffInfo.anySpecialBonus = Convert.ToInt32(_anySpecialBonus);
            StaffInfo.bankAcNo = _bankAccNo;
            StaffInfo.scaleHL = _scaleHL;
            StaffInfo.scaleSL = _scaleSL;
            StaffInfo.dailyJoinsAt = _daliyJoinsAt;
            StaffInfo.leavesAt = _leavesAt;
            StaffInfo.fridayLeavesTime = _fridayLeaves;
            StaffInfo.annualLeaves = Convert.ToInt32(_annualLeaves);
            StaffInfo.monthlyAllowed = Convert.ToInt32(_monthlyAllowed);
            StaffInfo.fixedSalaryAmount = _fixedSalaryAmount;


            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@StaffId",StaffInfo.staffId);
            cmd.Parameters.AddWithValue("@StaffName", StaffInfo.staffName);
            cmd.Parameters.AddWithValue("@ShortName", StaffInfo.shortName);
            cmd.Parameters.AddWithValue("@Gender", StaffInfo.Gender);
            cmd.Parameters.AddWithValue("@FatherName", StaffInfo.fatherName);
            cmd.Parameters.AddWithValue("@PhoneNo", StaffInfo.phoneNo);
            cmd.Parameters.AddWithValue("@EmailAddress", StaffInfo.Email);
            cmd.Parameters.AddWithValue("@CNICNo", StaffInfo.Cnic);
            cmd.Parameters.AddWithValue("@HomeAddress", StaffInfo.Address);
            cmd.Parameters.AddWithValue("@MaritalStatus", StaffInfo.maritalStatus);
            cmd.Parameters.AddWithValue("@MobileNo", StaffInfo.mobileNo);
            cmd.Parameters.AddWithValue("@Day", StaffInfo.days);
            cmd.Parameters.AddWithValue("@Month", StaffInfo.months);
            cmd.Parameters.AddWithValue("@Year", StaffInfo.year);
            cmd.Parameters.AddWithValue("@BloodGroup", StaffInfo.bloodGroup);
            cmd.Parameters.AddWithValue("@StaffImage", StaffInfo.Image);
            cmd.Parameters.AddWithValue("@StaffFingerPrint", StaffInfo.fingerPrint);

            cmd.Parameters.AddWithValue("@Qualification", StaffInfo.qualification);
            cmd.Parameters.AddWithValue("@EducationDetial", StaffInfo.personalEducation);
            cmd.Parameters.AddWithValue("@ExperianceDetail", StaffInfo.personalExperiance);
            cmd.Parameters.AddWithValue("@AppointedDate", StaffInfo.oppointed);
            cmd.Parameters.AddWithValue("@WillTeach", StaffInfo.willTeach);
            cmd.Parameters.AddWithValue("@DesignationId", StaffInfo.desiganationId);
            cmd.Parameters.AddWithValue("@DeptId", StaffInfo.departmentId);
            cmd.Parameters.AddWithValue("@GoodAt", StaffInfo.goodAt);
            cmd.Parameters.AddWithValue("@Status", StaffInfo.status);
            cmd.Parameters.AddWithValue("@LeavedDate", StaffInfo.leavesAt);

            cmd.Parameters.AddWithValue("@pay_scale", StaffInfo.payScale);
            cmd.Parameters.AddWithValue("@basic_salary", StaffInfo.basicSalary);
            cmd.Parameters.AddWithValue("@totall_of_allowance", StaffInfo.totalAlloance);
            cmd.Parameters.AddWithValue("@last_increament_salary", StaffInfo.lastIncreament);
            cmd.Parameters.AddWithValue("@increament_date", StaffInfo.lastIncreamentDate);
            cmd.Parameters.AddWithValue("@special_bonus", StaffInfo.anySpecialBonus);
            cmd.Parameters.AddWithValue("@bank_account_no", StaffInfo.bankAcNo);
            cmd.Parameters.AddWithValue("@ScaleHL", StaffInfo.scaleHL);
            cmd.Parameters.AddWithValue("@ScaleSL", StaffInfo.scaleSL);
            cmd.Parameters.AddWithValue("@DailyJointAt", StaffInfo.dailyJoinsAt);
            cmd.Parameters.AddWithValue("@DailyLeaveAt", StaffInfo.leavesAt);
            cmd.Parameters.AddWithValue("@FridayLeave", StaffInfo.fridayLeavesTime);
            cmd.Parameters.AddWithValue("@AnnualLeave", StaffInfo.annualLeaves);
            cmd.Parameters.AddWithValue("@MontlyAllowed", StaffInfo.monthlyAllowed);
            cmd.Parameters.AddWithValue("@SalaryAmount", StaffInfo.fixedSalaryAmount);
            cmd.Parameters.AddWithValue("@Shift", StaffInfo.shift);

        
            if (adp.Update(cmd))
            {
                mes = "Staff Record Update Successfuly ";
            }
            else
            {

                mes = "Does Not Update Successfuly ";
            }


            return mes;


        }


        
        public List<string> selectStaffById(int StaffId)
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYSTAFFID");
            cmd.Parameters.AddWithValue("@StaffId", StaffId);
            return adp.showDataTextbox(cmd);

        }


        public DataTable selectAllStaffRecordDataGridView()
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        /*Delect  Student Record By GR No */
        public string deleteSingleStaff(int StaffId)
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@StaffId", StaffId);

            if (adp.Delete(cmd))
            {
                return "Student Record Delete Successfuly";
            }
            else
            {

                return "Does Not Delete Successfuly";
            }

        }

        /*Search Staff By check box*/
        public DataTable searchStaff(int staffId, string staffName, string staffFather, string phone, string staffMobile, int day, string month, int year)
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "searchstaff");
            if (staffId != 0)
            {
                cmd.Parameters.AddWithValue("@StaffId", staffId);
            }
            
            if (staffName != null)
            {
                cmd.Parameters.AddWithValue("@StaffName", staffName);
            }
            if (staffFather != null)
            {
                cmd.Parameters.AddWithValue("@FatherName", staffFather);
            }
            if (phone != null)
            {
                cmd.Parameters.AddWithValue("@PhoneNo", phone);
            }
            if (staffMobile != null)
            {
                cmd.Parameters.AddWithValue("@MobileNo", staffMobile);
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


        /*Delect  Student Record By GR No */
        public DataTable searchStaff()
        {
            cmd = new SqlCommand("SfaffRegisterationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "dynamic");
            cmd.Parameters.AddWithValue("@StaffName", "StaffName");
            cmd.Parameters.AddWithValue("@value", "asdf");
            return adp.showDataGridView(cmd);


        }

    }
}
