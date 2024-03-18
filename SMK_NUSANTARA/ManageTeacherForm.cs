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
    public partial class a : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        string title = "Form Teacher";
        public a()
        {
            InitializeComponent();
        }

        private void a_Load(object sender, EventArgs e)
        {
            
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            teacherLoad();
        }

        private void teacherLoad()
        {
            ConnectionSql.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Teacher", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

        }
        private void txtTchrId_TextChanged(object sender, EventArgs e)
        {
            Teacher.TeacherId = txtTchrId.Text;
        }

        private void txtTchrNme_TextChanged(object sender, EventArgs e)
        {
            Teacher.TeacherName = txtTchrNme.Text;
        }

        private void rchTbAddrs_TextChanged(object sender, EventArgs e)
        {
            Teacher.address = rchTbAddrs.Text;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            Teacher.gander = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Teacher.gander = "Female";

        }

        private void dtpDoB_ValueChanged(object sender, EventArgs e)
        {
            Teacher.dateOfBirth = dtpDoB.Value;
        }

        private void txtNohp_TextChanged(object sender, EventArgs e)
        {
            Teacher.noHp = txtNohp.Text;
        }

        private bool Val()
        {
            var strgs = new List<string>()
            {
                txtTchrNme.Text,
                txtTchrId.Text,
                txtNohp.Text,
                rchTbAddrs.Text
            };

            var strVal = Validation.validationString(strgs);
            if (!strVal)
            {
                SnippetMbox.Error(title, "All fields must be fiiled");
                return false;
            }

            if (!rbFemale.Checked && !rbMale.Checked)
            {
                SnippetMbox.Error(title, "Gender must be selected");
                return false;
            }

            if (dtpDoB.Value >= DateTime.Today)
            {
                SnippetMbox.Error(title, "Date of BIrth must be lower");
                return false;
            }
            return true;
        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;

            ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand("insert into Teacher values(@Name, @Gender, @Address, @DateofBirth, @NoHp)", conn);
            cmd.Parameters.AddWithValue("@Name", Teacher.TeacherName);
            cmd.Parameters.AddWithValue("@Gender", Teacher.gander);
            cmd.Parameters.AddWithValue("@Address", Teacher.address);
            cmd.Parameters.AddWithValue("@DateofBirth", Teacher.dateOfBirth);
            cmd.Parameters.AddWithValue("@NoHp", Teacher.noHp);
            cmd.ExecuteNonQuery();
            SnippetMbox.Information(title, "Insert Succsess");
            ConnectionSql.CloseConnection();

            teacherLoad();
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true; 
            btnSave.Enabled = true;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;

            ConnectionSql.OpenConnection();
            using (SqlCommand slct = new SqlCommand($"select count(*) from Teacher where TeacherID = {Teacher.TeacherId}", conn))
            {
                int count = (int)slct.ExecuteScalar();
                if (count > 0)
                {
                    SqlCommand cmd = new SqlCommand($"delete from Teacher where TeacherID = {Teacher.TeacherId}", conn);
                    cmd.ExecuteNonQuery();
                    SnippetMbox.Information(title, "Delete Succsess");
                }
                else
                {
                    SnippetMbox.Error(title, "No has Data");
                }
            }
            ConnectionSql.CloseConnection();
            teacherLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;

            ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand($"update Teacher set Name = @TName, Gender = @Gender, Address = @Address, DateofBirth = @DoB, NoHp = @NoHp where TeacherID = {Teacher.TeacherId}", conn);
            cmd.Parameters.AddWithValue("@TName", Teacher.TeacherName);
            cmd.Parameters.AddWithValue("@Gender", Teacher.gander);
            cmd.Parameters.AddWithValue("@Address", Teacher.address);
            cmd.Parameters.AddWithValue("@DoB", Teacher.dateOfBirth);
            cmd.Parameters.AddWithValue("@NoHp", Teacher.noHp);
            cmd.ExecuteNonQuery();
            SnippetMbox.Information(title, "Update Succsess");

            teacherLoad();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNohp.Text = "";
            txtTchrNme.Text = "";
            txtTchrId.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            rchTbAddrs.Text = "";
            dtpDoB.Value = DateTime.Now;
        }
    }
}
