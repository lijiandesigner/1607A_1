using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Filter;

namespace ERP_MVC.Controllers
{
    public class PersonnelPermissionsController : Controller
    {
        /// <summary>
        /// 人事职位权限管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelPermissions
        [LoginAuthorization]
        public ActionResult PermissionsInterface()
        {
            return View();
        }
        [LoginAuthorization]
        public ActionResult EntryView()
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