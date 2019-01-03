using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class PersonnelInfomationController : Controller
    {
        /// <summary>
        /// 人事员工信息管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: PersonnelInfomation
        public ActionResult Index()
        {
            return View();
        }
    }
}