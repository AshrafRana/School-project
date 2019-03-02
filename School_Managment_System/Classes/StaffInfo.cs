using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
   partial class StaffInfo
    {
        //staff infomation
        public int staffId { set; get; }
        public string staffName { set; get; }
        public string shortName { set; get; }
        public string Gender { set; get; }
        public string fatherName { set; get; }
        public string phoneNo { set; get; }       
        public string Email { set; get; }
        public string Cnic { set; get; }
        public string maritalStatus { set; get; }
        public string mobileNo { set; get; }
        public int days { set; get; }
        public string months { set; get; }
        public int year { set; get; }
        public string bloodGroup { set; get; }
        public string Address { set; get; }
        public string Image { set; get; }
        public string fingerPrint { set; get; }

        //staff education information
        public string qualification { set; get; }
        public string personalEducation { set; get; }
        public string personalExperiance { set; get; }
        public string willTeach { set; get; }
        public string oppointed { set; get; }
        public int departmentId { set; get; }
        public int desiganationId { set; get; }
        public string shift { set; get; }
        public string goodAt { set; get; }
        public string status { set; get; }
        public string leaveStatus { set; get; }

        //staff salry information
        public string payScale { set; get; }
        public int basicSalary { set; get; }
        public int totalAlloance { set; get; }
        public int lastIncreament { set; get; }
        public string lastIncreamentDate { set; get; }
        public int anySpecialBonus { set; get; }
        public string bankAcNo { set; get; }
        public string scaleHL { set; get; }
        public string scaleSL { set; get; }
        public string dailyJoinsAt { set; get; }
        public string leavesAt { set; get; }
        public string fridayLeavesTime { set; get; }
        public int annualLeaves { set; get; }
        public int monthlyAllowed { set; get; }
        public int basicSalaryAmount { set; get; }
        public string salaryType { set; get; }
        public string fixedSalaryAmount { set; get; }
        
        public StaffInfo() { }
    }
}
