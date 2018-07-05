namespace StudentsInfo
{
    partial class frmStudent
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
            this.ucSubjects1 = new StudentsInfo.UcSubjects();
            this.ucStudents1 = new StudentsInfo.UcStudents();
            this.SuspendLayout();
            // 
            // ucSubjects1
            // 
            this.ucSubjects1.Location = new System.Drawing.Point(278, 12);
            this.ucSubjects1.Name = "ucSubjects1";
            this.ucSubjects1.Size = new System.Drawing.Size(176, 173);
            this.ucSubjects1.TabIndex = 1;
            // 
            // ucStudents1
            // 
            this.ucStudents1.Location = new System.Drawing.Point(12, 12);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(265, 324);
            this.ucStudents1.TabIndex = 0;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 332);
            this.Controls.Add(this.ucSubjects1);
            this.Controls.Add(this.ucStudents1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.ResumeLayout(false);

        }

        #endregion

        private UcStudents ucStudents1;
        private UcSubjects ucSubjects1;
    }
}

