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
    //请假控制器
    public class RestController : ApiController
    {
        /// <summary>
        ///根据条件查询请假信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Type">请假类型</param>
        /// <returns></returns>
        public List<LeaveInfo> Get(string ENo ="", string Rtype="")
        {
            return RestInfoBll.GetAllPositionInfo(ENo,Rtype);
        }
        /// <summary>
        /// 添加请假信息
        /// </summary>
        /// <param name="restInfo">请假信息对象</param>
        /// <returns></returns>
        public int Post([FromBody]string restInfoStr)
        {
            return RestInfoBll.Add(restInfoStr);
        }
        /// <summary>
        /// 请假信息审批
        /// </summary>
        /// <param name="RID">信息id</param>
        /// <param name="ReAuditTime">审批时间</param>
        /// <returns></returns>
        public  int Put([FromUri]int RID,[FromUri]int Restatic)
        {
            return RestInfoBll.Update(RID,Restatic==1?"同意":"驳回", DateTime.Now.ToString("yyyy/MM/dd hh:mm"));
        }
    }
}
