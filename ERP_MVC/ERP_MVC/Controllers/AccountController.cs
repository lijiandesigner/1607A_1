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
        public ActionResult Login(string txtname, string txtpwd)
        {
            var post = new LoginJsonString { ENo = txtname, Rpassword = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/APIAccount?jsonStr="+ JsonConvert.SerializeObject(post), "get");
            LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            if (loginResult.Result)
            {
                //List<EmployeeInfo> infos = JsonConvert.DeserializeObject<List<EmployeeInfo>>(result);
                //EmployeeInfo e = infos.FirstOrDefault();
                if (Session["Login"] != null)
                { Session.Remove(loginResult.ENo); }
                Session[loginResult.ENo] = loginResult;
                HttpCookie cok = Request.Cookies["cookie"];
                if (cok == null)
                {
                    HttpCookie httpCookie = new HttpCookie("cookie");
                    httpCookie.Expires = DateTime.Now.AddMinutes(20);
                    httpCookie.Values.Add("eno", loginResult.ENo);
                    Response.Cookies.Add(httpCookie);
                }
                else
                {
                    cok.Expires = DateTime.Now.AddMinutes(-1);
                    HttpCookie httpCookie = new HttpCookie("cookie");
                    httpCookie.Expires = DateTime.Now.AddMinutes(20);
                    httpCookie.Values.Add("eno", loginResult.ENo);
                    Response.Cookies.Add(httpCookie);
                }
                //ViewData["Name"] = loginResult.EName == null ? txtname : loginResult.EName;

                return View("Maininterface");
            }
            else
                return Content("<script>alert('登陆失败')</script>");
        }

        public ActionResult Maininterface()
        {
            return View();
        }
        /// <summary>
        /// 打卡
        /// </summary>
        /// <returns></returns>
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }
    }

}