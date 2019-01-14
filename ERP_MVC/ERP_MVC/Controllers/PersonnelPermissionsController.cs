﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class PersonnelPermissionsController : Controller
    {
        /// <summary>
        /// 人事职位权限管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelPermissions
        //
        public ActionResult PermissionsInterface()
        {
            return View();
        }
        public ActionResult EntryView()
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