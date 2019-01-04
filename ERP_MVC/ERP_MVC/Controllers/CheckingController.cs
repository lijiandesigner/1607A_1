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
        /// 考勤规则
        /// </summary>
        /// <returns></returns>
        public ActionResult AccountRules()
        {
            return View();
        }
    }
}