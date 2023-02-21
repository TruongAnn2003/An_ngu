using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanhTuan2
{
    public partial class Teacher_Form : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO teacherDAO  = new TeacherDAO();
        public Teacher_Form()
        {
            InitializeComponent();
        }

        private void Teacher_Form_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dataGridView_GiaoVien.DataSource = teacherDAO.GetList();
            resetTextBox();
        }
        private void resetTextBox()
        {
            txt_address.Text = "";
            txt_id.Text = "";
            txt_id.Enabled = true;
            txt_name.Text = "";
            txt_find.Text = "";
            datetime_birthday.Value = DateTime.Now;
        }
        public void FillTextBox(Teacher teacher)
        {
            txt_address.Text = teacher.Address;
            txt_id.Text = teacher.ID;
            txt_name.Text = teacher.Name;
            datetime_birthday.Text = teacher.Birthday;
        }
        private void dataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_GiaoVien.CurrentRow.Selected = true;
            Teacher teacher = new Teacher(dataGridView_GiaoVien.SelectedRows[0].Cells[0].Value.ToString(), dataGridView_GiaoVien.SelectedRows[0].Cells[1].Value.ToString(), dataGridView_GiaoVien.SelectedRows[0].Cells[3].Value.ToString(), dataGridView_GiaoVien.SelectedRows[0].Cells[2].Value.ToString());
            FillTextBox(teacher);
            txt_id.Enabled = false;
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txt_id.Text,txt_name.Text, txt_address.Text, datetime_birthday.Text);
            teacherDAO.Add(teacher);
            load();
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txt_id.Text, txt_name.Text, txt_address.Text, datetime_birthday.Text);
            teacherDAO.Delete(teacher);
            load();
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txt_id.Text, txt_name.Text, txt_address.Text, datetime_birthday.Text);
            teacherDAO.Edit(teacher);
            load();
        }
        private void link_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void bt_find_Click(object sender, EventArgs e)
        {
            dataGridView_GiaoVien.DataSource= teacherDAO.Find(txt_find.Text);
            Teacher teacher = new Teacher(dataGridView_GiaoVien.Rows[0].Cells[0].Value.ToString(), dataGridView_GiaoVien.Rows[0].Cells[1].Value.ToString(), dataGridView_GiaoVien.Rows[0].Cells[3].Value.ToString(), dataGridView_GiaoVien.Rows[0].Cells[2].Value.ToString());
            FillTextBox(teacher);
            txt_id.Enabled = false;
        }
        private void bt_all_Click(object sender, EventArgs e)
        { 
            load();
        }
    }
}
