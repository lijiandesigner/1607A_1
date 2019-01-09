using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_Bll;

namespace ERP_API.Controllers
{
    //考勤控制器
    public class APIAttendanceController : ApiController
    {
        /// <summary>
        /// 打卡
        /// </summary>
        /// <param name="EID">员工id</param>
        /// <param name="AttendanceTime">打卡时间</param>
        /// <returns></returns>
        public int Get(int EID,string AttendanceTime)
        {
            return AttendanceInfoBll.Get(EID,AttendanceTime);
        }
        
    }
}
