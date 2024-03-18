using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SMK_NUSANTARA.Dto;
using SMK_NUSANTARA.Helper;

namespace SMK_NUSANTARA
{
    public partial class FrmLogin : Form
    {
        string title = "Form Login";
        public FrmLogin()
        {
            InitializeComponent();
            //Student.Username = textBoxUsername.Text;
            
            //tAddrs.Teacher = textBoxUsername.Text;

        }

        /*public static class Student
        {
            public static string Username { get; set; }

        }*/

        private void login()
        {
            User user = new User();
            User.Username = textBoxUsername.Text;
            User.Password = textBoxPassword.Text;
            /*string nama = string.Join(",", user.Teacher);
            MessageBox.Show(nama);*/

            /*foreach (var data in user.Teacher)
            {
            }*/
            /*user.StudentId = textBoxUsername.Text;
            MessageBox.Show(user.StudentId);
            MessageBox.Show(user.Teacher);*/
            //user.Teacher = textBoxUsername.Text;



            SqlConnection conn = ConnectionSql.GetConnection();
            ConnectionSql.OpenConnection();
            DataTable dt = user.Login;
            string username = textBoxUsername.Text;
            /* string className;
             int studentId = 0;*/
            //user.Login.Fill(dt);

            user.dtLogin = dt;
            string role = user.atribut;


            if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
            {
                SnippetMbox.Error(title, "All fields must be filled");
            }
            else if (role == "Teacher")
            {
                /*SqlCommand cmd = new SqlCommand("select TeacherID from Userrr where Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int teacherId = reader.GetInt32(0);
                        Dto.User.TeacherId = teacherId;

                    }
                    reader.Close();
                }*/

                TeacherNav teachNav = new TeacherNav();
                teachNav.Show();
                SnippetMbox.Information(title, "Login Sucsses");
                this.Hide();
            }
            else if (role == "Student")
            {
                /*SqlCommand cmd = new SqlCommand("select StudentID from Userrr where Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        studentId = reader.GetInt32(0);
                        Dto.User.StudentId = studentId;

                    }
                    reader.Close();
                }*/
                StudentNav stdntNav = new StudentNav();
                stdntNav.Show();
                SnippetMbox.Information(title, "Login Sucsses");
                this.Hide();

                /*SqlCommand cls = new SqlCommand($"select ClassName from Student where StudentID = {Dto.User.StudentId}", conn);
                using (SqlDataReader rCls = cls.ExecuteReader())
                {
                    if (rCls.Read())
                    {
                        className = rCls.GetString(0);
                        Dto.User.ClassName = className;
                    }
                }*/
            }
            else if (role == "Admin")
            {
                AdminNav adminNav = new AdminNav(username);
                adminNav.Show();
                SnippetMbox.Information(title, "Login Sucsses");
                this.Hide();
            }


            /*else if (role == "Teacher")
            {
                string role = dt.Rows[0]["Role"].ToString();
                if (role == "Teacher")
                {
                    
                }
                else if(role == "Student")
                {
                    SqlCommand cmd = new SqlCommand("select StudentID from Userrr where Username = @Username", conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentId = reader.GetInt32(0);
                            Dto.User.StudentId = studentId;
                            
                        }
                        reader.Close();
                        StudentNav stdntNav = new StudentNav();
                        stdntNav.Show();
                        SnippetMbox.Information(title, "Login Sucsses");
                        this.Hide();
                    }

                    SqlCommand cls = new SqlCommand($"select ClassName from Student where StudentID = {Dto.User.StudentId}", conn);
                    using (SqlDataReader rCls = cls.ExecuteReader())
                    {
                        if (rCls.Read())
                        {
                            className = rCls.GetString(0);
                            Dto.User.ClassName = className;
                        }
                    }
                }else if (role == "Admin")
                {
                    AdminNav adminNav = new AdminNav(username);
                    adminNav.Show();
                    SnippetMbox.Information(title, "Login Sucsses");
                    this.Hide();
                }
                User tAddrs = new User();
                tAddrs.TeacherId = textBoxUsername.Text;
                MessageBox.Show("address  : "+tAddrs.TeacherId);
            }*/
            /*else if (dt.Rows[0]["Role"].ToString() == "Student")
            {
               
                StudentNav stdntNav = new StudentNav();
                stdntNav.Show();
                SnippetMbox.Information(title, "Login Sucsses");
                this.Hide();
            }
            else if (dt.Rows[0][5].ToString() == "Admin")
            {
                AdminNav adminNav = new AdminNav();
                adminNav.Show();
                SnippetMbox.Information(title, "Login Sucsses");
                this.Hide();
            }*/

            textBoxPassword.Text = "";
            textBoxUsername.Text = "";


            /* SqlCommand cmd = new SqlCommand("select StudentID from Userrr where Username = '"+textBoxUsername+"'", conn);
             int studentId = 0;

             using (SqlDataReader reader = cmd.ExecuteReader())
             {
                 if (reader.Read())
                 {
                     studentId = Convert.ToInt32(reader["ID"]);
                 }
             }
 */


            ConnectionSql.CloseConnection();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
