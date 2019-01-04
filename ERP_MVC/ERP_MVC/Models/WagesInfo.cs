using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class WagesInfo
    {
        public int WID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public string WDudectionMoney { get; set; }//应扣除金额
        public float WShouldMoney { get; set; }//实发金额
    }
}