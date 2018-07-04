using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegApplication
{
    public partial class frmReg : Form
    {
        private Employee employee;
        private BindingSource bs;

        public frmReg()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            fillData(employee);

            #region writing results in richText
            rtxtReport.Text += $"Name:{employee.name}\n Job : {employee.job}\n" +
                $" Date of birth : {employee.dateOfBirth}\n Status:{employee.status}\n " +
                $"Hobits:{employee.habbits}\n Gender:{employee.gender}\n " +
                $"Salary:{employee.salary}\n Descreption:{employee.description}\n " +
                $"cSharp:{employee.cSharp}\n--------------------\n";
            #endregion

            // adding current employee object into list
            Employee.addEmployee(employee);
            bs = new BindingSource();
            bs.DataSource = Employee.emps;
            dgvEmployees.DataSource = bs;
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            // Fill by array 
            string[] st = new string[2];
            st[0] = "Single";
            st[1] = "married";
            ComboBoxStatus.DataSource = st;
        }

        private void ComboBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument1.OriginAtMargins = true;

                // Link between print dialog and print document
                PrintDialog1.Document = PrintDocument1;
                PrintDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtReport.Text, new Font("TimesNewRoman", 20), Brushes.Black, 10, 10);
            e.Graphics.DrawImage(employee.profileImage, 100, 500);
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog1.ShowDialog();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ProgressBar1.Value = (int)NumericUpDown2.Value;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.ShowDialog();
            PrintPreviewDialog1.Document = PrintDocument1;
        }

        /// <summary>
        /// Adding data from the Form to the Employee Object
        /// </summary>
        /// <param name="employee">Employee object</param>
        public void fillData(Employee employee)
        {
            employee.name = txtName.Text;
            employee.job = txtJob.Text;
            employee.salary = NumericUpDownSalary.Value.ToString();
            employee.cSharp = ProgressBar1.Value.ToString();
            employee.dateOfBirth = DateTimePickerBirthDate.Text;
            employee.description = txtDescreption.Text;
            employee.profileImage = Image.FromFile(openFileDialog1.FileName);
            PictureBoxPersonalImg.Image = employee.profileImage;
            employee.status = ComboBoxStatus.Text;

            #region RadioButton
            if (RadioButtonMale.Checked)
                employee.gender = "Male";
            else
                employee.gender = "Female";
            #endregion

            #region checkBox
            // checkBox and radioBox results
            if (CheckBox1.Checked)
                employee.habbits += "Football\t";
            if (CheckBox2.Checked)
                employee.habbits += "Swimming\t";
            if (CheckBox3.Checked)
                employee.habbits += "Watching Tv\t";
            if (CheckBox4.Checked)
                employee.habbits += "Body Building\t";
            #endregion

            Helper.clearTextBoxes(this.Controls);

        }
    }
}
