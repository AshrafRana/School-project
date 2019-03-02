namespace School_Managment_System
{
    partial class FeesType
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
            this.feeTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feeName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.Exit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.feeTypeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // feeTypeDataGridView
            // 
            this.feeTypeDataGridView.AllowUserToAddRows = false;
            this.feeTypeDataGridView.AllowUserToDeleteRows = false;
            this.feeTypeDataGridView.AllowUserToResizeColumns = false;
            this.feeTypeDataGridView.AllowUserToResizeRows = false;
            this.feeTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feeTypeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.feeTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeTypeDataGridView.Location = new System.Drawing.Point(14, 158);
            this.feeTypeDataGridView.Name = "feeTypeDataGridView";
            this.feeTypeDataGridView.ReadOnly = true;
            this.feeTypeDataGridView.Size = new System.Drawing.Size(322, 176);
            this.feeTypeDataGridView.TabIndex = 11;
            this.feeTypeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.feeTypeDataGridView_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // feeName
            // 
            // 
            // 
            // 
            this.feeName.CustomButton.Image = null;
            this.feeName.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.feeName.CustomButton.Name = "";
            this.feeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.feeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.feeName.CustomButton.TabIndex = 1;
            this.feeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.feeName.CustomButton.UseSelectable = true;
            this.feeName.Lines = new string[0];
            this.feeName.Location = new System.Drawing.Point(99, 28);
            this.feeName.MaxLength = 32767;
            this.feeName.Name = "feeName";
            this.feeName.PasswordChar = '\0';
            this.feeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.feeName.SelectedText = "";
            this.feeName.SelectionLength = 0;
            this.feeName.SelectionStart = 0;
            this.feeName.ShortcutsEnabled = true;
            this.feeName.ShowButton = true;
            this.feeName.Size = new System.Drawing.Size(327, 23);
            this.feeName.TabIndex = 13;
            this.feeName.UseSelectable = true;
            this.feeName.WaterMark = "Enter Fee Name";
            this.feeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.feeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.feeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feeName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fee Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Upate);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(342, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 176);
            this.panel2.TabIndex = 12;
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
            // FeesType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 347);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.feeTypeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FeesType";
            this.Resizable = false;
            this.Text = "FeesType";
            this.Load += new System.EventHandler(this.FeesType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feeTypeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView feeTypeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox feeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroButton Exit;
    }
}