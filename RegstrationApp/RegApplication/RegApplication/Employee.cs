using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegApplication
{
    public class Employee
    {
        // static List to save Employees
        public static List<Employee> emps = new List<Employee>();

        #region Employee Properties
        public string name { get; set; }
        public string job { get; set; }
        public string dateOfBirth { get; set; }
        public string status { get; set; }
        public string habbits { get; set; }
        public string gender { get; set; }
        public string salary { get; set; }
        public string description { get; set; }
        public string cSharp { get; set; }
        public Image profileImage { get; set; }
        #endregion

        /// <summary>
        /// Adding new Employee object to the static employees list
        /// </summary>
        /// <param name="employee">employee Object</param>
        public static void addEmployee(Employee employee)
        {
            emps.Add(employee);
        }
    }
}
