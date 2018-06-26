namespace RegApplication
{
    partial class frmReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReg));
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnResult = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txtDescreption = new System.Windows.Forms.TextBox();
            this.NumericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.grpboxReport = new System.Windows.Forms.GroupBox();
            this.rtxtReport = new System.Windows.Forms.RichTextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.PictureBoxPersonalImg = new System.Windows.Forms.PictureBox();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblProgrammingLanguage = new System.Windows.Forms.Label();
            this.lblDescreption = new System.Windows.Forms.Label();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpBoxHobites = new System.Windows.Forms.GroupBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.grpBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSalary)).BeginInit();
            this.grpboxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPersonalImg)).BeginInit();
            this.grpBoxHobites.SuspendLayout();
            this.grpBoxBasicInfo.SuspendLayout();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.Document = this.PrintDocument1;
            this.PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(83, 502);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(120, 41);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Show Results";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(137, 458);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(138, 23);
            this.ProgressBar1.TabIndex = 31;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(116, 465);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage.TabIndex = 30;
            this.lblPercentage.Text = "%";
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(62, 461);
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.NumericUpDown2.TabIndex = 2;
            this.NumericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // txtDescreption
            // 
            this.txtDescreption.Location = new System.Drawing.Point(16, 339);
            this.txtDescreption.Multiline = true;
            this.txtDescreption.Name = "txtDescreption";
            this.txtDescreption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescreption.Size = new System.Drawing.Size(258, 99);
            this.txtDescreption.TabIndex = 1;
            // 
            // NumericUpDownSalary
            // 
            this.NumericUpDownSalary.Location = new System.Drawing.Point(163, 268);
            this.NumericUpDownSalary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumericUpDownSalary.Name = "NumericUpDownSalary";
            this.NumericUpDownSalary.Size = new System.Drawing.Size(111, 20);
            this.NumericUpDownSalary.TabIndex = 0;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(304, 123);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImageBrowse.TabIndex = 4;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // grpboxReport
            // 
            this.grpboxReport.Controls.Add(this.rtxtReport);
            this.grpboxReport.Controls.Add(this.btnPreview);
            this.grpboxReport.Controls.Add(this.btnPrint);
            this.grpboxReport.Controls.Add(this.btnPageSetup);
            this.grpboxReport.Location = new System.Drawing.Point(431, 12);
            this.grpboxReport.Name = "grpboxReport";
            this.grpboxReport.Size = new System.Drawing.Size(245, 535);
            this.grpboxReport.TabIndex = 33;
            this.grpboxReport.TabStop = false;
            this.grpboxReport.Text = "Report";
            // 
            // rtxtReport
            // 
            this.rtxtReport.Location = new System.Drawing.Point(6, 19);
            this.rtxtReport.Name = "rtxtReport";
            this.rtxtReport.Size = new System.Drawing.Size(233, 479);
            this.rtxtReport.TabIndex = 0;
            this.rtxtReport.Text = "";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(86, 506);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(164, 506);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Location = new System.Drawing.Point(5, 506);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(75, 23);
            this.btnPageSetup.TabIndex = 0;
            this.btnPageSetup.Text = "Page Setup";
            this.btnPageSetup.UseVisualStyleBackColor = true;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // PictureBoxPersonalImg
            // 
            this.PictureBoxPersonalImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxPersonalImg.Location = new System.Drawing.Point(280, 19);
            this.PictureBoxPersonalImg.Name = "PictureBoxPersonalImg";
            this.PictureBoxPersonalImg.Size = new System.Drawing.Size(127, 89);
            this.PictureBoxPersonalImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPersonalImg.TabIndex = 11;
            this.PictureBoxPersonalImg.TabStop = false;
            // 
            // PageSetupDialog1
            // 
            this.PageSetupDialog1.Document = this.PrintDocument1;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(24, 49);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Document = this.PrintDocument1;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(24, 26);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(6, 63);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Job";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(118, 272);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary";
            // 
            // lblProgrammingLanguage
            // 
            this.lblProgrammingLanguage.AutoSize = true;
            this.lblProgrammingLanguage.Location = new System.Drawing.Point(17, 465);
            this.lblProgrammingLanguage.Name = "lblProgrammingLanguage";
            this.lblProgrammingLanguage.Size = new System.Drawing.Size(21, 13);
            this.lblProgrammingLanguage.TabIndex = 22;
            this.lblProgrammingLanguage.Text = "C#";
            // 
            // lblDescreption
            // 
            this.lblDescreption.AutoSize = true;
            this.lblDescreption.Location = new System.Drawing.Point(16, 323);
            this.lblDescreption.Name = "lblDescreption";
            this.lblDescreption.Size = new System.Drawing.Size(60, 13);
            this.lblDescreption.TabIndex = 21;
            this.lblDescreption.Text = "Description";
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(62, 124);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.ComboBoxStatus.TabIndex = 3;
            this.ComboBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxStatus_KeyPress);
            // 
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(62, 89);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerBirthDate.TabIndex = 2;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(62, 62);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(200, 20);
            this.txtJob.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // grpBoxHobites
            // 
            this.grpBoxHobites.Controls.Add(this.CheckBox4);
            this.grpBoxHobites.Controls.Add(this.CheckBox3);
            this.grpBoxHobites.Controls.Add(this.CheckBox2);
            this.grpBoxHobites.Controls.Add(this.CheckBox1);
            this.grpBoxHobites.Location = new System.Drawing.Point(12, 179);
            this.grpBoxHobites.Name = "grpBoxHobites";
            this.grpBoxHobites.Size = new System.Drawing.Size(100, 128);
            this.grpBoxHobites.TabIndex = 25;
            this.grpBoxHobites.TabStop = false;
            this.grpBoxHobites.Text = "Hobites";
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(7, 96);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(90, 17);
            this.CheckBox4.TabIndex = 3;
            this.CheckBox4.Text = "Body Building";
            this.CheckBox4.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(7, 72);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(84, 17);
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "Watching tv";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(6, 49);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(73, 17);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "Swimming";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(6, 26);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(63, 17);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "Football";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // grpBoxBasicInfo
            // 
            this.grpBoxBasicInfo.Controls.Add(this.btnImageBrowse);
            this.grpBoxBasicInfo.Controls.Add(this.PictureBoxPersonalImg);
            this.grpBoxBasicInfo.Controls.Add(this.lblName);
            this.grpBoxBasicInfo.Controls.Add(this.ComboBoxStatus);
            this.grpBoxBasicInfo.Controls.Add(this.lblJob);
            this.grpBoxBasicInfo.Controls.Add(this.DateTimePickerBirthDate);
            this.grpBoxBasicInfo.Controls.Add(this.lblStatus);
            this.grpBoxBasicInfo.Controls.Add(this.txtJob);
            this.grpBoxBasicInfo.Controls.Add(this.lblBirthDate);
            this.grpBoxBasicInfo.Controls.Add(this.txtName);
            this.grpBoxBasicInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBoxBasicInfo.Name = "grpBoxBasicInfo";
            this.grpBoxBasicInfo.Size = new System.Drawing.Size(413, 152);
            this.grpBoxBasicInfo.TabIndex = 24;
            this.grpBoxBasicInfo.TabStop = false;
            this.grpBoxBasicInfo.Text = "Basic Information";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 95);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Birth date";
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.RadioButtonFemale);
            this.grpBoxGender.Controls.Add(this.RadioButtonMale);
            this.grpBoxGender.Location = new System.Drawing.Point(118, 179);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(156, 78);
            this.grpBoxGender.TabIndex = 26;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 559);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.NumericUpDown2);
            this.Controls.Add(this.txtDescreption);
            this.Controls.Add(this.NumericUpDownSalary);
            this.Controls.Add(this.grpboxReport);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblProgrammingLanguage);
            this.Controls.Add(this.lblDescreption);
            this.Controls.Add(this.grpBoxHobites);
            this.Controls.Add(this.grpBoxBasicInfo);
            this.Controls.Add(this.grpBoxGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSalary)).EndInit();
            this.grpboxReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPersonalImg)).EndInit();
            this.grpBoxHobites.ResumeLayout(false);
            this.grpBoxHobites.PerformLayout();
            this.grpBoxBasicInfo.ResumeLayout(false);
            this.grpBoxBasicInfo.PerformLayout();
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PrintDialog PrintDialog1;
        internal System.Windows.Forms.Button btnResult;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label lblPercentage;
        internal System.Windows.Forms.NumericUpDown NumericUpDown2;
        internal System.Windows.Forms.TextBox txtDescreption;
        internal System.Windows.Forms.NumericUpDown NumericUpDownSalary;
        internal System.Windows.Forms.Button btnImageBrowse;
        internal System.Windows.Forms.GroupBox grpboxReport;
        internal System.Windows.Forms.RichTextBox rtxtReport;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnPageSetup;
        internal System.Windows.Forms.PictureBox PictureBoxPersonalImg;
        internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.RadioButton RadioButtonFemale;
        internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblJob;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label lblSalary;
        internal System.Windows.Forms.Label lblProgrammingLanguage;
        internal System.Windows.Forms.Label lblDescreption;
        internal System.Windows.Forms.ComboBox ComboBoxStatus;
        internal System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
        internal System.Windows.Forms.TextBox txtJob;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.GroupBox grpBoxHobites;
        internal System.Windows.Forms.CheckBox CheckBox4;
        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.GroupBox grpBoxBasicInfo;
        internal System.Windows.Forms.Label lblBirthDate;
        internal System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
    }
}

