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
    /// <summary>
    /// 财务
    /// </summary>
    public class FinancialController : ApiController
    {
        /// <summary>
        /// 根据条件查询员工工资
        /// </summary>
        /// <returns></returns>
        public static List<GZ> GetGZs()
        {
            return WagesInfoBll.GetGZs();
        }
        /// <summary>
        /// 生成本月工资记录
        /// </summary>
        /// <returns></returns>
        public static int CreateGZ(string Date)
        {
            return WagesInfoBll.CreateGZ(Date);
        }
    }
}
