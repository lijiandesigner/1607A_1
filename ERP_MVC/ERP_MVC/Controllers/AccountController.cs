﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Models;
using Newtonsoft.Json;
using ERP_MVC.Filter;

namespace ERP_MVC.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 登录控制器
        /// </summary>
        /// <returns></returns>
        // GET: Account
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public void Login(string txtname, string txtpwd)
        {
            var post = new LoginJsonString { ENo = txtname, Rpassword = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/APIAccount?jsonStr="+ JsonConvert.SerializeObject(post), "get");
            LoginResult loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            if (loginResult.Result)
            {
                //List<EmployeeInfo> infos = JsonConvert.DeserializeObject<List<EmployeeInfo>>(result);
                //EmployeeInfo e = infos.FirstOrDefault();
                if(Session["Login"]!=null)
                { Session.Remove("Login");}
                Session["Login"] = loginResult;
                HttpCookie cok = Request.Cookies["cookie"];
                if ( cok== null)
                {
                    HttpCookie httpCookie = new HttpCookie("cookie");
                    httpCookie.Expires = DateTime.Now.AddMinutes(20);
                    httpCookie.Values.Add("eno", loginResult.ENo);
                    Response.SetCookie(httpCookie);
                }
                else
                {
                    cok.Expires = DateTime.Now.AddMinutes(-1);
                    HttpCookie httpCookie = new HttpCookie("cookie");
                    httpCookie.Expires = DateTime.Now.AddMinutes(20);
                    httpCookie.Values.Add("eno", loginResult.ENo);
                    Response.SetCookie(httpCookie);
                }
                //ViewData["Name"] = loginResult.EName == null ? txtname : loginResult.EName;
                
                Response.Write("<script>location.href='/Account/Maininterface'</script>");
            }
            else
                Response.Write("<script>alert('登陆失败');location.href='/Account/Index'</script>");
        }
        [LoginAuthorization]
        public ActionResult Maininterface()
        {
            return View();
        }

        /// <summary>
        /// 打卡
        /// </summary>
        /// <returns></returns>
        [LoginAuthorization]
        public ActionResult SignIn()
        {
            return View();
        }
        [LoginAuthorization]
        public ActionResult HomePage()
        {
            return View();
        }
    }

}