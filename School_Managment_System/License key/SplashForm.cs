using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class SplashForm : MetroFramework.Forms.MetroForm
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        LicenseKeyGenerate lkg = new LicenseKeyGenerate();

        public int timeLeft { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else
            {
                timer1.Stop();
               
               
                if (!String.IsNullOrEmpty(Properties.Settings.Default.SerialKey))
                {
                    if (Properties.Settings.Default.SerialKey.Equals(lkg.Hash("SMS" + lkg.getPrivateKey() + lkg.getCpuId() + lkg.getHdId() + lkg.GetMacAddress())))
                    {
                        LoginForm lf = new LoginForm();
                        this.Hide();
                        lf.WindowState = FormWindowState.Normal;
                        lf.Show();

                    }
                    else
                    {
                        LicenseForm s = new LicenseForm();
                        this.Hide();
                        s.WindowState = FormWindowState.Normal;
                        s.Show();
                       


                    }
                }
                else
                {
                    LicenseForm Lf = new LicenseForm();
                    this.Hide();
                    Lf.Show();
                    
                }
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timeLeft = 20;
            timer1.Start();
        }
    }
}
