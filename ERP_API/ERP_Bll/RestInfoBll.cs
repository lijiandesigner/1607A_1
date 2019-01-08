using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Dal;
using ERP_Model;
using Models;

namespace ERP_Bll
{
    public class RestInfoBll
    {
        /// <summary>
        /// 根据条件获取所有匹配的请假信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Type">请假类型</param>
        /// <returns></returns>
        public static List<LeaveInfo> GetAllPositionInfo(string ENo, string Type)
        {
            return RestInfoDal.GetAllPositionInfo(ENo, Type);
        }
        /// <summary>
        /// 添加请假信息
        /// </summary>
        /// <param name="restInfo">请假信息对象</param>
        /// <returns></returns>
        public static int Add(string restInfoStr)
        {
            return RestInfoDal.Add(restInfoStr);
        }
        /// <summary>
        /// 请假信息审批
        /// </summary>
        /// <param name="RID">信息id</param>
        /// <param name="ReAuditTime">审批时间</param>
        /// <returns></returns>
        public static int Update(int RID, string ReAuditTime)
        {
            return RestInfoDal.Update(RID, ReAuditTime);
        }
    }
}
