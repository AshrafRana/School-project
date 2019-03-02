using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
   partial class Student
    {
        public int GRNo { set; get; }
        public string Student_Name { set; get; }
        public string Short_Name { set; get; }
        public string Father_Name { set; get; }
        public string Guradian_Name { set; get; }
        public string Gender { set; get; }
        public string Birth_Place { set; get; }
        public string Religion { set; get; }
        public string Nationality { set; get; }
        public string B_Form_No { set; get; }
        public string day { set; get; }
        public string month { set; get; }
        public string year { set; get; }
        public string Mother_Tongue { set; get; }
        public string Blood_Group { set; get; }
        public string Image { set; get; }
        public string studentMobileNo { set; get; }

        public Student() { }

        /*
        public Student(string StudentName, string ShortName, string FatherName, string GuradianName, string Gender, string BirthPlace, string Religion, string Nationality, string B_Form_No, string DateOfBirth, string MotherTongue, string BloodGroup) 
        {

            this.Student_Name = StudentName;
            this.Short_Name = ShortName;
            this.Father_Name = FatherName;
            this.Guradian_Name = GuradianName;
            this.Gender = Gender;
            this.Birth_Place = BirthPlace;
            this.Religion = Religion;
            this.Nationality = Nationality;
            this.B_Form_No = B_Form_No;
            this.Date_Of_Birth = DateOfBirth;
            this.Mother_Tongue = MotherTongue;
            this.Blood_Group = BloodGroup;
            
        }
        */
      

    }

    
}
