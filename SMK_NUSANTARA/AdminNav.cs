using SMK_NUSANTARA.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMK_NUSANTARA
{

    public partial class AdminNav : Form
    {
        private string receivedData;
        public AdminNav(string username)
        {
            InitializeComponent();
            receivedData = username;
        }

        private void btnManageStudnet_Click(object sender, EventArgs e)
        {
            FrmStudent formStdnt = new FrmStudent();
            formStdnt.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin formLgn = new FrmLogin();
            formLgn.Show();
        }

        private void AdminNav_Load(object sender, EventArgs e)
        {
            labelAdminName.Text = receivedData;
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            a formTeacher = new a();
            formTeacher.Show();
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            MngClassForm formClass = new MngClassForm();
            formClass.Show();
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            ManageScheduleForm formSchedule = new ManageScheduleForm();
            formSchedule.Show();
        }
    }
}
