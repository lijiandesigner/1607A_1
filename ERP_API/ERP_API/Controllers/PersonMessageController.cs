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
        /// <param name="Static">工作状态</param>
        /// <returns></returns>
        public List<WorkState> Get(bool Static)
        {
            return PersonMessageBll.Get(Static);
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
