using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanhTuan2
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void perform(string str)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable GetList(string str)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public DBConnection()
        {

        }
    }
}
