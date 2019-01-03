using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 登录控制器
        /// </summary>
        /// <returns></returns>
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}