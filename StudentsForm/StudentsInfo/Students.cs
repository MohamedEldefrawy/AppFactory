using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class Students
    {
        #region Properties
        public int studentID { get; set; }
        public string studnetName { get; set; }
        public int studentMark { get; set; }
        public string subject { get; set; }
        #endregion

        public static List<Students> students = new List<Students>();

        #region Methods
        /// <summary>
        /// Adding new student to studnets collection
        /// </summary>
        /// <param name="subj">Student refrence</param>
        public static void addStudent(Students stu)
        {
            students.Add(stu);
        }

        /// <summary>
        ///  Remove studnet from studnets collection
        /// </summary>
        /// <param name="index">index of studnet</param>
        public static void removeStudent(int index)
        {
            students.RemoveAt(index);
        }
        #endregion
    }
}
