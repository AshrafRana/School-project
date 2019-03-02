using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace School_Managment_System
{
    class MasterEnteriesController
    {
        SchoolType schoolTypes;
        schoolEnteryy schoolEntr;
        ClassTypee clsstype;
        ClassEnteryy clsseEnty;
        SectionEntryy secEntry;
        SessionEntryy sessEntry;
        StaffDepartment staffdeprt;
        StaffDesiganation staffdesig;
        FeeTypee feetpye;
        StudentDecument stuDec;
        ClassSections cs;
        schoolFees scholFeeEntry;
        Subjects sub;
        Adapter adp;
        
        SqlCommand cmd;
        public MasterEnteriesController() 
        {
            clsseEnty = new ClassEnteryy();
            secEntry = new SectionEntryy();
            schoolTypes = new SchoolType();
            schoolEntr = new schoolEnteryy();
            clsstype = new ClassTypee();
            sessEntry = new SessionEntryy();
            staffdeprt = new StaffDepartment();
            staffdesig = new StaffDesiganation();
            feetpye = new FeeTypee();
            stuDec = new StudentDecument();
            cs = new ClassSections();
            scholFeeEntry = new schoolFees();
            sub = new Subjects(); 
           
            adp = new Adapter();
            cmd = new SqlCommand();
        }
        public List<string> designationCombobox()
        {
            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "DesignationName");
            return adp.showCombobox(cmd);

        }
        public int designationIdSelect(string _designation)
        {
            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DesignationName", _designation);
            return adp.SelectRecordID(cmd);

        }



        public List<string> shoolInfoReport()
        {
            cmd = new SqlCommand("SchoolInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTName");
            return adp.showDataTextbox(cmd);

        }

        /*Group CRUD Operation*/

        public string groupInsert(string _group)
        {

            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYNAME");
            cmd.Parameters.AddWithValue("@Group", _group);

            if (adp.Select(cmd))
            {
                return _group + " Group Already Exist";
            }
            else
            {
                cmd = new SqlCommand("GroupSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@Group", _group);

                if (adp.insert(cmd))
                {
                    return _group + " Group Insert Successfully";
                }
                else
                {

                    return _group + " Group does not Insert";
                }

            }

        }

        public string groupUpdate(int GroupId ,string _group)
        {

            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@Group", _group);
            cmd.Parameters.AddWithValue("@GroupId", GroupId);
            if (adp.insert(cmd))
            {
                return _group + " Group Update Successfully";
            }
            else
            {

                return _group + " Group does not Update";
            }

        }
        public string groupDelete(string _group)
        {
            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Group", _group);

            if (adp.SelectRecordID(cmd) > 0)
            {

                cmd = new SqlCommand("GroupSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@Group", _group);

                if (adp.Delete(cmd))
                {
                    return _group + " Group Delete Successfully";
                }
                else
                {

                    return _group + " Delete does not Insert";
                }


            }
            else
            {
                return _group + " Group does not in database";

            }

        }
        public DataTable groupDataGridView()
        {
            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }
        public List<string> groupNameCombobox()
        {
            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "GroupName");
            return adp.showCombobox(cmd);

        }

        public int groupIdSelect(string _group)
        {
            cmd = new SqlCommand("GroupSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Group", _group);
            return adp.SelectRecordID(cmd);


        }

        /*Department CRUD Operation*/

        public string departmentInsert(string _departName)
        {
            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DepartmentName", _departName);

            if (adp.Select(cmd))
            {

                return _departName + " Department Already Exist";
            }
            else
            {
                cmd = new SqlCommand("DepartmentSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@DepartmentName", _departName);

                if (adp.insert(cmd))
                {
                    return _departName + " Department Insert Successfully";
                }
                else
                {

                    return _departName + " Department does not Insert";
                }

            }


        }
        public string departmentUpdate(int DeptId, string DepartmentName)
        {
            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);


            if (adp.Update(cmd))
            {
                return DepartmentName + " Departmen Update Successfully";
            }
            else
            {

                return DepartmentName + " Departmen does not Update";
            }


        }
        public string departmentDelete(string DepartmentName)
        {

            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("DepartmentSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);

                if (adp.Delete(cmd))
                {
                    return DepartmentName + " Department Delete Successfully";
                }
                else
                {

                    return DepartmentName + " Department does not Delete";
                }


            }
            else
            {

                return DepartmentName + " Department does not in database";
            }

        }
        public DataTable departmentDataGridView()
        {
            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        public List<string> departmentCombobox()
        {
            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "DepartmentName");
            return adp.showCombobox(cmd);

        }
        public int departmentIdSelect(string DepartmentName)
        {
            cmd = new SqlCommand("DepartmentSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
            return adp.SelectRecordID(cmd);

        }
        
        /*Class Name CRUD Operation*/

        public int classIdSelect(string _className)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            return adp.SelectRecordID(cmd);

        }

        public string classInsert(string _className, string department)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);

            if (adp.Select(cmd))
            {

                return _className + " ClassType Already Exist";
            }
            else
            {
                cmd = new SqlCommand("DepartmentSp");
                cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
                cmd.Parameters.AddWithValue("@DepartmentName", department);
                int DeptId = adp.SelectRecordID(cmd);

                cmd = new SqlCommand("ClassSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@Class", _className);
                cmd.Parameters.AddWithValue("@DeptId", DeptId);

                if (adp.insert(cmd))
                {
                    return _className + " Class Insert Successfully";
                }
                else
                {

                    return _className + " Class does not Insert";
                }

            }



        }
        public string classUpdate(int class_id, string _className, int DeptId)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@class_id", class_id);
            cmd.Parameters.AddWithValue("@Class", _className);
            cmd.Parameters.AddWithValue("@DeptId", DeptId);

            if (adp.Update(cmd))
            {
                return _className + " Class Update Successfully";
            }
            else
            {

                return _className + " Class does not Update";
            }

        }
        public string classDelete(string _className)
        {

            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("ClassSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@Class", _className);

                if (adp.Delete(cmd))
                {
                    return _className + " Class Delete Successfully";
                }
                else
                {

                    return _className + " Class does not Delete";
                }



            }
            else
            {

                return _className + " Class does not in database Which you want to delete";
            }
        }
        public DataTable classDataGridView()
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        public List<string> classCombobox()
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "ClassName");
            return adp.showCombobox(cmd);

        }

        public List<string> classCombobox(int depId)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SeclectClassName");
            cmd.Parameters.AddWithValue("@DeptId", depId);
            return adp.showCombobox(cmd);

        }

        /*section Name CRUD Operation*/
        public string sectionInsert(string _section)
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);

            if (adp.Select(cmd))
            {

                return _section + " SectionName Already Exist";
            }
            else
            {
                cmd = new SqlCommand("SectionSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SectionName", _section);

                if (adp.insert(cmd))
                {
                    return _section + " SectionName Insert Successfully";
                }
                else
                {

                    return _section + " SectionName does not Insert";
                }

            }



        }
        public string sectionUpdate(int sectionId, string _section)
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@sectionId", sectionId);
            cmd.Parameters.AddWithValue("@SectionName", _section);

            if (adp.Update(cmd))
            {
                return _section + " Section Update Successfully";
            }
            else
            {

                return _section + " Section does not Update";
            }


        }
        public string sectionDelete(string _section)
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);


            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("SectionSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@SectionName", _section);
                if (adp.Delete(cmd))
                {
                    return _section + " Section Delete Successfully";
                }
                else
                {

                    return _section + " Section does not Delete";
                }


            }
            else
            {

                return _section + " Section does not in database";
            }




        }
        public DataTable sectionDataGridView()
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        public List<string> sectionCombobox()
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SECTIONNAME");
            return adp.showCombobox(cmd);

        }

        public int sectionIdSelect(string _section)
        {
            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);
            return adp.SelectRecordID(cmd);

        }

        /*Class Section CRUD Operation*/

        public string classSectionInsert(string _className, string _section, int maxStudent, int enRollStudent )
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int _class_id = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);
            int _sectionId = adp.SelectRecordID(cmd);


            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@sectionId", _sectionId);
            cmd.Parameters.AddWithValue("@ClassId", _class_id);


            if (adp.Select(cmd))
            {

                return _className + "    " + _section + " Already Exist";
            }
            else
            {

                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@sectionId", _sectionId);
                cmd.Parameters.AddWithValue("@ClassId", _class_id);
                cmd.Parameters.AddWithValue("@MaxStudent", maxStudent);
                cmd.Parameters.AddWithValue("@StudentEnRoll", enRollStudent);

                if (adp.insert(cmd))
                {
                    return _className + "    " + _section + " Insert Successfully";
                }
                else
                {

                    return _className + "    " + _section + " does not Insert";
                }

            }


        }
        public string classSectionUpdate(string _className, string _section, int maxStudent, int classSessionId)
        {

            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int _class_id = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);
            int _sectionId = adp.SelectRecordID(cmd);


            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@sectionId", _sectionId);
            cmd.Parameters.AddWithValue("@ClassId", _class_id);


            if (adp.Select(cmd))
            {

                return _className + "    " + _section + " Already Exist";
            }
            else {
                

                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@sectionId", _sectionId);
                cmd.Parameters.AddWithValue("@ClassId", _class_id);
                cmd.Parameters.AddWithValue("@MaxStudent", maxStudent);
                cmd.Parameters.AddWithValue("@ClassSectionId", classSessionId);

                if (adp.Update(cmd))
                {
                    return _className + "    " + _section + " Class Section Update Successfully";
                }
                else
                {

                    return _className + "    " + _section + " Class Section does not Update";
                }
            }

            

        }

        public string classSectionExdentStudent(int maxStudent, int classSessionId)
        {
            
                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATEMaxStudent");
                cmd.Parameters.AddWithValue("@MaxStudent", maxStudent);
                cmd.Parameters.AddWithValue("@ClassSectionId", classSessionId);

                if (adp.Update(cmd))
                {
                    return " Class Section Update Successfully";
                }
                else
                {

                    return " Class Section does not Update";
                }
            
        }
        public string classSectionDelete(string _className, string _section)
        {

            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int _class_id = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SectionName", _section);
            int _sectionId = adp.SelectRecordID(cmd);


            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@sectionId", _sectionId);
            cmd.Parameters.AddWithValue("@ClassId", _class_id);

            int classSessionId = adp.SelectRecordID(cmd);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("ClassSectionSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@ClassSectionId", classSessionId);
                if (adp.Delete(cmd))
                {
                    return _className + "    " + _section + " Class Section Delete Successfully";

                }
                else
                {
                    return _className + "    " + _section + " Class Section does not Delete";

                }


            }
            else
            {

                return _className + "    " + _section + " Class Section does not in database";
            }

        }
        public DataTable classSectionDataGridView()
        {
            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }


        public int classSectionIdSelect(int class_id, int sectionId)
        {
            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@ClassId", class_id);
            cmd.Parameters.AddWithValue("@sectionId", sectionId);
            return adp.SelectRecordID(cmd);

        }
        public List<string> classSectionByClassId(int class_id)
        {
            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTSESSIONBYCLASS");
            cmd.Parameters.AddWithValue("@ClassId", class_id);
            return adp.showCombobox(cmd);

        }
        public int classSectionEnRoll(int classSessionId)
        {
            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "StudentEnRoll");
            cmd.Parameters.AddWithValue("@ClassSectionId", classSessionId);
            return adp.SelectRecordID(cmd);

        }
        public int classSectionMax(int classSessionId)
        {
            cmd = new SqlCommand("ClassSectionSp");
            cmd.Parameters.AddWithValue("@Action", "MaxStudent");
            cmd.Parameters.AddWithValue("@ClassSectionId", classSessionId);
            return adp.SelectRecordID(cmd);

        }
        

        
       



        /*Desiganation CRUD Operation*/

        public string desiganationInsert(string _designation)
        {
            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DesignationName", _designation);

            if (adp.Select(cmd))
            {

                return _designation+" Designation Already Exist";
            }
            else
            {
                cmd = new SqlCommand("DesignationSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@DesignationName", _designation);

                if (adp.insert(cmd))
                {
                    return _designation+" Designation Insert Successfully";
                }
                else
                {

                    return _designation+" Designation does not Insert";
                }

            }
            


        }
        public string desiganationtUpdate(int Desig_id ,string _designation)
        {

            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@Desig_id", Desig_id);
            cmd.Parameters.AddWithValue("@DesignationName", _designation);
           

            if (adp.Update(cmd))
            {
                return _designation+" Designation Update Successfully";
            }
            else
            {

                return _designation+" Designation does not Update";
            }


        }
        public string desiganationtDelete(string _designation)
        {

            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@DesignationName", _designation);

            
            if (adp.SelectRecordID(cmd) > 0)
            {
               
                cmd = new SqlCommand("DesignationSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@DesignationName", _designation);

                if (adp.Delete(cmd))
                {
                    return _designation + " Designation Delete Successfully";
                }
                else
                {

                    return _designation + " Designation does not Delete";
                }


            }
            else
            {

                return _designation + " Subject does not in database";
            }

        }
        public DataTable designationDataGridView()
        {
            cmd = new SqlCommand("DesignationSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        
        /*SubjectEntry CRUD Operation*/

        public string subjectInsert(string _subjectName)
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);

            if (adp.Select(cmd))
            {

                return _subjectName + " Subjec Already Exist";
            }
            else
            {
                cmd = new SqlCommand("SubjectSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SubjectName", _subjectName);

                if (adp.insert(cmd))
                {
                    return _subjectName + " Subjec Insert Successfully";
                }
                else
                {

                    return _subjectName + " Subjec does not Insert";
                }

            }


        }
        public string subjectUpdate(int subjectId ,string _subjectName)
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@subjectId", subjectId);
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);


            if (adp.Update(cmd))
            {
                return _subjectName+" Subject Update Successfully";
            }
            else
            {

                return _subjectName+" Subject does not Update";
            }
            


        }
        public string subjectDelete(string _subjectName)
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("SubjectSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@SubjectName", _subjectName);

                if (adp.Delete(cmd))
                {
                    return _subjectName + " Subject Delete Successfully";
                }
                else
                {

                    return _subjectName + " Subject does not Delete";
                }

               
            }
            else
            {

                return _subjectName+" Subject does not in database";
            }
            
        }
        public DataTable subjectDataGridView()
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }
        public List<string> subjectCombobox()
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SubjectName");
            return adp.showCombobox(cmd);

        }

        public int subjectIdSelect(string SubjectName)
        {
            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            return adp.SelectRecordID(cmd);

        }

        /*FeeType CRUD Operation*/

        public string feeTypeInsert(string _feetype)
        {
            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@FeeType", _feetype);

            if (adp.Select(cmd))
            {

                return _feetype + " feeType Already Exist";
            }
            else
            {
                cmd = new SqlCommand("FeeTypeSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@FeeType", _feetype);

                if (adp.insert(cmd))
                {
                    return _feetype+" feeType Insert Successfully";
                }
                else
                {

                    return _feetype+" FeeType does not Insert";
                }

            }
            


        }
        public string feeTypeUpdate(int _FeeTypeId , string _feetype)
        {

            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@FeeTypeId", _FeeTypeId);
            cmd.Parameters.AddWithValue("@FeeType", _feetype);


            if (adp.Update(cmd))
            {
                return _feetype+" FeeType Update Successfully";
            }
            else
            {

                return _feetype+" FeeType does not Update";
            }
            
        }
        public string feeTypeDelete(string _feetype)
        {
            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@FeeType", _feetype);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("FeeTypeSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@FeeType", _feetype);

                if (adp.Delete(cmd))
                {
                    return _feetype + " FeeType Delete Successfully";
                }
                else
                {

                    return _feetype + " FeeType does not Delete";
                }


            }
            else
            {

                return _feetype + " FeeType does not in database";
            }

         
        }
        public DataTable feeTypeDataGridView()
        {
            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);


        }

        public List<string> feeTypeCombobox()
        {
            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTFeeType");
            return adp.showCombobox(cmd);

        }

        public int feeTypeIdSelect(string _feetype)
        {
            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@FeeType", _feetype);
            return adp.SelectRecordID(cmd);

        }

       
        
        /*Class Fee CRUD Operation*/

        public string classFeeInsert(string _className, string _feeType, string _Amount)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int class_id = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@FeeType", _feeType);
            int feeTypeId = adp.SelectRecordID(cmd);

            
            cmd = new SqlCommand("ClassFeeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@class_id", class_id);
            cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);
          


            if (adp.Select(cmd))
            {

                return _className + "   "+_feeType+ "   "+ _Amount+" Already Exist";
            }
            else
            {
                cmd = new SqlCommand("ClassFeeSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@class_id", class_id);
                cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);
                cmd.Parameters.AddWithValue("@FeeAmount", _Amount);

                if (adp.insert(cmd))
                {
                    return _className + "   " + _feeType + "   " + _Amount + "  Insert Successfully";
                }
                else
                {

                    return _className + "   " + _feeType + "   " + _Amount + "  does not Insert";
                }

            }
          
        }
        public string classFeeUpdate(string _className, string _feeType, string _Amount, int _ClassFeeId)
        {

                cmd = new SqlCommand("ClassSp");
                cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
                cmd.Parameters.AddWithValue("@Class", _className);
                int class_id = adp.SelectRecordID(cmd);

                cmd = new SqlCommand("FeeTypeSp");
                cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
                cmd.Parameters.AddWithValue("@FeeType", _feeType);
                int feeTypeId = adp.SelectRecordID(cmd);
            
                cmd = new SqlCommand("ClassFeeSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@class_id", class_id);
                cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);
                cmd.Parameters.AddWithValue("@FeeAmount", _Amount);
                cmd.Parameters.AddWithValue("@ClassFeeId", _ClassFeeId);

            if (adp.Update(cmd))
                {
                    return _className + "   " + _feeType + "   " + _Amount + "  Update Successfully";
                }
                else
                {

                    return _className + "   " + _feeType + "   " + _Amount + "  does not Update";
                }

            

        }

        public string classFeeDelete(string _className, string _feeType, string _Amount)
        {

            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int class_id = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("FeeTypeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@FeeType", _feeType);
            int feeTypeId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("ClassFeeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@class_id", class_id);
            cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);
            
            int ClassFeeId = adp.SelectRecordID(cmd);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("ClassFeeSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@ClassFeeId", ClassFeeId);
                if (adp.Delete(cmd))
                {
                    return _className + "   " + _feeType + "   " + _Amount + "  Delete Successfully";
                }
                else
                {
                    return _className + "   " + _feeType + "   " + _Amount + "  does not Delete";
                }


            }
            else
            {
                return _className + "   " + _feeType + "   " + _Amount + "  does not in database";
            }
            
        }

        public DataTable classFeeDataGridView()
        {
            cmd = new SqlCommand("ClassFeeSp");
            cmd.Parameters.AddWithValue("@Action", "ClassFee");
            return adp.showDataGridView(cmd);
        }

        public int classFeeIdSelect(int _class_id,int _FeeTypeId)
        {
            cmd = new SqlCommand("ClassFeeSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@class_id", _class_id);
            cmd.Parameters.AddWithValue("@FeeTypeId", _FeeTypeId);

            return adp.SelectRecordID(cmd);

        }

        public string classFeeUpdate(int feeAmounts, int ClassFeeId)
        {

            cmd = new SqlCommand("ClassFeeSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATECFee");
            cmd.Parameters.AddWithValue("@FeeAmount", feeAmounts);
            cmd.Parameters.AddWithValue("@ClassFeeId", ClassFeeId);

            if (adp.Update(cmd))
            {
                return " Fee Amount Update Successfully";
            }
            else
            {

                return " Fee Amount does not Update";
            }

        }


        /*Session CRUD Operation*/

        public int sessionIdSelect(string _session)
        {
            cmd = new SqlCommand("SessionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYNAME");
            cmd.Parameters.AddWithValue("@SessionName", _session);

            return adp.SelectRecordID(cmd);

        }
        public string sessionInsert(string _session)
        {

            cmd = new SqlCommand("SessionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTBYNAME");
            cmd.Parameters.AddWithValue("@SessionName", _session);

            if (adp.Select(cmd))
            {

                return _session + " Session Already Exist";
            }
            else
            {
                cmd = new SqlCommand("SessionSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SessionName", _session);

                if (adp.insert(cmd))
                {
                    return _session + " Session Insert Successfully";
                }
                else
                {

                    return _session + " Session does not Insert";
                }

            }
           

        }
        public string sessionUpdate(int SessionId , string _session)
        {

            cmd = new SqlCommand("SessionSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@SessionId", SessionId);
            cmd.Parameters.AddWithValue("@SessionName", _session);

            if (adp.Update(cmd))
            {
                return _session + " Session Update Successfully";
            }
            else
            {

                return _session + " Session does not Update";
            }
            
        }
        public string sessionDelete(string _session)
        {

            cmd = new SqlCommand("SessionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SessionName", _session);

            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("SessionSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@SessionName", _session);

                if (adp.Delete(cmd))
                {
                    return _session + " ClassType Delete Successfully";
                }
                else
                {

                    return _session + " ClassType does not Delete";
                }


            }
            else
            {

                return _session + " Subject does not in database";
            }


        }
        public DataTable SessionDataGridView()
        {
            cmd = new SqlCommand("SessionSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        /*Class Subject CRUD Operation*/

        public string classSubjectInsert(string _className, string _subjectName)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int ClassId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);
            int SubjectId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("ClassSubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTID");
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@subjectId", SubjectId);
            
            if (adp.Select(cmd))
            {

            return _className + "   " + _subjectName + " Already Exist";
            }
            else
            {
                cmd = new SqlCommand("ClassSubjectSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@ClassId", ClassId);
                cmd.Parameters.AddWithValue("@subjectId", SubjectId);

                if (adp.insert(cmd))
                {
                    return _className + "   " + _subjectName + " Insert Successfully";
                }
                else
                {

                    return _className + "   " + _subjectName + "   does not Insert";
                }

            }

        }
        public DataTable classSubjectDataGridView()
        {
            cmd = new SqlCommand("ClassSubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);
        }

        public string classSubjectUpdate(string _className, string _subjectName , int ClassSubjId)
        {

            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int ClassId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);
            int SubjectId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("ClassSubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTID");
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@subjectId", SubjectId);

            if (adp.Select(cmd))
            {

                return _className + "   " + _subjectName + " Already Exist";
            }
            else
            {
                cmd = new SqlCommand("ClassSubjectSp");
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@ClassId", ClassId);
                cmd.Parameters.AddWithValue("@subjectId", SubjectId);
                cmd.Parameters.AddWithValue("@ClassSubjId", ClassSubjId);

                if (adp.Update(cmd))
                {
                    return _className + "" + _subjectName + "  Update Successfully";
                }
                else
                {

                    return _className + "" + _subjectName + "  does not Update";
                }

            }
            
           
        }

        public string classSubjectDelete(string _className, string _subjectName)
        {
            cmd = new SqlCommand("ClassSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@Class", _className);
            int ClassId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("SubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SubjectName", _subjectName);
            int SubjectId = adp.SelectRecordID(cmd);

            cmd = new SqlCommand("ClassSubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTID");
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@subjectId", SubjectId);
            int ClassSubjId = adp.SelectRecordID(cmd);
            
            if (adp.SelectRecordID(cmd) > 0)
            {
                cmd = new SqlCommand("ClassSubjectSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@ClassSubjId", ClassSubjId);
                if (adp.Delete(cmd))
                {
                    return _className + "   " + _subjectName + " Delete Successfully";
                }
                else
                {
                    return _className + "   " + _subjectName + " does not Delete";
                }


            }
            else
            {
                return _className + "   " + _subjectName + " does not in database";
            }




           

            if (adp.Delete(cmd))
            {

                return _className + "   " + _subjectName + " Already Exist";
            }
            else
            {
                
            }


        }
        public int selectClassSubjectIdUpdate(int ClassId,int subjectId)
        {
            cmd = new SqlCommand("ClassSubjectSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTID");
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@subjectId", subjectId);

            return adp.SelectRecordID(cmd);
            
        }




      

        /*SchoolEntry CRUD Operation*/

        public string schoolInfoInsert(string _schoolName, string _address, string _phoneNo, string cellNumber, string _website, string _email, string _fax, string _selectLogo, string _periodInDay, string _schoolStatAt, string _breakStartAt, string _smsTitle, string _bankName,  string _bankAddress, string _softwareLocation, string _workingDayWeek, string _schoolCloseAt, string _periodDuration, string _breakDuration, string _bankAcc, string _bankLogo)
        {
            cmd = new SqlCommand("SchoolInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");

            if (adp.SelectRecordID(cmd) > 0)
            {

                return "Only One School Information Insert";
            }
            else
            {

                cmd = new SqlCommand("SchoolInfoSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SchoolName", _schoolName);
                cmd.Parameters.AddWithValue("@Address", _address);
                cmd.Parameters.AddWithValue("@PhoneNo ", _phoneNo);
                cmd.Parameters.AddWithValue("@MobileNo ", cellNumber);
                cmd.Parameters.AddWithValue("@Websit", _website);
                cmd.Parameters.AddWithValue("@EmailAddress", _email);
                cmd.Parameters.AddWithValue("@FaxNo", _fax);
                cmd.Parameters.AddWithValue("@schoolLogo", _selectLogo);
                cmd.Parameters.AddWithValue("@PeriodInDay", _periodInDay);
                cmd.Parameters.AddWithValue("@SchoolStartTime", _schoolStatAt);
                cmd.Parameters.AddWithValue("@SchoolBreakTime", _breakStartAt);
                cmd.Parameters.AddWithValue("@SMSTile", _smsTitle);
                cmd.Parameters.AddWithValue("@BankName", _bankName);
                cmd.Parameters.AddWithValue("@BankAddress", _bankAddress);
                cmd.Parameters.AddWithValue("@SoftwareLocation", _softwareLocation);
                cmd.Parameters.AddWithValue("@SchoolWorkingDay", _workingDayWeek);
                cmd.Parameters.AddWithValue("@SchoolCloseTime", _schoolCloseAt);
                cmd.Parameters.AddWithValue("@periodDuration", _periodDuration);
                cmd.Parameters.AddWithValue("@BreakDuration", _breakDuration);
                cmd.Parameters.AddWithValue("@AccountNo", _bankAcc);
                cmd.Parameters.AddWithValue("@BankLogo", _bankLogo);


                if (adp.insert(cmd))
                {
                    return " Insert Successfully";
                }
                else
                {

                    return "   does not Insert";
                }
            }
        }
        public string schoolInfoUpdate(int SchoolId , string _schoolName, string _address, string _phoneNo, string cellNumber, string _website, string _email, string _fax, string _selectLogo, string _periodInDay, string _schoolStatAt, string _breakStartAt, string _smsTitle, string _bankName, string _bankAddress, string _softwareLocation, string _workingDayWeek, string _schoolCloseAt, string _periodDuration, string _breakDuration, string _bankAcc, string _bankLogo)
        {
            cmd = new SqlCommand("SchoolInfoSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@SchoolId", SchoolId);
            cmd.Parameters.AddWithValue("@SchoolName", _schoolName);
            cmd.Parameters.AddWithValue("@Address", _address);
            cmd.Parameters.AddWithValue("@PhoneNo ", _phoneNo);
            cmd.Parameters.AddWithValue("@MobileNo ", cellNumber);
            cmd.Parameters.AddWithValue("@Websit", _website);
            cmd.Parameters.AddWithValue("@EmailAddress", _email);
            cmd.Parameters.AddWithValue("@FaxNo", _fax);
            cmd.Parameters.AddWithValue("@schoolLogo", _selectLogo);
            cmd.Parameters.AddWithValue("@PeriodInDay", _periodInDay);
            cmd.Parameters.AddWithValue("@SchoolStartTime", _schoolStatAt);
            cmd.Parameters.AddWithValue("@SchoolBreakTime", _breakStartAt);
            cmd.Parameters.AddWithValue("@SMSTile", _smsTitle);
            cmd.Parameters.AddWithValue("@BankName", _bankName);
            cmd.Parameters.AddWithValue("@BankAddress", _bankAddress);
            cmd.Parameters.AddWithValue("@SoftwareLocation", _softwareLocation);
            cmd.Parameters.AddWithValue("@SchoolWorkingDay", _workingDayWeek);
            cmd.Parameters.AddWithValue("@SchoolCloseTime", _schoolCloseAt);
            cmd.Parameters.AddWithValue("@periodDuration", _periodDuration);
            cmd.Parameters.AddWithValue("@BreakDuration", _breakDuration);
            cmd.Parameters.AddWithValue("@AccountNo", _bankAcc);
            cmd.Parameters.AddWithValue("@BankLogo", _bankLogo);
            
            if (adp.Update(cmd))
            {
                return " Update Successfully";
                
            }
            else
            {

                return "   does not Update";
            }

        }
       
        public List<string> selectSchoolInfo()
        {
            cmd = new SqlCommand("SchoolInfoSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataTextbox(cmd);

        }

        public string schoolInfoDelete(int SchoolId)
        {
            cmd = new SqlCommand("SchoolInfoSp");
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@SchoolId", SchoolId);
            if (adp.Delete(cmd))
            { 
                return "  Delete Successfully";
            }
            else
            {
                return "  does not Delete";
            }
        }










        /*

      public string classFeeUpdate(string _className, string _feeType, string _Amount, int _ClassFeeId)
      {

          cmd = new SqlCommand("ClassSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@Class", _className);
          int class_id = adp.SelectRecordID(cmd);

          cmd = new SqlCommand("FeeTypeSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@FeeType", _feeType);
          int feeTypeId = adp.SelectRecordID(cmd);

          cmd = new SqlCommand("ClassFeeSp");
          cmd.Parameters.AddWithValue("@Action", "UPDATE");
          cmd.Parameters.AddWithValue("@class_id", class_id);
          cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);
          cmd.Parameters.AddWithValue("@FeeAmount", _Amount);
          cmd.Parameters.AddWithValue("@ClassFeeId", _ClassFeeId);

          if (adp.insert(cmd))
          {
              return _className + "   " + _feeType + "   " + _Amount + "  Update Successfully";
          }
          else
          {

              return _className + "   " + _feeType + "   " + _Amount + "  does not Update";
          }



      }

      public string classFeeDelete(string _className, string _feeType, string _Amount)
      {

          cmd = new SqlCommand("ClassSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@Class", _className);
          int class_id = adp.SelectRecordID(cmd);

          cmd = new SqlCommand("FeeTypeSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@FeeType", _feeType);
          int feeTypeId = adp.SelectRecordID(cmd);

          cmd = new SqlCommand("ClassFeeSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@class_id", class_id);
          cmd.Parameters.AddWithValue("@FeeTypeId", feeTypeId);

          int ClassFeeId = adp.SelectRecordID(cmd);

          if (adp.SelectRecordID(cmd) > 0)
          {
              cmd = new SqlCommand("ClassFeeSp");
              cmd.Parameters.AddWithValue("@Action", "DELETE");
              cmd.Parameters.AddWithValue("@ClassFeeId", ClassFeeId);
              if (adp.Delete(cmd))
              {
                  return _className + "   " + _feeType + "   " + _Amount + "  Delete Successfully";
              }
              else
              {
                  return _className + "   " + _feeType + "   " + _Amount + "  does not Delete";
              }


          }
          else
          {
              return _className + "   " + _feeType + "   " + _Amount + "  does not in database";
          }

      }

      public DataTable classFeeDataGridView()
      {
          cmd = new SqlCommand("ClassFeeSp");
          cmd.Parameters.AddWithValue("@Action", "ClassFee");
          return adp.showDataGridView(cmd);
      }

      public int classFeeIdSelect(int _class_id, int _FeeTypeId)
      {
          cmd = new SqlCommand("ClassFeeSp");
          cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
          cmd.Parameters.AddWithValue("@class_id", _class_id);
          cmd.Parameters.AddWithValue("@FeeTypeId", _FeeTypeId);

          return adp.SelectRecordID(cmd);

      }

       */
        /************************************************************


        /*SchoolType CRUD Operation*

        public string schoolTypeInsert(string _schoolType)
        {
            schoolTypes.schoolType = _schoolType;
            query = "";
            if (adp.insert(query))
            {
                return "SchoolType Insert Successfully";
            }
            else
            {

                return "School does not Insert";
            }


        }
        public string schoolTypeUpdate(string _schoolType)
        {

            schoolTypes.schoolType = _schoolType;
            query = "";
            if (adp.Update(query))
            {
                return "SchoolType Update Successfully";
            }
            else
            {

                return "SchoolType does not Update";
            }


        }
        public string schoolTypeDelete(string _schoolType)
        {

            schoolTypes.schoolType = _schoolType;
            query = "";
            if (adp.Delete(query))
            {
                return "SchoolType Delete Successfully";
            }
            else
            {

                return "SchoolType does not Delete";
            }


        }
        public string schoolTypeDataGridView()
        {
            return null;

        }

        /*SchoolEntry CRUD Operation*

        public string schoolEntryInsert(string _schoolName, string _address, string _phoneNo, string _website, string _email, string _fax, string _selectLogo, string _periodInDay, string _schoolStatAt, string _breakStartAt, string _smsTitle, string _bankName, string _bankAddress, string _softwareLocation, string _workingDayWeek, string _schoolCloseAt, string _periodDuration, string _breakDuration, string _bankAcc, string _bankLogo)
        {

            schoolEntr.schoolName = _schoolName;
            schoolEntr.address = _address;
            schoolEntr.phoneNo = _phoneNo;
            schoolEntr.website = _website;
            schoolEntr.email = _email;
            schoolEntr.fax = _fax;
            schoolEntr.selectLogo = _selectLogo;
            schoolEntr.priodsInDay = _periodInDay;
            schoolEntr.schoolStartAt = _schoolStatAt;
            schoolEntr.breakStartAt = _breakStartAt;
            schoolEntr.smsTitle = _smsTitle;
            schoolEntr.bankName = _bankName;
            schoolEntr.bankAddress = _bankAddress;
            schoolEntr.softwareLocation = _softwareLocation;
            schoolEntr.workingDaysWeek = _softwareLocation;
            schoolEntr.schoolCloseAt = _schoolCloseAt;
            schoolEntr.periodDuration = _breakDuration;
            schoolEntr.bankAccount = _bankAcc;
            schoolEntr.bankLogo = _bankLogo;
            query = "";
            if (adp.insert(query))
            {
                return "SchoolEntry Insert Successfully";
            }
            else
            {

                return "SchoolEntry does not Insert";
            }


        }
        public string schoolEntryUpdate(string _schoolName, string _address, string _phoneNo, string _website, string _email, string _fax, string _selectLogo, string _periodInDay, string _schoolStatAt, string _breakStartAt, string _smsTitle, string _bankName, string _bankAddress, string _softwareLocation, string _workingDayWeek, string _schoolCloseAt, string _periodDuration, string _breakDuration, string _bankAcc, string _bankLogo)
        {

            schoolEntr.schoolName = _schoolName;
            schoolEntr.address = _address;
            schoolEntr.phoneNo = _phoneNo;
            schoolEntr.website = _website;
            schoolEntr.email = _email;
            schoolEntr.fax = _fax;
            schoolEntr.selectLogo = _selectLogo;
            schoolEntr.priodsInDay = _periodInDay;
            schoolEntr.schoolStartAt = _schoolStatAt;
            schoolEntr.breakStartAt = _breakStartAt;
            schoolEntr.smsTitle = _smsTitle;
            schoolEntr.bankName = _bankName;
            schoolEntr.bankAddress = _bankAddress;
            schoolEntr.softwareLocation = _softwareLocation;
            schoolEntr.workingDaysWeek = _softwareLocation;
            schoolEntr.schoolCloseAt = _schoolCloseAt;
            schoolEntr.periodDuration = _breakDuration;
            schoolEntr.bankAccount = _bankAcc;
            schoolEntr.bankLogo = _bankLogo;
            query = "";
            if (adp.insert(query))
            {
                return "SchoolEntry Update Successfully";
            }
            else
            {

                return "SchoolEntry does not Update";
            }


        }
        public string schoolEntryDelete(string _schoolName)
        {

            schoolTypes.schoolType = _schoolName;
            query = "";
            if (adp.Delete(query))
            {
                return "SchoolEntry Delete Successfully";
            }
            else
            {

                return "SchoolEntry does not Delete";
            }


        }
        public string schoolEntryDataGridView()
        {
            return null;

        }
        
        /*StudentDecoument CRUD Operation*

        public string studentDecoumentInsert(string _studentDecoument)
        {
            stuDec.studentDecouments = _studentDecoument;
            query = "";
            if (adp.insert(query))
            {
                return "student Decoument Insert Successfully";
            }
            else
            {

                return "student Decoument does not Insert";
            }


        }
        public string studentDecoumentUpdate(string _studentDecoument)
        {

            stuDec.studentDecouments = _studentDecoument;
            query = "";
            if (adp.insert(query))
            {
                return "student Decoument Update Successfully";
            }
            else
            {

                return "student Decoument does not Update";
            }


        }
        public string studentDecoumentDelete(string _studentDecoument)
        {

            stuDec.studentDecouments = _studentDecoument;
            query = "";
            if (adp.insert(query))
            {
                return "student Decoument Delete Successfully";
            }
            else
            {

                return "student Decoument does not Delete";
            }


        }
        public string studentDecoumentDataGridView()
        {
            return null;

        }

       
    */

        ///*ClassType CRUD Operation*/

        //public string classTypeInsert(string _classType)
        //{

        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "SELECTBYNAME");
        //    cmd.Parameters.AddWithValue("@class_type", _classType);

        //    if (adp.Select(cmd))
        //    {
        //        return _classType+" ClassType Already Exist";
        //    }
        //    else
        //    {
        //        cmd = new SqlCommand("ClassTypeSp");
        //        cmd.Parameters.AddWithValue("@Action", "INSERT");
        //        cmd.Parameters.AddWithValue("@class_type", _classType);

        //        if (adp.insert(cmd))
        //        {
        //            return _classType +" ClassType Insert Successfully";
        //        }
        //        else
        //        {

        //            return _classType+" ClassType does not Insert";
        //        }

        //    }

        //}
        //public string classTypeUpdate(string _classType , int classtype_id)
        //{


        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "UPDATE");
        //    cmd.Parameters.AddWithValue("@classtype_id", classtype_id);
        //    cmd.Parameters.AddWithValue("@class_type", _classType);

        //    if (adp.Update(cmd))
        //    {
        //        return _classType+" ClassType Update Successfully";
        //    }
        //    else
        //    {

        //        return _classType+" ClassType does not Update";
        //    }


        //}
        //public string classTypeDelete(string _classType)
        //{

        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
        //    cmd.Parameters.AddWithValue("@class_type", _classType);

        //    if (adp.SelectRecordID(cmd) > 0)
        //    {
        //        cmd = new SqlCommand("ClassTypeSp");
        //        cmd.Parameters.AddWithValue("@Action", "DELETE");
        //        cmd.Parameters.AddWithValue("@class_type", _classType);

        //        if (adp.Delete(cmd))
        //        {
        //            return _classType + " ClassType Delete Successfully";
        //        }
        //        else
        //        {

        //            return _classType + " ClassType does not Delete";
        //        }


        //    }
        //    else
        //    {

        //        return _classType + " Subject does not in database";
        //    }

        //}
        //public DataTable classTypeDataGridView()
        //{
        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "SELECT");
        //    return adp.showDataGridView(cmd);

        //}
        //public List<string> classTypeCombobox()
        //{
        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "SELECTClassType");
        //    return adp.showCombobox(cmd);

        //}
        //public int classTypeIdSelect(string _classType)
        //{
        //    cmd = new SqlCommand("ClassTypeSp");
        //    cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
        //    cmd.Parameters.AddWithValue("@class_type", _classType);
        //    return adp.SelectRecordID(cmd);

        //}










    }

}
