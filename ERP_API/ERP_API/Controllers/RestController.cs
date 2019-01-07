using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_Model;
using Models;
using ERP_Bll;

namespace ERP_API.Controllers
{
    public class RestController : ApiController
    {
        /// <summary>
        ///根据条件查询请假信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Type">请假类型</param>
        /// <returns></returns>
        public List<LeaveInfo> Get(string ENo, string Type)
        {
            return RestInfoBll.GetAllPositionInfo(ENo,Type);
        }
        /// <summary>
        /// 添加请假信息
        /// </summary>
        /// <param name="restInfo">请假信息对象</param>
        /// <returns></returns>
        public int Post(RestInfo restInfo)
        {
            return RestInfoBll.Add(restInfo);
        }
        /// <summary>
        /// 请假信息审批
        /// </summary>
        /// <param name="RID">信息id</param>
        /// <param name="ReAuditTime">审批时间</param>
        /// <returns></returns>
        public  int Put(int RID, string ReAuditTime)
        {
            return RestInfoBll.Update(RID, ReAuditTime);
        }
    }
}
