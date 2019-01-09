using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Helpers;
using Newtonsoft.Json;
using System.Net.Http;
using ERP_MVC.Models;

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
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddRest()
        {
            return View();
        }
    }
}