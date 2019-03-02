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
    public partial class StudnetSentBox : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();
        public StudnetSentBox()
        {
            InitializeComponent();
        }

        private void StudnetSentBox_Load(object sender, EventArgs e)
        {
            studentSentboxdataGridview.DataSource = mobileSmsController.selectAllStudentSentSMSDataGridView();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            
            if (mobileSmsController.deleteAllStudentSMSDataGridView())
            {
                MessageBox.Show("Delete All Records Successfully!");
                
            }
            else {
                MessageBox.Show("Not Delete All Records");
            }

        }
    }
}
