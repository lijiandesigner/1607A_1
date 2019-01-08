using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Model
{
    [Table("WagesInfo")]
    /// <summary>
    /// 工资信息表
    /// </summary>
    public class WagesInfo
    {
        [Key]
        public int WID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public string WDudectionMoney { get; set; }//应扣除金额
        public float WShouldMoney { get; set; }//实发金额
    }
}
