namespace School_Managment_System
{
    partial class ClassSessionSubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectNameCombo = new MetroFramework.Controls.MetroComboBox();
            this.classNameComb = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.classSubjectGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjectNameCombo);
            this.groupBox1.Controls.Add(this.classNameComb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // subjectNameCombo
            // 
            this.subjectNameCombo.FormattingEnabled = true;
            this.subjectNameCombo.ItemHeight = 23;
            this.subjectNameCombo.Location = new System.Drawing.Point(126, 78);
            this.subjectNameCombo.Name = "subjectNameCombo";
            this.subjectNameCombo.PromptText = "Enter Section Name";
            this.subjectNameCombo.Size = new System.Drawing.Size(350, 29);
            this.subjectNameCombo.TabIndex = 8;
            this.subjectNameCombo.UseSelectable = true;
            // 
            // classNameComb
            // 
            this.classNameComb.FormattingEnabled = true;
            this.classNameComb.ItemHeight = 23;
            this.classNameComb.Location = new System.Drawing.Point(126, 37);
            this.classNameComb.Name = "classNameComb";
            this.classNameComb.PromptText = "Enter Class Name";
            this.classNameComb.Size = new System.Drawing.Size(350, 29);
            this.classNameComb.TabIndex = 7;
            this.classNameComb.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Upate);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(412, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 168);
            this.panel2.TabIndex = 19;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(13, 126);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 32);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseCustomForeColor = true;
            this.Exit.UseMnemonic = false;
            this.Exit.UseSelectable = true;
            this.Exit.UseStyleColors = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Delete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete.Location = new System.Drawing.Point(13, 88);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 32);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseMnemonic = false;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Upate
            // 
            this.Upate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Upate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Upate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Upate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Upate.Location = new System.Drawing.Point(13, 50);
            this.Upate.Name = "Upate";
            this.Upate.Size = new System.Drawing.Size(94, 32);
            this.Upate.TabIndex = 15;
            this.Upate.Text = "Update";
            this.Upate.UseCustomBackColor = true;
            this.Upate.UseCustomForeColor = true;
            this.Upate.UseSelectable = true;
            this.Upate.UseStyleColors = true;
            this.Upate.Click += new System.EventHandler(this.Upate_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(13, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 32);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // classSubjectGridView
            // 
            this.classSubjectGridView.AllowUserToAddRows = false;
            this.classSubjectGridView.AllowUserToDeleteRows = false;
            this.classSubjectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classSubjectGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.classSubjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classSubjectGridView.Location = new System.Drawing.Point(23, 214);
            this.classSubjectGridView.Name = "classSubjectGridView";
            this.classSubjectGridView.ReadOnly = true;
            this.classSubjectGridView.Size = new System.Drawing.Size(383, 160);
            this.classSubjectGridView.TabIndex = 18;
            this.classSubjectGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classSubjectGridView_RowHeaderMouseClick);
            // 
            // ClassSessionSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.classSubjectGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ClassSessionSubject";
            this.Resizable = false;
            this.Text = "Class Subject";
            this.Load += new System.EventHandler(this.ClassSessionSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox subjectNameCombo;
        private MetroFramework.Controls.MetroComboBox classNameComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton Exit;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private System.Windows.Forms.DataGridView classSubjectGridView;
    }
}