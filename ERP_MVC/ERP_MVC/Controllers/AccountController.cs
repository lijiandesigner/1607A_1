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
            var post = new LoginJsonString { ENo = txtname, Rpassword = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/APIAccount?jsonStr="+ JsonConvert.SerializeObject(post), "get");
            LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            if (loginResult.Result)
            {
                //List<EmployeeInfo> infos = JsonConvert.DeserializeObject<List<EmployeeInfo>>(result);
                //EmployeeInfo e = infos.FirstOrDefault();
                Session["loginResult"] = loginResult;
                //ViewData["Name"] = loginResult.EName == null ? txtname : loginResult.EName;
                
                Response.Write("<script>location.href='/Account/Maininterface'</script>");
            }
            else
                Response.Write("<script>alert('登陆失败');location.href='/Account/Index'</script>");
        }

        public ActionResult Maininterface()
        {
            return View();
        }
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