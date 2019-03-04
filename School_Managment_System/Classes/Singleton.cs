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

                
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\sms.mdf;Integrated Security=True;");
                
                return connection;

            }
            else
            {
                return connection;

            }
        }

    }
}
