using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryApp
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        public Department ADepartment;

        private void deparmentSaveButton_Click(object sender, EventArgs e)
        {
            ADepartment = new Department(codeInputTextBox.Text, departmentNameTextBox.Text);
            MessageBox.Show("Department Creatded");

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regNoTextBox.Text, studentNameTextBox.Text, emailTextBox.Text);
            //ADepartment.Students.Add(aStudent);
            string msg = ADepartment.AddStudent(aStudent);
            MessageBox.Show(msg);

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string info = "Code :\t" + ADepartment.Code + "Name :\t" + ADepartment.Name + "\n";
            info += "Student Reg No\tName\tEmail\n";
            foreach (Student aStudent in ADepartment.GetStudent())
            {
                string aRow = aStudent.RegNo + "\t" + aStudent.Name + "\t\t" + aStudent.Email + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
