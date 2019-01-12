using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class GZ
    {
        public int WID { get; set; }//主键ID
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public string WDudectionMoney { get; set; }//应扣除金额
        public float WShouldMoney { get; set; }//实发金额
        public string CreateDate { get; set; }//日期
        public bool Pstatic { get; set; }//状态
    }
}