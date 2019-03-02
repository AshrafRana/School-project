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
    public partial class StudentUnsentBox : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();

        public StudentUnsentBox()
        {
            InitializeComponent();
        }

        private void studentSentboxdataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentUnsentBox_Load(object sender, EventArgs e)
        {
            studentUnsentboxdataGridview.DataSource = mobileSmsController.selectAllStudentUnsentSMSDataGridView();
            MessageBox.Show(mobileSmsController.re());
        }

        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteUnsentSMS_Click(object sender, EventArgs e)
        {

        }

        private void resend_Click(object sender, EventArgs e)
        {

        }
    }
}
