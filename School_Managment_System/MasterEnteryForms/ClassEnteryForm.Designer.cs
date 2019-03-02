namespace School_Managment_System
{
    partial class ClassEntery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.className = new MetroFramework.Controls.MetroTextBox();
            this.departmentComb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.classMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMetroGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.className);
            this.groupBox1.Controls.Add(this.departmentComb);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // className
            // 
            // 
            // 
            // 
            this.className.CustomButton.Image = null;
            this.className.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.className.CustomButton.Name = "";
            this.className.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.className.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.className.CustomButton.TabIndex = 1;
            this.className.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.className.CustomButton.UseSelectable = true;
            this.className.Lines = new string[0];
            this.className.Location = new System.Drawing.Point(104, 39);
            this.className.MaxLength = 32767;
            this.className.Name = "className";
            this.className.PasswordChar = '\0';
            this.className.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.className.SelectedText = "";
            this.className.SelectionLength = 0;
            this.className.SelectionStart = 0;
            this.className.ShortcutsEnabled = true;
            this.className.ShowButton = true;
            this.className.ShowClearButton = true;
            this.className.Size = new System.Drawing.Size(350, 23);
            this.className.TabIndex = 7;
            this.className.UseSelectable = true;
            this.className.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.className.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.className.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.className_KeyPress);
            // 
            // departmentComb
            // 
            this.departmentComb.FormattingEnabled = true;
            this.departmentComb.ItemHeight = 23;
            this.departmentComb.Location = new System.Drawing.Point(104, 78);
            this.departmentComb.Name = "departmentComb";
            this.departmentComb.PromptText = "Select Departmensts";
            this.departmentComb.Size = new System.Drawing.Size(350, 29);
            this.departmentComb.TabIndex = 6;
            this.departmentComb.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 15);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Department";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(30, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 15);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Class Name";
            // 
            // classMetroGrid
            // 
            this.classMetroGrid.AllowUserToAddRows = false;
            this.classMetroGrid.AllowUserToResizeRows = false;
            this.classMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.classMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classMetroGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.classMetroGrid.EnableHeadersVisualStyles = false;
            this.classMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.classMetroGrid.GridColor = System.Drawing.Color.White;
            this.classMetroGrid.Location = new System.Drawing.Point(13, 225);
            this.classMetroGrid.Name = "classMetroGrid";
            this.classMetroGrid.ReadOnly = true;
            this.classMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.classMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.classMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classMetroGrid.Size = new System.Drawing.Size(383, 175);
            this.classMetroGrid.TabIndex = 8;
            this.classMetroGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classMetroGrid_RowHeaderMouseClick);
            // 
            // Upate
            // 
            this.Upate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Upate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Upate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Upate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Upate.Location = new System.Drawing.Point(17, 52);
            this.Upate.Name = "Upate";
            this.Upate.Size = new System.Drawing.Size(94, 32);
            this.Upate.TabIndex = 9;
            this.Upate.Text = "Update";
            this.Upate.UseCustomBackColor = true;
            this.Upate.UseCustomForeColor = true;
            this.Upate.UseSelectable = true;
            this.Upate.UseStyleColors = true;
            this.Upate.Click += new System.EventHandler(this.Upate_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Delete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete.Location = new System.Drawing.Point(18, 90);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 32);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseMnemonic = false;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(17, 14);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 32);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.Exit);
            this.metroPanel1.Controls.Add(this.Delete);
            this.metroPanel1.Controls.Add(this.Upate);
            this.metroPanel1.Controls.Add(this.Save);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(402, 225);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(124, 175);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(17, 128);
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
            // ClassEntery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(539, 418);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.classMetroGrid);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.Name = "ClassEntery";
            this.Resizable = false;
            this.Text = "Add New Class";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.ClassEntery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMetroGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox className;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox departmentComb;
        private MetroFramework.Controls.MetroGrid classMetroGrid;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Exit;
    }
}