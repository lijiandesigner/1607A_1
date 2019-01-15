using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_Bll;
using Models;
using ERP_Model;

namespace ERP_API.Controllers
{
    //考勤控制器
    public class APIAttendanceController : ApiController
    {
        /// <summary>
        /// 根据条件查询日打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public List<AttendanceDay> Get(string ENo="", string EName="", string Adate="")
        {
            return AttendanceInfoBll.AttendanceDays(ENo, EName, Adate);
        }
        /// <summary>
        /// 打卡
        /// </summary>
        /// <param name="EID">员工id</param>
        /// <param name="AttendanceTime">打卡时间</param>
        /// <returns></returns>
        public int Post([FromBody]int EID)
        {
            return AttendanceInfoBll.DK(EID,DateTime.Now.ToString());
        }
        
    }
}
