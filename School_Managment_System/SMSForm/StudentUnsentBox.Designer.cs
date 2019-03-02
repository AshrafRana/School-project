namespace School_Managment_System
{
    partial class StudentUnsentBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.studentUnsentboxdataGridview = new System.Windows.Forms.DataGridView();
            this.deleteUnsentSMS = new MetroFramework.Controls.MetroButton();
            this.resend = new MetroFramework.Controls.MetroButton();
            this.exit = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentUnsentboxdataGridview)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Location = new System.Drawing.Point(407, 6);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(355, 51);
            this.metroTabControl1.TabIndex = 104;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl2.Location = new System.Drawing.Point(8, 63);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(634, 393);
            this.metroTabControl2.TabIndex = 105;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AccessibleName = "student";
            this.metroTabPage1.Controls.Add(this.panel4);
            this.metroTabPage1.Controls.Add(this.studentUnsentboxdataGridview);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(626, 351);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Students SMS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AccessibleName = "staff";
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(626, 351);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Staff SMS";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // studentUnsentboxdataGridview
            // 
            this.studentUnsentboxdataGridview.AllowUserToAddRows = false;
            this.studentUnsentboxdataGridview.AllowUserToDeleteRows = false;
            this.studentUnsentboxdataGridview.AllowUserToResizeColumns = false;
            this.studentUnsentboxdataGridview.AllowUserToResizeRows = false;
            this.studentUnsentboxdataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentUnsentboxdataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentUnsentboxdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentUnsentboxdataGridview.Location = new System.Drawing.Point(3, 3);
            this.studentUnsentboxdataGridview.Name = "studentUnsentboxdataGridview";
            this.studentUnsentboxdataGridview.ReadOnly = true;
            this.studentUnsentboxdataGridview.Size = new System.Drawing.Size(623, 273);
            this.studentUnsentboxdataGridview.TabIndex = 102;
            this.studentUnsentboxdataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentSentboxdataGridview_CellContentClick);
            // 
            // deleteUnsentSMS
            // 
            this.deleteUnsentSMS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteUnsentSMS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.deleteUnsentSMS.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.deleteUnsentSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteUnsentSMS.Location = new System.Drawing.Point(251, 13);
            this.deleteUnsentSMS.Name = "deleteUnsentSMS";
            this.deleteUnsentSMS.Size = new System.Drawing.Size(112, 32);
            this.deleteUnsentSMS.TabIndex = 14;
            this.deleteUnsentSMS.Text = "Delete All";
            this.deleteUnsentSMS.UseCustomBackColor = true;
            this.deleteUnsentSMS.UseCustomForeColor = true;
            this.deleteUnsentSMS.UseMnemonic = false;
            this.deleteUnsentSMS.UseSelectable = true;
            this.deleteUnsentSMS.UseStyleColors = true;
            this.deleteUnsentSMS.Click += new System.EventHandler(this.deleteUnsentSMS_Click);
            // 
            // resend
            // 
            this.resend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.resend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resend.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.resend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resend.Location = new System.Drawing.Point(117, 13);
            this.resend.Name = "resend";
            this.resend.Size = new System.Drawing.Size(112, 32);
            this.resend.TabIndex = 16;
            this.resend.Text = "Re-Send";
            this.resend.UseCustomBackColor = true;
            this.resend.UseCustomForeColor = true;
            this.resend.UseSelectable = true;
            this.resend.UseStyleColors = true;
            this.resend.Click += new System.EventHandler(this.resend_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(383, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 32);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseCustomBackColor = true;
            this.exit.UseCustomForeColor = true;
            this.exit.UseMnemonic = false;
            this.exit.UseSelectable = true;
            this.exit.UseStyleColors = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Controls.Add(this.resend);
            this.panel4.Controls.Add(this.deleteUnsentSMS);
            this.panel4.Location = new System.Drawing.Point(3, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 66);
            this.panel4.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Location = new System.Drawing.Point(2, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 66);
            this.panel1.TabIndex = 105;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.Location = new System.Drawing.Point(383, 13);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 32);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseMnemonic = false;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton2.Location = new System.Drawing.Point(117, 13);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 32);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Re-Send";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton3.Location = new System.Drawing.Point(251, 13);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 32);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Delete All";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseMnemonic = false;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(623, 273);
            this.dataGridView1.TabIndex = 104;
            // 
            // StudentUnsentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 462);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "StudentUnsentBox";
            this.Resizable = false;
            this.Text = "UNSENTBOX";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.StudentUnsentBox_Load);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentUnsentboxdataGridview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exit;
        private MetroFramework.Controls.MetroButton resend;
        private MetroFramework.Controls.MetroButton deleteUnsentSMS;
        private System.Windows.Forms.DataGridView studentUnsentboxdataGridview;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}