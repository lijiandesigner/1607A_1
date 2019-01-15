using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ERP_MVC.Models;

namespace ERP_MVC.Controllers
{
    public class CheckingController : Controller
    {
        // GET: Checking
        /// <summary>
        /// 日考勤管理
        /// </summary>
        /// <returns></returns>
        
        public ActionResult AccountRules()
        {
            string json = Helpers.HttpClientHelper.SendRequest("api/APIAttendance", "Get");
            List<AttendanceDay> attday = JsonConvert.DeserializeObject<List<AttendanceDay>>(json);
            return View(attday);
        }
        /// <summary>
        /// 月考勤管理
        /// </summary>
        /// <returns></returns>
        public ActionResult MonthAccount()
        {
            string json = Helpers.HttpClientHelper.SendRequest("api/APIMonthattendance", "Get");
            List<AttendanceMonth1> months = JsonConvert.DeserializeObject<List<AttendanceMonth1>>(json);
            return View(months);
        }
    }
}