using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class PositionInfo
    {
        public int PoID { get; set; }//主键ID
        public string PoName { get; set; }//职位名称
        public int PoLeave { get; set; }//岗位级别
        public double PoMinMoney { get; set; }//底薪
    }
}