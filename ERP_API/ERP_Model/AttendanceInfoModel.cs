using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 日考勤信息表
    /// </summary>
    public class AttendanceInfoModel
    {
        [Key]
        public int AID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public DateTime AMBeginTime { get; set; }//上午上班打卡时间
        public DateTime AMEndTime { get; set; }//上午下班打卡时间
        public DateTime AABeginTime { get; set; }//下午上班打卡时间
        public DateTime AAEndTime { get; set; }//下午下班打卡时间
        public int ABeLateTime { get; set; }//迟到分钟数
        public int ALeaveTime { get; set; }//早退分钟数
        public string AStatic { get; set; }//状态(正常,迟到,早退,旷工)
        public DateTime Adate { get; set; }//考勤日期
    }
}
