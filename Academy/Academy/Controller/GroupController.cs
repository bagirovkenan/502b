using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class GroupController
    {
        //creat
        public  static void Creat(string _GroupName)

        {
            if (Curs.Groups == null)
            {
                Group newGrup = new Group(1, _GroupName);
                Curs.Groups.Add(newGrup);
                Show(newGrup);
            }
            else
            {
                var maxID = Curs.Groups.Max(m => m.GroupID);
                Group newGrup = new Group(maxID+1, _GroupName);
                Curs.Groups.Add(newGrup);
                Show(newGrup);
            }
        }


//delet
        public static void delet(Group dltGr)
        {
            var DltGroup = Curs.Groups.Find(f => f.GroupID == dltGr.GroupID);
            if (DltGroup == null)
            {
                Console.WriteLine("Bele Grup Yoxdur");
            }
            else
            {
                Curs.Groups.Remove(DltGroup);
                Console.WriteLine("===============================================");
                Console.WriteLine("{0} Qurupu   ve o qurupda tehsil alan asagidaki telebeler  cursdan silindi", DltGroup.GroupName);
                foreach (var j in DltGroup.GroupStudents)
                {
                    var dltGoupStudent = Curs.CursStudent.Find(f => f.StudentID == j.StudentID);
                    Curs.CursStudent.Remove(dltGoupStudent);
                    Console.WriteLine("ID=>{0}  Ad=>{1} Soy Ad=>{1}", dltGoupStudent.StudentID,dltGoupStudent.FirstName,dltGoupStudent.LastName);
                    Console.WriteLine("===============================================");
                }

                var dltGroupTeacher = Curs.CursTeachers.Find(f => f.TeacherID == DltGroup.GroupTeacher.TeacherID);
                dltGroupTeacher.TeacherGroups.Remove(DltGroup);
                if (dltGroupTeacher.TeacherGroups.Count == 0)
                {
                    Curs.CursTeachers.Remove(dltGroupTeacher);
                    Console.WriteLine("{0} Qurupu Silindiyi Ucun Asagidaki Muellim Muveqqeti Olaraq Kursdan Silindi\n ID=>{1}, Ad=>{2} Soy Ad=>{3}", DltGroup.GroupName, dltGroupTeacher.TeacherID, dltGroupTeacher.FirstName, dltGroupTeacher.LastName);
                    Console.WriteLine("===============================================");
                }
                else
                {
                    Console.WriteLine("{0} qurupu silindiyi ucun {1} {2} Melimin quruplarindan cixarildi", DltGroup, dltGroupTeacher.FirstName, dltGroupTeacher.LastName);
                    Console.WriteLine("===============================================");
                }
            }
        }

        //show group information 
        public static void groupInformation(Group gr)
        {
            if (gr.GroupTeacher == null && gr.GroupStudents.Count==0)
            {
                Console.WriteLine("Bu qurupda hal-hazirda bosdur Muellim ve telebe yoxdur ");
            }
            else if (gr.GroupTeacher != null && gr.GroupStudents.Count == 0)
            {
                Console.WriteLine("Bu qurupun Muellimi {0} {1} muellimdir ama telebesi heleki yoxdur",gr.GroupTeacher.LastName,gr.GroupTeacher.FirstName);

            }
            else if (gr.GroupTeacher == null && gr.GroupStudents.Count >0)
            {
                Console.WriteLine("Bu qurupda {0}  telebe var ve telebelerin adlari asagidakilardir amma mellim yoxdur", gr.GroupStudents.Count);
                foreach(var i in gr.GroupStudents)
                {
                    Console.WriteLine(i.FirstName + " " + i.LastName);
                }
            }
            else if (gr.GroupTeacher != null && gr.GroupStudents.Count > 0)
            {
                Console.WriteLine(" Qurupun Muellimi {1} {2}  ve Bu qurupda {0} telebe var  telebelerin adlari asagidakilardir ", gr.GroupStudents.Count, gr.GroupTeacher.LastName, gr.GroupTeacher.FirstName);

                foreach (var i in gr.GroupStudents)
                {
                    Console.WriteLine("Telebe=>" +  i.FirstName + " " + i.LastName);
                }
            }
            else
            {
                Console.WriteLine("Melumat yoxdur");
            }
        }

        //show
        public static void Show(Group newGroup)
        {
            Console.WriteLine(" Grup:\n ID:{0} \t Qurupun Adi:{1}", newGroup.GroupID, newGroup.GroupName);
            Console.WriteLine("Qurup Haqqinda Melumat");
            groupInformation(newGroup);
        }

        //all groupshow
        public static void AllGroup()
        {
            foreach(var k in Curs.Groups)
              
            {
                Console.WriteLine("===========================================================");
                Show(k);
                Console.WriteLine("===========================================================");
            }
        }


    }
}
