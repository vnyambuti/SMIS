using Org.BouncyCastle.Asn1.Mozilla;

namespace CRUD
{
    public partial class FormStudintInfo : Form
    {

        StudentInfo form;
        public FormStudintInfo()
        {
            InitializeComponent();
            form=new StudentInfo(this);
        }

        public void Display()
        {

            DBStudent.DisplayandSearch("SELECT ID,Name,Reg,Class,Stream from students", dataGridView1);

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
           form.Clear();
            form.ShowDialog();
        }

        private void FormStudintInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.reg = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.@class = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.stream = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Are you sure you want to delete?", "Informaation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    {
                        DBStudent.DeleteStudent(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                    }

                    return;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBStudent.DisplayandSearch("SELECT ID,Name,Reg,Class,Stream FROM students WHERE Name LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }
    }
}