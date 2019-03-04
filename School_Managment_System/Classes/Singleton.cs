using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace School_Managment_System
{
    class Singleton
    {
        private static SqlConnection connection;
        private Singleton()
        { }

        public static SqlConnection getConnection()
        {
            if (connection == null)
            {

                //"Data Source=.\SQLEXPRESS;AttachDbFilename=filepath\bin\Debug\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"


              //  connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\sms.mdf;Integrated Security=True;");

                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sms.mdf;Integrated Security=True;");

                //connection = new SqlConnection("Data Source=DESKTOP-PTH0QEP\\SQLEXPRESS; Initial Catalog=sms;Integrated Security=True");
                
                return connection;

            }
            else
            {
                return connection;

            }
        }

    }
}
