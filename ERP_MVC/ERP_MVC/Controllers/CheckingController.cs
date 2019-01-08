using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
        /// <summary>
        /// 月考勤管理
        /// </summary>
        /// <returns></returns>
        public ActionResult MonthAccount()
        {
            return View();
        }
    }
}