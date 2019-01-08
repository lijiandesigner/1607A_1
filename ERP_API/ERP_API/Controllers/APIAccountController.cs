using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Bll;
using Newtonsoft.Json;

namespace ERP_API.Controllers
{
    public class APIAccountController : ApiController
    {
        /// <summary>
        /// 登录管理
        /// </summary>
        /// <param name="jsonstr">json登录字符串</param>
        /// <returns></returns>

        public LoginResult Get(string jsonstr)
        {
            LoginJsonString loginJsonString = JsonConvert.DeserializeObject<LoginJsonString>(jsonstr);
            return EmployeeInfoBll.Login(loginJsonString.ENo, loginJsonString.Rpassword);
        }

    }
}
