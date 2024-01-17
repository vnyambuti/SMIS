namespace CRUD
{
    public partial class FormStudintInfo : Form
    {
        public FormStudintInfo()
        {
            InitializeComponent();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            StudentInfo form = new StudentInfo(this);
            form.ShowDialog();
        }
    }
}