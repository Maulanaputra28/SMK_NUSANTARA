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
    public partial class FrmViewScheduleTeacher : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        public FrmViewScheduleTeacher()
        {
            InitializeComponent();
        }

        private void FrmViewScheduleTeacher_Load(object sender, EventArgs e)
        {
            User user = new User();
            string teacher = user.Name;
            SqlDataAdapter adapter = new SqlDataAdapter("select SubjectID, Subject, ClassName, Day, Time from HeaderSchedule where TeacherName = @tnme", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@tnme", teacher);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected  = true;
            string clsNme = dataGridView1.CurrentRow.Cells["ClassName"].Value.ToString();

            SqlDataAdapter adapter2 = new SqlDataAdapter("Select StudentID, Name, Gender from Student where ClassName = @cn", conn);
            adapter2.SelectCommand.Parameters.AddWithValue("@cn", clsNme);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2); 

            dataGridView2.DataSource = dt2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            string nameSub = dataGridView1.CurrentRow.Cells["Subject"].Value.ToString();
            FrmSubInfo frmSubInfo = new FrmSubInfo(nameSub);
            frmSubInfo.Show(); 

        }
    }
}
