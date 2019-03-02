using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace School_Managment_System
{
    public partial class StudentDetailReportFrm : Form
    {
        public StudentDetailReportFrm()
        {
            InitializeComponent();
        }

        StudentController sc = new StudentController();
        MasterEnteriesController mec = new MasterEnteriesController();
        //int width = 100, height = 100;
        private void StudentDetailReportFrm_Load(object sender, EventArgs e)
        {

            List<string> list = mec.shoolInfoReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            
            ReportParameter rp1 = new ReportParameter("SchoolName", list[0]);
            ReportParameter rp2 = new ReportParameter("SchoolAddress", list[1]);
            string pic = list[2];
            
            string filePath = Application.StartupPath + "\\Images\\" + pic;
            ReportParameter rp3 = new ReportParameter("im",new Uri(filePath).AbsoluteUri);


            //using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //{

            //    Image originalImage = Image.FromStream(stream);

            //    Bitmap result = new Bitmap(width, height);

            //    using (Graphics g = Graphics.FromImage(result))
            //    {
            //        // Draw the originam image in a new size.
            //        g.DrawImage(originalImage, 0, 0, width, height);
            //    }
            //    ReportParameter rp3 = new ReportParameter("Image", result);

            //    stream.Dispose();
            //}




            reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2,rp3 });
            
            ReportDataSource rds2 = new ReportDataSource("StudentDataSet", sc.studentInfoReport());
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
