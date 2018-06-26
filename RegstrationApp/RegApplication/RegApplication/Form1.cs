using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegApplication
{
    public partial class frmReg : Form
    {
        #region variables
        string name;
        string job;
        string dob;
        string status;
        string habites;
        string gender;
        string salary;
        string description;
        string cSharp;
        Image profileImage;
        #endregion

        public frmReg()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            #region store textbox, date, Numeric and combo values
            name = txtName.Text;
            job = txtJob.Text;
            dob = DateTimePickerBirthDate.Value.ToShortDateString();
            status = ComboBoxStatus.Text;
            cSharp = NumericUpDown2.Value.ToString();
            description = txtDescreption.Text;
            salary = NumericUpDownSalary.Value.ToString();
            habites = string.Empty;
            #endregion

            #region checkBox
            // checkBox and radioBox results
            if (CheckBox1.Checked)
                habites += "Football\t";
            if (CheckBox2.Checked)
                habites += "Swimming\t";
            if (CheckBox3.Checked)
                habites += "Watching Tv\t";
            if (CheckBox4.Checked)
                habites += "Body Building\t";
            #endregion

            #region RadioButton
            if (RadioButtonMale.Checked)
                gender = "Male";
            else
                gender = "Female";
            #endregion

            #region writing results in richText
            rtxtReport.Text = string.Format("---------- your information ----------\n Name : {0}\n Job : {1}\n Birth date : {2}\n Status : {3}\n Hobits : {4}\n Gender : {5}\n Salary : {6:C}\n C# : {7}%\n Descreption : {8}", name, job, dob, status, habites, gender, salary, cSharp, description);
            #endregion
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

            // PictureBoxPersonalImg.ImageLocation = openFileDialog1.FileName;
            profileImage = Image.FromFile(openFileDialog1.FileName);
            PictureBoxPersonalImg.Image = profileImage;
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
            e.Graphics.DrawImage(profileImage, 100, 500);
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
    }
}
