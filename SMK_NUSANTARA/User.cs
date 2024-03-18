using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security;
using System.Net.Sockets;

namespace SMK_NUSANTARA
{
    class User
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        private string Username1;
        //private string[] TeacherData;
        public static string Username { get; set; }
        public static string Password { get; set; }

        public DataTable dtLogin;

        public DataTable Login
        {
            get
            {
                ConnectionSql.OpenConnection();
                SqlDataAdapter sda = new SqlDataAdapter($"select * from Userrr where Username = @Username and password = @Password", conn);
                sda.SelectCommand.Parameters.AddWithValue("@Username", Username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", Password);
                DataTable dtLogin = new DataTable();
                sda.Fill(dtLogin);

                return dtLogin;
            }
        } 

        public string atribut
        {
            get
            {
                string role = "";
                DataTable dt = dtLogin;
                if (dt.Rows.Count > 0)
                {
                    role = dt.Rows[0]["Role"].ToString();
                }
                return role;
            }
        }

        /*conn.Open();
        SqlCommand cmd = new SqlCommand("select * from Userrr where Username = @Username and Password = @Password",conn);
        cmd.Parameters.AddWithValue("@Username", Username);
        cmd.Parameters.AddWithValue("@Password", Password);

        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            if (rdr.Read())
            {
                data = rdr.ToString();
            }
            rdr.Close();
        }
        conn.Close();*/

        public string Student
        {
            get
            {
                string data = "";
                SqlCommand cmd = new SqlCommand("Select * from Student where Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", Username1);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        data = reader["ClassName"].ToString();
                    }
                    reader.Close();
                }
                return data;
            }
            set
            {
                Username1 = value;
            }
        }

        public int StudentId
        {
            get
            {
                int id = 0;
               // conn.Open();
                SqlCommand cmd = new SqlCommand("select StudentID from userrr where Username = @name and Password = @pass", conn);
                cmd.Parameters.AddWithValue("@name", Username);
                cmd.Parameters.AddWithValue("@pass", Password);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {   
                    if (reader.Read())
                    {
                        id = reader.GetInt32(reader.GetOrdinal("StudentID"));
                    }
                    reader.Close();
                }
                //conn.Close();
                return id;
            }
        }

        public string Name
        {
            get
            {
                int dataTeacher = 0;
                int dataStudent = 0;
                string name = "";

                ConnectionSql.OpenConnection();
                SqlCommand cmd = new SqlCommand($"SELECT ISNULL(TeacherID, 0) AS TeacherID, ISNULL(StudentID, 0) AS StudentID from Userrr where Username = @n", conn);
                cmd.Parameters.AddWithValue("@n", Username);
                //cmd.Parameters.AddWithValue("@Password", pswrd);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dataTeacher = reader.GetInt32(reader.GetOrdinal("TeacherID"));
                        dataStudent = reader.GetInt32(reader.GetOrdinal("StudentID"));
                    }
                    reader.Close();
                    if (dataTeacher > 0)
                    {
                        SqlCommand cmd1 = new SqlCommand("select Name from Teacher where TeacherID = @TeacherId", conn);
                        cmd1.Parameters.AddWithValue("@TeacherId", dataTeacher);
                        using (SqlDataReader reader2 = cmd1.ExecuteReader())
                        {
                            if (reader2.Read())
                            {
                                name = reader2.GetString(0);
                            }
                            reader2.Close();
                        } 
                    }else if (dataStudent > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("select Name from Student where StudentID = @StudentId", conn);
                        cmd2.Parameters.AddWithValue("@StudentId", dataStudent);
                        using (SqlDataReader reader3 = cmd2.ExecuteReader())
                        {
                            if (reader3.Read())
                            {
                                name = reader3.GetString(0);
                            }
                        }
                    }
                }
                return name;
            }
        }
         

        public int[] TeacherID
        {
            get
            {
                int[] dataArray;
                int teacherId = 0;
                List<int> listResult = new List<int>();

                ConnectionSql.GetConnection();

                SqlCommand cmd = new SqlCommand("select TeacherID from Teacher", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teacherId = reader.GetInt32(0);
                        listResult.Add(teacherId);
                    }
                    reader.Close();
                    dataArray = listResult.ToArray();
                }
                return dataArray;
            }
        }
         


        public string[] Teacher
        {
            get
            {
                string[] dataArray;
                string name= "";
                int teacherId = 0;
                List<string> listResult = new List<string>();

                ConnectionSql.OpenConnection();


                SqlCommand cmd2 = new SqlCommand("Select * from Teacher", conn);
                cmd2.Parameters.AddWithValue("@tchrId", teacherId);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["Name"].ToString();
                        listResult.Add(name);
                    }
                    reader.Close();
                    dataArray = listResult.ToArray();
                }


                return dataArray;
            }
        }

        public string[] Gender
        {
            get
            {
                string[] dataArray;
                string name = "";
                int teacherId = 0;
                List<string> listResult = new List<string>();

                ConnectionSql.OpenConnection();


                SqlCommand cmd2 = new SqlCommand("Select * from Teacher", conn);
                cmd2.Parameters.AddWithValue("@tchrId", teacherId);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["Gender"].ToString();
                        listResult.Add(name);
                    }
                    reader.Close();
                    dataArray = listResult.ToArray();
                }
                return dataArray;
            }
        }

        public string[] Address
        {
            get
            {
                string[] dataArray;
                string address = "";
                List<string> listAddress = new List<string>();

                ConnectionSql.OpenConnection();
                SqlCommand cmdAddrss = new SqlCommand("select Address from Teacher", conn);

                using (SqlDataReader reader = cmdAddrss.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        address = reader["address"].ToString();
                        listAddress.Add(address);
                    }
                    reader.Close();
                    dataArray = listAddress.ToArray();
                    ConnectionSql.CloseConnection();
                }
                return dataArray;
            }
        }
        /*public List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            return list;
        }*/
    }
}
