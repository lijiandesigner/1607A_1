using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Helpers;
using Newtonsoft.Json;
using System.Net.Http;
using ERP_MVC.Models;
using ERP_MVC.Filter;

namespace ERP_MVC.Controllers
{
    public class LeaveController : Controller
    {
        /// <summary>
        /// 请假管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: Leave
        [HttpGet]
        [LoginAuthorization]
        public ActionResult Index()
        {
            string json = HttpClientHelper.SendRequest("http://localhost:59776/api/Rest", "get");
            List<LeaveInfo> leaves = JsonConvert.DeserializeObject<List<LeaveInfo>>(json);
            return View(leaves);
        }
        [HttpGet]
        [LoginAuthorization]
        public ActionResult AddRest()
        {
            return View();
        }
    }
}