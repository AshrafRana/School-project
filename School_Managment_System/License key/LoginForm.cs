using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace School_Managment_System
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
      

        public LoginForm()
        {         
            InitializeComponent();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "admin" && password.Text == "admin")
            {
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid User Id or Password!");
            }


        }
    }
}
