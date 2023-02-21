namespace BaiTapThucHanhTuan2
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void bt_Student_Click(object sender, EventArgs e)
        {
            Student_Form student_Form = new Student_Form();
            this.Hide();
            student_Form.ShowDialog();
            this.Show();
        }
        private void bt_Teacher_Click(object sender, EventArgs e)
        {
            Teacher_Form teacher_Form = new Teacher_Form();
            this.Hide();
            teacher_Form.ShowDialog();
            this.Show();
        }
        private void Start_Form_Load(object sender, EventArgs e)
        {
        }
    }
}