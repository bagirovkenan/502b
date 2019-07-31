using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Teacher:Person
    {
        public int TeacherID { get; set; }
        public int GrubSayi { get; set; }
     
        public List<Group> TeacherGroups { get; set; } = new List<Group>();

        public Teacher(int TcID, string TcFirstName, string TcLastName, int TcAge)
        {
            this.TeacherID = TcID;
            this.FirstName = TcFirstName;
            this.LastName = TcLastName;
            this.Age = TcAge;
        }

       
    }
}
