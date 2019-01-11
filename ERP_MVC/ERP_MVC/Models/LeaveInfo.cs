using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class LeaveInfo
    {
        public int RID { get; set; }            //id
        public string ENo { get; set; }         //员工编号
        public string EName { get; set; }       //员工姓名
        public string PoName { get; set; }      //员工职位
        public string Rtype { get; set; }       //请假类型
        public string RBeginTime { get; set; }  //开始时间
        public string REndTime { get; set; }    //结束时间
        public string RemarkInfo { get; set; }  //请假理由
        public string ReAuditTime { get; set; } //审核时间
        public string Restatic { get; set; }    //审核状态
        public string Remark { get; set; }      //备注
    }
}