using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Curs
    {
        public int CursID { get; set; }
        public string CursName { get; set; }
        public static List<Group> Groups { get; set; } = new List<Group>();
        public static List<Teacher> CursTeachers { get; set; } = new List<Teacher>();
        public static List<Student> CursStudent { get; set; } = new List<Student>();

        public Curs(int _ID, string _Name)
        {
            this.CursID = _ID;
            this.CursName = _Name;
        }
    }
}
