using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class Subjects
    {
        #region Properties
        public int subjectID { get; set; }
        public string subjectName { get; set; }
        public int subjectMark { get; set; }
        #endregion

        public static List<Subjects> subjects = new List<Subjects>();

        #region Methods
        /// <summary>
        /// Adding new Subject to subjects collection
        /// </summary>
        /// <param name="subj">Subjects refrence</param>
        public static void addSubject(Subjects subj)
        {
            subjects.Add(subj);
        }

        /// <summary>
        ///  Remove subjects from subjects collection
        /// </summary>
        /// <param name="index">index of subject</param>
        public static void removeSubject(int index)
        {
            subjects.RemoveAt(index);
        }

        /// <summary>
        /// get Subject names from subjects list
        /// </summary>
        /// <returns> list<string> of subject names</returns>
        public static List<string> getSubjectNames()
        {
            List<string> subjectNames = new List<string>();

            foreach (var item in subjects)
            {
                subjectNames.Add(item.subjectName.ToString());
            }
            return subjectNames;
        }
        #endregion
    }
}
