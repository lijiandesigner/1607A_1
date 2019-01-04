using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Model
{
    [Table("AttendanceInfo")]
    /// <summary>
    /// 日考勤信息表
    /// </summary>
    public class AttendanceInfo
    {
        [Key]
        public int AID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
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
