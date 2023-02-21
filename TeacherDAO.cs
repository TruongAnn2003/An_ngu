using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace BaiTapThucHanhTuan2
{
    public class TeacherDAO
    {
        DBConnection dbConnection = new DBConnection();

        public void Add(Teacher teacher)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi, Cmnd, namsinh) VALUES ('{0}', '{1}','{2}','{3}')", teacher.Name, teacher.Address, teacher.ID, teacher.Birthday);
            dbConnection.perform(sqlStr);
        }
        public void Delete(Teacher teacher)
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", teacher.ID);
            dbConnection.perform(sqlStr);
        }
        public void Edit(Teacher teacher)
        {
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi ='{1}',namsinh='{2}' WHERE Cmnd = '{3}'", teacher.Name, teacher.Address, teacher.Birthday, teacher.ID);
            dbConnection.perform(sqlStr);
        }
        public DataTable GetList()
        {
            return dbConnection.GetList("Select * From GiaoVien");
        }
        public DataTable Find(string id)
        {
            string sqlstr = string.Format("Select * From GiaoVien Where Cmnd = '{0}'", id);
            return dbConnection.GetList(sqlstr);
        }
    }
}
