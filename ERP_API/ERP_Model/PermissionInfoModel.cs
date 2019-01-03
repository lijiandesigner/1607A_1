using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 职位权限表
    /// </summary>
    public class PermissionInfoModel
    {
        [Key]
        public int PMID { get; set; }//主键ID
        public int PoID { get; set; }//员工ID
        public int Permission { get; set; }//权限
    }
}
