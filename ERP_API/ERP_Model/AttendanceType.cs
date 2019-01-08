using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Model
{
    [Table("AttendanceType")]
    /// <summary>
    /// 考勤规则表
    /// </summary>
    public class AttendanceType
    {
        [Key]
        public int ATID { get; set; }//主键ID
        public string MBeginTime { get; set; }//上午上班时间
        public string MEndTime { get; set; }//上午下班时间
        public string ABeginTime { get; set; }//下午上班时间
        public string AEndTime { get; set; }//下午下班时间
        public string Remark { get; set; }//说明
    }
}
