using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SMK_NUSANTARA.Helper;
using SMK_NUSANTARA.Dto;

namespace SMK_NUSANTARA
{
    public partial class ManageScheduleForm : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        string title = "Schedule Form";
        public ManageScheduleForm()
        {
            InitializeComponent();
        }

        private void ManageScheduleForm_Load(object sender, EventArgs e)
        {
            ConnectionSql.OpenConnection();
            SqlDataAdapter dta = new SqlDataAdapter("select * from HeaderSchedule",conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            dataGridView1.DataSource = dt;
            //dataGridView1.AllowUserToOrderColumns = true;

            dataGridView1.Columns["Subject"].DisplayIndex = 2;
            dataGridView1.Columns["TeacherName"].DisplayIndex = 4;
            dataGridView1.Columns["ClassName"].DisplayIndex = 6;

            List<string> dayList = new List<string>()
            {
                "Senin",
                "Selasa",
                "Rabu",
                "Kamis",
                "Jumat",
                "Sabtu"
            };

            foreach (var day in dayList)
            {
                cb_Day.Items.Add(day);
            }

            List<string> timeList = new List<string>
            {
                "08.00-12.00",
                "13.00-17.00"
            };

            foreach(var time in timeList)
            {
                cb_Time.Items.Add(time);
            }
        }

        private void LoadSchedule()
        {
            ConnectionSql.OpenConnection();
            SqlDataAdapter dta = new SqlDataAdapter("select * from HeaderSchedule", conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            dataGridView1.DataSource = dt;
            ConnectionSql.CloseConnection();
        }

        private void LoadData()
        {
            string subNme;
            string teachNme;
            string clsNme;
            ConnectionSql.OpenConnection();
            SqlCommand subject = new SqlCommand($"select Name from Subject where SubjectID = {Schedule.SubjectId}", conn);
            SqlCommand teacher = new SqlCommand($"select Name from Teacher where TeacherID = {Schedule.TeacherId}", conn);
            SqlCommand cls = new SqlCommand($"select Name from Class where ClassID = {Schedule.ClassId}", conn);
            using (SqlDataReader rSub = subject.ExecuteReader())
            {
                if (rSub.Read())
                {
                subNme = rSub.GetString(0);
                Schedule.Subject = subNme;
                }
                rSub.Close();
            }
            using(SqlDataReader rTeach = teacher.ExecuteReader())
            {
                if (rTeach.Read())
                {
                teachNme = rTeach.GetString(0);
                Schedule.Teacher = teachNme;
                }
                rTeach.Close();
            }
            using(SqlDataReader rCls = cls.ExecuteReader())
            {
                if (rCls.Read())
                {
                clsNme = rCls.GetString(0);
                Schedule.Class = clsNme;
                }
                rCls.Close();
            }
        } 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            LoadData();
            ConnectionSql.OpenConnection();
            
            SqlCommand cmd = new SqlCommand("insert into HeaderSchedule(SubjectID, TeacherID, ClassID, Subject, TeacherName, ClassName, Day, Time) values (@Sub, @Teach, @Cls, @SubNme, @TeachNme, @ClsNme, @Day, @Time)", conn);
            cmd.Parameters.AddWithValue("@Sub", Schedule.SubjectId);
            cmd.Parameters.AddWithValue("@Teach", Schedule.TeacherId);
            cmd.Parameters.AddWithValue("@Cls", Schedule.ClassId);
            cmd.Parameters.AddWithValue("@SubNme", Schedule.Subject);
            cmd.Parameters.AddWithValue("@TeachNme", Schedule.Teacher);
            cmd.Parameters.AddWithValue("@ClsNme", Schedule.Class);
            cmd.Parameters.AddWithValue("@Day", Schedule.Day);
            cmd.Parameters.AddWithValue("@Time", Schedule.Time);
            cmd.ExecuteNonQuery();
            LoadSchedule();
            SnippetMbox.Information(title, "Succsess");
        }

        private void tb_SubjectID_TextChanged(object sender, EventArgs e)
        {
            Schedule.SubjectId = tb_SubjectID.Text;
        }

        private void tb_TeacherID_TextChanged(object sender, EventArgs e)
        {
            Schedule.TeacherId = tb_TeacherID.Text;
        }

        private void tb_ClassID_TextChanged(object sender, EventArgs e)
        {
            Schedule.ClassId = tb_ClassID.Text;
        }

        private void cb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule.Day = cb_Day.Text;
        }

        private void cb_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule.Time = cb_Time.Text;
        }
    }
}
