using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Bll;

namespace ERP_API.Controllers
{
    public class APIAccountController : ApiController
    {
        [HttpGet]
        public LoginResult Login(string ENo="",string Rpassword="")
        {
            return EmployeeInfoBll.Login(ENo, Rpassword);
        }
    }
}
