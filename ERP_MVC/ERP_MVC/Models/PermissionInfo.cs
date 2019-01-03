using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class PermissionInfo
    {
        public int PMID { get; set; }//主键ID
        public int PoID { get; set; }//员工ID
        public int Permission { get; set; }//权限
    }
}