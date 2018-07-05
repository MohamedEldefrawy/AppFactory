using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class Helper
    {
        /// <summary>
        /// Check if selected subject is already saved in the subjects collection or no
        /// If so return it's index and true value else return false value and index = 0
        /// </summary>
        /// <param name="subject">subject object</param>
        /// <param name="index">Output variable to save the index</param>
        /// <returns>Boolean , index</returns>
        public static Boolean checkSubjectExist(Subjects subject, out int index)
        {
            Boolean result = false;
            index = 0;
            foreach (var item in Subjects.subjects)
            {
                if (subject.subjectID == item.subjectID)
                {
                    result = true;
                    index = Subjects.subjects.IndexOf(item);
                    break;
                }
            }
            return result;

        }

        /// <summary>
        /// Check if selected student is already saved in the studnets collection or no
        /// If so return it's index and true value else return false value and index = 0
        /// </summary>
        /// <param name="students">studnet object</param>
        /// <param name="index">Output variable to save the index</param>
        /// <returns>Boolean , index</returns>
        public static Boolean checkStudnetExist(Students students, out int index)
        {
            Boolean result = false;
            index = int.MaxValue;
            foreach (var item in Students.students)
            {
                if (students.studentID == item.studentID)
                {
                    result = true;
                    index = Students.students.IndexOf(item);
                    break;
                }
            }
            return result;

        }
    }
}
