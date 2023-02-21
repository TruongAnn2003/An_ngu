using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanhTuan2
{
    public class StudentDAO
    {
        DBConnection dbConnection= new DBConnection();
        public void Add(Student student)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(Ten , Diachi, Cmnd, namsinh) VALUES ('{0}', '{1}','{2}','{3}')", student.Name, student.Address, student.ID, student.Birthday);
            dbConnection.perform(sqlStr);
        }
        public void Delete(Student student)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", student.ID);
            dbConnection.perform(sqlStr);
        }
        public void Edit(Student student)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi ='{1}',namsinh='{2}' WHERE Cmnd = '{3}'", student.Name, student.Address, student.Birthday, student.ID);
            dbConnection.perform(sqlStr);
        }
        public DataTable GetList()
        {
            return dbConnection.GetList("Select * From HocSinh");
        }
        public DataTable Find(string id)
        {
            string sqlstr = string.Format("Select * From HocSinh Where Cmnd = '{0}'", id);
            return dbConnection.GetList(sqlstr);
        }
    }
}
