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
using System.Data.Common;
using SMK_NUSANTARA.Helper;
using SMK_NUSANTARA.Dto;

namespace SMK_NUSANTARA.Dto
{
    public partial class MngClassForm : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        string title = "Manage Class";
        public MngClassForm()
        {
            InitializeComponent();
        }

        private void LoadStudent()
        {
            ConnectionSql.OpenConnection();
            SqlDataAdapter dta1 = new SqlDataAdapter($"select StudentID, Name from Student where ClassName is NULL", conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);

            dataGridView2.DataSource = dt1;
            ConnectionSql.CloseConnection();
        }

        private void LoadStudentList()
        {
            ConnectionSql.OpenConnection();
            SqlDataAdapter dta1 = new SqlDataAdapter($"select StudentID, Name from Student where ClassName = '" + comboBox1.Text + "'", conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);

            dataGridView1.DataSource = dt1;
        }

        private void MngClassForm_Load(object sender, EventArgs e)
        {
            ConnectionSql.OpenConnection();
            SqlCommand ClsName = new SqlCommand("select Name from Class", conn);
            SqlDataReader ClsDtReader = ClsName.ExecuteReader();

            while (ClsDtReader.Read())
            {
                string clsName = ClsDtReader["Name"].ToString();
                comboBox1.Items.Add(clsName);
            }

            ClsDtReader.Close();
            LoadStudent();
            LoadStudentList();
        }

        private void btnStdntLst_Click(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            bool valAlreadyStudent = false;
            string clsNme = comboBox1.Text;
            //  string nameClass = comboBox1.Text;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StudentID"].Value != null && Convert.ToInt32(row.Cells["StudentID"].Value) == selectedId)
                {
                    valAlreadyStudent = true; break;
                }
            }

            if (clsNme != "")
            {
                if (valAlreadyStudent)
                {
                    SnippetMbox.Information(title, "Sudah ada di kelas lain  ");
                }
                else
                {

                ConnectionSql.OpenConnection();

                SqlCommand cmd = new SqlCommand($"update Student set ClassName = @ClasName where StudentID = {selectedId}", conn);
                    cmd.Parameters.AddWithValue("@ClasName", clsNme);
                cmd.ExecuteNonQuery();
                    

                    Schedule.ClsNme = comboBox1.Text;
                    User user = new User();
                    dataGridView2.CurrentRow.Selected = true;
                    int StudentId = Convert.ToInt32(dataGridView2.CurrentRow.Cells["StudentID"].Value);

                    int[] schIds = Schedule.Scheduleid;
                    foreach (var ids in schIds)
                    {
                        conn.Open();
                        SqlCommand cmdd = new SqlCommand("insert into DetailSchedulee values(@schId, @stdntId)", conn);
                        cmdd.Parameters.AddWithValue("@schId", ids);
                        cmdd.Parameters.AddWithValue("stdntId", StudentId);
                        cmdd.ExecuteNonQuery();

                        conn.Close();
                    }
                SnippetMbox.Information(title, "Succsess");
                }
            }else
            {
                SnippetMbox.Error(title, "Select class first");
            }



            //SqlCommand cmd2 = new SqlCommand($"select StudentID from Detail_class where ClassID = {Class.ClassID}", conn);
            LoadStudent();
            LoadStudentList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ClsName = comboBox1.Text;
            int classId = 0;
            string className;
            ConnectionSql.OpenConnection();
            /*SqlCommand cmd = new SqlCommand("select ClassID from Class where Name = @Name", conn);
            cmd.Parameters.AddWithValue("@Name", ClsName);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    classId = reader.GetInt32(0);
                    Class.ClassID = classId;
                }
                reader.Close();
            }*/

            /*SqlCommand clsName = new SqlCommand($"select Name from Class where ClassID = {Class.ClassID}", conn);
            using (SqlDataReader reader1 = clsName.ExecuteReader())
            {
                if (reader1.Read())
                {
                    className = reader1.GetString(0);
                    Class.Name = className;
                }
            }*/

            

            /*SqlDataAdapter dta = new SqlDataAdapter($"select StudentID from Detail_class where ClassID = {Class.ClassID}", conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            dataGridView1.DataSource = dt;*/

            //LoadStudentList();
            ConnectionSql.OpenConnection();
            SqlDataAdapter dta1 = new SqlDataAdapter($"select StudentID, Name from Student where ClassName = '"+comboBox1.Text+"'", conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);

            dataGridView1.DataSource = dt1;
        }

        private void btnPrtcptStndt_Click_1(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            SqlCommand cmd = new SqlCommand($"update Student set ClassName = NULL where StudentID = {selectedId}", conn);
            cmd.ExecuteNonQuery();
            SnippetMbox.Information(title, "Succsess");
            LoadStudent();
            LoadStudentList();
        }
    }
}
