using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Filter;

namespace ERP_MVC.Controllers
{
    public class PersonnelPositionController : Controller
    {
        /// <summary>
        /// 人事职位管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelPosition
        [LoginAuthorization]
        public ActionResult Index()
        {
            return View();
        }
        [LoginAuthorization]
        public ActionResult Add()
        {
            return View();
        }
        [LoginAuthorization]
        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}