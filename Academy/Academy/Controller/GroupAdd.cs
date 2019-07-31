using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class GroupAdd
    {
        public static void AddStudent(Student st,Group Gr)
        {
            foreach(var i in Curs.Groups)
            {
                var axtarilanSt = i.GroupStudents.FirstOrDefault(f => f.StudentID == st.StudentID);
                if (axtarilanSt != null)
                {
                    Console.WriteLine("Bu telebe halhazirda" + " "+ axtarilanSt.StudentGroup.GroupName + "de  oxuyur");
                    Console.WriteLine(axtarilanSt.FirstName + " " +axtarilanSt.LastName + " " + "Gurupun deyismek Isdeyirsiniz =>he ve ya yox");
                    var a = Console.ReadLine();

                    if (a == "he")
                    {
                        i.GroupStudents.Remove(axtarilanSt);
                        axtarilanSt.StudentGroup.GroupName = Gr.GroupName;
                        axtarilanSt.StudentGroup.GroupID = Gr.GroupID;
                        Gr.GroupStudents.Add(axtarilanSt);
                        Console.WriteLine(axtarilanSt.FirstName + " " + axtarilanSt.LastName + "  qurupu " + Gr.GroupName +" olaraq deyisdirildi ");
                        Console.WriteLine("Bu telebe artiq" + " " + axtarilanSt.StudentGroup.GroupName + "de  oxuyur");
                    }
                    else break;


                }
                //
                
                
            }
            //mellime sual ver 
            st.StudentGroup = Gr ;
            Gr.GroupStudents.Add(st);
            Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.StudentGroup.GroupName + "qurupuna  elave olundu");

        }

        public static void AddStudent(List<Student> GrupsAddStdents, Group Gr)
        {

            if (Gr.GroupStudents == null)
            {
                Gr.GroupStudents = GrupsAddStdents;
            }
            else
            {
                Gr.GroupStudents = (Gr.GroupStudents.Concat(GrupsAddStdents)).ToList();
            }


        }

        public static void AddTeacher(Teacher adTeacher, Group Gr)
        {
            var tc = Curs.CursTeachers.Find(f => f.TeacherID == adTeacher.TeacherID);
            var gr = Curs.Groups.Find(f => f.GroupID == Gr.GroupID);
            if (gr.GroupTeacher == null)
            {
                gr.GroupTeacher = tc;
                tc.TeacherGroups.Add(gr);
            }
            else
            {
                Console.WriteLine("{0} qurupunun muellimi {1} {2} muellimdir qurupun muellimin deyismek isdeyirsiz/ he ve ya yox",gr.GroupName,gr.GroupTeacher.FirstName,gr.GroupTeacher.LastName);
                Console.WriteLine("===============================================");
                var a = Console.ReadLine();
                if (a=="he")
                {
                    gr.GroupTeacher = tc;
                    tc.TeacherGroups.Add(gr);
                    Console.WriteLine("Bu qurupun Meullimi Artiq {0}  {1}  muellimdir", tc.FirstName, tc.LastName);
                    Console.WriteLine("===============================================");
                }
            }
           
        }


    }
}
