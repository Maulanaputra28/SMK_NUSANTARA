using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK_NUSANTARA.Helper
{
    public static class Student
    {
        private static readonly SqlConnection conn = ConnectionSql.GetConnection();
        /*public static int subId {get; set; } */

        public static DataTable StudentList
        {
            get
            {
                ConnectionSql.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select StudentID, Name, Address, Gender, DateofBirth, NoHp from Student", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        /*public static string NameSub
        {
            get
            {
                string name = "";
                ConnectionSql.OpenConnection();
                //List<string> SubInfolist = new List<string>();
                SqlCommand cmd = new SqlCommand("select * from Subject where SubjectID = @sid", conn);
                cmd.Parameters.AddWithValue("@sid", subId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["Name"].ToString();
                        //string description = reader["Description"].ToString();
                        //SubInfolist.Add(name, description);
                    }
                    reader.Close();
                }
                return name;
            }
            *//*set
            {

            }*//*
        }*/

        public static string studentId {  get; set; }  
        public static string name { get; set; }
        public static string address { get; set; }
        public static string gander { get; set; }
        public static DateTime dateOfBirth { get; set; }
        public static string noHp { get; set; }
    }

    /*class DetailStudent
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        public DataTable Atribut
        {
            get
            {
                   
            }
        }

    }*/
}
