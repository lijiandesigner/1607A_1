using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class CheckingController : Controller
    {
        /// <summary>
        /// 考勤信息控制器
        /// </summary>
        /// <returns></returns>
        // GET: Checking
        public ActionResult Index()
        {
            return View();
        }
    }
}