﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_MVC.Models;

namespace ERP_MVC.Filters
{
    public class LoginAuthorization : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //判断userName的值是否为空，如果为空表示用户未登录。
            //如果未登录，则转到Login控制器的Index方法。
            if (System.Web.HttpContext.Current.Session["userName"] == null)
            {
                filterContext.Result = new RedirectResult("/Account/Index");
            }
        }
    }

}