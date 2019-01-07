using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class LoginResult
    {
        public Boolean Result { get; set; }
        public int EID { get; set; }

        public string  EName { get; set; }
        public string EPermissins { get; set; }
    }
}