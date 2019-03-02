namespace School_Managment_System
{
    partial class GroupForm
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
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Upate);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(351, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 173);
            this.panel2.TabIndex = 17;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(13, 130);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseCustomBackColor = true;
            this.exitButton.UseCustomForeColor = true;
            this.exitButton.UseMnemonic = false;
            this.exitButton.UseSelectable = true;
            this.exitButton.UseStyleColors = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 95);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupName
            // 
            // 
            // 
            // 
            this.groupName.CustomButton.Image = null;
            this.groupName.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.groupName.CustomButton.Name = "";
            this.groupName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.groupName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.groupName.CustomButton.TabIndex = 1;
            this.groupName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.groupName.CustomButton.UseSelectable = true;
            this.groupName.Lines = new string[0];
            this.groupName.Location = new System.Drawing.Point(137, 34);
            this.groupName.MaxLength = 32767;
            this.groupName.Name = "groupName";
            this.groupName.PasswordChar = '\0';
            this.groupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.groupName.SelectedText = "";
            this.groupName.SelectionLength = 0;
            this.groupName.SelectionStart = 0;
            this.groupName.ShortcutsEnabled = true;
            this.groupName.ShowButton = true;
            this.groupName.ShowClearButton = true;
            this.groupName.Size = new System.Drawing.Size(290, 23);
            this.groupName.TabIndex = 9;
            this.groupName.UseSelectable = true;
            this.groupName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.groupName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.groupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group Name";
            // 
            // groupGridView
            // 
            this.groupGridView.AllowUserToAddRows = false;
            this.groupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupGridView.Location = new System.Drawing.Point(23, 164);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.ReadOnly = true;
            this.groupGridView.Size = new System.Drawing.Size(322, 173);
            this.groupGridView.TabIndex = 18;
            this.groupGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.groupGridView_RowHeaderMouseClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(366, 296);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 32);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseCustomForeColor = true;
            this.Exit.UseMnemonic = false;
            this.Exit.UseSelectable = true;
            this.Exit.UseStyleColors = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupGridView);
            this.Controls.Add(this.Exit);
            this.MaximizeBox = false;
            this.Name = "GroupForm";
            this.Resizable = false;
            this.Text = "Add Group ";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox groupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView groupGridView;
        private MetroFramework.Controls.MetroButton Exit;
    }
}