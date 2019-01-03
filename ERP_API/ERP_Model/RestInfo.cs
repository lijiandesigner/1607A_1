using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 请假信息表
    /// </summary>
    public class RestInfo
    {
        [Key]
        public int RID { get; set; }//主键ID
        public int EID { get; set; }//请假员工ID
        public string Rtype { get; set; }//请假类型
        public DateTime RBeginTime { get; set; }//请假开始时间
        public DateTime REndTime { get; set; }//请假结束时间
        public string RemarkInfo { get; set; }//理由
        public DateTime ReAuditTime { get; set; }//审核时间
        public string Restatic { get; set; }//状态（待审批，同意，已驳回）
        public string Remark { get; set; }//备注
    }
}
