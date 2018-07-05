namespace StudentsInfo
{
    partial class UcSubjects
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSubjectsInfo = new System.Windows.Forms.GroupBox();
            this.btnSubjectDelete = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtSubjectMark = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSubjectsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSubjectsInfo
            // 
            this.gbSubjectsInfo.Controls.Add(this.btnSubjectDelete);
            this.gbSubjectsInfo.Controls.Add(this.btnAddSubject);
            this.gbSubjectsInfo.Controls.Add(this.txtSubjectMark);
            this.gbSubjectsInfo.Controls.Add(this.txtSubjectName);
            this.gbSubjectsInfo.Controls.Add(this.txtID);
            this.gbSubjectsInfo.Controls.Add(this.label3);
            this.gbSubjectsInfo.Controls.Add(this.label2);
            this.gbSubjectsInfo.Controls.Add(this.label1);
            this.gbSubjectsInfo.Location = new System.Drawing.Point(3, 3);
            this.gbSubjectsInfo.Name = "gbSubjectsInfo";
            this.gbSubjectsInfo.Size = new System.Drawing.Size(169, 178);
            this.gbSubjectsInfo.TabIndex = 0;
            this.gbSubjectsInfo.TabStop = false;
            this.gbSubjectsInfo.Text = "Subject Informations";
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.Location = new System.Drawing.Point(87, 140);
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectDelete.TabIndex = 15;
            this.btnSubjectDelete.Text = "Delete";
            this.btnSubjectDelete.UseVisualStyleBackColor = true;
            this.btnSubjectDelete.Click += new System.EventHandler(this.btnSubjectDelete_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(6, 140);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 13;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtSubjectMark
            // 
            this.txtSubjectMark.Location = new System.Drawing.Point(48, 102);
            this.txtSubjectMark.Name = "txtSubjectMark";
            this.txtSubjectMark.Size = new System.Drawing.Size(114, 20);
            this.txtSubjectMark.TabIndex = 12;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(48, 67);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(114, 20);
            this.txtSubjectName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID: ";
            // 
            // UcSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSubjectsInfo);
            this.Name = "UcSubjects";
            this.Size = new System.Drawing.Size(176, 173);
            this.gbSubjectsInfo.ResumeLayout(false);
            this.gbSubjectsInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSubjectsInfo;
        private System.Windows.Forms.Button btnSubjectDelete;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.TextBox txtSubjectMark;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
