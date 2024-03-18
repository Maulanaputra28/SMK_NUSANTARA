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
    public partial class FormEditProfile : Form
    {
        SqlConnection conn  = ConnectionSql.GetConnection();
        string title = "Edit Profile";
        public FormEditProfile()
        {
            InitializeComponent();
            
        }

        private void clearForms()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private bool Validd()
        {
            var strgs = new List<string>()
            {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                richTextBox1.Text,
                /*dateTimePicker1.Value;*/
            };

            var strVal = Validation.validationString(strgs);
            if (!strVal)
            {
                SnippetMbox.Error(title, "All form must be filled");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionSql.OpenConnection();
            var val = Validd();
            if (!val) return;


            User user = new User();
            int studentId = user.StudentId;

            string id = textBox1.Text;
            string name = textBox2.Text;
            string address = richTextBox1.Text;
            DateTime dateOfBirth = dateTimePicker1.Value; 
            string noHp = textBox3.Text;

            SqlCommand cmd = new SqlCommand($"update Student set Name = @name, Address = @addres, DateofBirth = @dob, NoHp = @nohp where StudentID = {studentId}", conn);
            //cmd.Parameters.AddWithValue("@stdntId", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@addres", address);
            cmd.Parameters.AddWithValue("@dob", dateOfBirth);
            cmd.Parameters.AddWithValue("@nohp", noHp);
            cmd.ExecuteNonQuery();

            clearForms();

            SnippetMbox.Information(title, "succsess");
            ConnectionSql.CloseConnection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForms(); 
        }
    }
}
