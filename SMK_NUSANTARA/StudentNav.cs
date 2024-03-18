using SMK_NUSANTARA.Dto;
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

namespace SMK_NUSANTARA
{
    public partial class StudentNav : Form
    {
        //private int receivedData;
        SqlConnection conn = ConnectionSql.GetConnection();
        public StudentNav(/*int studentId*/)
        {
            InitializeComponent();
            //receivedData = studentId;
        }

        private void StudentNav_Load(object sender, EventArgs e)
        {
            ConnectionSql.OpenConnection();
            //int studentId = receivedData;
            //cmd.Parameters.AddWithValue("@StudentID", studentId);
            /*SqlCommand cmd = new SqlCommand($"select Name from Student where StudentID = {Dto.User.StudentId}", conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    labelStudentName.Text = name;
                }
                reader.Close();
            }*/

            User name = new User();
            string studentName = name.Name;
            labelStudentName.Text = studentName;
            name.Student = studentName;
             Schedule.ClsNme = name.Student;

            //MessageBox.Show(name.Student);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin formLgn = new FrmLogin();
            formLgn.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            FrmViewSchedule frmSchdle = new FrmViewSchedule();
            frmSchdle.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditProfile frmSchdle = new FormEditProfile();
            frmSchdle.Show();
        }
    }
}
