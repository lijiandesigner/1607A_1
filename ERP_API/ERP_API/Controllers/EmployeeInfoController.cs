using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Model;
using ERP_Bll;

namespace ERP_API.Controllers
{
    /// <summary>
    /// 员工信息管理
    /// </summary>
    public class EmployeeInfoController : ApiController
    {
        /// <summary>
        /// 根据条件获取员工信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Pstatic">工作状态</param>
        /// <returns></returns>
        public List<EmployeeInfos> Get(bool Pstatic, string ENo = "", string EName = "")
        {
            return EmployeeInfoBll.GetEmployeeInfos(ENo, EName, Pstatic);
        }
    }
}
