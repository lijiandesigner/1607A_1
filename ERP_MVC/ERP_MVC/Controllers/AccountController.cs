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
        [HttpGet]
        public void Login(string txtname, string txtpwd)
        {
            var post = new { Eno = txtname, Rpassword = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/APIAccount/Login", "get", JsonConvert.SerializeObject(post));
            LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            if (loginResult.Result)
            {
                Session[txtname] = loginResult;
                Response.Write("<script>location.href='/Account/Maininterface'</script>");
            }
            else
                Response.Write("<script>alert('登陆失败')</script>");
        }

        public ActionResult Maininterface()
        {
            return View();
        }

    }

}