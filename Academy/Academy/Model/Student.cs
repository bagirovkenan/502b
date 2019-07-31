using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student : Person
    {
        public int StudentID { get; set; }
        public bool Status { get; set; }
        public Group StudentGroup { get; set; }



        public Student(int _StID, string _StFirstName, string _StLAstName, int _StAge)
        {
            this.StudentID = _StID;
            this.FirstName = _StFirstName;
            this.LastName = _StLAstName;
            this.Age = _StAge;
        }
    }
}
