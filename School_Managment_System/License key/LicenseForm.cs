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
    public partial class LicenseForm : MetroFramework.Forms.MetroForm
    {
        LicenseKeyGenerate lkg = new LicenseKeyGenerate();

        public LicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                string getKey = textBox1.Text;
               
                if (getKey.Equals(lkg.Hash("SMS"+lkg.getPrivateKey() + lkg.getCpuId() + lkg.getHdId() + lkg.GetMacAddress())))
                {
                    Properties.Settings.Default.SerialKey = textBox1.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Successfully Activated.");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Invalid Serial Key.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Serial Key.");
            }
        }

       
       
    }
}
