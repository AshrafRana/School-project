namespace School_Managment_System
{
    partial class ClassFee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.classFeeGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classNameComb = new MetroFramework.Controls.MetroComboBox();
            this.feeTypeComb = new MetroFramework.Controls.MetroComboBox();
            this.feeAmount = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feeUpdateBtn = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classFeeGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Upate);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(364, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 172);
            this.panel2.TabIndex = 19;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(11, 130);
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
            this.Delete.Location = new System.Drawing.Point(14, 92);
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
            this.Upate.Location = new System.Drawing.Point(14, 54);
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
            this.Save.Location = new System.Drawing.Point(14, 16);
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
            // classFeeGridView
            // 
            this.classFeeGridView.AllowUserToAddRows = false;
            this.classFeeGridView.AllowUserToDeleteRows = false;
            this.classFeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classFeeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.classFeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classFeeGridView.Location = new System.Drawing.Point(10, 260);
            this.classFeeGridView.Name = "classFeeGridView";
            this.classFeeGridView.ReadOnly = true;
            this.classFeeGridView.Size = new System.Drawing.Size(348, 172);
            this.classFeeGridView.TabIndex = 18;
            this.classFeeGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classFeeGridView_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feeUpdateBtn);
            this.groupBox1.Controls.Add(this.classNameComb);
            this.groupBox1.Controls.Add(this.feeTypeComb);
            this.groupBox1.Controls.Add(this.feeAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 155);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // classNameComb
            // 
            this.classNameComb.FormattingEnabled = true;
            this.classNameComb.ItemHeight = 23;
            this.classNameComb.Location = new System.Drawing.Point(128, 33);
            this.classNameComb.Name = "classNameComb";
            this.classNameComb.Size = new System.Drawing.Size(289, 29);
            this.classNameComb.TabIndex = 16;
            this.classNameComb.UseSelectable = true;
            // 
            // feeTypeComb
            // 
            this.feeTypeComb.FormattingEnabled = true;
            this.feeTypeComb.ItemHeight = 23;
            this.feeTypeComb.Location = new System.Drawing.Point(128, 74);
            this.feeTypeComb.Name = "feeTypeComb";
            this.feeTypeComb.Size = new System.Drawing.Size(289, 29);
            this.feeTypeComb.TabIndex = 15;
            this.feeTypeComb.UseSelectable = true;
            // 
            // feeAmount
            // 
            // 
            // 
            // 
            this.feeAmount.CustomButton.Image = null;
            this.feeAmount.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.feeAmount.CustomButton.Name = "";
            this.feeAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.feeAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.feeAmount.CustomButton.TabIndex = 1;
            this.feeAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.feeAmount.CustomButton.UseSelectable = true;
            this.feeAmount.Lines = new string[0];
            this.feeAmount.Location = new System.Drawing.Point(128, 109);
            this.feeAmount.MaxLength = 32767;
            this.feeAmount.Name = "feeAmount";
            this.feeAmount.PasswordChar = '\0';
            this.feeAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.feeAmount.SelectedText = "";
            this.feeAmount.SelectionLength = 0;
            this.feeAmount.SelectionStart = 0;
            this.feeAmount.ShortcutsEnabled = true;
            this.feeAmount.ShowButton = true;
            this.feeAmount.Size = new System.Drawing.Size(169, 23);
            this.feeAmount.TabIndex = 14;
            this.feeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.feeAmount.UseSelectable = true;
            this.feeAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.feeAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.feeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fee_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Class";
            // 
            // feeUpdateBtn
            // 
            this.feeUpdateBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.feeUpdateBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.feeUpdateBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.feeUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.feeUpdateBtn.Location = new System.Drawing.Point(303, 109);
            this.feeUpdateBtn.Name = "feeUpdateBtn";
            this.feeUpdateBtn.Size = new System.Drawing.Size(114, 23);
            this.feeUpdateBtn.TabIndex = 17;
            this.feeUpdateBtn.Text = "Fee Update";
            this.feeUpdateBtn.UseCustomBackColor = true;
            this.feeUpdateBtn.UseCustomForeColor = true;
            this.feeUpdateBtn.UseSelectable = true;
            this.feeUpdateBtn.UseStyleColors = true;
            this.feeUpdateBtn.Click += new System.EventHandler(this.feeUpdateBtn_Click);
            // 
            // ClassFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.classFeeGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ClassFee";
            this.Resizable = false;
            this.Text = "Class Fee";
            this.Load += new System.EventHandler(this.ClassFee_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classFeeGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton Exit;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private System.Windows.Forms.DataGridView classFeeGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox classNameComb;
        private MetroFramework.Controls.MetroComboBox feeTypeComb;
        private MetroFramework.Controls.MetroTextBox feeAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton feeUpdateBtn;
    }
}