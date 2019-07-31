using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class TeacherController
    {
        public static void Creat (string _frname,string _lsname,int _age)
        {
            if (Curs.CursTeachers == null)
            {
                Teacher newTchr = new Teacher(1, _frname, _lsname, _age);
                Curs.CursTeachers.Add(newTchr);
                information(newTchr);
            } 
            else
            {
                var maxID = Curs.CursTeachers.Max(m => m.TeacherID);
                Teacher newTchr = new Teacher(maxID+1, _frname, _lsname, _age);
                Curs.CursTeachers.Add(newTchr);
                information(newTchr);
            }
        }
    //delet
        public static void delet(Teacher dltTeacher)
        {
            var dltTch = Curs.CursTeachers.Find(f => f.TeacherID == dltTeacher.TeacherID);

            if (dltTch == null)
            {
                Console.WriteLine("Bele Mellim yoxdur");
            }
            else
            {
                Curs.CursTeachers.Remove(dltTch);
                Console.WriteLine("Muellim {0} {1}  Cursdan Silindi Asagidaki Quruplarda ve ya Qurupda Muellim Yoxdur", dltTch.FirstName, dltTch.LastName);
                foreach (var i in dltTch.TeacherGroups)
                {
                    var tchGroup = Curs.Groups.FirstOrDefault(f => f.GroupID == i.GroupID);
                    tchGroup.GroupTeacher = null;
                    Console.WriteLine("ID=>"+tchGroup.GroupID +" " +"Qurup Adi=>"+ tchGroup.GroupName);
                

                }

            }
        }

        //information
        public static void information(Teacher newTeacher)
        {
            Console.WriteLine(" Muellim:\n ID:{0} \t Ad:{1}\t Soy Ad:{2} \t Yas:{3} ", newTeacher.TeacherID, newTeacher.FirstName, newTeacher.LastName, newTeacher.Age);
            foreach(var j in newTeacher.TeacherGroups)
            {
                if (newTeacher.TeacherGroups==null)
                {
                    Console.WriteLine("Bu muellim hal hazirdaa hec bir qurupda ders demir");
                }
                else
                {
                    Console.WriteLine("Mellimin Asagidaki Quruplarda ders deyir");
                    Console.WriteLine("ID:{0} Gurup Adi:{1}",j.GroupID,j.GroupName);
                    Console.WriteLine("============================================================");

                }
            }
        }

        //All Teacher Show

        public static void AllTeacher()
        {
            foreach (var i in Curs.CursTeachers)
            {
                // Console.WriteLine("ID:=>{0} Ad:=>{1} Soy Ad {2}", i.TeacherID, i.FirstName, i.LastName);
                information(i);
                Console.WriteLine("============================================================");

            }
        }
    }
}
