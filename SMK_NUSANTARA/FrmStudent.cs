using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SMK_NUSANTARA.Helper;


namespace SMK_NUSANTARA
{
    public partial class FrmStudent : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        string title = "Form Student";
        string name = Student.name;
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            StudentLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void ClearFields()
        {
            txtBoxStdntID.Text = "";
            txtBoxStdntName.Text = "";
            rchTxtBoxAddrs.Text = "";
            txtBoxPhone.Text = "";
            dteTimePickerDoB.Value = DateTime.Now;
            rdiobtnFemale.Checked = false;
            rdiobtnMale.Checked = false;
        }

        private void StudentLoad()
        {
            /*ConnectionSql.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select StudentID, Name, Address, Gender, DateofBirth, NoHp from Student", conn);

            adapter.Fill(dt);*/
            DataTable dt = Student.StudentList;

            dataGridView1.DataSource = dt;
            ConnectionSql.CloseConnection();
        }

        private void txtBoxStdntName_TextChanged(object sender, EventArgs e)
        {
            Student.name = txtBoxStdntName.Text;
        }

        private void rchTxtBoxAddrs_TextChanged(object sender, EventArgs e)
        {
            Student.address = rchTxtBoxAddrs.Text;
        }

        private void rdiobtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Student.gander = "Male";
        }

        private void rdiobtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Student.gander = "Female";

        }

        private void dteTimePickerDoB_ValueChanged(object sender, EventArgs e)
        {
            Student.dateOfBirth = dteTimePickerDoB.Value;
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            Student.noHp = txtBoxPhone.Text;
        }

        private void txtBoxStdntID_TextChanged(object sender, EventArgs e)
        {
            Student.studentId = txtBoxStdntID.Text;
        }

        private bool Val()
        {
            var strgs = new List<string>()
            {
                txtBoxStdntName.Text,
                txtBoxPhone.Text,
                txtBoxStdntID.Text,
                rchTxtBoxAddrs.Text
            };

            var strVal = Validation.validationString(strgs);
            if (!strVal)
            {
                SnippetMbox.Error(title, "Field must be filled");
                return false;
            }

            if (!rdiobtnFemale.Checked && !rdiobtnMale.Checked)
            {
                SnippetMbox.Error(title, "Gander must be selected");
                return false;
            }

            if (dteTimePickerDoB.Value >= DateTime.Today)
            {
                SnippetMbox.Error(title, "Birth date must be lower");
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;

            ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand("insert into Student values(@Name, @Address, @Gender, @DateofBirth, @NoHp, NULL)", conn);
            cmd.Parameters.AddWithValue("@Name", Student.name);
            cmd.Parameters.AddWithValue("@Address", Student.address);
            cmd.Parameters.AddWithValue("@Gender", Student.gander);
            cmd.Parameters.AddWithValue("@DateofBirth", Student.dateOfBirth);
            cmd.Parameters.AddWithValue("@NoHp", Student.noHp);
            cmd.ExecuteNonQuery();
            SnippetMbox.Information(title, "Add Sucsses");
            StudentLoad();
            ClearFields(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;
            ConnectionSql.OpenConnection();

            using (SqlCommand SlctData = new SqlCommand($"select count (*) from Student where StudentID = {Student.studentId}",conn))
            {
            int count = (int)SlctData.ExecuteScalar();  
             if (count > 0)
                {
                    SqlCommand cmd = new SqlCommand($"delete from Student where StudentID = {Student.studentId}", conn);
                    SnippetMbox.Information(title, "Delete Sucsses");
                }else
                {
                    SnippetMbox.Error(title, "No has data");
                }
            }
            ConnectionSql.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = Val();
            if (!valid) return;

            ConnectionSql.OpenConnection();
            SqlCommand cmd = new SqlCommand($"update Student set Name = @Name, Address = @Address, Gender = @Gender, DateofBirth = @DateofBirth, NoHp = @NoHp where StudentID = {Student.studentId}", conn);
            cmd.Parameters.AddWithValue("@Name", Student.name);
            cmd.Parameters.AddWithValue("@Address", Student.address);
            cmd.Parameters.AddWithValue("@Gender", Student.gander);
            cmd.Parameters.AddWithValue("@DateofBirth", Student.dateOfBirth);
            cmd.Parameters.AddWithValue("@NoHp", Student.noHp);
            cmd.ExecuteNonQuery();
            SnippetMbox.Information(title, "Edit Sucsses");
            ClearFields();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

    }
}
