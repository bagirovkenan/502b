using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public List<Student> GroupStudents { get; set; } = new List<Student>();
        public Teacher GroupTeacher { get; set; }

        public Group(int _ID,string _Name)
        {
            this.GroupID = _ID;
            this.GroupName = _Name;
        }
    }
}
