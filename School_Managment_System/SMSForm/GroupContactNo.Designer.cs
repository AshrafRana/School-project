namespace School_Managment_System
{
    partial class GroupContactNo
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.classNameComb = new MetroFramework.Controls.MetroComboBox();
            this.ClearContactList = new MetroFramework.Controls.MetroButton();
            this.contactAddList = new MetroFramework.Controls.MetroButton();
            this.groupContactsdataGridview = new System.Windows.Forms.DataGridView();
            this.listContact = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupContactsdataGridview)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(157, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 87;
            this.metroLabel2.Text = "Class Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(17, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 85;
            this.metroLabel1.Text = "Group Name";
            // 
            // groupCombo
            // 
            this.groupCombo.FormattingEnabled = true;
            this.groupCombo.ItemHeight = 23;
            this.groupCombo.Location = new System.Drawing.Point(17, 85);
            this.groupCombo.Name = "groupCombo";
            this.groupCombo.PromptText = "Select Group";
            this.groupCombo.Size = new System.Drawing.Size(134, 29);
            this.groupCombo.TabIndex = 84;
            this.groupCombo.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(17, 119);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 89;
            this.metroLabel3.Text = "Contact List";
            // 
            // classNameComb
            // 
            this.classNameComb.FormattingEnabled = true;
            this.classNameComb.ItemHeight = 23;
            this.classNameComb.Location = new System.Drawing.Point(157, 85);
            this.classNameComb.Name = "classNameComb";
            this.classNameComb.PromptText = "Select Class";
            this.classNameComb.Size = new System.Drawing.Size(189, 29);
            this.classNameComb.TabIndex = 91;
            this.classNameComb.UseSelectable = true;
            // 
            // ClearContactList
            // 
            this.ClearContactList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClearContactList.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ClearContactList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ClearContactList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearContactList.Location = new System.Drawing.Point(468, 85);
            this.ClearContactList.Name = "ClearContactList";
            this.ClearContactList.Size = new System.Drawing.Size(95, 29);
            this.ClearContactList.TabIndex = 93;
            this.ClearContactList.Text = "ClearList";
            this.ClearContactList.UseCustomBackColor = true;
            this.ClearContactList.UseCustomForeColor = true;
            this.ClearContactList.UseSelectable = true;
            this.ClearContactList.UseStyleColors = true;
            this.ClearContactList.Click += new System.EventHandler(this.ClearContactList_Click);
            // 
            // contactAddList
            // 
            this.contactAddList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.contactAddList.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.contactAddList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.contactAddList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contactAddList.Location = new System.Drawing.Point(352, 85);
            this.contactAddList.Name = "contactAddList";
            this.contactAddList.Size = new System.Drawing.Size(101, 29);
            this.contactAddList.TabIndex = 92;
            this.contactAddList.Text = "Add List";
            this.contactAddList.UseCustomBackColor = true;
            this.contactAddList.UseCustomForeColor = true;
            this.contactAddList.UseSelectable = true;
            this.contactAddList.UseStyleColors = true;
            this.contactAddList.Click += new System.EventHandler(this.contactAddList_Click);
            // 
            // groupContactsdataGridview
            // 
            this.groupContactsdataGridview.AllowUserToAddRows = false;
            this.groupContactsdataGridview.AllowUserToDeleteRows = false;
            this.groupContactsdataGridview.AllowUserToResizeColumns = false;
            this.groupContactsdataGridview.AllowUserToResizeRows = false;
            this.groupContactsdataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupContactsdataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupContactsdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupContactsdataGridview.Location = new System.Drawing.Point(157, 139);
            this.groupContactsdataGridview.Name = "groupContactsdataGridview";
            this.groupContactsdataGridview.ReadOnly = true;
            this.groupContactsdataGridview.Size = new System.Drawing.Size(410, 318);
            this.groupContactsdataGridview.TabIndex = 94;
            // 
            // listContact
            // 
            this.listContact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContact.FormattingEnabled = true;
            this.listContact.ItemHeight = 22;
            this.listContact.Location = new System.Drawing.Point(17, 141);
            this.listContact.Name = "listContact";
            this.listContact.Size = new System.Drawing.Size(134, 312);
            this.listContact.TabIndex = 98;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(157, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 99;
            this.metroLabel4.Text = "Contact Number";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Controls.Add(this.Save);
            this.panel4.Location = new System.Drawing.Point(17, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 66);
            this.panel4.TabIndex = 100;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(333, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseCustomBackColor = true;
            this.exitButton.UseCustomForeColor = true;
            this.exitButton.UseMnemonic = false;
            this.exitButton.UseSelectable = true;
            this.exitButton.UseStyleColors = true;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(191, 18);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 32);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GroupContactNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.listContact);
            this.Controls.Add(this.groupContactsdataGridview);
            this.Controls.Add(this.ClearContactList);
            this.Controls.Add(this.contactAddList);
            this.Controls.Add(this.classNameComb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupCombo);
            this.MaximizeBox = false;
            this.Name = "GroupContactNo";
            this.Resizable = false;
            this.Text = "Group Contact No";
            this.Load += new System.EventHandler(this.GroupContactNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupContactsdataGridview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox groupCombo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox classNameComb;
        private MetroFramework.Controls.MetroButton ClearContactList;
        private MetroFramework.Controls.MetroButton contactAddList;
        private System.Windows.Forms.DataGridView groupContactsdataGridview;
        private System.Windows.Forms.ListBox listContact;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton Save;
    }
}