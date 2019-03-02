namespace School_Managment_System
{
    partial class ClassSectionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sectionNameCombo = new MetroFramework.Controls.MetroComboBox();
            this.classNameComb = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.classSectiondataGrid = new System.Windows.Forms.DataGridView();
            this.maxStudentText = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateMaxStudentBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classSectiondataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Section Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateMaxStudentBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maxStudentText);
            this.groupBox1.Controls.Add(this.sectionNameCombo);
            this.groupBox1.Controls.Add(this.classNameComb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // sectionNameCombo
            // 
            this.sectionNameCombo.FormattingEnabled = true;
            this.sectionNameCombo.ItemHeight = 23;
            this.sectionNameCombo.Location = new System.Drawing.Point(126, 78);
            this.sectionNameCombo.Name = "sectionNameCombo";
            this.sectionNameCombo.PromptText = "Enter Section Name";
            this.sectionNameCombo.Size = new System.Drawing.Size(350, 29);
            this.sectionNameCombo.TabIndex = 8;
            this.sectionNameCombo.UseSelectable = true;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(402, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 171);
            this.panel2.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(15, 127);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 32);
            this.Exit.TabIndex = 15;
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
            this.Delete.Location = new System.Drawing.Point(15, 89);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 32);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseMnemonic = false;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.updateBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateBtn.Location = new System.Drawing.Point(15, 51);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 32);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseCustomBackColor = true;
            this.updateBtn.UseCustomForeColor = true;
            this.updateBtn.UseSelectable = true;
            this.updateBtn.UseStyleColors = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(15, 13);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 32);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // classSectiondataGrid
            // 
            this.classSectiondataGrid.AllowUserToAddRows = false;
            this.classSectiondataGrid.AllowUserToDeleteRows = false;
            this.classSectiondataGrid.AllowUserToResizeColumns = false;
            this.classSectiondataGrid.AllowUserToResizeRows = false;
            this.classSectiondataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classSectiondataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.classSectiondataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classSectiondataGrid.Location = new System.Drawing.Point(13, 234);
            this.classSectiondataGrid.Name = "classSectiondataGrid";
            this.classSectiondataGrid.ReadOnly = true;
            this.classSectiondataGrid.Size = new System.Drawing.Size(383, 171);
            this.classSectiondataGrid.TabIndex = 11;
            this.classSectiondataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classSectiondataGrid_RowHeaderMouseClick);
            // 
            // maxStudentText
            // 
            // 
            // 
            // 
            this.maxStudentText.CustomButton.Image = null;
            this.maxStudentText.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.maxStudentText.CustomButton.Name = "";
            this.maxStudentText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maxStudentText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maxStudentText.CustomButton.TabIndex = 1;
            this.maxStudentText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maxStudentText.CustomButton.UseSelectable = true;
            this.maxStudentText.CustomButton.Visible = false;
            this.maxStudentText.Lines = new string[0];
            this.maxStudentText.Location = new System.Drawing.Point(126, 113);
            this.maxStudentText.MaxLength = 32767;
            this.maxStudentText.Name = "maxStudentText";
            this.maxStudentText.PasswordChar = '\0';
            this.maxStudentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxStudentText.SelectedText = "";
            this.maxStudentText.SelectionLength = 0;
            this.maxStudentText.SelectionStart = 0;
            this.maxStudentText.ShortcutsEnabled = true;
            this.maxStudentText.Size = new System.Drawing.Size(233, 23);
            this.maxStudentText.TabIndex = 9;
            this.maxStudentText.UseSelectable = true;
            this.maxStudentText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maxStudentText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.maxStudentText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxStudentText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Max Students";
            // 
            // updateMaxStudentBtn
            // 
            this.updateMaxStudentBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateMaxStudentBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.updateMaxStudentBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.updateMaxStudentBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateMaxStudentBtn.Location = new System.Drawing.Point(365, 113);
            this.updateMaxStudentBtn.Name = "updateMaxStudentBtn";
            this.updateMaxStudentBtn.Size = new System.Drawing.Size(111, 23);
            this.updateMaxStudentBtn.TabIndex = 16;
            this.updateMaxStudentBtn.Text = "Extends";
            this.updateMaxStudentBtn.UseCustomBackColor = true;
            this.updateMaxStudentBtn.UseCustomForeColor = true;
            this.updateMaxStudentBtn.UseSelectable = true;
            this.updateMaxStudentBtn.UseStyleColors = true;
            this.updateMaxStudentBtn.Click += new System.EventHandler(this.updateMaxStudentBtn_Click);
            // 
            // ClassSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.classSectiondataGrid);
            this.MaximizeBox = false;
            this.Name = "ClassSectionForm";
            this.Resizable = false;
            this.Text = "Class Sections";
            this.Load += new System.EventHandler(this.ClassSectionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classSectiondataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView classSectiondataGrid;
        private MetroFramework.Controls.MetroComboBox sectionNameCombo;
        private MetroFramework.Controls.MetroComboBox classNameComb;
        private MetroFramework.Controls.MetroButton Delete;
      //  private MetroFramework.Controls.MetroButton Update;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroButton updateBtn;
        private MetroFramework.Controls.MetroButton Exit;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox maxStudentText;
        private MetroFramework.Controls.MetroButton updateMaxStudentBtn;
    }
}