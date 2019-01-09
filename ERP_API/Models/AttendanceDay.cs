using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AttendanceDay
    {
        public int AID { get; set; }//主键ID
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public string AMBeginTime { get; set; }//上午上班打卡时间
        public string AMEndTime { get; set; }//上午下班打卡时间
        public string AABeginTime { get; set; }//下午上班打卡时间
        public string AAEndTime { get; set; }//下午下班打卡时间
        public int ABeLateTime { get; set; }//迟到分钟数
        public int ALeaveTime { get; set; }//早退分钟数
        public string AStatic { get; set; }//状态(正常,迟到,早退,旷工)
        public string Adate { get; set; }//考勤日期
    }
}
