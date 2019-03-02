namespace School_Managment_System
{
    partial class StudnetSentBox
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.clearAll = new MetroFramework.Controls.MetroButton();
            this.studentSentboxdataGridview = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentSentboxdataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(7, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(724, 410);
            this.metroTabControl1.TabIndex = 102;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel4);
            this.metroTabPage1.Controls.Add(this.studentSentboxdataGridview);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(716, 368);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Students SMS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(716, 368);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Staff SMS";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Controls.Add(this.clearAll);
            this.panel4.Location = new System.Drawing.Point(3, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(713, 66);
            this.panel4.TabIndex = 103;
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
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clearAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearAll.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.clearAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearAll.Location = new System.Drawing.Point(147, 18);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(156, 32);
            this.clearAll.TabIndex = 16;
            this.clearAll.Text = "All Clear";
            this.clearAll.UseCustomBackColor = true;
            this.clearAll.UseCustomForeColor = true;
            this.clearAll.UseSelectable = true;
            this.clearAll.UseStyleColors = true;
            // 
            // studentSentboxdataGridview
            // 
            this.studentSentboxdataGridview.AllowUserToAddRows = false;
            this.studentSentboxdataGridview.AllowUserToDeleteRows = false;
            this.studentSentboxdataGridview.AllowUserToResizeColumns = false;
            this.studentSentboxdataGridview.AllowUserToResizeRows = false;
            this.studentSentboxdataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentSentboxdataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentSentboxdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentSentboxdataGridview.Location = new System.Drawing.Point(3, 3);
            this.studentSentboxdataGridview.Name = "studentSentboxdataGridview";
            this.studentSentboxdataGridview.ReadOnly = true;
            this.studentSentboxdataGridview.Size = new System.Drawing.Size(717, 290);
            this.studentSentboxdataGridview.TabIndex = 102;
            // 
            // StudnetSentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "StudnetSentBox";
            this.Resizable = false;
            this.Text = "SENTBOX";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.StudnetSentBox_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentSentboxdataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton clearAll;
        private System.Windows.Forms.DataGridView studentSentboxdataGridview;
    }
}