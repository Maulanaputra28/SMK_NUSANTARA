using SMK_NUSANTARA.Helper;
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
    public partial class FrmSubInfo : Form
    {
        private string receivedata;
        SqlConnection conn = ConnectionSql.GetConnection();
        public FrmSubInfo(string data)
        {
            InitializeComponent();
            receivedata = data;
        }

        private void FrmSubInfo_Load(object sender, EventArgs e)
        {
            label1.Text = receivedata;
            string nme = label1.Text;
            string desc = "";
            int assgnmnt = 0;
            int mExam = 0;
            int fExam = 0;
            ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select Description, Assignment, Mid_Exam, Final_Exam from Subject where Name = @nme", conn);
            cmd.Parameters.AddWithValue("@nme", nme);

            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    desc = reader["Description"].ToString();
                    assgnmnt = reader.GetInt32(reader.GetOrdinal("Assignment"));
                    mExam = reader.GetInt32(reader.GetOrdinal("Mid_Exam"));
                    fExam = reader.GetInt32(reader.GetOrdinal("Final_Exam"));
                }
                    label2.Text = desc;
                    label7.Text = Convert.ToString(assgnmnt) + "%";
                    label8.Text = Convert.ToString(mExam) + "%";
                    label9.Text = Convert.ToString(fExam) + "%";
            }
            ConnectionSql.CloseConnection();
        }
    }
}
