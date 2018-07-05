using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInfo
{
    public partial class UcStudents : UserControl
    {

        #region Data Types
        private Students students;
        private BindingSource bs;
        #endregion

        public UcStudents()
        {
            InitializeComponent();
        }

        private void btnAddStudnet_Click(object sender, EventArgs e)
        {
            students = new Students();
            getNewData();

            #region AddOrUpdateLogic
            int index;
            Boolean flag = Helper.checkStudnetExist(students, out index);
            if (flag)
            {
                Students.students[index].studentMark = students.studentMark;
                Students.students[index].studnetName = students.studnetName;
                Students.students[index].subject = students.subject;

            }
            else
            {
                Students.addStudent(students);

            }
            #endregion
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbSubjects.DataSource = Subjects.getSubjectNames();
        }

        private void btnShowStudentData_Click(object sender, EventArgs e)
        {
            bs = new BindingSource();
            bs.DataSource = Students.students;
            dgvStudents.DataSource = bs;
        }

        /// <summary>
        /// Get Data from the student form
        /// </summary>
        private void getNewData()
        {
            try
            {
                students.studentID = int.Parse(txtStudentID.Text);
                students.studnetName = txtStudentName.Text;
                students.studentMark = int.Parse(txtStudentMark.Text);
                students.subject = cmbSubjects.Text;

            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            int index;
            Helper.checkStudnetExist(students, out index);

            try
            {
                Students.removeStudent(index);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
