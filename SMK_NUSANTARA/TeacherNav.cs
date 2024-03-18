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
using SMK_NUSANTARA.Dto;

namespace SMK_NUSANTARA
{
    public partial class TeacherNav : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        public TeacherNav()
        {
            InitializeComponent();
        }

        private void TeacherNav_Load(object sender, EventArgs e)
        {
            /*ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand($"select Name from Teacher where TeacherID = {Dto.User.TeacherId}", conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    labelTeacherName.Text = name;
                }
                reader.Close();
            }*/

            //string nama = name.Teacher.ToString();
            //dataGridView1.DataSource = name.Gender;
            /*User name = new User();
            foreach (var gndr in name.Gender)
            {
                string ganderList = string.Join(",", gndr);
                MessageBox.Show("gender : " + ganderList);
            }
            dataGridView1.DataSource = name.Gender;
            dataGridView1.AutoGenerateColumns = true;*/
            //DataGridView dataGridView = new DataGridView();
            User name = new User();
            labelTeacherName.Text = name.Name;

            int[] dataTeachersId = name.TeacherID;
            string[] dataArrayName = name.Teacher;
            string[] dataArrayGender = name.Gender;
            string[] dataArrayAddress = name.Address;

            List<string> nameColumn = new List<string>()
            {
                "ID",
                "Name",
                "Gender",
                "Address",
                "DateofBirth",
                "NoHp"
            };

            foreach(var columnName in nameColumn)
            {
                dataGridView1.Columns.Add("DataColumn", columnName.ToString());
            }
             
            /*dataGridView1.Columns.Add("DataColumn", "Name");
            dataGridView1.Columns.Add("DataColumn", "Gander");
            dataGridView1.Columns.Add("DataColumn", "Address");*/
            dataGridView1.Rows.Clear();

            //int rowCount = Math.Max(dataArrayName.Length, (dataArrayGender.Length, dataArrayAddress.Length));
            int rowCount = Math.Max(Math.Max(dataArrayName.Length, dataTeachersId.Length), Math.Max(dataArrayGender.Length, dataArrayAddress.Length));

            for (int i = 0; i < rowCount; i++)
            {
                int teachersId = i < dataTeachersId.Length ? dataTeachersId[i] : 0;
                string nameData = i < dataArrayName.Length ? dataArrayName[i] : "";
                string genderData = i < dataArrayGender.Length ? dataArrayGender[i] : "";
                string addressData = i < dataArrayAddress.Length ? dataArrayAddress[i] : "";

                dataGridView1.Rows.Add(teachersId, nameData, genderData, addressData);
                DataGridViewButtonCell btn = new DataGridViewButtonCell();
            }

            /*foreach (string itemName in dataArrayName)
            {
                dataGridView1.Rows.Add(itemName);
            }

            foreach (string itemGendeer in dataArrayGender)
            {
                dataGridView1.Rows.Add(itemGendeer);
            }*/
            //this.Controls.Add(dataGridView);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin formLgn = new FrmLogin();
            formLgn.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            FrmViewScheduleTeacher frmViewScheduleTeacher = new FrmViewScheduleTeacher(); 
            frmViewScheduleTeacher.Show();
        }
    }
}
