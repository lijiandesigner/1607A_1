using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WorkState
    {
        public int PID { get; set; }//主键ID
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public string PeBeginWork { get; set; }//入职时间
        public string PeEndwork { get; set; }//离职时间
        public bool Pstatic { get; set; }//状态
    }
}
