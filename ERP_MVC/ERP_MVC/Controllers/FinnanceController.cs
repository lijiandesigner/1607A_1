using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class FinnanceController : Controller
    {
        /// <summary>
        /// 财务部控制器
        /// </summary>
        /// <returns></returns>
        // GET: Finnance
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HistoryIndex()
        {
            return View();
        }
    }
}