﻿namespace School_Managment_System
{
    partial class SMS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.inbox = new System.Windows.Forms.PictureBox();
            this.closeform = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unsentbox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sentbox = new System.Windows.Forms.PictureBox();
            this.outbox = new System.Windows.Forms.PictureBox();
            this.composesms = new System.Windows.Forms.PictureBox();
            this.groupContacts = new System.Windows.Forms.PictureBox();
            this.createGroup = new System.Windows.Forms.PictureBox();
            this.gsmsetting = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unsentbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.composesms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsmsetting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.inbox);
            this.panel1.Controls.Add(this.closeform);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.unsentbox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sentbox);
            this.panel1.Controls.Add(this.outbox);
            this.panel1.Controls.Add(this.composesms);
            this.panel1.Controls.Add(this.groupContacts);
            this.panel1.Controls.Add(this.createGroup);
            this.panel1.Controls.Add(this.gsmsetting);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 79);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Inbox";
            // 
            // inbox
            // 
            this.inbox.BackgroundImage = global::School_Managment_System.Properties.Resources.Crystal_Project_Folder_inbox;
            this.inbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inbox.Location = new System.Drawing.Point(233, 12);
            this.inbox.Name = "inbox";
            this.inbox.Size = new System.Drawing.Size(51, 42);
            this.inbox.TabIndex = 19;
            this.inbox.TabStop = false;
            this.inbox.Click += new System.EventHandler(this.inbox_Click);
            // 
            // closeform
            // 
            this.closeform.BackgroundImage = global::School_Managment_System.Properties.Resources.logout1;
            this.closeform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeform.Location = new System.Drawing.Point(600, 13);
            this.closeform.Name = "closeform";
            this.closeform.Size = new System.Drawing.Size(51, 42);
            this.closeform.TabIndex = 17;
            this.closeform.TabStop = false;
            this.closeform.Click += new System.EventHandler(this.closeform_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Exit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Un-Sent";
            // 
            // unsentbox
            // 
            this.unsentbox.BackgroundImage = global::School_Managment_System.Properties.Resources.Folder_Open_icon;
            this.unsentbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unsentbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unsentbox.Location = new System.Drawing.Point(528, 12);
            this.unsentbox.Name = "unsentbox";
            this.unsentbox.Size = new System.Drawing.Size(57, 43);
            this.unsentbox.TabIndex = 14;
            this.unsentbox.TabStop = false;
            this.unsentbox.Click += new System.EventHandler(this.unsentbox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "&Sent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "&Outbox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "&Compose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "&Groups";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Phone";
            // 
            // sentbox
            // 
            this.sentbox.BackgroundImage = global::School_Managment_System.Properties.Resources.pst;
            this.sentbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sentbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentbox.Location = new System.Drawing.Point(453, 12);
            this.sentbox.Name = "sentbox";
            this.sentbox.Size = new System.Drawing.Size(58, 43);
            this.sentbox.TabIndex = 6;
            this.sentbox.TabStop = false;
            this.sentbox.Click += new System.EventHandler(this.sentbox_Click);
            // 
            // outbox
            // 
            this.outbox.BackgroundImage = global::School_Managment_System.Properties.Resources._11950008841140226759folder_outbox_svg_med;
            this.outbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outbox.Location = new System.Drawing.Point(380, 12);
            this.outbox.Name = "outbox";
            this.outbox.Size = new System.Drawing.Size(51, 42);
            this.outbox.TabIndex = 5;
            this.outbox.TabStop = false;
            this.outbox.Click += new System.EventHandler(this.outbox_Click);
            // 
            // composesms
            // 
            this.composesms.BackgroundImage = global::School_Managment_System.Properties.Resources.email_compose;
            this.composesms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.composesms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.composesms.Location = new System.Drawing.Point(300, 12);
            this.composesms.Name = "composesms";
            this.composesms.Size = new System.Drawing.Size(58, 43);
            this.composesms.TabIndex = 4;
            this.composesms.TabStop = false;
            this.composesms.Click += new System.EventHandler(this.composesms_Click);
            // 
            // groupContacts
            // 
            this.groupContacts.BackgroundImage = global::School_Managment_System.Properties.Resources.matt_icons_contact_add;
            this.groupContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupContacts.Location = new System.Drawing.Point(159, 11);
            this.groupContacts.Name = "groupContacts";
            this.groupContacts.Size = new System.Drawing.Size(55, 43);
            this.groupContacts.TabIndex = 2;
            this.groupContacts.TabStop = false;
            this.groupContacts.Click += new System.EventHandler(this.groupContacts_Click);
            // 
            // createGroup
            // 
            this.createGroup.BackgroundImage = global::School_Managment_System.Properties.Resources._1600;
            this.createGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createGroup.Location = new System.Drawing.Point(86, 11);
            this.createGroup.Name = "createGroup";
            this.createGroup.Size = new System.Drawing.Size(57, 43);
            this.createGroup.TabIndex = 1;
            this.createGroup.TabStop = false;
            this.createGroup.Click += new System.EventHandler(this.createGroup_Click);
            // 
            // gsmsetting
            // 
            this.gsmsetting.BackgroundImage = global::School_Managment_System.Properties.Resources._817610c21;
            this.gsmsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gsmsetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gsmsetting.Location = new System.Drawing.Point(11, 11);
            this.gsmsetting.Name = "gsmsetting";
            this.gsmsetting.Size = new System.Drawing.Size(60, 43);
            this.gsmsetting.TabIndex = 0;
            this.gsmsetting.TabStop = false;
            this.gsmsetting.Click += new System.EventHandler(this.gsmsetting_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::School_Managment_System.Properties.Resources.sms2;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 144);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(829, 278);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SMS";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "SMS Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SMS_FormClosed);
            this.Load += new System.EventHandler(this.SMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unsentbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.composesms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsmsetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gsmsetting;
        private System.Windows.Forms.PictureBox createGroup;
        private System.Windows.Forms.PictureBox groupContacts;
        private System.Windows.Forms.PictureBox composesms;
        private System.Windows.Forms.PictureBox outbox;
        private System.Windows.Forms.PictureBox sentbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox unsentbox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox closeform;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox inbox;
    }
}