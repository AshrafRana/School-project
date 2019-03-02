using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace School_Managment_System
{
    public partial class Session : MetroFramework.Forms.MetroForm
    {
        public Session()
        {
            InitializeComponent();
        }
        MasterEnteriesController mec = new MasterEnteriesController();
        int SessionId = 0;

        
        private void Session_Load(object sender, EventArgs e)
        {
            sessionGridView.DataSource = mec.SessionDataGridView();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (sessionName.Text != "")
            {

                MessageBox.Show(mec.sessionInsert(sessionName.Text.Trim()));
                mec.SessionDataGridView().Clear();
                sessionGridView.DataSource = mec.SessionDataGridView();
                sessionName.Text = null;
            }
            else
            {
                MessageBox.Show("Filed should not Empty");

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (sessionName.Text != "" && SessionId > 0)
            {

                MessageBox.Show(mec.sessionUpdate(SessionId, sessionName.Text.Trim()));
                mec.SessionDataGridView().Clear();
                sessionGridView.DataSource = mec.SessionDataGridView();
                SessionId = 0;
                sessionName.Text = null;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (sessionName.Text != "" && SessionId > 0)
            {

                MessageBox.Show(mec.sessionDelete(sessionName.Text.Trim()));
                mec.SessionDataGridView().Clear();
                sessionGridView.DataSource = mec.SessionDataGridView();
                sessionName.Text = null;
                SessionId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void sessionGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sessionGridView.Rows[e.RowIndex];
                sessionName.Text = row.Cells["SessionName"].Value.ToString();
                SessionId = Convert.ToInt32(row.Cells["SessionId"].Value.ToString());

            }
        }
        
        private void sessionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
