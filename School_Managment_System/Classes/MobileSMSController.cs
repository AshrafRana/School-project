using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.IO.Ports;

namespace School_Managment_System
{
    class MobileSMSController
    {

        Adapter adp;
        SqlCommand cmd;
        MobileSMS mobileSMS;


        public MobileSMSController()
        {
            adp = new Adapter();
            cmd = new SqlCommand();
            mobileSMS = new MobileSMS();
        }


        /*Phone Setting CRUD Operation*/
        public string gsmConnection(string comPort, string baudRate)
        {
            return mobileSMS.set(comPort, baudRate);

        }
        public List<string> smsModemDetail()
        {
            return mobileSMS.modemDetail();

        }
        public bool checkGSMConnected()
        {
            return mobileSMS.checkGSMConected();

        }
        public bool disconnectProt()
        {
           return mobileSMS.disconnectPort();
            

        }

        

        /*Group SMS CRUD Operation*/

        public string groupSMSNameInsert(string _group)
        {

            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SmsGroupName", _group);

            if (adp.Select(cmd))
            {
                return _group + " Group Already Exist";
            }
            else
            {
                cmd = new SqlCommand("GroupSMSSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SmsGroupName", _group);

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

        public string groupSMSNameUpdate(int GroupId, string _group)
        {

            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@SmsGroupName", _group);
            cmd.Parameters.AddWithValue("@SmsGroupId", GroupId);
            if (adp.insert(cmd))
            {
                return _group + " Group Update Successfully";
            }
            else
            {

                return _group + " Group does not Update";
            }

        }
        public string groupSMSNameDelete(string _group)
        {
            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SmsGroupName", _group);

            if (adp.SelectRecordID(cmd) > 0)
            {

                cmd = new SqlCommand("GroupSMSSp");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@SmsGroupName", _group);

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
        public DataTable groupSMSDataGridView()
        {
            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }
        public List<string> groupSMSNameCombobox()
        {
            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "GroupSMSName");
            return adp.showCombobox(cmd);

        }

        public int groupSMSNameIdSelect(string _group)
        {
            cmd = new SqlCommand("GroupSMSSp");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SmsGroupName", _group);
            return adp.SelectRecordID(cmd);
        }
        //select student record by class name
        public DataTable groupSMSContacts(string className)
        {
            cmd = new SqlCommand("StudentRegiserationInfoSp");
            cmd.Parameters.AddWithValue("@Action", "StudentMobile");
            cmd.Parameters.AddWithValue("@Class", className);
            return adp.showDataGridView(cmd);

        }

        /*Group Contacts CRUD Operation*/
        public bool groupSMSContactsInsert(int GRNo, int SmsGroupId)
        {
                cmd = new SqlCommand("SMSStudentGroupContactSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@GRNo", GRNo);
                cmd.Parameters.AddWithValue("@SmsGroupId", SmsGroupId);
               return adp.insert(cmd);
                
        }

        /*Define SMS CRUD Operation*/
        public string defineSMSInsert(string title, string smsText)
        {

            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SMSTitle", title);

            if (adp.Select(cmd))
            {
                return title + " SMS Title Already Exist";
            }
            else
            {
                cmd = new SqlCommand("SMSDefineMessagesSP");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@SMSTitle", title);
                cmd.Parameters.AddWithValue("@Massege", smsText);

                if (adp.insert(cmd))
                {
                    return title + " SMS Title Insert Successfully";
                }
                else
                {

                    return title + " SMS Title does not Insert";
                }

            }

        }

        public DataTable defineSMSDataGridView()
        {
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECT");
            return adp.showDataGridView(cmd);

        }

        public string defineSMSTitlesDelete(string SMSTitle)
        {
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECTIDBYNAME");
            cmd.Parameters.AddWithValue("@SMSTitle", SMSTitle);

            if (adp.SelectRecordID(cmd) > 0)
            {

                cmd = new SqlCommand("SMSDefineMessagesSP");
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@SMSTitle", SMSTitle);

                if (adp.Delete(cmd))
                {
                    return SMSTitle + "  Delete Successfully";
                }
                else
                {

                    return SMSTitle + " Delete does not Insert";
                }


            }
            else
            {
                return SMSTitle + "  does not in database";

            }

        }

        public string defineSMSUpdate(int MessgId, string title, string smsText)
        {

            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@SMSTitle", title);
            cmd.Parameters.AddWithValue("@Massege", smsText);
            cmd.Parameters.AddWithValue("@MessgId", MessgId);

            if (adp.Update(cmd))
            {
                return title + " Update Successfully";
            }
            else
            {

                return title + "  does not Update";
            }

        }


        public List<string> defineSMSTitleCombobox()
        {
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SMSTitle");
            return adp.showCombobox(cmd);

        }

        public List<string> defineSMSTexSelect(string title)
        {
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECTMessg");
            cmd.Parameters.AddWithValue("@SMSTitle", title);
            return adp.showDataTextbox(cmd);


        }

        public int defineSMSSelectIdByTitle(string title)
        {
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECTMessgId");
            cmd.Parameters.AddWithValue("@SMSTitle", title);
            return adp.SelectRecordID(cmd);
            
        }
        /*Single SMS CRUD Operation*/
        public string singleSMSSend(string mobileNo, string messg)
        {
            string status = "";

            if (mobileSMS.checkGSMConected())
            {
                    if (mobileSMS.sendSMS(mobileNo, messg))
                    {
                        status = "M E S S A G E - S E N T Send Successfully!";

                    }
                    else
                    {
                        status = "SMS No Send!";
                    }
                
            }
            else
            {
                status = "GSM Device Not Connected!";

            }

            return status;
        }

        //public string sendToContactList(string smsTitle, string smsText , int GRNo)
        //{

        //    string messg = smsTitle + "\n" + smsText;
              
        //        cmd = new SqlCommand("SMSDefineMessagesSP");
        //        cmd.Parameters.AddWithValue("@Action", "SELECTMessg");
        //        cmd.Parameters.AddWithValue("@SMSTitle", smsTitle);
        //        int MessgId = adp.SelectRecordID(cmd);

        //        cmd = new SqlCommand("StudentRegiserationInfoSp");
        //        cmd.Parameters.AddWithValue("@Action", "SELECTFatherMobile");
        //        cmd.Parameters.AddWithValue("@GRNo", GRNo);
        //        string mobileNo = adp.SelectColunmValue(cmd);

        //        singleSMSSend(mobileNo, messg);

        //        cmd = new SqlCommand("SMSStudentSentboxSp");
        //        cmd.Parameters.AddWithValue("@Action", "INSERT");
        //        cmd.Parameters.AddWithValue("@StudentId", GRNo);
        //        cmd.Parameters.AddWithValue("@MessgId", MessgId);
        //        cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
        //        cmd.Parameters.AddWithValue("@Status", "Send");

        //        if (adp.insert(cmd))
        //        {
        //            return " SMS Send Successfully";
        //        }
        //        else
        //        {

        //            return " SMS does not Send";
        //        }
        //}

        public string sendToContactList(string smsTitle, string smsText, List<string> contactList)
        {

            string status = "";
            List<string> groudContact = new List<string>();
            string messg = smsTitle + "\n" + smsText;

            if (mobileSMS.checkGSMConected())
            {
                try
                {
                    cmd = new SqlCommand("SMSDefineMessagesSP");
                    cmd.Parameters.AddWithValue("@Action", "SELECTMessgId");
                    cmd.Parameters.AddWithValue("@SMSTitle", smsTitle);
                    int MessgId = adp.SelectRecordID(cmd);

                    foreach (string item in contactList)
                    {
                        cmd = new SqlCommand("GroupSMSSp");
                        cmd.Parameters.AddWithValue("@Action", "GroupContact");
                        cmd.Parameters.AddWithValue("@SmsGroupName", item);
                        foreach (string contacts in adp.showCombobox(cmd))
                        {
                            groudContact.Add(contacts);
                        }

                    }
                    foreach (string item in groudContact)
                    {
                        //mobileSms.sendSMS(item, messg);
                        cmd = new SqlCommand("StudentRegiserationInfoSp");
                        cmd.Parameters.AddWithValue("@Action", "SelectStudentMobile");
                        cmd.Parameters.AddWithValue("@StudentMobileNo", item);
                        int GRNo = adp.SelectRecordID(cmd);

                        cmd = new SqlCommand("SMSStudentSentboxSp");
                        cmd.Parameters.AddWithValue("@Action", "INSERT");
                        cmd.Parameters.AddWithValue("@GRNo", GRNo);
                        cmd.Parameters.AddWithValue("@MessgId", MessgId);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        // status += item;
                        if (mobileSMS.sendSMS(item, messg))
                        {
                            //status = "M E S S A G E - S E N T Send Successfully!";
                            cmd.Parameters.AddWithValue("@Status", "sent");
                        }
                        else
                        {
                            //    status = "SMS No Send!";
                            cmd.Parameters.AddWithValue("@Status", "unsent");
                        }

                        adp.insert(cmd);

                    }
                    status = "M E S S A G E - S E N T Send Successfully!";

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                status = "Check GSM Device Connected With Computer or Port!";

            }

            return status;

            /*check code
            cmd = new SqlCommand("SMSDefineMessagesSP");
            cmd.Parameters.AddWithValue("@Action", "SELECTMessgId");
            cmd.Parameters.AddWithValue("@SMSTitle", smsTitle);
            int MessgId = adp.SelectRecordID(cmd);

            foreach (string item in contactList)
            {
                cmd = new SqlCommand("GroupSMSSp");
                cmd.Parameters.AddWithValue("@Action", "GroupContact");
                cmd.Parameters.AddWithValue("@SmsGroupName", item);
                foreach (string contacts in adp.showCombobox(cmd))
                {
                    groudContact.Add(contacts);
                }

            }
            foreach (string item in groudContact)
            {
                cmd = new SqlCommand("StudentRegiserationInfoSp");
                cmd.Parameters.AddWithValue("@Action", "SelectStudentMobile");
                cmd.Parameters.AddWithValue("@StudentMobileNo", item);
                int GRNo = adp.SelectRecordID(cmd);

                cmd = new SqlCommand("SMSStudentSentboxSp");
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@GRNo", GRNo);
                cmd.Parameters.AddWithValue("@MessgId", MessgId);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "unsent");
                adp.insert(cmd);

            }
            status = "M E S S A G E - S E N T Send Successfully!";
            return status;*/
        }

        /*student sent box crud operation*/
        public DataTable selectAllStudentSentSMSDataGridView()
        {
            cmd = new SqlCommand("SMSStudentSentboxSp");
            cmd.Parameters.AddWithValue("@Action", "sent");
            cmd.Parameters.AddWithValue("@Status", "sent");

            return adp.showDataGridView(cmd);

        }
        public DataTable selectAllStudentUnsentSMSDataGridView()
        {
            cmd = new SqlCommand("SMSStudentSentboxSp");
            cmd.Parameters.AddWithValue("@Action", "unsent");
            cmd.Parameters.AddWithValue("@Status", "unsent");
            return adp.showDataGridView(cmd);

        }
        
        public bool deleteAllStudentSMSDataGridView()
        {
            cmd = new SqlCommand("SMSStudentSentboxSp");
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            return adp.Delete(cmd);

        }

        public string re()
        {

            return mobileSMS.MessageReceived();
        }

    }
    }




    

