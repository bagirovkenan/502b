using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlParalelFilereader
{
    class Program
    {
        static void Main(string[] args)
        {

            write.dbwrite(read.txtread());
        }


    }


    static class read
    {
        public static List<string> txtread()
        {


            List<string> list = new List<string>();

            Task task1 = Task.Run(() =>
            {
                StreamReader sr = new StreamReader("txt.txt");
                string line1;
                while ((line1 = sr.ReadLine()) != null)
                {

                    list.Add(line1);
                }
                sr.Close();
            });


            //task1.Wait();
            return list;
        }
    }
    //=================================================================

    static class write
    {
        public static object achar = new object();

        public static void dbwrite(List<string> d)
        {
            Task task2 = Task.Run(() =>
            {
                
                    for (var i = 0; i < d.Count; )
                {
                    

                    
                  //  var c = d[i];
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {


                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");

                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();
                                if (sdr > 0)
                                {
                                    d.Remove(d[i]);
                                    // Console.WriteLine(d[i]);
                                    //d.Remove(d[i]);
                                    Console.WriteLine(d.Count);
                                }




                            }

                        }

                    }
                   
                }

               
            });
            //=================================================================

            Task task3 = Task.Run(() =>
            {

                for (var i = 0; i < d.Count;)
                {
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {

                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");
                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();

                                if (sdr > 0)
                                {
                                    d.Remove(d[i]);
                                }

                            }
                        }

                    }

                }
            });

            //   =================================================================

            Task task4 = Task.Run(() =>
            {

                for (var i = 0; i < d.Count;)
                {
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {

                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");
                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();
                                if (sdr > 0)
                                {
                                    d.Remove(d[i]);
                                }


                            }

                        }

                    }

                }

            });

            Task task5 = Task.Run(() =>
            {

                for (var i = 0; i < d.Count;)
                {
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {

                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");
                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();
                                if (sdr > 0)
                                {
                                    d.Remove(d[i]);
                                }


                            }

                        }

                    }

                }

            });

            Task task6 = Task.Run(() =>
            {

                for (var i = 0; i < d.Count;)
                {
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {

                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");
                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();
                                if (sdr > 0)
                                {
                                    d.Remove(d[i]);
                                }


                            }

                        }

                    }

                }

            });

            Task task7 = Task.Run(() =>
            {

                for (var i = 0; i < d.Count;)
                {
                    lock (achar)
                    {
                        if (d.Count == 0)
                        {
                            Console.WriteLine("Elave edecek item qalmadi");
                        }
                        else
                        {
                            using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                            {

                                StringBuilder sb = new StringBuilder();
                                connect.Open();

                                sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + d[i] + "');");
                                SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                                var sdr = cam.ExecuteNonQuery();
                                if (sdr > 0) //??? 
                                {
                                    d.Remove(d[i]);
                                }


                            }

                        }

                    }

                }

            });
            // =================================================================
            Task.WaitAll(task2, task3, task4, task5, task6, task7);
        }
    }


}
