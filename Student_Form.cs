using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapThucHanhTuan2
{
    public partial class Student_Form : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO studentDAO = new StudentDAO();
        public Student_Form()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void load()
        {
            dataGridView_SinhVien.DataSource = studentDAO.GetList();
            resetTextBox();
        }
        private void resetTextBox()
        {
            txt_address.Text = "";
            txt_id.Text = "";
            txt_id.Enabled = true;
            txt_name.Text = "";
            txt_find.Text = "";
            datetime_birthday.Value= DateTime.Now;
        }
        public void FillTextBox(Student student)
        {
            txt_address.Text = student.Address;
            txt_id.Text = student.ID;
            txt_name.Text = student.Name;
            datetime_birthday.Text = student.Birthday;
        }
        private void Student_Form_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                load();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(txt_id.Text, txt_name.Text, txt_address.Text, datetime_birthday.Text);
            studentDAO.Add(student);
            load();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Student student = new Student(txt_id.Text, txt_name.Text, txt_address.Text, datetime_birthday.Text);
            studentDAO.Edit(student);
            load();
        }
        private void link_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void bt_find_Click(object sender, EventArgs e)
        {
            
        }
        private void bt_all_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_SinhVien.CurrentRow.Selected= true;
            Student student = new Student(dataGridView_SinhVien.SelectedRows[0].Cells[2].Value.ToString(), dataGridView_SinhVien.SelectedRows[0].Cells[0].Value.ToString(), dataGridView_SinhVien.SelectedRows[0].Cells[1].Value.ToString(), dataGridView_SinhVien.SelectedRows[0].Cells[3].Value.ToString());
            FillTextBox(student);
            txt_id.Enabled = false;
        }
    }
}
