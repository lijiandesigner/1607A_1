using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Models;
using Newtonsoft.Json;
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
        [HttpPost]
        public void Index(string txtname, string txtpwd)
        {
            var post = new { Eno = txtname, Rpassword = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/APIAccount/Login", "get", JsonConvert.SerializeObject(post));
            LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            Session[txtname] = loginResult;
            if(loginResult.Result )
            {
                Response.Write("<script>alert('cg')</script>");
            }
            else
            {
                Response.Write("<script>alert('sb')</script>");
            }
        }

        public ActionResult Maininterface()
        {
            return View();
        }

    }

}