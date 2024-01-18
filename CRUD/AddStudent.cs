using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD
{
    public partial class StudentInfo : Form
    {

        private readonly FormStudintInfo _parent;
        public StudentInfo(FormStudintInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public  void Clear()
        {
            textBoxName.Text= textBoxClass.Text= textBoxReg.Text= textBoxSection.Text=string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is too short > 3");
                return;
            }
            if (textBoxClass.Text.Trim().Length ==0)
            {
                MessageBox.Show("Student class is too short > 0");
                return;
            }

            if (textBoxReg.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student Registration is too short > 3");
                return;
            }

            if (textBoxSection.Text.Trim().Length ==0)
            {
                MessageBox.Show("Student stream cannot be empty");
                return;
            }
            if (btnSaveStudent.Text == "Save")
            {
                Student std = new Student(textBoxName.Text.Trim(), textBoxReg.Text.Trim(), textBoxClass.Text.Trim(), textBoxSection.Text.Trim());

                DBStudent.AddStudent(std);
                Clear();
                
            }
            _parent.Display();



        }
    }
}
