using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
  {
    class StudentController
    {
        //creat
        public static void  Creat(string _frname, string _lsname, int _age)
        {
            if (Curs.CursStudent == null)
            {
                Student newStd = new Student(1, _frname, _lsname, _age);
                Curs.CursStudent.Add(newStd);
                Information(newStd);
            }
            else
            {
                var maxID = Curs.CursStudent.Max(m => m.StudentID);
                Student newStd = new Student(maxID+1, _frname, _lsname, _age);
                Curs.CursStudent.Add(newStd);
                Information(newStd);
            }

        }

        //delete
        public static void deletStudent(Student st)
        {
            var dltStd = Curs.CursStudent.Find(f => f.StudentID == st.StudentID);

            if (dltStd == null)
            {
                Console.WriteLine(  "Bele telebe yoxdur");
            }
            else
            {
                var StGroup = Curs.Groups.Find(f => f.GroupID == dltStd.StudentGroup.GroupID && f.GroupName == dltStd.StudentGroup.GroupName);
                Curs.CursStudent.Remove(dltStd);
                
                StGroup.GroupStudents.Remove(dltStd);
                Console.WriteLine("{0} {1} cursdan  ve {2} qurupundan  silindi", dltStd.FirstName, dltStd.LastName, StGroup.GroupName);
                Console.WriteLine("===============================================");
            }
          
        }
        //Information
        public static void Information(Student newStudent)
        {
            Console.WriteLine(" Telebe:\n ID:{0} \t Ad:{1}\t Soy Ad:{2} \t Yas:{3} ",newStudent.StudentID,newStudent.FirstName,newStudent.LastName,newStudent.Age);
        }

        //all student show

        public static void AllStudent()
        {
            foreach(var i in Curs.CursStudent)
            {
                //Console.WriteLine("ID=>:{0} Ad=>:{1} Soy Ad {2}",i.StudentID,i.FirstName,i.LastName);
                Console.WriteLine("============================================================");
                Information(i);
                Console.WriteLine("============================================================");
            }
        }
    }
}
