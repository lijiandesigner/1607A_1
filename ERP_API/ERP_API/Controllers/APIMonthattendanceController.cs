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
    public class APIMonthattendanceController : ApiController
    {
        /// <summary>
        /// 根据条件查询月打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public List<AttendanceMonth> Get()
        {
            return MonthAttenBll.AttendanceMonth();
        }
    }
}
