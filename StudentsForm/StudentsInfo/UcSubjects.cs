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
    public partial class UcSubjects : UserControl
    {
        Subjects subjects;

        public UcSubjects()
        {
            InitializeComponent();
        }

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            int index;
            Helper.checkSubjectExist(subjects, out index);

            try
            {
                Subjects.removeSubject(index);
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

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            subjects = new Subjects();
            getNewData();

            #region AddOrUpdateLogix
            int index;
            Boolean flag = Helper.checkSubjectExist(subjects, out index);
            if (flag)
            {
                Subjects.subjects[index].subjectMark = subjects.subjectMark;
                Subjects.subjects[index].subjectName = subjects.subjectName;
            }
            else
            {
                Subjects.addSubject(subjects);
            }
            #endregion
        }

        /// <summary>
        /// Get data form subject form
        /// </summary>
        private void getNewData()
        {
            try
            {
                subjects.subjectID = int.Parse(txtID.Text);
                subjects.subjectName = txtSubjectName.Text;
                subjects.subjectMark = int.Parse(txtSubjectMark.Text);

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
    }
}
