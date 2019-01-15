using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Helpers;
using ERP_MVC.Models;
using Newtonsoft.Json;

namespace ERP_MVC.Controllers
{
    public class FinnanceController : Controller
    {
        /// <summary>
        /// 财务部控制器
        /// </summary>
        /// <returns></returns>
        // GET: Finnance
        public ActionResult SettleWage()
        {
            string json = HttpClientHelper.SendRequest("http://localhost:59776/api/Financial", "get");
            List<GZ> Lgz = JsonConvert.DeserializeObject<List<GZ>>(json);
            return View(Lgz);
        }
    }
}