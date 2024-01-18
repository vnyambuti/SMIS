using Org.BouncyCastle.Asn1.Mozilla;

namespace CRUD
{
    public partial class FormStudintInfo : Form
    {
        public FormStudintInfo()
        {
            InitializeComponent();
        }

        public void Display()
        {

            DBStudent.DisplayandSearch("SELECT ID,Name,Reg,Class,Stream from students", dataGridView1);

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            StudentInfo form = new StudentInfo(this);
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