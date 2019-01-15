using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class AttendanceMonth
    {
        public int MID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public int MAbsenteeism { get; set; }//总旷工次数
        public int MLateTime { get; set; }//总迟到分钟数
        public int MLeaveTime { get; set; }//总早退分钟数
        public string Remark { get; set; }//说明
    }
}