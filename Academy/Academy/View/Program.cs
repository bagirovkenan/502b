using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {


            //static telebeler
            Student st1 = new Student(1, "Hesen", "Hesenov", 21);
            Student st2 = new Student(2, "Eli", "Eliyev", 20);
            Student st3 = new Student(3, "Veli", "Veliyev", 23);


            //static mellimler
            Teacher tc1 = new Teacher(1, "Ilkin", "Vahubov", 25);
            tc1.GrubSayi = 1;

            Teacher tc2 = new Teacher(2, "Ilqar", "Soltanov", 35);
            tc2.GrubSayi = 1;

            Teacher tc3 = new Teacher(3, "Cahangir", "Salmanov", 33);
            tc3.GrubSayi = 1;


            //static gruplar
            Group gr1 = new Group(1, "p502");
            gr1.GroupTeacher = tc1;
            gr1.GroupStudents.Add(st1);
            st1.StudentGroup = gr1;
            tc1.TeacherGroups.Add(gr1);

            Group gr2 = new Group(2, "p503");
            gr2.GroupTeacher = tc2;
            gr2.GroupStudents.Add(st2);
            st2.StudentGroup = gr2;
            tc2.TeacherGroups.Add(gr2);


            Group gr3 = new Group(3, "p504");
            gr3.GroupTeacher = tc3;
            gr3.GroupStudents.Add(st3);
            st3.StudentGroup = gr3;
            tc3.TeacherGroups.Add(gr3);


            //static curs
            Curs Cd = new Curs(1, "Cod");

            //cursa static telebe artir
            Curs.CursStudent.Add(st1);
            Curs.CursStudent.Add(st2);
            Curs.CursStudent.Add(st3);

            //cursa static mellim artir

            Curs.CursTeachers.Add(tc1);
            Curs.CursTeachers.Add(tc2);
            Curs.CursTeachers.Add(tc3);

            //cursa static grup artir

            Curs.Groups.Add(gr1);
            Curs.Groups.Add(gr2);
            Curs.Groups.Add(gr3);


            //3 telebe 3 mellim 3 qurup  her qurupda 1 mellim 1 telebe   

            //=========================================================================================================================


            while (true)
            {//w
                try
                {
                    Console.WriteLine("Etmek isdediyiniz emeliyyatin qarsisindaki reqemi secin");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("1=>Telebe Artir");
                    Console.WriteLine("2=>Muellim Artir");
                    Console.WriteLine("3=>Gurup Artir");
                    Console.WriteLine("4=>Qurupa Telebe  Elave Et");
                    Console.WriteLine("5=>Qurupa Muellim Elave Et");
                    Console.WriteLine("6=>Butun Telebeleri Gorsed");
                    Console.WriteLine("7=>Butun Muellimleri Gorsed");
                    Console.WriteLine("8=>Butun Quruplari Gorsed");
                    Console.WriteLine("9=>Telebe Sil");
                    Console.WriteLine("10=>Muellim Sil");
                    Console.WriteLine("11=>Qurupu Sil");
                    Console.WriteLine("============================================================");


                    var SecilenEmeliyyat = int.Parse(Console.ReadLine());

                    if (SecilenEmeliyyat == 1) //telebe elave et
                    {
                        Console.Write("Ad:");
                        var Ad = Console.ReadLine();
                        Console.Write("Soyad:");
                        var SoyAd = Console.ReadLine();
                        Console.Write("Yas:");
                        var Yas = int.Parse(Console.ReadLine());
                        StudentController.Creat(Ad, SoyAd, Yas);
                    }

                    else if (SecilenEmeliyyat == 2)
                    {
                        Console.Write("Muellim Ad:");
                        var Ad = Console.ReadLine();
                        Console.Write("Muellim Soyad:");
                        var SoyAd = Console.ReadLine();
                        Console.Write("Muellim Yas:");
                        var Yas = int.Parse(Console.ReadLine());
                        TeacherController.Creat(Ad, SoyAd, Yas);
                    }

                    else if (SecilenEmeliyyat == 3)
                    {
                        Console.Write("Qurup Adi:");
                        var Ad = Console.ReadLine();
                        GroupController.Creat(Ad);
                    }

                    else if (SecilenEmeliyyat == 4)
                    {
                        StudentController.AllStudent();
                        Console.WriteLine("Telebenin ID-ni sec");
                        var secilenTelebeID = int.Parse(Console.ReadLine());
                        try
                        {
                            var secilenTelebe = Curs.CursStudent.Find(f => f.StudentID == secilenTelebeID);
                            if (secilenTelebe == null)
                            {
                                Console.WriteLine("Bele Telebe Yoxdur");
                            }
                            else
                            {
                                GroupController.AllGroup();
                                Console.WriteLine("Qurupun  ID sini secin");
                                var secilenGurupID = int.Parse(Console.ReadLine());
                                try
                                {
                                    var SecilenGrup = Curs.Groups.Find(f => f.GroupID == secilenGurupID);
                                    if (SecilenGrup == null)
                                    {
                                        Console.WriteLine("Bele qurup Yoxdur");
                                        Console.WriteLine("===============================================");

                                    }
                                    else
                                    {
                                        GroupAdd.AddStudent(secilenTelebe, SecilenGrup);
                                        Console.WriteLine("===============================================");
                                        GroupController.groupInformation(SecilenGrup);
                                        Console.WriteLine("===============================================");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Duzgun Secim Edin");
                                    Console.WriteLine("===============================================");

                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun Secim Edin");
                            Console.WriteLine("===============================================");

                        }

                    }
                    else if (SecilenEmeliyyat == 5)
                    {
                        TeacherController.AllTeacher();
                        Console.WriteLine("Muellimin ID-ni sec");
                        var secilenMuellimID = int.Parse(Console.ReadLine());
                        try
                        {
                            var secilenMuellim = Curs.CursTeachers.Find(f => f.TeacherID == secilenMuellimID);
                            if (secilenMuellim == null)
                            {
                                Console.WriteLine("Bele Muellim Yoxdur");
                            }
                            else
                            {
                                GroupController.AllGroup();
                                Console.WriteLine("Qurupun  ID sini secin");
                                var secilenGurupID = int.Parse(Console.ReadLine());
                                try
                                {
                                    var SecilenGrup = Curs.Groups.Find(f => f.GroupID == secilenGurupID);
                                    if (SecilenGrup == null)
                                    {
                                        Console.WriteLine("Bele qurup Yoxdur");
                                        Console.WriteLine("===============================================");

                                    }
                                    else
                                    {
                                        GroupAdd.AddTeacher(secilenMuellim, SecilenGrup);
                                        Console.WriteLine("===============================================");
                                        GroupController.groupInformation(SecilenGrup);
                                        Console.WriteLine("===============================================");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Duzgun Secim Edin");
                                    Console.WriteLine("===============================================");

                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun Secim Edin");
                            Console.WriteLine("===============================================");
                        }
                    }
                    else if (SecilenEmeliyyat == 6)
                    {
                        StudentController.AllStudent();
                    }
                    else if (SecilenEmeliyyat == 7)
                    {
                        TeacherController.AllTeacher();
                    }
                    else if (SecilenEmeliyyat == 8)
                    {
                        GroupController.AllGroup();
                    }
                    else if (SecilenEmeliyyat == 9)
                    {

                        StudentController.AllStudent();
                        Console.WriteLine("Telebenin ID-ni sec");
                        var secilenTelebeID = int.Parse(Console.ReadLine());
                        try
                        {
                            var secilenTelebe = Curs.CursStudent.Find(f => f.StudentID == secilenTelebeID);
                            if (secilenTelebe == null)
                            {
                                Console.WriteLine("Bele Telebe Yoxdur");
                            }
                            else
                            {
                                StudentController.deletStudent(secilenTelebe);
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Duzgun Secim Edin");
                            Console.WriteLine("===============================================");
                        }
                    }
                    else if (SecilenEmeliyyat == 10)
                    {
                        TeacherController.AllTeacher();
                        Console.WriteLine("Muellimin ID-ni sec");
                        var secilenMuellimID = int.Parse(Console.ReadLine());
                        try
                        {
                            var secilenMuellim = Curs.CursTeachers.Find(f => f.TeacherID == secilenMuellimID);
                            if (secilenMuellim == null)
                            {
                                Console.WriteLine("Bele Muellim Yoxdur");
                            }
                            else
                            {
                                TeacherController.delet(secilenMuellim);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun Secim Edin");
                            Console.WriteLine("===============================================");
                        }

                    }

                    else if (SecilenEmeliyyat == 11)
                    {
                        GroupController.AllGroup();
                        Console.WriteLine("Qurupun  ID sini secin");
                        var secilenGurupID = int.Parse(Console.ReadLine());
                        try
                        {
                            var SecilenGrup = Curs.Groups.Find(f => f.GroupID == secilenGurupID);
                            if (SecilenGrup == null)
                            {
                                Console.WriteLine("Bele qurup Yoxdur");
                                Console.WriteLine("===============================================");

                            }
                            else
                            {
                                GroupController.delet(SecilenGrup);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun Secim Edin");
                            Console.WriteLine("===============================================");
                        }

                    }

                }
                catch
                {
                    Console.WriteLine("Duzgun Secim Edin");
                    Console.WriteLine("===============================================");
                }
            }//w

        }
    }
}
