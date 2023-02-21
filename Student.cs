using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanhTuan2
{
    public class Student
    {
        private string id;
        private string name;
        private string address;
        private string birthday;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public Student()
        {

        }
        public Student(string id, string name, string address, string birthday)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.birthday = birthday;
        }

    }
}
