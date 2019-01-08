using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class PersonnelPositionController : Controller
    {
        /// <summary>
        /// 人事职位管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelPosition
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