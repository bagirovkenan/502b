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

    static class write
    {
        public static object achar = new object();

        public static void dbwrite(List<string> d)
        {
            Task task2 = Task.Run(() =>
            {

                foreach (var i in d)
                {
                    lock (achar)
                    {
                        using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                        {

                            StringBuilder sb = new StringBuilder();
                            connect.Open();

                            sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + i + "');");
                            SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                            var sdr = cam.ExecuteNonQuery();

                        }

                    }

                }
            });
            //=================================================================

            Task task3 = Task.Run(() =>
            {

                foreach (var i in d)
                {
                    lock (achar)
                    {
                        using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                        {

                            StringBuilder sb = new StringBuilder();
                            connect.Open();

                            sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + i + "');");
                            SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                            var sdr = cam.ExecuteNonQuery();

                        }


                    }

                }
            });

            //=================================================================

            Task task4 = Task.Run(() =>
            {

                foreach (var i in d)
                {
                    lock (achar)
                    {
                        using (SqlConnection connect = new SqlConnection(@"Data Source=KENAN\SQLEXPRESS;Initial Catalog=Item;Integrated Security=True"))
                        {

                            StringBuilder sb = new StringBuilder();
                            connect.Open();

                            sb.Append("Insert into [Item].[dbo].[itm] (Item) values('" + i + "');");
                            SqlCommand cam = new SqlCommand(sb.ToString(), connect);
                            var sdr = cam.ExecuteNonQuery();



                        }

                    }

                }

            });
            //=================================================================
            Task.WaitAll(task2, task3, task4);
        }
    }


}
