using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace ERP_MVC.Controllers
{
    public class PersonnelInfomationController : Controller
    {
        /// <summary>
        /// 人事员工信息管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelInfomation
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}