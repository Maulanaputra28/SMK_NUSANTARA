using SMK_NUSANTARA.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK_NUSANTARA.Dto
{
    public static class Schedule
    {
        private static readonly SqlConnection conn = ConnectionSql.GetConnection();
        public static string ClsNme { get; set; }
        public static int[] Scheduleid
        {
            get
            {
                ConnectionSql.OpenConnection();
                int[] dataArray;
                int schId = 0;
                List<int> schIds = new List<int>();
                //conn.Open();
                SqlCommand cmd = new SqlCommand("Select ScheduleID from HeaderSchedule where ClassName = @cls", conn);
                cmd.Parameters.AddWithValue("@cls", ClsNme);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        schId = reader.GetInt32(0);
                        schIds.Add(schId);
                    }
                    reader.Close();
                    dataArray = schIds.ToArray();
                }
                //conn.Close();
                ConnectionSql.CloseConnection();
                return dataArray;
                
            }
        }

        public static DataTable viewSchedule
        {
            get
            {
                int[] schIds = Schedule.Scheduleid;
                SqlDataAdapter sda = new SqlDataAdapter($"Select SubjectID, Subject, ClassName, Day, Time, TeacherName from HeaderSchedule where ScheduleID IN ({string.Join(",", schIds)})", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        public static string SubjectId { get; set; }
        public static string Subject {  get; set; }
        public static string TeacherId { get; set; }
        public static string Teacher {  get; set; }
        public static string ClassId { get; set; }
        public static string Class { get; set; }
        public static string Day { get; set; }
        public static string Time { get; set; }
    }
}
