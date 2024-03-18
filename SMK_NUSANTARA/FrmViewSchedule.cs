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
using SMK_NUSANTARA.Dto;
using SMK_NUSANTARA.Helper;

namespace SMK_NUSANTARA
{
    public partial class FrmViewSchedule : Form
    {
        SqlConnection conn = ConnectionSql.GetConnection();
        string title = "View Schedule";
        public FrmViewSchedule()
        {
            InitializeComponent();
        }

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {
            
            /*int[] schIds = Schedule.Scheduleid;
            SqlDataAdapter sda = new SqlDataAdapter($"Select SubjectID, Subject, ClassName, Day, Time, TeacherName from HeaderSchedule where ScheduleID IN ({string.Join(",", schIds)})", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            */
            DataTable dtSchedule = Schedule.viewSchedule;
            dataGridView1.DataSource = dtSchedule;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        { 

            dataGridView1.CurrentRow.Selected = true;
            string nameSub = dataGridView1.CurrentRow.Cells["Subject"].Value.ToString();
            FrmSubInfo frmSubInfo = new FrmSubInfo(nameSub);
            frmSubInfo.Show(); 

           /* int sId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SubjectID"].Value);
            Student.subId = sId;*/

            //MessageBox.Show(Student.NameSub);  
        }
    }
}
