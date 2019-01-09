using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Bll;

namespace ERP_API.Controllers
{
    public class PersonMessageController : ApiController
    {
        /// <summary>
        /// 根据条件查询员工工作状态
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Static">工作状态</param>
        /// <returns></returns>
        public List<WorkState> Get(string ENo=null, string EName=null, string Static=null)
        {
            return PersonMessageBll.Get(ENo, EName, Static);
        }
        /// <summary>
        /// 员工工作状态修改
        /// </summary>
        /// <param name="workState"></param>
        /// <returns></returns>
        public int Put([FromBody]WorkState workState)
        {
            return PersonMessageBll.Update(workState);
        }
    }
}
