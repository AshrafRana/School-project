namespace School_Managment_System
{
    partial class Designation
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
            this.designationGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.designationName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designationGridView)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(340, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 172);
            this.panel2.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(13, 130);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 32);
            this.Exit.TabIndex = 17;
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
            this.Delete.Location = new System.Drawing.Point(13, 92);
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
            this.Upate.Location = new System.Drawing.Point(13, 54);
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
            this.Save.Location = new System.Drawing.Point(13, 16);
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
            // designationGridView
            // 
            this.designationGridView.AllowUserToAddRows = false;
            this.designationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.designationGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.designationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designationGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.designationGridView.Location = new System.Drawing.Point(12, 165);
            this.designationGridView.Name = "designationGridView";
            this.designationGridView.ReadOnly = true;
            this.designationGridView.Size = new System.Drawing.Size(322, 172);
            this.designationGridView.TabIndex = 11;
            this.designationGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.designationGridView_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.designationName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // designationName
            // 
            // 
            // 
            // 
            this.designationName.CustomButton.Image = null;
            this.designationName.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.designationName.CustomButton.Name = "";
            this.designationName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.designationName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.designationName.CustomButton.TabIndex = 1;
            this.designationName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.designationName.CustomButton.UseSelectable = true;
            this.designationName.Lines = new string[0];
            this.designationName.Location = new System.Drawing.Point(137, 34);
            this.designationName.MaxLength = 32767;
            this.designationName.Name = "designationName";
            this.designationName.PasswordChar = '\0';
            this.designationName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.designationName.SelectedText = "";
            this.designationName.SelectionLength = 0;
            this.designationName.SelectionStart = 0;
            this.designationName.ShortcutsEnabled = true;
            this.designationName.ShowButton = true;
            this.designationName.ShowClearButton = true;
            this.designationName.Size = new System.Drawing.Size(290, 23);
            this.designationName.TabIndex = 9;
            this.designationName.UseSelectable = true;
            this.designationName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.designationName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.designationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.designationName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation Name";
            // 
            // Designation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.designationGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Designation";
            this.Resizable = false;
            this.Text = "Designation";
            this.Load += new System.EventHandler(this.Designation_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designationGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView designationGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox designationName;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroButton Exit;
    }
}