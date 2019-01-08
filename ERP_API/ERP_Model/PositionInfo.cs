using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Model
{
    [Table("PositionInfo")]
    /// <summary>
    /// 职位表
    /// </summary>
    public class PositionInfo
    {
        [Key]
        public int PoID { get; set; }//主键ID
        public string PoName { get; set; }//职位名称
        public int PoLeave { get; set; }//岗位级别
        public double PoMinMoney { get; set; }//底薪
        public string Permission { get; set; }//权限
    }
}
